namespace RepositoryModules
{
    sealed class Condition
    {
        public string PrimaryLabelItemNumber { get; }

        public string ValidValue { get; }

        public Condition(string primaryLabelItemNumber, string validValue)
        {
            if (string.IsNullOrEmpty(primaryLabelItemNumber)) throw new System.ArgumentException($"'{nameof(primaryLabelItemNumber)}' を NULL または空にすることはできません。", nameof(primaryLabelItemNumber));
            if (string.IsNullOrEmpty(validValue)) throw new System.ArgumentException($"'{nameof(validValue)}' を NULL または空にすることはできません。", nameof(validValue));

            PrimaryLabelItemNumber = primaryLabelItemNumber;
            ValidValue = validValue;
        }
    }
}
