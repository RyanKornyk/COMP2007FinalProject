using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2007FinalAssingment.Models
{
    public class Brand
    {
        public Brand()
        {

        }

        public virtual int BrandID { get; set; }
        public virtual string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual string Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}