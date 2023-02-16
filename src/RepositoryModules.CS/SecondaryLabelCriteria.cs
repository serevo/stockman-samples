﻿using System;

namespace RepositoryModules
{
    public class SecondaryLabelCriteria
    {
        public static string PropertyKey { get; } = "15db8aaf-3d90-42e0-9d69-dffcf5a6adc0";
        
        public SecondaryLabelTypes AcceptableTypes { get; set; }
        
        [Obsolete]
        public bool IsRequired { get; set; }

        public SecondaryNoLabelBehavior NoLabelBehavior { get; set; }

        public SecondaryLabelBehavior ItemNumberEqualsToPrimaryOneBehavior { get; set; }
        public SecondaryLabelBehavior SpecifiedByConditionFileBehavior { get; set; }

        [Obsolete]
        public SecondaryLabelBehavior OtherLabelsBehavior { get; set; }

        SecondaryLabelBehavior _otherNotSingleSymbolLabelsBehavior;
        public SecondaryLabelBehavior OtherNotSingleSymbolLabelsBehavior 
        {
            get
            {
                if (OtherLabelsBehavior != SecondaryLabelBehavior.Default) 
                {
                    _otherNotSingleSymbolLabelsBehavior = OtherLabelsBehavior;
                    OtherLabelsBehavior = SecondaryLabelBehavior.Default;
                }

                return _otherNotSingleSymbolLabelsBehavior;
            }
            set => _otherNotSingleSymbolLabelsBehavior = value;
        }
    }
}