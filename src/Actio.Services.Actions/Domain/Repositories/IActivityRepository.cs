using System;
using System.Threading.Tasks;
using Actio.Services.Actions.Domain.Models;

namespace Actio.Services.Actions.Domain.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task AddAsync(Activity activity);
    }
}
