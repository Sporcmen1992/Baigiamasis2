using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Page
{
    class KilobaitasLoginPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";
        private IWebElement _logIn => Driver.FindElement(By.CssSelector("#lytA_ctl08_LogIn > b"));
        private IWebElement _emailField => Driver.FindElement(By.CssSelector("#lytA_ctl08_UserName"));
        private IWebElement _passwordField => Driver.FindElement(By.Id("lytA_ctl08_Password"));
        private IWebElement _loginButton => Driver.FindElement(By.Id("lytA_ctl08_LoginButton"));
        private IWebElement _emailResult => Driver.FindElement(By.Id("lytA_ctl08_UserName"));
        private IWebElement _passwordResult => Driver.FindElement(By.Id("lytA_ctl08_Password"));




        public KilobaitasLoginPage(IWebDriver webdriver) : base(webdriver) { }



        public KilobaitasLoginPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;

            
        }

        public KilobaitasLoginPage LoginButton()
        {
            _logIn.Click();


            return this;
        }


        public KilobaitasLoginPage UserFields()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2)); 
            wait.Until(d => d.FindElement(By.CssSelector("#modal-login > div > div")).Displayed);
            _emailField.Clear();
            _emailField.SendKeys("ezik4@mail.ru");

            return this;
        }

        public KilobaitasLoginPage PasswordField()
        {
            _passwordField.Clear();
            _passwordField.SendKeys("860023377aA!");


            return this;
        }

        public KilobaitasLoginPage LogButton()
        { 
            _loginButton.Click();

            return this;
        }


        public KilobaitasLoginPage AssertLogin(string expectedResult)
        {
            Assert.AreEqual($"Email:{expectedResult}", _emailResult.Text, "Email is wrong!");
            Assert.AreEqual($"Password;{expectedResult}", _passwordResult.Text, "Password is wrong");

            return this;
        }

    }
}
