using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class HomePage
    {

        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver) { this.driver = driver; }

        public void GoToSkills()
        {
            //Navigate to skills page
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);
            skillsPage.Click();
        }

        public void GoToEducation()
        {
            //navigate to education page
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5); 
            educationPage.Click();
        }
        public void GoToCertification()
        {
            //Navigate to certification page
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            certificationPage.Click();
        }
        private IWebElement skillsPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement educationPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private IWebElement certificationPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
    }
}
