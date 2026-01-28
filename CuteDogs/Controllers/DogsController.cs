using CuteDogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace CuteDogs.Controllers
{
    public class DogsController : Controller
    {
        // LÅTSASDATABAS i form av en statisk lista
        private static List<Dog> _dogs = new List<Dog>
        {
            new Dog{ Id = 1, Name = "Lady Gaga", Cuteness = 9, Image = "dog1.jpg", FavFood = "Barkoni", FavToy = "Barkle", Temperament = 7, IsAdopted= false },
            new Dog{ Id = 2, Name = "Lady Swaggertail", Cuteness = 8, Image = "dog2.jpg", FavFood = "Pawsta", FavToy = "Fetch Stick", Temperament = 6, IsAdopted= false },
            new Dog{ Id = 3, Name = "La Bisquite", Cuteness = 6, Image = "dog3.jpg", FavFood = "Bone Appetit", FavToy = "Squeaky Ball", Temperament = 8, IsAdopted= false }
        };
        // METOD för att VISA hela listan med hundar på Start-sidan (Motsvarar GET i HTTP och READ i CRUD)
        public IActionResult Start()
        {
            //// ANGER att listan ska visa titeln "Våra hundar"
            //ViewData["Title"] = "Våra hundar";
            var allDogs = _dogs.OrderBy(d => d.Name).ToList();
            // SKICKAR listan med alla hundar till VIEW
            return View(allDogs);
        }
        // METOD för att VISA detaljer om en specifik hund baserat på dess Id 
        public IActionResult DogDetails(int id)
        {
            //// ANGER att listan ska visa titel 
            //ViewData["Title"] = "Våra hundar";
            // TAR EMOT id från ROUTE:n (asp-route-id) 
            var dog = _dogs.FirstOrDefault(d => d.Id == id);
            // SKICKAR en specifik hund till VIEW
            return View(dog);
        }
        // METOD för att VISA när adoption gått genom
        public IActionResult Adopted(int id)
        {
            //// ANGER att listan ska visa titeln "Våra hundar"
            //ViewData["Title"] = "Våra hundar";
            var adopted = _dogs.FirstOrDefault(d => d.Id == id);
            if (adopted != null)
            {
                adopted.IsAdopted = true;
            }
            return RedirectToAction("Start");
        }
    }
}
