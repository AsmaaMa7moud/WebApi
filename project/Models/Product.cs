using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace project.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    
        public double Price { get; set; }
        public string Image { get; set; }
       
     
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [JsonIgnore]
        public virtual IdentityUser Customer { get; set; }


    }
}