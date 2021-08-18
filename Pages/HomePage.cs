using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Test_Automation_Project.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage()
        {
            driver = new ChromeDriver(@"C:\Drivers");
            // PageFactory.InitElements(driver, this);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Login')]")]
        private IWebElement LoginText;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign In')]")]
        private IWebElement LoginButton;

        private string Url = "https://courses.letskodeit.com/";

        public void Load()
        {
            driver.Navigate().GoToUrl(Url);
        }
        public void Close()
        {
            driver.Close();
        }

        public string Click_On_Login()
        {
            LoginButton.Click();

            return LoginText.Text;
           
        }


    }

        



    
}
