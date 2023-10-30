using Microsoft.AspNetCore.Http;
using Miscellaneous;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Models
{
    [Table("UpdateEntries", Schema = "dbo")]
    public class UpdateEntry
    {
        [Key(), Column("Id")]
        public int Id { get; set; }
        
        [Column("Title")]
        public string Title { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Description")]
        public string Description { get; set; }
        
        [Column("Data")]
        //[JsonConverter(typeof(ByteArrayConverter))]
        public byte[]? Data { get; set; }
    }
}
