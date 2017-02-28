using Blueprint.Common.Data;
using Roboweb;
using Roboweb.Controls;
using Roboweb.Pages;

namespace Blueprint.PageObjects
{
    public class V2OHomePage : Page, IPage
    {
        IButton PlaceOrderButton;
        public V2OHomePage(RoboBrowser browser) : base(browser)
        {
            PlaceOrderButton = ControlFactory.Create<IButton>("__tab_ct100_cphApp_tcMain_TabPanel2");
        }

        public bool PlaceOrder()
        {
            return PlaceOrderButton.Click();
        }

    }
}
