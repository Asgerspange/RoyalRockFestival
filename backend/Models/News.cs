using Google.Protobuf.WellKnownTypes;
using System;
using System.ComponentModel.DataAnnotations;
namespace backend.Models
{
    public class News
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }
        public DateOnly date { get; set; }
        public string author { get; set; }
    }
}
