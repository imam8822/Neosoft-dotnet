using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC
{
    public class Mapper
    {
        public static Models.SuperHero Map(Data.Entities.SuperHero superHero)=> new Models.SuperHero()
            {
                id=superHero.Id,
                name=superHero.Name,
                alias=superHero.Alias,
                hideOuts=superHero.HideOuts
            };
        
        public static Data.Entities.SuperHero Map(Models.SuperHero superHero)=> new Data.Entities.SuperHero()
            {
                Id = superHero.id,
                Name = superHero.name,
                Alias = superHero.alias,
                HideOuts = superHero.hideOuts
            };


        public static IEnumerable<Models.SuperHero> Map(IEnumerable<Data.Entities.SuperHero> superHeroes) => superHeroes.Select(Map);
    }
}
