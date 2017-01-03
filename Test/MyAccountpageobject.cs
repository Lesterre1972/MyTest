using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    internal class MyAccountPageObject : Page

    {
        public MyAccountPageObject(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "info-account")]
        public IWebElement AccountInfo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "# header > div.nav > div > div > nav > div:nth-child(2) > a")]
        public  IWebElement LogOut { get; set; }
    }
}