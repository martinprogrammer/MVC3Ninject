using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3Ninject.Models
{
    public interface ICars
    {
        int ID { get; set; }
        string Make { get; set; }
        string Model { get; set; }
    }
}