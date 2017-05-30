namespace tomtekdevhome.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using tomtekdevhome.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<tomtekdevhome.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "tomtekdevhome.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "admin@tomtekdev.com"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = "admin@tomtekdev.com", Email = "admin@tomtekdev.com", LockoutEnabled = false };

                userManager.Create(user, "Bartisgr8!");
                roleManager.Create(new IdentityRole { Name = "admin" });
                userManager.AddToRole(user.Id, "admin");
            }
        }
    }
}
