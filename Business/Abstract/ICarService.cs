using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetCarsByBrandId(int branId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal min,decimal max);

    }
}
