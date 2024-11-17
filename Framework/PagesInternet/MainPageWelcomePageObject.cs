using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using NUnitSpecFlow.Framework;
using OpenQA.Selenium;


namespace ExampleProject.Framework.Pages
{
    internal class MainPageWelcomePageObject : Form
    {
        private ILink navigationLink(string navigation) => ElementFactory.GetLink(
            By.XPath(string.Format(LocatorConstants.PreciseTextLocator, navigation)), "Navigation link");


        public MainPageWelcomePageObject() : base(By.XPath("//*[@class='heading']"), "Main page")
        {
        }

        public void ClickNavigationLink(string navigationName)
        {
            var link = navigationLink(navigationName);
            link.State.WaitForClickable();
            link.Click();
        }

    }
}