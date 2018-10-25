using ApiSleepingPatener.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TokenAuth.Services
{
    public class UserService
    {

        public User ValidateUser(string email, string password)
        {
            // Here you can write the code to validate
            // User from database and return accordingly
            // To test we use dummy list here
            var userList = GetUserList();
            var user = userList.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public List<User> GetUserList()
        {
            return new List<User>(){
                  new User() {
                    Id = 1,
                    Name ="Zulqarnain",
                    Email = "z@g.com",
                    Password="test"
                },
                new User() {
                    Id = 2,
                    Name ="twt",
                    Email = "t@g.com",
                    Password="test"
                }
            };
        }
    }
}