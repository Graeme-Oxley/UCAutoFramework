namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {     
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [TestCase]
        public void LessThan5Chars()
        {
            NavigateTo.LoginFormScenarioThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();            
        }

        [TestCase]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }
       
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}