﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
       List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
    }
}
