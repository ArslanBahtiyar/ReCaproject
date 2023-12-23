using Business.Concrete;
using DataAcces.Abstracts;
using DataAcces.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager=new CarManager(new InMemoryCar());
            Car car1= new Car {Id=7,BrandId=3,ColorId=9,DailyPrice=33000,Description="yeni aracımız temiz araç",ModelYear=2019 };
            carManager.Add(car1);
            //carManager.Delete(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
