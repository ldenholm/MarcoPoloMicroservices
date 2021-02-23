using Catalog.API.Entities;
using Catalog.API.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data.Interfaces
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get;  }
        public CatalogContext(ICatalogDatabaseSettings settings)
        {
            //var client = new MongoClient(settings.ConnectionString);
            var connectionString = "mongodb://localhost:27017/marcopolo-mongo?readPreference=primary";
            var mongoUrl = new MongoUrl(connectionString);

            var client = new MongoClient(mongoUrl);
            var database = client.GetDatabase(mongoUrl.DatabaseName);

            Products = database.GetCollection<Product>("Product");
            CatalogContextSeed.SeedData(Products);
        }
    }
}
