using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roboweb.App;
using Blueprint.PageObjects;
using Blueprint.Common.Data;

namespace Blueprint.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var options = new Options();
            options.BrowserType = BrowserType.Chrome;
            options.Apphost = "v2o.valmont.com";
            options.SSL = false;
            TestData testData = new TestData()
            {
                LoginDetails = new LoginData()
                {
                    Username = "RM70",
                    Password = "Valmont@5"
                }
            };

            var app = new App(options).Start();
                      
            LoginPage loginPage = new LoginPage(app);
            HomePage homePage = loginPage.Login(testData);
            V2OHomePage v2OHomepage = homePage.GotoValleyV2O();
            v2OHomepage.PlaceOrder();

        }
    }
}
