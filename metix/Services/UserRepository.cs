using metix.Models;
 

namespace metix.Services
{
    public class UserRepository : BaseMongoRepository<User>
    {
        public UserRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
