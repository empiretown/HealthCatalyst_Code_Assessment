using Microsoft.AspNetCore.Mvc;

using MyApp.Data;
using Xunit;
using MyApp.Controllers;


namespace XunitIntegrationTestMyApp
{
    public class UnitTest1_pm_EntityFramework_Core_UseSqlServer_ApplicationDbContextTest
    {

        [Fact]
        public void Application_DbContext_Connects_To_UseSqlServer_Database()
        {
            ApplicationDbContext Dbcontext = new ApplicationDbContext();
            bool expected = true;
            bool result = Dbcontext.Database.CanConnect();



            Assert.Equal(expected, result);

        }

        [Fact]
        public async void Application_DbContext_Connects_To_UseSqlServer_Database_Async()
        {
            ApplicationDbContext Dbcontext = new ApplicationDbContext();
            bool expected = true;
            bool result = await Dbcontext.Database.CanConnectAsync();



            Assert.Equal(expected, result);

        }
    }
}
