﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Employee
    {
        public int Id { get; private set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get;private set; }
        public HashedPasswordWithSalt PassWord { get; set; }
        public Employee(int id,string firstName,string lastName,string username, HashedPasswordWithSalt passWord)
        {
            Id = id;
            FirstName = firstName;
            LastName=lastName;
            Username = username;
            PassWord = passWord;
        }
    }
}