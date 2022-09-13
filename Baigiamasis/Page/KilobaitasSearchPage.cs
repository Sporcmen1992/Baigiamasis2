using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Page
{
    class KilobaitasSearchPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";


        private IWebElement _searchField => Driver.FindElement(By.Id("search"));
        private IWebElement _insertText => Driver.FindElement(By.Name("lytA$ctl23$search"));
        private IWebElement _clickSearchButton => Driver.FindElement(By.Id("lytA_ctl23_searchBtn"));
        private IWebElement _clickItem => Driver.FindElement(By.CssSelector("#lytA_ctl29_UpdatePanel > div.category-products > div.products-grid.row > div:nth-child(3) > div > div.item-info.item-align > div.item-title.line-clamp > a > p"));
        private IWebElement _result => Driver.FindElement(By.ClassName("product-name"));


        public KilobaitasSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public KilobaitasSearchPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public KilobaitasSearchPage ClickSearchField()
        {
            _searchField.Click();

            return this;
        }
        public KilobaitasSearchPage InsertText(string value)
            {
                _insertText.Clear();
                _insertText.SendKeys(value);

                return this;
            }



            public KilobaitasSearchPage ClickSearchButton()
            {
                _clickSearchButton.Click();

                return this;
            }

            public KilobaitasSearchPage ClickItem()
            {
                 _clickItem.Click();

                return this;
            }

            public KilobaitasSearchPage Result(string text)
            {
            Assert.IsTrue(_result.Text.Contains(text), "Nothing was found!");

            return this;



            }
    }
}
