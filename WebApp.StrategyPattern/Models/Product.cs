using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.StrategyPattern.Models
{
    public class Product
    {
        [Key]
        [BsonId] // mongodb'ye id alanını göstermemiz gerekiyor.
        [BsonRepresentation(BsonType.ObjectId)] // string id alanı otomatik object id tipine dönüştürülecek 
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }

    }
}
