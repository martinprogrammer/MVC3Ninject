using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


namespace MVC3Ninject.Models
{
    public class Cars: ICars
    {
        [Key]
        public int ID{get; set;}
        
        [Required]
        public string Make{get;set;}
        
        [Required]
        public string Model{get;set;}
        
    }
}