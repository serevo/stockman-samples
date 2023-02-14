namespace RepositoryModules
{
    sealed class SecondaryLabelBehaviorViewModel
    {
        public string Display { get; }

        public SecondaryLabelBehavior Behavior { get; }

        public SecondaryLabelBehaviorViewModel(string display, SecondaryLabelBehavior labelBehavior)
        {
            Display = display;
            Behavior = labelBehavior;
        }
    }
}
