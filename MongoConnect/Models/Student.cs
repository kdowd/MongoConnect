﻿using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoConnect.Models
{
    public class Student
    {

        [BsonId]
        protected ObjectId Id { get; set; }

        // name in Mongo
        [BsonElement("firstname")]
        public string? FirstName { get; set; }


        [BsonElement("lastname")]
        public string? LastName { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("age")]

        public int? Age { get; set; }

        public Student(string? firstName, string? lastName, string? email, int? age)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
        }
    }
}


//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using OA.Domain;

//namespace OA.Persistence.WriteMongoRepositories.AntiCorruptionLayer.Collections;

//public class Product : BaseEntity
//{
//    public Product()
//    {
//    }

//    public Product(Domain.Product product)
//    {
//        (Id, Name, Price, Stock, CategoryId) =
//            (product.Id, product.Name, product.Price, product.Stock, product.CategoryId);
//        CreatedDate = DateTime.Now;
//    }

//    [BsonId]
//    [BsonRepresentation(BsonType.ObjectId)]
//    public string Id { get; set; }

//    public string Name { get; set; }

//    [BsonRepresentation(BsonType.Decimal128)]
//    public decimal Price { get; set; }

//    public int Stock { get; set; }

//    [BsonRepresentation(BsonType.ObjectId)]
//    public string CategoryId { get; set; }

//    public Category Category { get; set; }
//}