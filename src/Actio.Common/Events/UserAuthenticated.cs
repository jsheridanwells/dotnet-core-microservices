namespace Actio.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; private set; }
        protected UserAuthenticated() {}
        public UserAuthenticated(string email)
        {
            Email = email;
        }

    }
}
