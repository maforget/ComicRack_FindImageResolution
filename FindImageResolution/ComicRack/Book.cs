﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindImageResolutionNET.ComicRack
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
                string existingValue = GetExistingValue(key);
                if (IsCustom)
                {
                    if (existingValue != value)
                        SetCustomValue(key, value);
                }
                else
                {
                    if (existingValue != value)
                        base.SetValue(key, value);
                }
            }
        }

        public string GetExistingValue(string key)
        {
            return GetValue<string>(key) ?? GetCustomValue(key);
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

        public bool IsLinked => GetValue<bool>();

        public string Title => GetValue<string>();
        public string ShadowTitle => GetValue<string>();

        public string Series => GetValue<string>();
        public string ShadowSeries => GetValue<string>();

        public string Number => GetValue<string>();
        public string ShadowNumber => GetValue<string>();

        public int Volume => GetValue<int>();
        public int ShadowVolume => GetValue<int>();

        public string Caption => GetValue<string>();
        public string CaptionWithoutTitle => GetValue<string>();
        public string CaptionWithoutFormat => GetValue<string>();

        public string FilePath => GetValue<string>();
        public int PageCount => GetValue<int>();
    }
}
