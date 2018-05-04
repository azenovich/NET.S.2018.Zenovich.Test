﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Api;
using Task5.Solution.Api.Converters;

namespace Task5.Solution.LaTeX
{
    public class LaTeXPlainText : DocumentPart, ILaTeXConverter
    {
        public override string Convert()
        {
            return this.Text;
        }
    }
}
