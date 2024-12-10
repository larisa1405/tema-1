using Microsoft.AspNetCore.Mvc;
using Puppy.Service;
using Puppy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puppy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet()]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IEnumerable<DogViewModel> GetAll()
        {
            IEnumerable<DogViewModel> dogViewModels = _dogService.GetAll();
            if (dogViewModels == null)
            {
                Response.StatusCode = 201;
            }
            else
            {
                Response.StatusCode = 400;
            }
            return dogViewModels;
        }

        [HttpGet("{name}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public DogViewModel GetDogByName([FromRoute] string name)
        {
            DogViewModel dogViewModels = _dogService.FindByName(name);
            if (dogViewModels == null)
            {
                Response.StatusCode = 201;
            }
            else
            {
                Response.StatusCode = 400;
            }
            return dogViewModels;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public DogViewModel Create(DogCreateVM dog)
        {
            DogViewModel dogViewModel = _dogService.Create(dog);
            if (dogViewModel == null)
            {
                Response.StatusCode = 400;
            }
            else
            {
                Response.StatusCode = 201;
            }
            return dogViewModel;
        }

        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(409)]
        public void Edit(DogViewModel dog)
        {
            if (_dogService.Update(dog))
            {
                Response.StatusCode = 204;
            }
            else
            {
                Response.StatusCode = 409;
            }
        }

        [HttpDelete("{name}")]
        [ProducesResponseType(202)]
        [ProducesResponseType(400)]
        public void Delete(string name)
        {
            if (_dogService.Delete(name))
            {
                Response.StatusCode = 202;
            }
            else
            {
                Response.StatusCode = 400;
            }
        }

    }
}
