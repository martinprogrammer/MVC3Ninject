using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3Ninject.Models
{
    public class FakeCarRepository: IRepository
    {
        private List<Cars> theCars;

        public FakeCarRepository()
        {
            theCars = new List<Cars>();
        }
        
        public IEnumerable<Cars> getCars()
        {
            return theCars;
        }

        public Cars getCarByID(int ID)
        {
            return theCars.SingleOrDefault(p => p.ID == ID);
        }

        public void addCar(Cars theCar)
        {
            theCar.ID = getNewID();
            theCars.Add(theCar);
        }

        public void removeCar(int ID)
        {
            var carToRemove = theCars.Find(p => p.ID == ID);
            theCars.Remove(carToRemove);
        }

        public void updateCar(Cars theCar)
        {
            var carToUpdate = theCars.Find(p => p.ID ==theCar.ID);
            carToUpdate.Make = theCar.Make;
            carToUpdate.Model = theCar.Model;
        }

        private int getNewID()
        {
            var result = theCars.OrderByDescending(p => p.ID).FirstOrDefault();
            if (result == null)
            {
                return 1;
            }
            else
            {
                return result.ID + 1;
            }
        }
    }
}