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

            var pages = book.GetPageList();
            foreach (var page in pages)
            {
                if (Token.IsCancellationRequested || page == null) continue;
                if (page.ImageHeight > 0 || page.ImageHeight > 0)
                {
                    resolutions.Add(new ImageResolutionEventArgs(page.ImageWidthAsText, page.ImageHeightAsText));
                    SimpleLogger.Debug($"Read page {page.ImageIndex + 1} from cache. {page.ImageWidthAsText} X {page.ImageHeightAsText}");
                }
                else
                {
                    var image = App.GetComicPage(book, page.ImageIndex);
                    if (image == null)
                        SimpleLogger.Warning($"Page {page.ImageIndex + 1} of {book.CaptionWithoutFormat} is null, maybe corrupted.");

                    if (image != null)
                    {
                        string width = image.Width.ToString(), height = image.Height.ToString();
                        resolutions.Add(new ImageResolutionEventArgs(width, height));
                        SimpleLogger.Debug($"Read page {page.ImageIndex + 1} from image. {width} X {height}");
                    }
                }
            }

            var most = resolutions.GroupBy(x => x.Width).OrderByDescending(g => g.Count()).SelectMany(i => i).FirstOrDefault();
            SimpleLogger.Info($"Most occurring dimension is: {most.Width} X {most.Height}");
            OnResolutionFound(most);
        }

        protected virtual void OnResolutionFound(ImageResolutionEventArgs e) => ResolutionFound?.Invoke(this, e);
    }

    public class ImageResolutionEventArgs : EventArgs
    {
        public string Width { get; }
        public string Height { get; }

        public ImageResolutionEventArgs(string Width, string Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public bool TryParse(string inputText, out string output)
        {
            output = string.Empty;
            Regex regex = new Regex(@"<(.*?)>", RegexOptions.IgnoreCase);
            var matches = regex.Matches(inputText);
            Func<Match, string> valueDelegate = x => this.Get<string>(x.Groups[1].Value);

            if (matches.Count == 0)
                return false;

            foreach (Match match in matches)
            {
                if (!match.Success || match.Groups.Count < 2)
                    return false;

                string value = valueDelegate(match);
                if (string.IsNullOrEmpty(value))
                    return false;
            }

            output = regex.Replace(inputText, new MatchEvaluator(valueDelegate));
            return true;
        }
    }
}
