using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cver.Models.Database;
namespace Cver.Models.Viewmodels
{
    public class SkimmedUser
    {
        public string Id { get; set; }
        public string Lokation { get; set; }
        public bool Moveable { get; set; }
        public string SpecialType { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public IEnumerable<UserSkills> Skills { get; set; }
    }
}