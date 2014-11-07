
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3Ninject.Models
{
    public interface IRepository
    {
        IEnumerable<Cars> getCars();
        Cars getCarByID(int ID);
        void addCar(Cars theCar);
        void removeCar(int ID);
        void updateCar(Cars theCar);
    }
}