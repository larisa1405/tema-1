using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy.ViewModel
{
    public class DogCreateVM
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string HealthStatus { get; set; }
    }
}
