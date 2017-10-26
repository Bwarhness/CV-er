using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cver.Models.Database
{
    public class Projekt
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Fk_user { get; set; }

        [ForeignKey("Fk_user")]
        public virtual ApplicationUser User { get; set; }
    }
}