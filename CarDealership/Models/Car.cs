using System.Collections.Generic;
namespace CarDealership.Models
{
  class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car>{};
    public static List<Car> GetAll()
    {
      return _instances;
    }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
  }
}
