using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Actio.Common.Mongo
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        protected readonly IMongoDatabase Database;
        public DatabaseSeeder(IMongoDatabase db)
        {
            Database = db;
        }
        public async Task SeedAsync()
        {
            var collectionCursor = await Database.ListCollectionsAsync();
            var collections = await collectionCursor.ToListAsync();

            if (collections.Any()) return;

            await CustomSeedAsync();
        }

        protected virtual async Task CustomSeedAsync()
        {
            await Task.CompletedTask;
        }
    }
}
