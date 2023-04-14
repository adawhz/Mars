using FluentAssertions;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class ProfilePage
    {
        public void EditDescription(IWebDriver driver)
        {
            //Edit new description
            //Click on create new description icon
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 5);

            IWebElement createDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
            createDescription.Click();

            //Input description
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("I like playing badminton in my spare time.");

            //Click on save button
            IWebElement descriptionSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            descriptionSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }

        public string GetDescription(IWebDriver driver)
        {
            
            //Check if the new discription has been saved
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return newDescription.Text;
        }

        public void CreateLanguage(IWebDriver driver)
        {
            //Add new languages
            //Click on add new language button
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addLanguageButton.Click();

            //Input language into add language textbox
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextbox.SendKeys("Chinese");

            //Select language level from language level dropdown
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown.Click();
            IWebElement languageLevelOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            languageLevelOption.Click();

            //Click on save button
            IWebElement languageSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 10);


        }
        public string GetLastLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;
        }
        public void EditLanguage(IWebDriver driver, string languagename, string languagelevel)
        {
            //Edit an existing language record
            //Click edit button of last language record
            IWebElement languageEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
            languageEditButton.Click();

            //Edit language name and language level of the last language record
            IWebElement languageToBeEditTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            languageToBeEditTextbox.Clear();
            languageToBeEditTextbox.SendKeys(languagename);
            IWebElement languageToBeEditLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            SelectElement languageLevelSelect = new(languageToBeEditLevel);
            languageLevelSelect.SelectByValue(languagelevel);

            //Click on update button
            IWebElement languageUpdateBUtton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            languageUpdateBUtton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);

        }

        public string GetEditedLanguageName(IWebDriver driver)
        {
            //Check if the last language name record has been edited successfully
            IWebElement checkOfEditLanguageName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfEditLanguageName.Text;

        }
        public string GetEditedLanguageLevel(IWebDriver driver)
        {
            //Check if the last language level record has been edited successfully
            IWebElement checkOfEditLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfEditLanguageLevel.Text;
        }
    
        public void DeleteLanguage(IWebDriver driver)
        {
            //Delete an existing language record
            //Delete the last language record
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]", 5);
            IWebElement recordTobeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            recordTobeDeleteButton.Click();
            
           
        } 
        public string GetPopUpMessage(IWebDriver driver)
        {
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);
            IWebElement popupNotice = driver.FindElement(By.CssSelector(".ns-box-inner"));
            return popupNotice.Text;
        }



        public void CreateSkill(IWebDriver driver)
        {
            //Add new skills
            //Navigate to skills page
            IWebElement skillsPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsPage.Click();

            //Click add new button
            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addSkillButton.Click();

            //Input skill into add skill textbox
            IWebElement skillTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextbox.SendKeys("Editing");

            //Selct skill level from skill level dropdown
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();
            IWebElement skillLevelOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skillLevelOption.Click();

            //Click on save button
            IWebElement skillSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillSaveButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);



        }
        public string GetLastSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        }

        public void EditSkill(IWebDriver driver,string skillname,string skilllevel)
        {
            //Eidting an existing skill record
            //Click on edit button of last skill record
            IWebElement recordToBeEdit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            recordToBeEdit.Click();

            //Edit skill of last skill record
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input", 5);
            IWebElement skillToBeEditTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            skillToBeEditTextbox.Clear();
            skillToBeEditTextbox.SendKeys(skillname);
            Wait.WaitToBeVisiable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 5);


            IWebElement skillToBeEditLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));    
            SelectElement skillSelect = new(skillToBeEditLevel);
            skillSelect.SelectByValue(skilllevel);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]", 5);

            //Click on update button
            IWebElement skillUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            skillUpdateButton.Click();
            Wait.WaitToBeVisiable(driver, "CssSelector", ".ns-box-inner", 5);



        }
        public string GetEditedSkillName(IWebDriver driver)
        {
            //Check if the last skill name record has been edited successfully
            IWebElement checkOfEditSkillName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfEditSkillName.Text;
        }
        public string GetEditedSkillLevel(IWebDriver driver)
        {
            //Check if the last skill level record has been edited successfully
            IWebElement checkOfEditSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfEditSkillLevel.Text;
        }

        public void DeleteSkill(IWebDriver driver)
        {
            //Delete an existing skill record
            //Click on delete button of last record
            IWebElement recordToBeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            recordToBeDeleteButton.Click();
         
        }



        public void CreateEducation(IWebDriver driver)
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
        public string GetLastEducation(IWebDriver driver)
        {
            IWebElement newEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newEducation.Text;
        }
        public void EditEducation(IWebDriver driver,string country,string university)
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
        public string GetEditedEducationCountry(IWebDriver driver)
        {
            //Check if the last education country record has been updated successfully
            IWebElement checkOfEducationCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfEducationCountry.Text;
        }
        public string GetEditedEducationUniversity(IWebDriver driver)
        {
            //Check if the last education university has been updated successfully
            IWebElement checkOfEducationUniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfEducationUniversity.Text;
        }
       
        public void DeleteEducation(IWebDriver driver)
        {
            //Delete an existing education record
            //Click on delete button of the last education record
            IWebElement educationToBeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]"));
            educationToBeDeleteButton.Click();
            

        }


        public void CreateCertification(IWebDriver driver)
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
        public string GetLastCertification(IWebDriver driver)
        {
            IWebElement newCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newCertification.Text;
        }

        public void EditCertification(IWebDriver driver,string certificatename,string certificatefrom)
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

        public string GetEditedCertificateName(IWebDriver driver)
        {
            IWebElement checkOfCertificateName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return checkOfCertificateName.Text;
        }
        public string GetEditedCertificateFrom(IWebDriver driver)
        {
            IWebElement checkOfCertificateFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return checkOfCertificateFrom.Text;
        }
        public void DeleteCertification(IWebDriver driver)
        {
            //Delete an existing certification record
            //Click on delete button of the last certification record
            IWebElement certificationToBeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]"));
            certificationToBeDeleteButton.Click();
        }


       

    }


}


