using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cver.Models;
using System.Web.Http.Cors;
using Cver.Models.Viewmodels;
using System.Data.Entity;

namespace Cver.Controllers
{
    
    public class ValuesController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [Route("api/GetPlayerCards")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<ApplicationUser> GetPlayerCards()
        {
            List<SkimmedUser> UsersModel = new List<SkimmedUser>();
            var users = db.Users.Include(p => p.Skills).Include(p => p.Jobs).ToList();
            foreach (var item in users)
            {
                var bla = new SkimmedUser()
                {
                    Id = item.Id,
                    ImgUrl = "http://skyje.com/wp-content/uploads/2014/03/Business-Portrait.jpg",
                    Lokation = item.Lokation,
                    Moveable = item.Movable,
                    Name = item.UserName,
                    Skills = item.Skills.OrderByDescending(p => p.SkillLevel).Take(4).ToList(),
                    SpecialType = ((SpecialTypes)item.Special).ToString()
                };

                    foreach (var job in item.Jobs)
                    {
                        job.User = null;
                    }
                    foreach (var sd in item.Skills)
                    {
                        sd.User = null;
                    }
                    foreach (var GG in item.Educations)
                    {
                        GG.User = null;
                    }
                    foreach (var GG in item.References)
                    {
                        GG.User = null;
                    }
                    foreach (var GG in item.Projekts)
                    {
                        GG.User = null;
                    }

                UsersModel.Add(bla);
            }

            return users;
        }


    }
}
