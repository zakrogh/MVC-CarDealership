using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

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
    public ActionResult AddCar()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult Create(string makemodel, int price, int miles)
    {
      Car myCar = new Car(makemodel, price, miles);
      return RedirectToAction("Index", "Home");
    }
  }
}
