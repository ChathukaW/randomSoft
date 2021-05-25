using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PostAPIClient
{
    public class Post
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [JsonPropertyName("CreatedTime")]
        public int CreatedTime { get; set; }
        public string AuthorName { get; set; }
        [JsonPropertyName("TotalLikes")]
        public int TotalLikes { get; set; }

        public int personId { get; set; }
       // public Person Person { get; set; }
    }
}
