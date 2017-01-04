using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test;


namespace Practice
{
    internal class Program
    {
        //Create reference for driver
        private readonly IWebDriver driver = new ChromeDriver();

        private dynamic page;

        private static void Main(string[] args)
        {
        }

        [SetUp]
        public void BeforeTest()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            //Navigate to practice test
            driver.Navigate().GoToUrl("http://automationpractice.com");

            //Enlage window for better viewing
            driver.Manage().Window.Maximize();
            //Browser waits for 10 seconds
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Test]
        public void SignInAndRegisterTest()
        {
            //Home page
            var homePage = new HomePageObject(driver);
          
            //Click on sign in link on upper right of home page
            homePage.SignIn.Click();


            //Account sign in page
            var signInPage = new SignInPageObject(driver);

            IWebElement createForm = driver.FindElement(By.CssSelector("#create-account_form > h3"));

            //Verify "create an account" text appears on page 
            StringAssert.AreEqualIgnoringCase("create an account", createForm.Text);
            //Enter email address
            signInPage.EmailCreateId.SendKeys("mypracti1ddddddcetest1@mypractice.com");
            //ckick the submit buttton
            signInPage.Submitbtn.Click();

            //Check to make sure click was successful..

            while (driver.Url != Constant.RegisterURL)
            {
            }
            //Account register page
                var regPage = new RegisterPageObject(driver);

                //Enter informmation in all required fields
                regPage.Title.Click();
                regPage.CustomerFirstName.SendKeys("Johnny");
                regPage.CustomerLastName.SendKeys("Smith");
                regPage.Email.Clear();
                regPage.Email.SendKeys("mypract1idddddddcetest1@mypractice.com");
                regPage.Password.SendKeys("54321");
                regPage.Dateofbirth.Click();
                regPage.Monthofbirth.Click();
                regPage.Yearofbirth.Click();
                regPage.FirstName.Clear();
                regPage.FirstName.SendKeys("Johnny");
                regPage.LastName.Clear();
                regPage.LastName.SendKeys("Smith");
                regPage.CompanyName.SendKeys("Acme Inc.");
                regPage.Address.SendKeys("100 Main Street");
                regPage.City.SendKeys("Any Town");
                regPage.State.Click();
                regPage.ZipCode.SendKeys("12345");
                regPage.Country.Click();
                regPage.MobilePhone.SendKeys("(123)987-6543");
                regPage.EmailAlias.Clear();
                regPage.EmailAlias.SendKeys("HappyNewYear");
                regPage.RegisterBtn.Click();


            // Account create page
            MyAccountPageObject actPage = new MyAccountPageObject(driver);

            //CssSelector where text to be verified is located
            IWebElement accountInfo = driver.FindElement(By.CssSelector("#center_column>p"));
            
            //Verify welcome to your account is visible on My Account Info page
            Assert.IsTrue(driver.PageSource.Contains("Welcome to your account"));

        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            //Close browser
         driver.Close();
        }
    }
}