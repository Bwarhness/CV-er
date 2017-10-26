using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using Cver.Models.Database;
using System.Collections.Generic;

namespace Cver.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public string Name { get; set; }
        public string AboutMe { get; set; }
        public int Age { get; set; }
        public string Lokation { get; set; }
        public bool Movable { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Picture { get; set; }
        public SpecialTypes Special { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<Reference> References { get; set; }
        public virtual ICollection<UserSkills> Skills { get; set; }
        public virtual ICollection<Projekt> Projekts { get; set; }
    }
    public enum SpecialTypes
    {
        Frontend = 0,
        Backend = 10,
        Fullstack = 20,
        Apps = 30

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Education> Educations{ get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
        public DbSet<RegisteredSkill> RegisteredSkill { get; set; }
        public DbSet<Projekt> Projekts { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}