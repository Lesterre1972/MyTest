using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    internal abstract class Page
    {

        protected Page(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        protected IWebDriver _driver;

        public IWebDriver Driver
        {
            get { return _driver; }
            set
            {
                _driver = value;

            }
        }
    }
}