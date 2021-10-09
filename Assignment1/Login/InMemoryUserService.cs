using System;
using System.Collections.Generic;
using System.Linq;
using LoginExample.Models;
using Models;

namespace FileData
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    City = "Bratislava",
                    Password = "123456",
                    Sex = "Male", 
                    BirthYear = 1999,
                    SecurityLevel = 4, 
                    UserName = "Peter"
                },
                new User
                {
                    City = "Prague",
                    Password = "654321", 
                    Sex = "Female",
                    BirthYear = 2000,
                    SecurityLevel = 2, 
                    UserName = "Milan"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}