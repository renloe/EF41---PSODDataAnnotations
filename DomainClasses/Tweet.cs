using System;

namespace DomainClasses
{
    public class Tweet
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        public Alias Author { get; set; }
    }
}