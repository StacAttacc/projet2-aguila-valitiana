using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Models
{
    [Table("BinaryUpdates", Schema = "dbo")]
    public class BinaryUpdates
    {
        [Key(), Column("Id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("File")]
        public IFormFile File { get; set; }
    }
}
