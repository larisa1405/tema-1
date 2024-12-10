using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Puppy.Data
{
    internal class DbInitializer
    {
        internal static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();//applies any pending migrations for the context to the database.

            if (context.Dogs.Any())//Check if there are any people in the database, if there are end the Initialize here. 
            {
                return;
            }
        }
    }
}
