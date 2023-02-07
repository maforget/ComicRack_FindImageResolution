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
            Book _CurrentBook;
            int _CurrentBookIndex = 0;
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
                    if (_ComicRackApp == null || _Books?.Length <= 0 || _CurrentBookIndex >= _Books?.Length)
                    {
                        _frmProgress?.Close();
                        return;
                    }

                    _frmProgress.Token.ThrowIfCancellationRequested();

                    _CurrentBook = _Books[_CurrentBookIndex];
                    if (_CurrentBook == null)
                        return;

                    var bookSeries = _CurrentBook.Series;
                    var bookShadowSeries = _CurrentBook.ShadowSeries;
                    var serie = string.IsNullOrEmpty(bookSeries) ? bookShadowSeries : bookSeries;

                    var bookVolume = _CurrentBook.Volume;
                    var bookShadowVolume = _CurrentBook.ShadowVolume;
                    var volume = bookVolume <= -1 ? bookShadowVolume : bookVolume;

                    var bookNumber = _CurrentBook.Number;
                    var bookShadowNumber = _CurrentBook.ShadowNumber;
                    var number = string.IsNullOrEmpty(bookNumber) ? bookShadowNumber : bookNumber;
                    number = string.IsNullOrEmpty(number) ? volume.ToString() : number;

                    //Get the current book thumbnail
                    var currentImage = _ComicRackApp.GetComicThumbnail(_CurrentBook, 0);
                    _frmProgress.UpdateForm(currentImage, serie, number);
                    SimpleLogger.Info($"Processing Book: {_CurrentBook.CaptionWithoutFormat}, File: {_CurrentBook.FilePath}");

                    //Check Image Resolution
                    if (_CurrentBook.IsLinked)
                        Task.Run(() => bookImageResolution.FindResolution(_CurrentBook));
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

                    if (_CurrentBook.TryGetValue(config.Text, out string parsedValue) && e.TryParse(parsedValue, out string value))
                    {
                        _CurrentBook.SetStringValue(key, value, IsCustom);

                        SimpleLogger.Info($"Setting value: \"{value}\" into {(IsCustom ? "custom field " : "")}{key}.");
                    }
                }

                //Increase Current Book Index & Process Next Book
                _CurrentBookIndex++;
                ProcessBook();
            }
        }
    }
}
