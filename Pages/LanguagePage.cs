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
    public class LanguagePage
    {
        private readonly IWebDriver driver;

        public LanguagePage(IWebDriver driver) { this.driver = driver; }

        public void CreateLanguage()
        {
            //Add new languages
            //Click on add new language button

            addLanguageButton.Click();

            //Input language into add language textbox
            languageTextbox.SendKeys("Chinese");

            //Select language level from language level dropdown
            languageLevelDropdown.Click();
            languageLevelOption.Click();

            //Click on save button
            languageSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 10);

        }
        public string GetLastLanguage()
        {
            return newLanguage.Text;
        }
        public void EditLanguage(string languagename, string languagelevel)
        {
            //Edit the last language record
            //Click edit button of last language record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]", 5);
            lastLanguageEditButton.Click();

            //Edit language name and language level of the last language record
            lastLanguageToBeEditTextbox.Clear();
            lastLanguageToBeEditTextbox.SendKeys(languagename);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 5);
            SelectElement lastLanguageLevelSelect = new(lastLanguageToBeEditLevel);
            lastLanguageLevelSelect.SelectByValue(languagelevel);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]", 5);

            //Click on update button
            languageUpdateBUtton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }

        public string GetEditedLanguageName()
        {
            //Check if the last language name record has been edited successfully
            return newLanguage.Text;

        }
        public string GetEditedLanguageLevel()
        {
            //Check if the last language level record has been edited successfully
            return checkOfEditLanguageLevel.Text;
        }

        public void DeleteLanguage()
        {
            //Delete an existing language record
            //Delete the last language record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]", 5);
            lastLanguageDeleteButton.Click();

        }
        public string GetPopUpMessage()
        {
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);
            IWebElement popupNotice = driver.FindElement(By.CssSelector(".ns-box-inner"));
            return popupNotice.Text;
        }

        private IWebElement addLanguageButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private IWebElement languageLevelDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement languageLevelOption => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
        private IWebElement languageSaveButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement newLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement lastLanguageEditButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
        private IWebElement lastLanguageToBeEditTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private IWebElement lastLanguageToBeEditLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private IWebElement languageUpdateBUtton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        private IWebElement checkOfEditLanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private IWebElement lastLanguageDeleteButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));


    }
}

   
