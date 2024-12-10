using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy.Repository
{
    public interface IDogRepo
    {
        //C
        Dog Create(Dog dog);

        //R
        Dog FindByName(string name);
        Dog FindById(int id);
        List<Dog> GetAll();

        //U
        void Update(Dog dog);

        //D
        void Delete(Dog dog);
    }
}
