namespace RepositoryModules
{
    sealed class SecondaryCondition
    {
        public string PrimaryLabelItemNumber { get; }

        public string SecondaryLabelPartNumber { get; }

        public SecondaryCondition(string primaryLabelItemNumber, string secondaryLabelPartNumber)
        {
            if (string.IsNullOrEmpty(primaryLabelItemNumber)) throw new System.ArgumentException($"'{nameof(primaryLabelItemNumber)}' を NULL または空にすることはできません。", nameof(primaryLabelItemNumber));
            if (string.IsNullOrEmpty(secondaryLabelPartNumber)) throw new System.ArgumentException($"'{nameof(secondaryLabelPartNumber)}' を NULL または空にすることはできません。", nameof(secondaryLabelPartNumber));

            PrimaryLabelItemNumber = primaryLabelItemNumber;
            SecondaryLabelPartNumber = secondaryLabelPartNumber;
        }
    }
}
