using DataAcces.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;
        public InMemoryCar()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=2,ColorId=0,DailyPrice=85000,ModelYear=2003,Description="2 parçada boya var"},
                new Car {Id=2,BrandId=2,ColorId=3,DailyPrice=79000,ModelYear=2005,Description="Araç Taklalı komple boyalı"},
                new Car {Id=3,BrandId=3,ColorId=7,DailyPrice=46000,ModelYear=2011,Description="1 parçada boya var"},
                new Car {Id=4,BrandId=3,ColorId=1,DailyPrice=120000,ModelYear=2017,Description="Arabada boya yok"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateCar.Id = car.Id;
            updateCar.BrandId = car.BrandId;
            updateCar.ColorId = car.ColorId;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.Description = car.Description;
            updateCar.DailyPrice = car.DailyPrice;
        }
    }
}
