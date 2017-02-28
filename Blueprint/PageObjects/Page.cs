using System.Collections.Generic;
using Roboweb.Pages;
using Roboweb.Controls;
using Roboweb;
namespace Blueprint.PageObjects
{
    public class Page : IPage
    {
        private List<IControl> controls;
        protected RoboBrowser Browser;
        protected ControlFactory ControlFactory;
        private string name;
        public Page(RoboBrowser browser)
        {
            Browser = browser;
            ControlFactory = new ControlFactory(browser);
        }
        public List<IControl> Controls
        {
            get{return this.controls;}
            set{this.controls = value;}
        }

        public string Name
        {
            get{return this.name;}
            set{this.name = value;}
        }

        public bool IsPageLoaded(string identifier)
        {
            return true;
        }
    }
}
