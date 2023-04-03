using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {

            //Open chrome browser
            driver.Manage().Window.Maximize();

            //launch Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Sign in Mars portal
            IWebElement signButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signButton.Click();
            Thread.Sleep(1000);

            //Identify email textbox and enter email
            IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailTextbox.SendKeys("ada@example.com");
            Thread.Sleep(1000);

            //Identify password textbox and enter password
            IWebElement enterpasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            enterpasswordTextbox.SendKeys("123456");
            Thread.Sleep(1000);

            //Identify remember me checkbox and click
            IWebElement remembermeCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            remembermeCheckbox.Click();
            Thread.Sleep(1000);

            //Identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(8000);




        }
    }
}
