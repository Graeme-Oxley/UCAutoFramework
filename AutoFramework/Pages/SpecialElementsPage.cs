namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

    }
}
