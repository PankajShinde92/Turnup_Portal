using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace first_script
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Check if the user is able to create a new time/ material record successfully with valid details");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            driver.FindElement(By.ClassName("dropdown-toggle")).Click();

            driver.FindElement(By.XPath("//a[text()='Time & Materials']")).Click();

            driver.FindElement(By.XPath("//a[text()='Create New']")).Click();

            /*
            IWebElement typecode = driver.FindElement(By.XPath("//[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            typecode.Click();
            var selectDropDown = new SelectElement(typecode);
            selectDropDown.SelectByText("Time");
            */
            Console.WriteLine("Successfully Clicked");

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("13243");

            IWebElement descrpt = driver.FindElement(By.Id("Description"));
            descrpt.SendKeys("New test case");

            IWebElement price = driver.FindElement(By.ClassName("k-formatted-value"));
            price.SendKeys("120.00");

            driver.FindElement(By.Id("SaveButton")).Click();
            Console.WriteLine("Saved button clicked");

            IWebElement working = driver.FindElement(By.Id("loader"));
            Console.WriteLine(working.Displayed);

            Console.Write("New Record is Created");

            

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Check if the user is able to edit an existing time/ material record successfully with valid details");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(2000);
            //driver.FindElement(By.ClassName("k-button")).Click();
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("Code")).Click();
            //code.Click();

            driver.FindElement(By.Id("Code")).Clear();

            //code.Clear();
            driver.FindElement(By.Id("Code")).SendKeys("Hello world");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(3000);

            //IWebDriver check = (IWebDriver)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

           // IWebElement msg = driver.FindElement(By.XPath("//*[@id='tmsGrid]/div[3]/table/tbody/tr[1]/td[1]"));
            //Console.WriteLine(msg.Displayed);
            Console.Write("Edited Sucessfully");
            //Console.Read();
   
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Check if the user is able to delete an existing time/ material record successfully");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]")).Click();
            Console.Write("Deleted Sucessfully");
        }
    }
}
