using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy
{
    class Dog
    {
        public string name;
        public string breed;
        public string size;
        public int age;
        public int weight;
        public string healthStatus;

        public Dog(string aName, string aBreed, string aSize, int aAge, int aWeight, string aHealthStatus)
        {
            this.name = aName;
            this.breed = aBreed;
            this.size = aSize;
            this.age = aAge;
            this.weight = aWeight;
            this.healthStatus = aHealthStatus;
        }
    }
}
