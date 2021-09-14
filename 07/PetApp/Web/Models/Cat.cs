using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}