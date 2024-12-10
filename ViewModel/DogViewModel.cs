using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy.ViewModel
{
    public class DogViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public string HealthStatus { get; set; }

        public DogViewModel() { }

        public DogViewModel(Dog dog)
        {
            Id = dog.Id;
            Name = dog.name;
            Breed = dog.breed;
            Size = dog.size;
            Age = dog.age;
            Weight = dog.weight;
            HealthStatus = dog.healthStatus;
        }
    }
}
