﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DotNet_101.SharedKernel.Helpers
{
    public class ModelException : Exception
    {
        public ModelException() : base() { }

        public ModelException(string message) : base(message) { }

        public ModelException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
