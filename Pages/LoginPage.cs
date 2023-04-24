using MarsQA.Utilities;
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

        readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) { this.driver = driver; }

        public void LoginAction()
        {

            //Open chrome browser
            driver.Manage().Window.Maximize();

            //launch Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Sign in Mars portal
            signButton.Click();
            Wait.WaitToBeVisiable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input",5);
               
            //Identify email textbox and enter email
            emailTextbox.SendKeys("ada@example.com");

            //Identify password textbox and enter password
            enterpasswordTextbox.SendKeys("123456");

            //Identify remember me checkbox and click
            remembermeCheckbox.Click();

            //Identify login button and click
            loginButton.Click();
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span",5);
        }

        private IWebElement signButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement emailTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement enterpasswordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement remembermeCheckbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

    }
}
