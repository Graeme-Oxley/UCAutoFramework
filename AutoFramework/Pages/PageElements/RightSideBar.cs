namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class RightSideBar
    {
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(1)")]
        public IWebElement FirstRecentPost { get; set; }

        [FindsBy(How = How.Name, Using = "cat")]
        public IWebElement CategoryMenu { get; set; }

    }
}
