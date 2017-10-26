using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cver.Models.Database
{
    public class RegisteredSkill
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}