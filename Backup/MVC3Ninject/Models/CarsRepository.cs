using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace MVC3Ninject.Models
{
    public class CarsRepository: IRepository
    {
        private CarsContext myContext;

        public CarsRepository()
        {
            myContext = new CarsContext();
        }
        
        public IEnumerable<Cars> getCars()
        {
            myContext.theCars.Where(p => p.Make.Contains("mits")).AsQueryable().Load();
            return myContext.theCars.Local.ToList();
            

            //return myContext.theCars.Where(p => p.Make.Contains("mits")).AsQueryable();

            //return myContext.theCars.ToList();
             
            
        }

        public Cars getCarByID(int ID)
        {
            return myContext.theCars.SingleOrDefault(p => p.ID == ID);
        }

        public void addCar(Cars theCar)
        {
            myContext.theCars.Add(theCar);
            myContext.SaveChanges();
        }

        public void removeCar(int ID)
        {
            var theCarToRemove = myContext.theCars.Find(ID);
            myContext.theCars.Remove(theCarToRemove);
            myContext.SaveChanges();
        }

        public void updateCar(Cars theCar)
        {
            //var theCarToEdit = myContext.theCars.Find(theCar.ID);
            //myContext.Entry(theCarToEdit).CurrentValues.SetValues(theCar);
            //var oc = myContext.ObjectContext();
            //oc.ApplyCurrentValues("theCars", theCar);

            //myContext.SaveChanges();

            //var theCarToEdit = myContext.theCars.Find(theCar.ID);
            //myContext.Entry(theCarToEdit).CurrentValues.SetValues(theCar);
            //myContext.SaveChanges();

            var oc = myContext.ObjectContext();
            oc.ApplyCurrentValues("theCars", theCar);
            oc.SaveChanges();



        }



    }
}