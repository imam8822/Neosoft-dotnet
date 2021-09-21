using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models
{
	public class Cat
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Cat> getCats()
        {
            return new List<Cat>() { 
                new Cat(){Id=1, Name="Kitty"},
                new Cat(){Id=2, Name="Billy"},
                new Cat(){Id=3, Name="Dextor"},
                new Cat(){Id=4, Name="Tom"}            
            };
        }
    }
}