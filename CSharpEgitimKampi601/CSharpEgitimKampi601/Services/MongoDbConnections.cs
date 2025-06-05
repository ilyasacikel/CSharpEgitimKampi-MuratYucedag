using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnections
    {
        private IMongoDatabase _database;
        public MongoDbConnections()
        {
            var client = new MongoClient("mongodb://localhost:27017"); // veritabaının bağlantı adresi
            _database = client.GetDatabase("Db601Customer"); // veritabanının adı
        }
        public IMongoCollection<BsonDocument> GetCustomersCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers"); // Db601Customer isimli veritabanının içine 'Customers' adında, SQL'de tabloya karşılık gelen, bir koleksiyon eklemiş oluyoruz.
        }
    }
}
