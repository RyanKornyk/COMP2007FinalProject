using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2007FinalAssingment.Models
{
    public class Goal
    {
        public Goal()
        {

        }

        public virtual int GoalID { get; set; }
        public virtual string Title { get; set; }

        public virtual string Image { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Benefits { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}