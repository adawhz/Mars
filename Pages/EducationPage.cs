using MarsQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
   public class EducationPage
    {
        private readonly IWebDriver driver;

        public EducationPage(IWebDriver driver) { this.driver = driver; }

        public void CreateEducation()
        {
            //Add new education
            //navigate to education page
            IWebElement educationPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationPage.Click();

            //Click add new button
            IWebElement educationAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddButton.Click();

            //Input university name into university textbox
            IWebElement universityName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityName.SendKeys("Tianjin ForeignStudies University");

            //Select university country from dropdown
            IWebElement universityCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            universityCountry.Click();
            IWebElement universityCountryOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[32]"));
            universityCountryOption.Click();

            //Select title from dripdown
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();
            IWebElement titleOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[9]"));
            titleOption.Click();

            //Input degree into degree textbox
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextbox.SendKeys("Post Graduate Diploma");

            //Select year of graduation from dropdown
            IWebElement yearOfGraduationDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearOfGraduationDropdown.Click();
            IWebElement yearOfGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[13]"));
            yearOfGraduation.Click();

            //Click on save button
            IWebElement educationSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            educationSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);


        }
        public string GetLastEducation()
        {
            IWebElement newEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newEducation.Text;
        }
        public void EditEducation(string country, string university)
        {
            //Eidting an existing education record
            //Click on the edit button of the last education record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]", 5);
            IWebElement educationToBeEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]"));
            educationToBeEditButton.Click();
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[2]/select", 5);


            //Edit the last education record
            IWebElement educationToBeEditCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[2]/select"));
            SelectElement countrySelect = new(educationToBeEditCountry);
            countrySelect.SelectByValue(country);
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input", 5);

            IWebElement educationToBeEditUniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input"));
            educationToBeEditUniversity.Clear();
            educationToBeEditUniversity.SendKeys(university);

            //Click update button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]", 5);
            IWebElement educationUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]"));
            educationUpdateButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }
        public string GetEditedEducationCountry()
        {
            //Check if the last education country record has been updated successfully
            IWebElement checkOfEducationCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfEducationCountry.Text;
        }
        public string GetEditedEducationUniversity()
        {
            //Check if the last education university has been updated successfully
            IWebElement checkOfEducationUniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfEducationUniversity.Text;
        }

        public void DeleteEducation()
        {
            //Delete an existing education record
            //Click on delete button of the last education record
            IWebElement educationToBeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]"));
            educationToBeDeleteButton.Click();


        }

    }
}
