using Aquality.Selenium.Elements.Interfaces;
using ExampleProject.Framework.Tests;
using NUnitSpecFlow.Framework.Pages2;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;


namespace NUnitSpecFlow.Framework.Tests
{
    [AllureNUnit]
    [AllureSuite("Drop Down Test")]

    internal class WelcomeMessageIsPisplayed : BaseTest
    {
        private DropDownPage DropDownPage = new();

        string userName = settings.GetValue<string>("userName");
        string userPassword = settings.GetValue<string>("userPassword");

        [Test]
        public void WelcomeMessageIsPisplayedCheck()
        {
            ClickNavigationLink();
            DropDownPageIsOpenedCheck();
            ClickDropdownBtn();
            ClickOptionBtn();
            IsOption1LabelDisplayed();
        }

        [AllureStep("Click Link")]
        private void ClickNavigationLink()
        {
            mainPage.ClickNavigationLink("Dropdown");
        }

        [AllureStep("Open Check")]
        private void DropDownPageIsOpenedCheck()
        {
            DropDownPage.DropDownPageIsOpenedCheck();
        }

        [AllureStep("Open Drop Down")]
        private void ClickDropdownBtn()
        {
            DropDownPage.ClickDropdownBtn();
        }

        [AllureStep("Chose Option")]
        private void ClickOptionBtn()
        {
            DropDownPage.ClickOptionBtn();
        }

        [AllureStep("Check correct option")]
        private void IsOption1LabelDisplayed()
        {
            Assert.IsTrue(DropDownPage.IsOption1LabelDisplayed(), "Option 1 should be displayed on the page.");
        }
    }
}
