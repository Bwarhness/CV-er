using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cver.Models.Database
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string EducationPlace { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Fk_user { get; set; }

        [ForeignKey("Fk_user")]
        public virtual ApplicationUser User { get; set; }
    }
}