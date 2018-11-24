using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Events;
using RawRabbit;

namespace Actio.Services.Actions.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _bus;
        public CreateActivityHandler(IBusClient bus)
        {
            _bus = bus;
        }
        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating Activity : {command.Name}");
            await _bus.PublishAsync(new ActivityCreated(command.Id, command.UserId, command.Category, command.Name));
        }
    }
}
