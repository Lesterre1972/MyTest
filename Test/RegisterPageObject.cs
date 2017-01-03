using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test
{
    internal class RegisterPageObject : Page
    {
        public RegisterPageObject(IWebDriver driver) : base(driver)
        {
            //Need to start off on this URL.. if it is not already set, set the driver to be this
            if (driver.Url != Constant.RegisterURL)
            {
                driver.Url = Constant.RegisterURL;
            }
        }

        

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#customer_firstname")]
        public IWebElement CustomerFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#customer_lastname")]
        public IWebElement CustomerLastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#days>option:nth-child(5)")]
        public IWebElement Dateofbirth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#months>option:nth-child(8)")]
        public IWebElement Monthofbirth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#years>option:nth-child(39)")]
        public IWebElement Yearofbirth { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement CompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_state > option:nth-child(13)")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobilePhone { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement EmailAlias { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement RegisterBtn { get; set; }
    }
}
