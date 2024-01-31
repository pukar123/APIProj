using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiredFirstInfrastructure.Database
{
    public interface IMongoDatabaseFactory
    {
        IMongoDatabase GetDatabase();
    }
}
