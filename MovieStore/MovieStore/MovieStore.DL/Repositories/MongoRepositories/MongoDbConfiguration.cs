using MongoDB.Driver;

namespace MovieStore.DL.Repositories.MongoRepositories
{
    public class MongoDbConfiguration
    {
        public MongoClientSettings ConnectionString { get; internal set; }
        public string DatabaseName { get; internal set; }
    }
}