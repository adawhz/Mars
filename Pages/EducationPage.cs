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
            educationPage.Click();

            //Click add new button
            educationAddButton.Click();

            //Input university name into university textbox
            universityName.SendKeys("Tianjin ForeignStudies University");

            //Select university country from dropdown
            universityCountry.Click();
            universityCountryOption.Click();

            //Select title from dripdown
            titleDropdown.Click();
            titleOption.Click();

            //Input degree into degree textbox
            degreeTextbox.SendKeys("Post Graduate Diploma");

            //Select year of graduation from dropdown
            yearOfGraduationDropdown.Click();
            yearOfGraduation.Click();

            //Click on save button
            educationSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);


        }
        public string GetLastEducation()
        {
            return checkOfEducationUniversity.Text;
        }
        public void EditEducation(string country, string university)
        {
            //Eidting an existing education record
            //Click on the edit button of the last education record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]", 5);
            educationToBeEditButton.Click();
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[2]/select", 5);


            //Edit the last education record
            SelectElement countrySelect = new(educationToBeEditCountry);
            countrySelect.SelectByValue(country);
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input", 5);

            educationToBeEditUniversity.Clear();
            educationToBeEditUniversity.SendKeys(university);

            //Click update button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]", 5);
            educationUpdateButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }
        public string GetEditedEducationCountry()
        {
            //Check if the last education country record has been updated successfully
            return checkOfEducationCountry.Text;
        }
        public string GetEditedEducationUniversity()
        {
            //Check if the last education university has been updated successfully
            return checkOfEducationUniversity.Text;
        }

        public void DeleteEducation()
        {
            //Delete an existing education record
            //Click on delete button of the last education record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]", 5);
            educationToBeDeleteButton.Click();


        }
        private IWebElement educationPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private IWebElement educationAddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private IWebElement universityName => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private IWebElement universityCountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement universityCountryOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[32]"));
        private IWebElement titleDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement titleOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[9]"));
        private IWebElement degreeTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private IWebElement yearOfGraduationDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private IWebElement yearOfGraduation => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[13]"));
        private IWebElement educationSaveButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private IWebElement educationToBeEditButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]"));
        private IWebElement educationToBeEditCountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[2]/select"));
        private IWebElement educationToBeEditUniversity => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input"));
        private IWebElement educationUpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[3]/input[1]"));
        private IWebElement checkOfEducationCountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement checkOfEducationUniversity => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private IWebElement educationToBeDeleteButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]"));


    }
}
