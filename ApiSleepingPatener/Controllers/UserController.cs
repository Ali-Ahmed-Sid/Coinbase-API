using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiSleepingPatener.Models;
using System.Web.Http;

namespace ApiSleepingPatener.Controllers
{
    [System.Web.Mvc.RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        // GET: User

        static List<User> list = new List<User> {
                new User() {
                    UId = 1,
                    Name ="Zulqarnain",
                    Email = "z@g.com",
                    Password="test"
                },
                new User() {
                    UId = 2,
                    Name ="twt",
                    Email = "t@g.com",
                    Password="test"
                },
            };
       

        public IEnumerable<User> Get()
        {
            return list;
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetById/{id}")]
        public User GetById(int id)
        {
            return list[id];
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetPassword/{id}")]
        public string GetPassword(int id)
        {
            return "Password "+list[id].Password;
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("NewUser")]
        public IHttpActionResult NewUser([FromBody]User value)
        {
            list.Add(value);
            return Ok(1);
        }

        //public string getEmail(int id)
        //{
        //    return "Email " + list[id].Email;
        //}

    }
}