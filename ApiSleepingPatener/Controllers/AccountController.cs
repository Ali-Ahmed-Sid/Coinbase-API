using ApiSleepingPatener.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ApiSleepingPatener.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("api/account/getuser/{id}")]
        public IHttpActionResult GetUFirstUser(int id)
        {
            // Get user from dummy list

            var userList = new List<User>(){
                 new User(   2,
                   "twt",
                    "t@g.com",
                    "test",
                    "test") {

                },
                  new User(  1,
                   "twt",
                    "t@g.com",
                    "test",
                    "test") {

                }
                
            };

            var user = userList.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }
    }
}