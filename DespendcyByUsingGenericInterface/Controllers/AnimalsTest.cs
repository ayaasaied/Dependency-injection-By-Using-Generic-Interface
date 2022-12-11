using DespendcyByUsingGenericInterface.Interface;
using DespendcyByUsingGenericInterface.Models;
using Microsoft.AspNetCore.Mvc;

namespace DespendcyByUsingGenericInterface.Controllers
{
    public class AnimalsTestController : Controller
    {
        IAnimalGeneric<Dog> animalDog;
        IAnimalGeneric<Cat> AnimalCat;
       
        public AnimalsTestController(IAnimalGeneric<Dog> animalDog, IAnimalGeneric<Cat> AnimalCat)
        {
            this.animalDog = animalDog;
            this.AnimalCat = AnimalCat; 

        }
        public IActionResult Index()
        {
            var Dog = animalDog.GetAll();

            return View();
        }
    }
}
