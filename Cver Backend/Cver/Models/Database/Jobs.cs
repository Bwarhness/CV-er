using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cver.Models.Database
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        public string JobPosition { get; set; }
        public string WorkPlace { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Fk_user { get; set; }

        [ForeignKey("Fk_user")]
        public virtual ApplicationUser User { get; set; }
    }
}