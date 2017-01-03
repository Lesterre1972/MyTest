using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    internal class SignInPageObject : Page
    {
        public SignInPageObject(IWebDriver driver) : base(driver)
        {
            driver.Url = Constant.SignInURL;
        }

        [FindsBy(How = How.CssSelector, Using = "#create-account_form")]
        public IWebElement CreateForm { get; set; }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailCreateId { get; set; }
        
        public object SubmitCreate { get; internal set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement Submitbtn { get; set; }

 
    }
}