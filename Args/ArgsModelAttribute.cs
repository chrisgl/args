﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Args
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ArgsModelAttribute : Attribute
    {
        public static ArgsModelAttribute Default
        {
            get { return new ArgsModelAttribute(); }
        }

        public ArgsModelAttribute()
        {
            SwitchDelimiter = "/";
            StringComparison = StringComparison.CurrentCultureIgnoreCase;
        }

        public string SwitchDelimiter { get; set; }
        public StringComparison StringComparison { get; set; }

        public StringComparer StringComparer
        {
            get
            {
                switch (StringComparison)
                {
                    case StringComparison.CurrentCulture:
                        return StringComparer.CurrentCulture;
                    case StringComparison.CurrentCultureIgnoreCase:
                        return StringComparer.CurrentCultureIgnoreCase;
                    case StringComparison.InvariantCulture:
                        return StringComparer.InvariantCulture;
                    case StringComparison.InvariantCultureIgnoreCase:
                        return StringComparer.InvariantCultureIgnoreCase;
                    case StringComparison.Ordinal:
                        return StringComparer.Ordinal;
                    case StringComparison.OrdinalIgnoreCase:
                        return StringComparer.OrdinalIgnoreCase;
                    default:
                        throw new ArgumentOutOfRangeException("StringComparison");
                }
            }
        }
    }
}