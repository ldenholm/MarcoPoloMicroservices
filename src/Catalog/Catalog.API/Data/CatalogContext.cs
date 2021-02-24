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
        private readonly IMongoDatabase _db;
        public IMongoCollection<Product> Products { get;  }

        public CatalogContext(ICatalogDatabaseSettings settings)
        {
            //var client = new MongoClient(settings.ConnectionString);
            var client = new MongoClient("mongodb://root:test@ds011111.mongolab.com:11111/CatalogDb?connect=replicaSet");

            _db = client.GetDatabase(settings.Database);

            Products = _db.GetCollection<Product>("Products");
            CatalogContextSeed.SeedData(Products);
        }
    }
}
