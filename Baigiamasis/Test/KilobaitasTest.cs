using Baigiamasis.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis.Test
{
    class KilobaitasTest : BaseTest
    {
        [Test]

        public static void TestKilobaitasaddToCart()
        {
            _kilobaitasAddToChartPage.NavigateToPage();
            _kilobaitasAddToChartPage.AddToChart();
            _kilobaitasAddToChartPage.OverCartButton();
            _kilobaitasAddToChartPage.BuyButton();
            _kilobaitasAddToChartPage.IncreasValue();
            _kilobaitasAddToChartPage.AssertValue("307,34 €");
        }

        [Test]
        public static void KilobaitasLoginTest()
        {
            string email = "ezik4mail.ru";
            string password = "860023377aA!";

            _kilobaitasLoginPage.NavigateToPage();
            _kilobaitasLoginPage.LoginButton();
            _kilobaitasLoginPage.UserFields();
            _kilobaitasLoginPage.PasswordField();
            _kilobaitasLoginPage.LogButton();
        }



        [Test]
        public static void KilobaitasAdress()
        {
            _kilobaitasAdressPage.NavigateToPage();
            _kilobaitasAdressPage.OverSalonAddress();
            _kilobaitasAdressPage.SelectCity();
        }

        [Test]
        public static void KilobaitasSearchPage()
        {

            string value = "Nešiojamasis kompiuteris Lenovo";

            _kilobaitasSearchPage.NavigateToDefaultPage();
            _kilobaitasSearchPage.ClickSearchField();
            _kilobaitasSearchPage.InsertText(value);
            _kilobaitasSearchPage.ClickSearchButton();
            _kilobaitasSearchPage.ClickItem();
            _kilobaitasSearchPage.Result(value);



        }
    }
}
