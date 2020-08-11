using System;
namespace Application
{
    public class Homepage
    {
        {
        // navigate to Time and Material page
        public void NavigateToTM(IWebDriver driver)
        {
            // Navigate to Time and Material page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
    }
}
