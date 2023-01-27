using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolution.ComicRack
{
    public class App : ObjectBase
    {
        public App(object comicRackApp) 
            : base(comicRackApp)
        {
        }

        public Bitmap GetComicPage(Book currentBook, int page) => InvokeMethod("GetComicPage", currentBook.Object, page) as Bitmap;

        public Bitmap GetComicThumbnail(Book currentBook, int page) => InvokeMethod("GetComicThumbnail", currentBook.Object, page) as Bitmap;

        public void SetCustomBookThumbnail(Book currentBook, Image page) => InvokeMethod("SetCustomBookThumbnail", currentBook.Object, page);
    }
}
