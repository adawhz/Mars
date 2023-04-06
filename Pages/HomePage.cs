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
        public void GoToSkills(IWebDriver driver)
        {
            //Navigate to skills page
            Thread.Sleep(1000);
            
            IWebElement skillsPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsPage.Click();
        }

        public void GoToEducation(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //navigate to education page
            IWebElement educationPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationPage.Click();
        }
        public void GoToCertification(IWebDriver driver)
        {
            //Navigate to certification page
            Thread.Sleep(1000);
            IWebElement certificationPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationPage.Click();
        }
    }
}
