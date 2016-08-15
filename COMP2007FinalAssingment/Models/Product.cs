using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2007FinalAssingment.Models
{
    public class Product
    {
        public Product()
        {

        }

        public virtual int ProductID { get; set; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual string Image { get; set; }

        [Range(0, 5)]
        public virtual int Rating { get; set; }

        public virtual int IngredientID { get; set; }
        public virtual Ingredient Ingredient {get;set;}

        public virtual int BrandID { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual int GoalID { get; set; }
        public virtual Goal Goal { get; set; }


    }
}