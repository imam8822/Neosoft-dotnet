using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models
{
    public class Mapper
    {
        public static RestService.Models.CatModel Map(Data.Entities.Cat cat)
        {
            return new RestService.Models.CatModel()
            {
                Id = cat.Id,
                Name = cat.Name,
                Dob = cat.Dob,
                Gender = cat.Gender.Name,
                CatType = cat.catType1.Name,
                FurType = cat.FurType1.Name,
                legLength = cat.legLength,
                ribCage = cat.ribcage
            };
        }
    }
}