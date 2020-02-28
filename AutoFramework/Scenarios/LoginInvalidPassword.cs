namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [Test]
        public void LessThan5Chars()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, 
                Config.Credentials.Invalid.Password.FourCharacters);
            Thread.Sleep(1000);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }
        
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}