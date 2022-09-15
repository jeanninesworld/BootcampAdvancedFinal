using BootcampAdvancedFinal.DriverFactory;
using BootcampAdvancedFinal.Pages;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampAdvancedFinal.Tests
{

    [TestFixture]
    public class LogInAndOutTest : TestSetup

    {
        HomePage homePage;

        static string url = "http://automationpractice.com/index.php";

        [SetUp]
        public void Init()
        {
            homePage = new HomePage(this.driver);            
        }

        [Test(Description = "This will verfify Login")]
        [TestCase(TestName = "Verify Login")]
        public void LoginAndLogout()
        {
            driver.Navigate().GoToUrl(url);
            homePage.GetViewLabel();
        }
    }
}