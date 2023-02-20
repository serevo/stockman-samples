using System;

namespace RepositoryModules
{
    sealed class SecondaryCondition
    {
        public string PrimaryLabelItemNumber { get; }

        public string SecondaryItemNumber { get; }

        public SecondaryCondition(string primaryLabelItemNumber, string secondaryItemNumber)
        {
            if (string.IsNullOrWhiteSpace(primaryLabelItemNumber)) throw new ArgumentException($"'{nameof(primaryLabelItemNumber)}' を null または空白にすることはできません。", nameof(primaryLabelItemNumber));
            if (string.IsNullOrWhiteSpace(secondaryItemNumber)) throw new ArgumentException($"'{nameof(secondaryItemNumber)}' を null または空白にすることはできません。", nameof(secondaryItemNumber));
            
            PrimaryLabelItemNumber = primaryLabelItemNumber;
            SecondaryItemNumber = secondaryItemNumber;
        }
    }
}
