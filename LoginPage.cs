using System;
namespace Application
{
    public class LoginPage
    {
        // steps to login to TurnUp portal
        public void LoginSteps()
        {
            // Init and define webdriver
            IWebDriver driver = new ChromeDriver();

            // launch TurnUp portal
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // Maximize the browser
            driver.Manage().Window.Maximize();

            // Find Username textbox and input username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Find Password textbox and input password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Find login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();


            // Find hello hari hyperlink
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            // Validate if the text on the hyperlink is hello Hari
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged In successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }
        }
    }
}
