using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolution.ComicRack
{
    public class ComicPageInfo : ObjectBase
    {
        public ComicPageInfo(object comicPageInfo) 
            : base(comicPageInfo)
        {
        }

        public string Key => GetValue<string>("Key");
        public int ImageIndex => GetValue<int>("ImageIndex");
        public int ImageWidth => GetValue<int>("ImageWidth");
        public int ImageHeight => GetValue<int>("ImageHeight");
        public string ImageWidthAsText => GetValue<string>("ImageWidthAsText");
        public string ImageHeightAsText => GetValue<string>("ImageHeightAsText");
        public string PageTypeAsText => GetValue<string>("PageTypeAsText");
    }
}
