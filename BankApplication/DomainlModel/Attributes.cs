﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainlModel
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AccountMetadataAttribute : System.Attribute
    {

        
        public string AccountDescription { get; private set; }
        public string AccountLimitations { get; private set; }
        public AccountMetadataAttribute(string accountDescription, string accountLimitations)
        {
            AccountDescription = accountDescription;
            AccountLimitations = accountLimitations;
        }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class FormatRestrictionAttribute : Attribute
    {
        public string FormatString { get; private set; }
        public int MaxLength { get; private set; }
        public FormatRestrictionAttribute(string formatString, int maxLength)
        {
            FormatString = formatString;
            MaxLength = maxLength;
        }
  
    }
}
