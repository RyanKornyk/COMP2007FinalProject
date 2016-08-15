using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COMP2007FinalAssingment.Models;

namespace COMP2007FinalAssingment.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}