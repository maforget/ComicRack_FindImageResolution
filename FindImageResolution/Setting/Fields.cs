﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetterINI;

namespace FindImageResolutionNET.Setting
{
    [IniSection("Fields")]
    public class Fields
    {
        [IniParam(Default = false)]
        public bool Custom { get; set; } = false;

        [IniParam(Default = false)]
        public bool ForceRecheck { get; set; } = false;

        [IniParam(Default = "")]
        public string CustomField { get; set; } = "";

        [IniParam(Default = "ScanInformation")]
        public string Field { get; set; } = "ScanInformation";

        [IniParam(Default = "{<Width>px}")]
        public string Text { get; set; } = "{<Width>px}";

        [IniParam(Default = "INFO")]
        public string LogLevel { get; set; } = "INFO";

        [IniParam(Default = 100)]
        public int PercentageOfSlowInspection { get; set; } = 100;
    }
}
