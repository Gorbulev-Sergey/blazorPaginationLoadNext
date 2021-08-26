using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorPaginationLoadNext.Models
{
    public class post
    {
        public int id { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public string cover_image { get; set; }
    }
}
