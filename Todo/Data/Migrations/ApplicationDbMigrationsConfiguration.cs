using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.Entity.Migrations;

namespace Todo.Data.Migrations
{
    public class ApplicationDbMigrationsConfiguration : DbMigrationsConfiguration
    {
        public ApplicationDbMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
