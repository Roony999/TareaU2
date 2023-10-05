using Microsoft.AspNetCore.Mvc;
using TareaU2.Models;
using TareaU2.Models.ViewModels;

namespace TareaU2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(indexvm vm)
        {
            AnimalesContext context = new AnimalesContext();
            List<animalcl> datos = context.Clase.Select(Clase => new animalcl
            {
                id = Clase.Id,
                Nombre = Clase.Nombre,
                descripcion = Clase.Descripcion

            }).ToList(); 
            vm.AnimalCLS = datos;
            return View(vm);
        }

        public IActionResult Especies(string nombrees)
        {
            AnimalesContext context = new AnimalesContext();
            List<Especiec> datos = context.Especies.Where(x=>x.IdClaseNavigation.Nombre == nombrees).Select(x => new Especiec
            {
                Id = x.Id,
                Especie = x.Especie,
                idclase = x.IdClase
            }).ToList();
            EspeciesVM vm = new EspeciesVM();
            vm.Especiesls = datos;
            vm.id = datos.First().idclase;
            vm.nombre = nombrees;
            return View(vm);
        }
        public IActionResult Especie(string nombreesp)
        {
            AnimalesContext context = new AnimalesContext();
            var animal = context.Especies.Where(x=>x.Especie == nombreesp).Select(x=> new Especievm 
            { Id = x.Id, Habitat = x.Habitat, Observaciones = x.Observaciones,Peso = x.Peso, Tamano = x.Tamaño,NombreClase = x.IdClaseNavigation.Nombre
            }).First();
            
            return View(animal);
        }

    }
}
