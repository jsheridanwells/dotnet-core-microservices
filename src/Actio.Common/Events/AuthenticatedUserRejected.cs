namespace Actio.Common.Events
{
    public class AuthenticatedUserRejected : IRejectedEvent
    {
        protected AuthenticatedUserRejected() {}
        public AuthenticatedUserRejected(string email, string code, string reason)
        {
            Email = email;
            Code = code;    
            Reason = reason;
        }

        public string Email { get; }
        public string Code { get; }
        public string Reason { get; }
    }
}
