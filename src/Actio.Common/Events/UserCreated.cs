namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; private set; }
        public string Name { get; private set; }
        protected UserCreated() {}
        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }

    }
}
