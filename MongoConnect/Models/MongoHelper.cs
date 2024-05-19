using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Diagnostics;
namespace MongoConnect.Models
{
    public class MongoHelper
    {
        private const string connectionUri = "mongodb+srv://yourHero:Yoobee01@bse2024.jon1dt4.mongodb.net/?retryWrites=true&w=majority&appName=BSE2024";
        public List<Student> students;
        public MongoHelper() { }

        public void Connector_Click()
        {

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            // Send a ping to confirm a successful connection
            try
            {
                //var result = client.GetDatabase("kdowd").RunCommand<BsonDocument>(new BsonDocument("ping", 1));

                var _database = client.GetDatabase("kdowd");
                IMongoCollection<Student> collection = _database.GetCollection<Student>("employees");

                students = collection.AsQueryable().ToList<Student>();




                List<string> databases = client.ListDatabaseNames().ToList();

                foreach (string database in databases)
                {
                    Debug.WriteLine(database);
                }



                // MessageBox.Show(students.Count.ToString());

                //var isOK = _database.RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                //Debug.Write(isOK.ToString());
                //MessageBox.Show("Pinged your deployment. You successfully connected to MongoDB!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("DAMN");
                Debug.WriteLine(ex);
            }

        }
    }
}











