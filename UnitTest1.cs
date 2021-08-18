using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Portfolio_Test_Automation_Project.Pages;
using System;

namespace Portfolio_Test_Automation_Project
{
    public class Tests
    {

        HomePage hp;
        [SetUp]
        public void Setup()
        {

            hp = new HomePage();

            hp.Load();
        

       }

        [TestCase]
        public void Test1()
        {


            if (hp.Click_On_Login().Equals("Login")){

                Assert.Pass();
            }

            
         }

    }
}
    
