using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindImageResolution.ComicRack
{
    public class Book : ObjectBase
    {
        public Book(object book) 
            : base(book)
        {
        }

        public IEnumerable<ComicPageInfo> GetPageList() => InvokeMethod<ComicPageInfo>("GetPageList");

        public ComicPageInfo GetPage(int pageIndex) => new ComicPageInfo(InvokeMethod("GetPage", pageIndex));

        public void SetCustomValue(string key, string value) => InvokeMethod("SetCustomValue", key, value);
        public string GetCustomValue(string key) => InvokeMethod("GetCustomValue", key) as string;

        public void SetStringValue(string key, string value, bool IsCustom)
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {
                if (IsCustom)
                    SetCustomValue(key, value);
                else
                    base.SetValue(key, value); 
            }
        }

        public void AppendStringValue(string key, string value, bool IsCustom, bool NewLine = false)
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {
                if (IsCustom)
                {
                    string existingValue = GetCustomValue(key);
                    string newValue = CheckNewLine(value, NewLine, existingValue) as string;
                    SetCustomValue(key, newValue);
                }
                else
                {
                    base.AppendValue(key, value, NewLine);
                }
            }
        }

        public bool IsLinked => GetValue<bool>("IsLinked");

        public string Title => GetValue<string>("Title");
        public string ShadowTitle => GetValue<string>("ShadowTitle");

        public string Series => GetValue<string>("Series");
        public string ShadowSeries => GetValue<string>("ShadowSeries");

        public string Number => GetValue<string>("Number");
        public string ShadowNumber => GetValue<string>("ShadowNumber");

        public int Volume => GetValue<int>("Volume");
        public int ShadowVolume => GetValue<int>("ShadowVolume");

        public string FilePath => GetValue<string>("FilePath");
    }
}
