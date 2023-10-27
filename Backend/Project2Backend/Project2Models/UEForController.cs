using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Models
{
    public class UEForController
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        //[JsonConverter(typeof(ByteArrayConverter))]
        public string? Data { get; set; }
    }
}
