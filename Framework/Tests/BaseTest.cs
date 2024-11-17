using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using ExampleProject.Framework.Pages;




namespace ExampleProject.Framework.Tests
{
    internal class BaseTest
    {
        protected MainPageWelcomePageObject mainPage = new(); 
        protected Browser browser;

        protected static readonly JsonSettingsFile testdata = new JsonSettingsFile(
             Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "testdata.json"));
        protected static readonly JsonSettingsFile config = new JsonSettingsFile(
             Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "config.json"));
        protected static readonly JsonSettingsFile settings = new JsonSettingsFile(
             Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "settings.json"));
        string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "settings.json");


        [SetUp]
        public void SetUp()
        {
            browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(settings.GetValue<string>("url2"));
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}