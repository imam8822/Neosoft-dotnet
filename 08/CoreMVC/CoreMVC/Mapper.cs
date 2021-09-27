using Data.Entities;
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
                hideOuts=superHero.HideOuts,
                superPowers=Map(superHero.SuperPowers).ToList()
            };
        
        public static Data.Entities.SuperHero Map(Models.SuperHero superHero)=> new Data.Entities.SuperHero()
            {
                Id = superHero.id,
                Name = superHero.name,
                Alias = superHero.alias,
                HideOuts = superHero.hideOuts
            };

        private static string Map(CoreMVC.Models.SuperHero superHero, int ownerId)
        {
            return superHero.name;
        }

        public static Models.SuperPower Map(Data.Entities.SuperPower superPower) {
            if (superPower==null)
            {
                return null;
            }
            return new Models.SuperPower()
            {
                Id = superPower.Id,
                Name = superPower.Name,
                Description = superPower.Description,
                SuperHeroId = superPower.Owner.Id
            };
        }
        public static Data.Entities.SuperPower Map(Models.SuperPower superPower,SuperHero hero)
        {
            if (superPower == null)
            {
                return null;
            }
            return new Data.Entities.SuperPower()
            {
                Name = superPower.Name,
                Description = superPower.Description,
                Owner = hero
            };
        }
        public static IEnumerable<Models.SuperHero> Map(IEnumerable<Data.Entities.SuperHero> superHeroes) => superHeroes.Select(Map);
        public static IEnumerable<Models.SuperPower> Map(IEnumerable<Data.Entities.SuperPower> superPowers) => superPowers.Select(Map);

    }
}
