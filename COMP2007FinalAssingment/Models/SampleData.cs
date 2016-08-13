using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace COMP2007FinalAssingment.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<AtlasStoreContext>
    {
        protected override void Seed(COMP2007FinalAssingment.Models.AtlasStoreContext context)
        {
        }
        }
}