using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstracts
{
    public interface ICarDal
    {
        List<Car> GetById(Car car);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
