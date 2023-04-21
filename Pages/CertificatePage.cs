using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class CertificatePage
    {


        private readonly IWebDriver driver;

        public CertificatePage(IWebDriver driver) { this.driver = driver; }

        public void CreateCertification()
        {
            //Add new certifiations
            //Navigate to certification page
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
            IWebElement certificationPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationPage.Click();

            //Click add new button
            IWebElement certifiationAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certifiationAddButton.Click();

            //Input certificate into certificate textbox
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextbox.SendKeys("ISTQB Certified Tester Foundation Level");

            //Input organization into certified from textbox
            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextbox.SendKeys("ISTQB");

            //Select year of certification from dropdown
            IWebElement yearOfCertificationDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearOfCertificationDropdown.Click();
            IWebElement yearOfCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            yearOfCertification.Click();

            //Click on save button
            IWebElement certificationSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificationSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);


        }
        public string GetLastCertification()
        {
            IWebElement newCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newCertification.Text;
        }

        public void EditCertification(string certificatename, string certificatefrom)
        {
            //Eidting an existing certification record
            //Click on edit button of the last certification record
            IWebElement certificationToBeEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]"));
            certificationToBeEditButton.Click();
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input", 5);
            IWebElement certificateTobeEditName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input"));
            certificateTobeEditName.Clear();
            certificateTobeEditName.SendKeys(certificatename);
            IWebElement certificateToBeEditFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input"));
            certificateToBeEditFrom.Clear();
            certificateToBeEditFrom.SendKeys(certificatefrom);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]", 5);


            //Click on update button
            IWebElement certificateUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            certificateUpdateButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }

        public string GetEditedCertificateName()
        {
            IWebElement checkOfCertificateName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfCertificateName.Text;
        }
        public string GetEditedCertificateFrom()
        {
            IWebElement checkOfCertificateFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfCertificateFrom.Text;
        }
        public void DeleteCertification()
        {
            //Delete an existing certification record
            //Click on delete button of the last certification record
            IWebElement certificationToBeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]"));
            certificationToBeDeleteButton.Click();
        }
    }
}
