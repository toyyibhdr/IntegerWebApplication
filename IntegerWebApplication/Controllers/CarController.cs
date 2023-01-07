using Microsoft.AspNetCore.Mvc;
using IntegerWebApplication.Models;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            //var cars = new List<Car>();

           /* cars.Add(new Car()
            {
                IdRegistration = 1,
                Type = "Sedan",
                Brand = "Toyota",
                Varian = "FT86"
            });

            cars.Add(new Car()
            {
                IdRegistration = 2,
                Type = "SUV",
                Brand = "Toyota",
                Varian = "RAv4"
            });

            cars.Add(new Car()
            {
                IdRegistration = 3,
                Type = "Sedan",
                Brand = "Honda",
                Varian = "Accord"
            });

            cars.Add(new Car()
            {
                IdRegistration = 4,
                Type = "SUV",
                Brand = "Honda",
                Varian = "CRV"
            });

            cars.Add(new Car()
            {
                IdRegistration = 5,
                Type = "Sedan",
                Brand = "Honda",
                Varian = "City"
            });*/
          
            var cars = new Car[]{
            new Car{IdRegistration = 0001, Type = "Sedan", Brand = "Toyota", Varian = "FT86"},
            new Car{IdRegistration = 0002, Type = "SUV", Brand = "Toyota", Varian = "RAV4"},
            new Car{IdRegistration = 0003, Type = "Sedan", Brand = "Honda", Varian = "Accord"},
            new Car{IdRegistration = 0004, Type = "SUV", Brand = "Honda", Varian = "CRV"},
            new Car{IdRegistration = 0005, Type = "Sedan", Brand = "Honda", Varian = "City"},
            };




            //var search = cars.Single(x => x.IdRegistration == 2);
            //cars.Remove(search);

            //No 1
            /*            var tampil = cars.Where(x => x.Brand == "Honda").FirstOrDefault();
                        ViewBag.Cars = new List<Car>() { tampil};*/

            //No 2
            /*var tampil2 = cars.Where(x => x.Brand == "Honda" && x.Type == "Sedan");
            ViewBag.Cars = tampil2;
*/
            //3
            /*var tampil3 = cars.Where(x => x.Brand == "Honda" && x.Varian == "City");
            ViewBag.Cars = tampil3;
*/
            //4
            /*var tampil4 = cars.Where(x => x.Brand == "Toyota");
            ViewBag.Cars = tampil4;
*/
            //5
            /*var tampil5 = cars.Where(x => x.Varian == "City");
            ViewBag.Cars = tampil5;
*/
            //6
            var tampil6 = cars.Where(x => x.Brand == "Toyota" || x.Varian == "CRV");
            ViewBag.Cars = tampil6;


            return View();

        }
    }
}
