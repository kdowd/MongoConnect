using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnect.Models
{
    internal class Find
    {
    }
}

// SEARCH
//public async Task<IActionResult> Index(CancellationToken cancellationToken)
//{
//    //  Fetch objects from MongoDB collection.
//    IMongoDatabase database = _mongoClient.GetDatabase("TestDatabase");
//    IMongoCollection<SampleObject> collection = database.GetCollection<SampleObject>("SampleObjects");
//    List<SampleObject> objects = await collection.Find(obj => true).ToListAsync(cancellationToken);

//    return View(new MongoDbViewModel
//    {
//        SampleObjects = objects
//    });
//}
