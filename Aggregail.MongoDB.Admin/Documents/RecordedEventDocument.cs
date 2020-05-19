using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Aggregail.MongoDB.Admin.Documents
{
    public sealed class RecordedEventDocument
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("stream")]
        public string Stream { get; set; } = null!;
        
        [BsonElement("event_id")]
        public Guid EventId { get; set; }
        
        [BsonElement("event_type")]
        public string EventType { get; set; } = null!;
        
        [BsonElement("event_number")]
        public long EventNumber { get; set; }
        
        [BsonElement("created")]
        public DateTime Created { get; set; }
        
        [BsonElement("data")]
        public byte[]? Data { get; set; }
    }
}