using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cver.Models.Database
{
    public class UserSkills
    {
        [Key]
        public int Id { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public string Fk_user { get; set; }
        
        public int Fk_SkillType { get; set; }
        public DateTime ExperianceTime { get; set; }
        [ForeignKey("Fk_user")]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("Fk_SkillType")]

        public virtual RegisteredSkill SkillType { get; set; }
    }
   public enum SkillLevel
    {
        poor = 0,
        Fine = 1,
        Trained = 2,
        Expert = 3
    }
}