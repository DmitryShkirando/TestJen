using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Aquality.Selenium.Forms;


namespace NUnitSpecFlow.Framework.Pages2
{
    internal class DropDownPage : Form
    {

        private ILabel DropdownListPageIndicator = ElementFactory.GetLabel(By.XPath("//div[@id='content']/div[@class='example']"), "Use your current location");

        private IButton clickDropdownBtn => ElementFactory.GetButton(By.XPath("//select[@id='dropdown']"), "DropDown");

        private IButton clickOption1Btn => ElementFactory.GetButton(By.XPath("//option[@value='1']"), "DropDown");

        private ILabel Option1Label => ElementFactory.GetLabel(By.XPath("//option[@value='1' and text()='Option 1']"), "Option 1");

        public DropDownPage() : base(By.XPath("//option[contains(text(), 'Please select an option')]"), "Drop Down  page")
        {
        }

        public void DropDownPageIsOpenedCheck() => DropdownListPageIndicator.State.WaitForClickable();

        public void ClickDropdownBtn() => clickDropdownBtn.Click();
        public void ClickOptionBtn()
        {
            var link = clickOption1Btn;
            link.State.WaitForClickable();
            link.Click();
        }

        public bool IsOption1LabelDisplayed() => Option1Label.State.IsDisplayed;

    }
}
