using Puppy.Repository;
using Puppy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy.Service
{
    public class DogService :  IDogService
    {
        private readonly IDogRepo _dogRepo;

        public DogService(IDogRepo dogRepo) 
        {
            _dogRepo = dogRepo;
        }

        public DogViewModel Create(DogCreateVM dog)
        {
            Dog newDog = _dogRepo.Create(new Dog
                {
                    name = dog.Name,
                    breed = dog.Breed,
                    age = dog.Age,
                    weight = dog.Weight,
                    size = dog.Size,
                    healthStatus = dog.HealthStatus,
                }
            );

            if (newDog == null)
            {
                return null;
            }
            else
            {
                return new DogViewModel(newDog);
            }

            throw new NotImplementedException();
        }

        public IEnumerable<DogViewModel> GetAll()
        {
            List<DogViewModel> dogList = new List<DogViewModel>();

            foreach (Dog dog in _dogRepo.GetAll())
            {
                dogList.Add(new DogViewModel(dog));
            }

            return dogList;
        }

        public DogViewModel FindByName(string name) 
        {
            var dog = _dogRepo.FindByName(name);
            if (dog == null)
            {
                return null;
            }
            else
            {
                return new DogViewModel(dog);
            }
        }

        public bool Update(DogViewModel dog)
        {
            Dog originalDog = _dogRepo.FindById(dog.Id);

            originalDog.name = dog.Name;
            originalDog.breed = dog.Breed;
            originalDog.size = dog.Size;
            originalDog.weight = dog.Weight;
            originalDog.healthStatus = dog.HealthStatus;

            _dogRepo.Update(originalDog);

            return true;
        }

        public bool Delete(string name)
        {
            var dog = _dogRepo.FindByName(name);
            if (dog != null)
            {
                return false;
            }
            else
            {
                _dogRepo.Delete(dog);
                return true;
            }
        }
    }
}
