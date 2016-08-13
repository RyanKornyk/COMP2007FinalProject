namespace COMP2007FinalAssingment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AtlasStoreContext : DbContext
    {
        public AtlasStoreContext()
            : base("name=AtlasStoreConnection")
        {
        }


       public virtual DbSet<Product> Products { get; set; }

       public virtual DbSet<Goal> Goals { get; set; }

       public virtual DbSet<Ingredient> Ingredients { get; set; }

       public virtual DbSet<Brand> Brands { get; set; }
    }
}
