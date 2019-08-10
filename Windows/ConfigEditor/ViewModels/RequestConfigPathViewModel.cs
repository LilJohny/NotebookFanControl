﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConfigEditor.ViewModels
{
    public class RequestConfigPathViewModel
    {
        public static string ConfigV1FileExtension => "config";
        public static string ConfigV2FileExtension => "xml";      

        public bool IsPathValid
        {
            get
            {
                return File.Exists(this.ConfigFilePath);
            }
        }

        public string ConfigFilePath { get; set; }
    }
}
