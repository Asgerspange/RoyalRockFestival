using Google.Protobuf.WellKnownTypes;
using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Events
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateOnly date { get; set; }
        public string content { get; set; }
        public string location { get; set; }
    }
}
