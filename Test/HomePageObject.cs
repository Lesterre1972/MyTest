using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    internal class HomePageObject : Page
    {
        public HomePageObject(IWebDriver driver) : base(driver)
        {
            driver.Url = Constant.RegisterURL;
        }

        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div.header_user_info > a")]
        public IWebElement SignIn { get; set; }

    }
}
