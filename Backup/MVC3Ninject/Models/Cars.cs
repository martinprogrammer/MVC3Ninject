using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC3Ninject.Models
{
    public class Cars: ICars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{get; set;}
        
        [Required]
        public string Make{get;set;}
        
        [Required]
        public string Model{get;set;}
        
    }
}