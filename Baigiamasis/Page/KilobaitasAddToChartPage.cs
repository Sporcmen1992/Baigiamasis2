using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Page
{
    class KilobaitasAddToChartPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/tinklo_gsm_gps_iranga%2Ftelefonai_ir_priedai%2Fmobilieji_telefonai%2Fxiaomi_redmi_9a_232gb_gray__37568/product.aspx?itemid=721292";
        private IWebElement _addButton => Driver.FindElement(By.CssSelector("#lytA_ctl08_buttonToCart > span"));
        private IWebElement _cartIcon => Driver.FindElement(By.Id("cartRound"));
        private IWebElement _buyButton => Driver.FindElement(By.CssSelector("#priceLabel > button"));
        private IWebElement _riseValue => Driver.FindElement(By.Id("qtyAdd-721292__"));
        private IWebElement _assertPrice => Driver.FindElement(By.CssSelector("#cartTotalSum > div > div.order-bottom-details > span.side-details.order-sum-total"));

        public  KilobaitasAddToChartPage(IWebDriver webDriver) : base(webDriver) { }

        public KilobaitasAddToChartPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;
        }

        public KilobaitasAddToChartPage AddToChart()
        {
            _addButton.Click();

            return this;
        }

        public KilobaitasAddToChartPage OverCartButton()
        {
            Actions actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(_cartIcon).Build().Perform();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));

            return this;

        }
        public KilobaitasAddToChartPage BuyButton()
        {
            _buyButton.Click();

            return this;
        }

        public KilobaitasAddToChartPage IncreasValue()
        {
            _riseValue.Click();

            return this;
        }

        public KilobaitasAddToChartPage AssertValue(string text)
        {
            Assert.AreEqual(text, _assertPrice.Text, "Price wrong!");


            return this;


        }
    }
}
