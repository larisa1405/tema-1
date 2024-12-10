using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puppy.ViewModel;

namespace Puppy.Service
{
    public interface IDogService
    {
        //C
        DogViewModel Create(DogCreateVM dog);

        //R
        IEnumerable<DogViewModel> GetAll();

        DogViewModel FindByName(string name);

        //U

        bool Update(DogViewModel dog);

        //D
        bool Delete(string name);

    }
}
