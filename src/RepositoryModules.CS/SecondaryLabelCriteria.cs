using System;

namespace RepositoryModules
{
    public class SecondaryLabelCriteria
    {
        public static string PropertyKey { get; } = "15db8aaf-3d90-42e0-9d69-dffcf5a6adc0";

        [Obsolete]
        public bool IsRequired { get; set; }

        public SecondaryLabelBehavior NoLabelBehavior { get; set; }
        public SecondaryLabelBehavior ItemNumberEqualsToPrimaryOneBehavior { get; set; }
        public SecondaryLabelBehavior SpecifiedByConditionFileBehavior { get; set; }
        public SecondaryLabelBehavior OtherLabelsBehavior { get; set; }
    }
}