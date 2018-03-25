using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeBeaBlog.Models
{
    public class Customer
    {

     
       [Key]  public int    ID { get; set; }
         
        public string CustomerName { get; set; }
        public string CustomerLast { get; set; }


    }
}