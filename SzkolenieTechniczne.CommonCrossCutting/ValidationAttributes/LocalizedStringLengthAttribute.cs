﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;

namespace SzkolenieTechniczne.CommonCrossCutting.ValidationAttributes
{
    public class LocalizedStringLengthAttribute  : StringLengthAttribute
    {
        public LocalizedStringLengthAttribute(int maximumLength) : base(maximumLength)
        {
        }

        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }
            if (value is LocalizedString localizedString)
            {
                return localizedString.Values.All(languageText => base.IsValid(languageText));
            }
            return false;
        }
    }
}
