using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Page
{
    class KilobaitasAdressPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";
        private IWebElement _address => Driver.FindElement(By.CssSelector("#sfHeadertop > div.header-default.header-v2 > div:nth-child(1) > div > div.yt-header-top > div > div > div.col-lg-6.col-md-5.top-links-action > div.block-action-header.top-link-account.our-shops-link > ul > li > span > b"));

        private IWebElement _dropdown => Driver.FindElement(By.CssSelector("#sfHeadertop > div.header-default.header-v2 > div:nth-child(1) > div > div.yt-header-top > div > div > div.col-lg-6.col-md-5.top-links-action > div.block-action-header.top-link-account.our-shops-link > ul > li > ul > li:nth-child(2) > a"));



        public KilobaitasAdressPage(IWebDriver webDriver) : base(webDriver) { }


        public KilobaitasAdressPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public KilobaitasAdressPage OverSalonAddress()
        {
            Actions actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(_address).Build().Perform();

            return this;
        }

        public KilobaitasAdressPage SelectCity()
        {
            _dropdown.Click();

            return this;
        }


        }
    }

