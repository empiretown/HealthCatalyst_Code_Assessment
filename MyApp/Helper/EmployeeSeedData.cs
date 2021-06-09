using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Helper
{
    public static class EmployeeSeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 4,
                   Firstname = "Laura",
                   Lastname = "Reed",
                   Address = "80th DownTown Street, Rebel, 98000",
                   Interest = "Skydiving",
                   Age = 24

               },

                new Employee
                {
                    Id = 5,
                    Firstname = "Johnny",
                    Lastname = "Lott",
                    Address = "45 W 6th S, Village Lane, 670891",
                    Interest = "Swimming, Politics",
                    Age = 20

                },
                 new Employee
                 {
                     Id = 6,
                     Firstname = "JoAnn",
                     Lastname = "Orezi",
                     Address = " #12 Ifako Str, Nigeria, 400467",
                     Interest = "soccer, Binge watching movies",
                     Age = 29
                 }
            );
        
         }        
    }
}
