using Storex;

namespace AuthenticationModules
{
    class User : IUser
    {
        public string Id { get; set; }

        public string DisplayName { get; set; }

        public User(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
    }
}