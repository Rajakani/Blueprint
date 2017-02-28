using Roboweb;
using Roboweb.Controls;
using Roboweb.Pages;

namespace Blueprint.PageObjects
{
    public class ProjectManagementPage: Page, IPage
    {
        IGrid ProjectManagementGrid;
        
        public ProjectManagementPage(RoboBrowser browser) : base(browser)
        {
           
            ProjectManagementGrid = ControlFactory.Create<IGrid>("ProjectManagementGrid");
            ProjectManagementGrid.AddControl<ITextBox>("Text");

        }




    }
}