namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
