using Roboweb;
using Roboweb.Controls;
using Roboweb.Pages;

namespace Blueprint.PageObjects
{
    public class HomePage : Page, IPage
    {
        IButton BlueprintButton;
        IButton GotoValleyButton;

        public HomePage(RoboBrowser browser) : base(browser)
        {
            BlueprintButton = ControlFactory.Create<IButton>("bluePrintMenu");
            GotoValleyButton = ControlFactory.Create<IButton>("ValyVirtualOfficemenu");
        }

        public ProjectManagementPage GotoBlueprint()
        {
            BlueprintButton.Click();
            return new ProjectManagementPage(Browser);
        }

        public V2OHomePage GotoValleyV2O()
        {
            GotoValleyButton.Click();
            return new V2OHomePage(Browser);
        }
    }
}