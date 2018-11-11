using System;

namespace Actio.Common.Commands
{
    public interface IAuthenticatedUser : ICommand
    {
         Guid UserId { get; set; }
    }
}
