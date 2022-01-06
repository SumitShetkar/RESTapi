using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cricketer.Models
{
    public class Cricketer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int JerseyNo { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }

        public Cricketer()
        {

        }

        public Cricketer(int id, string name,int jerseyno,DateTime dob,int age,string country,string role)
        {
            ID = id;
            Name = name;
            JerseyNo = jerseyno;
            DOB = dob;
            Age = age;
            Country = country;
            Role = role;
        }

        public override string ToString()
        {
            return ID + " " + Name + " " + JerseyNo + " " + DOB + " " + Age + " " + Country + " " + Role;
        }

    }
}