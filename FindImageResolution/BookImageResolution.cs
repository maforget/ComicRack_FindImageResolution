using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using FindImageResolutionNET.ComicRack;
using FindImageResolutionNET.Tools;

namespace FindImageResolutionNET
{
    public class BookImageResolution
    {
        public App App { get; }

        public CancellationToken Token { get; }

        public event EventHandler<ImageResolutionEventArgs> ResolutionFound;

        public BookImageResolution(App app, CancellationToken token = default)
        {
            App = app;
            Token = token;
        }

        public void FindResolution(Book book)
        {
            List<ImageResolutionEventArgs> resolutions = new List<ImageResolutionEventArgs>();
            Token.ThrowIfCancellationRequested();

            resolutions.AddRange(CheckFastPages(book));
            resolutions.AddRange(CheckSlowPages(book));

            var most = resolutions.GroupBy(x => x.Width).OrderByDescending(g => g.Count()).SelectMany(i => i).FirstOrDefault();
            SimpleLogger.Info($"Most occurring dimension is: {most.Width} X {most.Height}");
            OnResolutionFound(most);
        }

        private IEnumerable<ImageResolutionEventArgs> CheckFastPages(Book book)
        {
            var pages = book.GetPageList();
            var setting = Setting.Config.ReadUserFromFile();
            bool forceRecheck = setting.ForceRecheck;
            var fastPages = forceRecheck ? Enumerable.Empty<ComicPageInfo>() : pages.Where(p => p?.ImageHeight > 0 || p?.ImageHeight > 0);
            SimpleLogger.Info($"Number of Fast pages: {fastPages.Count()} // Total: {pages.Count()}");

            List<ImageResolutionEventArgs> resolutions = new List<ImageResolutionEventArgs>();
            foreach (var page in fastPages)
            {
                resolutions.Add(new ImageResolutionEventArgs(page.ImageWidthAsText, page.ImageHeightAsText));
                SimpleLogger.Debug($"Read page {page.ImageIndex + 1} from cache. {page.ImageWidthAsText} X {page.ImageHeightAsText}");
            }
            return resolutions;
        }

        private IEnumerable<ImageResolutionEventArgs> CheckSlowPages(Book book)
        {
            var pages = book.GetPageList();
            var setting = Setting.Config.ReadUserFromFile();
            bool forceRecheck = setting.ForceRecheck;
            int percentageToCheck = setting.PercentageOfSlowInspection;
            var slowPages = forceRecheck ? pages : pages.Where(p => p?.ImageHeight == 0 || p?.ImageHeight == 0);
            int numberOfPagesToCheck = (int)(percentageToCheck / 100.0 * slowPages.Count());
            int minNumberOfPagesToCheck = forceRecheck && slowPages.Count() >= 2 && numberOfPagesToCheck <= 2 ? 2 : numberOfPagesToCheck;
            SimpleLogger.Info($"Number of Slow pages: {slowPages.Count()} (Inspecting {minNumberOfPagesToCheck} - {percentageToCheck}%) // Total: {pages.Count()}");

            List<ImageResolutionEventArgs> resolutions = new List<ImageResolutionEventArgs>();
            int pageIndex = 0;
            foreach (var page in slowPages)
            {
                if (Token.IsCancellationRequested) break;
                if (pageIndex < minNumberOfPagesToCheck)
                {
                    var image = App.GetComicPage(book, page.ImageIndex);
                    if (image == null)
                        SimpleLogger.Warning($"Page {page.ImageIndex + 1} of {book.CaptionWithoutFormat} is null, maybe corrupted.");

                    if (image != null)
                    {
                        string width = image.Width.ToString(), height = image.Height.ToString();
                        string dpi = image.VerticalResolution == image.HorizontalResolution ? image.VerticalResolution.ToString() : $"{image.VerticalResolution.ToString()}V & {image.HorizontalResolution.ToString()}H";
                        resolutions.Add(new ImageResolutionEventArgs(width, height, dpi));
                        SimpleLogger.Debug($"Read page {page.ImageIndex + 1} from image. {width} X {height} ({dpi}dpi)");
                    }
                }
                pageIndex++;
            }
            return resolutions;
        }

        protected virtual void OnResolutionFound(ImageResolutionEventArgs e) => ResolutionFound?.Invoke(this, e);
    }

    public class ImageResolutionEventArgs : EventArgs
    { 
        public string Width { get; }
        public string Height { get; }
        public string dpi { get; }

        public ImageResolutionEventArgs(string Width, string Height, string dpi = "")
        {
            this.Width = Width;
            this.Height = Height;
            this.dpi = dpi;
        }
    }
}
