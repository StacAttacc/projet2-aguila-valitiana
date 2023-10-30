using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Models
{
    [Table("TextUpdates", Schema = "dbo")]
    public class TextUpdates
    {
        [Key(), Column("Id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }
}
