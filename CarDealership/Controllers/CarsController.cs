using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using CarDealership.Models;
namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")] 
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

      [HttpPost("/cars")]
    public ActionResult Create(string makeModel, double price, int miles)
    {
      Car myCars = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

  }
}