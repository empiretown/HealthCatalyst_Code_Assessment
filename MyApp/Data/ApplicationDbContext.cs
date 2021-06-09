using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Models;
using MyApp.Helper;

namespace MyApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyApp.Models.Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-MyApp-5BE7FE40-DCF6-4958-B6A5-22ECEC3411FB;Trusted_Connection=True;MultipleActiveResultSets=true", builder => builder.EnableRetryOnFailure());
           
            base.OnConfiguring(optionsBuilder);
        }

        //Seeding the application database with data 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Firstname = "Jordan",
                    Lastname = "Alohan",
                    Address = "59th 11th Street, Turkey, 780002",
                    Interest = "Golfing",
                    Age = 30

                },

                 new Employee
                 {
                     Id = 2,
                     Firstname = "Johnny",
                     Lastname = "Belizuk",
                     Address = "249 Hilltop Street,Belgium, 80002-12",
                     Interest = "Skiing",
                     Age = 20

                 },
                  new Employee
                  {
                      Id = 3,
                      Firstname = "Janet",
                      Lastname = "Ohakwe",
                      Address = " #1 Transcorp Hill Road, Nigeria, 450232",
                      Interest = "Skiing",
                      Age = 45
                  }

            );
            
            base.OnModelCreating(builder);


        }
       
    }
}
