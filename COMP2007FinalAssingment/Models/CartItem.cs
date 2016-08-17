using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMP2007FinalAssingment.Models
{
    public class CartItem
    {
         
        [Key]
        public int RecordId { get; set; }
        public string CartItemId { get; set; }
        
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    
        
}
}