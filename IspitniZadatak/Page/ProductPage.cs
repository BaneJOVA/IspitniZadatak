using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IspitniZadatak.Page
{
    internal class ProductPage
    {
        private IWebDriver driver = WebDriver.Instance;
        public IWebElement AddBackPac => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddT_Shirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement SortByHighPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement MenuClick => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement AboutClick => driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement ShoppingCardClick => driver.FindElement(By.Id("shopping_cart_container"));


        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByHighPrice);
            element.SelectByText(text);
        }
    }
}