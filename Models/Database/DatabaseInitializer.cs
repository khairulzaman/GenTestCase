using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace GenTestCase.Models
{
    // Creates database if doesn't already exist
    public class CreateInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Seed(context);

            base.Seed(context);
        }
    }

    // Drops database and re-creates if model changes
    public class DropCreateAlwaysInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Seed(context);

            base.Seed(context);
        }
    }
}