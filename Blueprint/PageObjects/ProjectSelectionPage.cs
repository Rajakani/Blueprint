using Roboweb;
using Roboweb.Controls;
using Roboweb.Pages;

namespace Blueprint.PageObjects
{
    public class ProjectSelectionPage : Page, IPage
    {
        IButton OpenExistingProject;
        IButton StartNewProjectWithMap;
        IButton StartNewProjectWithoutMap;

        public ProjectSelectionPage(RoboBrowser browser) : base(browser)
        {
            OpenExistingProject = ControlFactory.Create<IButton>("bluePrintMenu");
            StartNewProjectWithMap = ControlFactory.Create<IButton>("bluePrintMenu");
            StartNewProjectWithoutMap = ControlFactory.Create<IButton>("bluePrintMenu");
        }

        public ProjectManagementPage OpenExistingProjectPage()
        {
            OpenExistingProject.Click();
            return new ProjectManagementPage(Browser);
        }

    }
}