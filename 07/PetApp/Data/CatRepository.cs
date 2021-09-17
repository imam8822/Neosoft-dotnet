using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CatRepository : ICatRepository
    {
        private PetModel db;
        public CatRepository(PetModel db)
        {
            this.db = db;
        }
        public void AddCat(Cat cat)
        {
            db.Cats.Add(cat);
            Save();
        }

        public void DeleteCat(int id)
        {
            var cat=db.Cats.Find(id);
            if (cat != null)
            {
                db.Cats.Remove(cat);
                Save();
            }
            else
                throw new ArgumentException("Cat is not found");
        }

        public Cat GetCatById(int? id)
        {
            if (id > 0 && id != null)
            {
                var cat = db.Cats
                    .Include(g => g.Gender)
                    .Include(c => c.catType1)
                    .Include(f => f.FurType1)
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
                if (cat != null)
                    return cat;
                else
                    return null;
            }
            else
            {
                throw new ArgumentException("Id cannot be less than 0");               
            }
        }

        public IEnumerable<Cat> GetCats()
        {
            return db.Cats
                    .Include("Gender")
                    .ToList();            
        }

        public Cat UpdateCat(int? id)
        {
            var cat = db.Cats.Find(id);
            if (cat != null)
            {
                db.Entry(cat).State = EntityState.Modified;
                Save();
                return cat;
            }
            else
                return cat;
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<catType> getCatType()
        {
            return db.catTypes.ToList();
        }
        public IEnumerable<FurType> getFurType()
        {
            return db.FurTypes.ToList();
        }
    }
}
