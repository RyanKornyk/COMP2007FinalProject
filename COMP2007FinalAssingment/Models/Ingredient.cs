using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007FinalAssingment.Models
{
    public class Ingredient
    {
        public Ingredient()
        {

        }

        public virtual int IngredientID { get; set; }
        public virtual string Title { get; set; }

        public virtual List<string> Benefits { get; set; }

        public virtual string Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}