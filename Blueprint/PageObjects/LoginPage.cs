using Blueprint.Common.Data;
using Roboweb;
using Roboweb.Controls;
using Roboweb.Pages;


namespace Blueprint.PageObjects
{
    internal class LoginPage : Page, IPage
    {
        ITextBox Username;
        ITextBox Password;
        IButton Submit;
        public LoginPage(RoboBrowser browser): base(browser)
        {
            Name = "LoginPage";
            Username = ControlFactory.Create<ITextBox>("Login1_UserName");
            Password = ControlFactory.Create<ITextBox>("Login1_Password");
            Submit = ControlFactory.Create<IButton>("Login1_Login");
        }

        public HomePage Login(TestData data)
        {
            Username.Type(data.LoginDetails.Username);
            Password.Type(data.LoginDetails.Password);           
            Submit.Click();
            return new HomePage(Browser);
        }
    }
}
