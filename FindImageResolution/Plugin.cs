using FindImageResolutionNET.ComicRack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindImageResolutionNET.Setting;
using FindImageResolutionNET.Parser;

namespace FindImageResolutionNET
{
    public class Plugin
    {
        private static App _ComicRackApp;
        private static BookCollection _Books;
        private static frmProgress _frmProgress;
        private static CurrentBook _CurrentBook;

        public static void Run(object ComicRackApp, object[] books)
        {
            try
            {
                if (ComicRackApp == null || books?.Length <= 0)
                    return;

                _ComicRackApp = new App(ComicRackApp);
                _Books = new BookCollection(books);
                _frmProgress = new frmProgress(_Books.Length);
                _CurrentBook = new CurrentBook();

                SimpleLogger.DividingLine();
                SimpleLogger.Info($"Starting plugin, processing {_Books.Length.ToString()} books");
                _frmProgress.ShowDialog();
            }
            catch (OperationCanceledException e) 
            { 
                SimpleLogger.Error($"Canceled: {e.Message}"); 
            }
            catch (Exception e)
            {
                SimpleLogger.Error($"Exception: {e.Message}");
                throw;
            }
            finally
            {
                SimpleLogger.Info("Plugin finished, cleaning up");
                _frmProgress?.Dispose();
                _Books = null;
                _CurrentBook = null;
                GC.Collect();
            }
        }

        public static void ProcessBooks()
        {
            if (_ComicRackApp == null && _Books?.Length <= 0)
                return;

            _CurrentBook.ProcessBook();
        }

        public class CurrentBook
        {
            Book currentBook;
            int currentBookIndex = 0;
            BookImageResolution bookImageResolution;

            public CurrentBook()
            {
                bookImageResolution = new BookImageResolution(_ComicRackApp, _frmProgress.Token);
                bookImageResolution.ResolutionFound += ResolutionFound;
            }

            public void ProcessBook()
            {
                try
                {
                    if (_ComicRackApp == null || _Books?.Length <= 0 || currentBookIndex >= _Books?.Length)
                    {
                        _frmProgress?.Close();
                        return;
                    }

                    _frmProgress.Token.ThrowIfCancellationRequested();

                    currentBook = _Books[currentBookIndex];
                    if (currentBook == null)
                        return;

                    var bookSeries = currentBook.Series;
                    var bookShadowSeries = currentBook.ShadowSeries;
                    var serie = string.IsNullOrEmpty(bookSeries) ? bookShadowSeries : bookSeries;

                    var bookVolume = currentBook.Volume;
                    var bookShadowVolume = currentBook.ShadowVolume;
                    var volume = bookVolume <= -1 ? bookShadowVolume : bookVolume;

                    var bookNumber = currentBook.Number;
                    var bookShadowNumber = currentBook.ShadowNumber;
                    var number = string.IsNullOrEmpty(bookNumber) ? bookShadowNumber : bookNumber;
                    number = string.IsNullOrEmpty(number) ? volume.ToString() : number;

                    //Get the current book thumbnail
                    var currentImage = _ComicRackApp.GetComicThumbnail(currentBook, 0);
                    _frmProgress.UpdateForm(currentImage, serie, number);
                    SimpleLogger.Info($"Processing Book: {currentBook.CaptionWithoutFormat}");
                    SimpleLogger.Info($"Processing File: {currentBook.FilePath}");

                    //Check Image Resolution
                    if (currentBook.IsLinked)
                        Task.Run(() => bookImageResolution.FindResolution(currentBook));
                }
                catch (OperationCanceledException e)
                {
                    SimpleLogger.Error($"Canceled: {e.Message}");
                }
                catch (Exception e)
                {
                    SimpleLogger.Error($"Exception: {e.Message}");
                    throw;
                }
            }

            private void ResolutionFound(object sender, ImageResolutionEventArgs e)
            {
                var token = _frmProgress.Token;
                if (!token.IsCancellationRequested)
                {
                    var config = Config.ReadUserFromFile();
                    _frmProgress.IncreaseProgressBarByOne();
                    bool IsCustom = config.Custom;
                    string key = IsCustom ? config.CustomField : config.Field;

                    if (!string.IsNullOrEmpty(key) && currentBook.TryGetValue(config.Text, key, e, out string value))
                    {
                        currentBook.SetStringValue(key, value, IsCustom);
                        SimpleLogger.Info($"Setting value: \"{value}\" into {(IsCustom ? "custom field " : "")}{key}.");
                    }
                }

                //Increase Current Book Index & Process Next Book
                currentBookIndex++;
                ProcessBook();
            }
        }
    }
}
