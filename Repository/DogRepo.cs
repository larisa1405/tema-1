using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Puppy.Data;

namespace Puppy.Repository
{
    public class DogRepo : IDogRepo
    {
        private readonly AppDbContext _appDb;
        public DogRepo(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public Dog Create(Dog dog)
        {            
            _appDb.Dogs.Add(dog);

            _appDb.SaveChanges();

            return dog;
        }

        public void Delete(Dog dog)
        {
            _appDb.Dogs.Remove(dog);
            _appDb.SaveChanges();
        }

        public List<Dog> GetAll()
        {
            return _appDb.Dogs.ToList();
        }

        public void Update(Dog dog)
        {
            _appDb.Entry(dog).State = EntityState.Modified;
            _appDb.SaveChanges();
        }

        public Dog FindByName(string name)
        {
            return _appDb.Dogs.SingleOrDefault(d => d.name == name);
        }

        public Dog FindById(int id)
        {
            return _appDb.Dogs.SingleOrDefault(d => d.Id == id);
        }
    }
}
