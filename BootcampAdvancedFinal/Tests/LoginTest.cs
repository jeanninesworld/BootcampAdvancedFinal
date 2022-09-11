using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampAdvancedFinal.Tests
{
    [TestFixture]
    public class LogInAndOutTest : BaseTest
    {
        [Test(Description = "This will verfify Login")]
        [TestCase(TestName = "Verify Login")]
        public void LoginAndLogout()
        {
            PagesContext.HomePage.GetTitle().Should().Be("My Store");
        }
    }
}