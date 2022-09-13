using Baigiamasis.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;
        public static KilobaitasAddToChartPage _kilobaitasAddToChartPage;
        public static KilobaitasLoginPage _kilobaitasLoginPage;
        public static KilobaitasAdressPage _kilobaitasAdressPage;
        public static KilobaitasSearchPage _kilobaitasSearchPage;



        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _kilobaitasAddToChartPage = new KilobaitasAddToChartPage(Driver);
            _kilobaitasLoginPage = new KilobaitasLoginPage(Driver);
            _kilobaitasAdressPage = new KilobaitasAdressPage(Driver);
            _kilobaitasSearchPage = new KilobaitasSearchPage(Driver);
        }


            [OneTimeTearDown]
            public static void TearDown()
            {
                Driver.Close();
            }
        }
    }
