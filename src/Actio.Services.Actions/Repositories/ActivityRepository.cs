using System;
using System.Threading.Tasks;
using Actio.Services.Actions.Domain.Models;
using Actio.Services.Actions.Domain.Repositories;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Actio.Services.Actions.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IMongoDatabase _database;

        public ActivityRepository(IMongoDatabase db)
        {
            _database = db;
        }
        public async Task AddAsync(Activity activity)
         => await Collection
                .InsertOneAsync(activity);

        public async Task<Activity> GetAsync(Guid id)
            => await Collection
                .AsQueryable()
                .FirstOrDefaultAsync(a => a.Id == id);

        private IMongoCollection<Activity> Collection
            => _database.GetCollection<Activity>("Activities");
    }
}
