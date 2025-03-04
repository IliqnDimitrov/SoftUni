﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name,age,"")
        {
        }
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range 1..100");
                }
                this.age = value;
            }
        }
        public string Email 
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    value = "no email";
                }
                else if (!value.Contains('@'))
                {
                    throw new ArgumentException("Email must contain @");
                }
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1} \nEmail: {2}",this.name,this.age,this.email);
            
        }
    }
}
