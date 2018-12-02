using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Mongo;
using Actio.Services.Actions.Domain.Models;
using Actio.Services.Actions.Domain.Repositories;
using MongoDB.Driver;

namespace Actio.Services.Actions.Services
{
    public class CustomMongoSeeder : DatabaseSeeder
    {
        private readonly ICategoryRepository _categoryRepository;
        public CustomMongoSeeder(IMongoDatabase db, ICategoryRepository categoryRepository) : base(db)
        {
            _categoryRepository = categoryRepository;
        }
        protected override async Task CustomSeedAsync()
        {
            var categories = new List<string>
            {
                "work",
                "play",
                "hobby"
            };
            await Task.WhenAll(categories.Select(x => 
                _categoryRepository.AddAsync(new Category(x))));
        }
            
        
    }
}
