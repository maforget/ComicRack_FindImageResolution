using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolutionNET.ComicRack
{
    public class ComicPageInfo : ObjectBase
    {
        public ComicPageInfo(object comicPageInfo) 
            : base(comicPageInfo)
        {
        }

        public string Key => GetValue<string>();
        public int ImageIndex => GetValue<int>();
        public int ImageWidth => GetValue<int>();
        public int ImageHeight => GetValue<int>();
        public string ImageWidthAsText => GetValue<string>();
        public string ImageHeightAsText => GetValue<string>();
        public string PageTypeAsText => GetValue<string>();
        public int PageCount => GetValue<int>();
    }
}
