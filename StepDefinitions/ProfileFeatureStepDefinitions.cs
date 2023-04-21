using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions:CommonDriver
    {
        //Page object initialization
        LoginPage logininPageObj;
        HomePage homepageObj;  
       
        LanguagePage languagePageObj;
        SkillPage skillPageObj;
        EducationPage educationPageObj;
        CertificatePage certificatePageObj;

        public ProfileFeatureStepDefinitions() {
            logininPageObj = new LoginPage(driver);
            homepageObj = new HomePage(driver);
            languagePageObj = new LanguagePage(driver);
            skillPageObj = new SkillPage(driver);   
            certificatePageObj = new CertificatePage(driver);
            educationPageObj = new EducationPage(driver);
        }


        [Given(@"I logged in Mars portal successfully")]
        public void GivenILoggedInMarsPortalSuccessfully()
        {
          
            //Login page object initialization and definition
            logininPageObj.LoginAction();
        }

        [When(@"I add new language record with valid details")]
        public void WhenIAddNewLanguageRecordWithValidDetails()
        {
            //Create language record
            languagePageObj.CreateLanguage();
        }

        [Then(@"The new language record should be added successfully")]
        public void ThenTheNewLanguageRecordShouldBeAddedSuccessfully()
        {
            //Check new language record has been added
            string newLanguage = languagePageObj.GetLastLanguage();
            Assert.AreEqual("Chinese", newLanguage,  "Actual and expected result are not equal.");
        }



        [When(@"I navigate to skills feature")]
        public void WhenINavigateToSkillsFeature()
        {
            //Go to skill tab
            homepageObj.GoToSkills();
        }

        [When(@"I add add new skills record with valid details")]
        public void WhenIAddAddNewSkillsRecordWithValidDetails()
        {
            //Create skill record
            skillPageObj.CreateSkill();
        }

        [Then(@"The new skill record should be added successfully")]
        public void ThenTheNewSkillRecordShouldBeAddedSuccessfully()
        {
            //Check new skill record has been added
            string newSkill = skillPageObj.GetLastSkill();
            Assert.AreEqual("Editing", newSkill,  "Actual and expected skill record do not match.");
        }


        [When(@"I navigate to education feature")]
        public void WhenINavigateToEducationFeature()
        {
           //Go to education tab
           homepageObj.GoToEducation();
        }

        [When(@"I add a new education record with valid details")]
        public void WhenIAddANewEducationRecordWithValidDetails()
        {
            //Create education record
            educationPageObj.CreateEducation();
        }

        [Then(@"The new education record should be added successfully")]
        public void ThenTheNewEducationRecordShouldBeAddedSuccessfully()
        {
            //Check new education record has been added
            string newEducation = educationPageObj.GetLastEducation();
            Assert.AreEqual("Tianjin ForeignStudies University", newEducation,  "Actual and expected skill record do not match.");
        }


        [When(@"I navigate to certification feature")]
        public void WhenINavigateToCertificationFeature()
        {
           //Go to certification
           homepageObj.GoToCertification();
        }

        [When(@"I add new certification record with valid details")]
        public void WhenIAddNewCertificationRecordWithValidDetails()
        {
            //Create new certification record
            certificatePageObj.CreateCertification();
        }

        [Then(@"The new certification should be added successfully")]
        public void ThenTheNewCertificationShouldBeAddedSuccessfully()
        {
            //Check new certification record has been added
           string newCertification = certificatePageObj.GetLastCertification();
           Assert.AreEqual("ISTQB Certified Tester Foundation Level", newCertification,  "Actual and expected skill record do not match.");

        }

       

        [Given(@"I update '([^']*)','([^']*)' on an existing language record")]
        public void GivenIUpdateOnAnExistingLanguageRecord(string languagename, string languagelevel)
        {
            //Edit language
            languagePageObj.EditLanguage(languagename,languagelevel);
        }

        [Then(@"The language record should have updated '([^']*)','([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string languagename, string languagelevel)
        {
            //Check the last language record has been edited
            string checkEditedLanguageName = languagePageObj.GetEditedLanguageName();
            string checkEditedLanguageLevel = languagePageObj.GetEditedLanguageLevel();
            Assert.AreEqual(languagename, checkEditedLanguageName, "Actual and expected skill record do not match.");
            Assert.AreEqual(languagelevel, checkEditedLanguageLevel,  "Actual and expected skill record do not match.");

        }

        [When(@"I update '([^']*)','([^']*)' on an existing skill record")]
        public void WhenIUpdateOnAnExistingSkillRecord(string skillname, string skilllevel)
        {
            //Edit skill
            skillPageObj.EditSkill(skillname,skilllevel);
        }

        [Then(@"The skill record should have updated '([^']*)','([^']*)'")]
        public void ThenTheSkillRecordShouldHaveUpdated(string skillname, string skilllevel)
        {
            //Check the last skill record has been edited
            string checkEditedSkillName = skillPageObj.GetEditedSkillName();
            String checkEditedSkillLevel = skillPageObj.GetEditedSkillLevel();

            Assert.AreEqual(skillname, checkEditedSkillName, "Actual and expected skill record do not match.");
            Assert.AreEqual(skilllevel, checkEditedSkillLevel,  "Actual and expected skill record do not match.");
        }

        [When(@"I update'([^']*)','([^']*)' on an existing education record")]
        public void WhenIUpdateOnAnExistingEducationRecord(string country, string university)
        {

            //Edit education
            educationPageObj.EditEducation(country, university);

        }

        [Then(@"The education record should have updated'([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string country, string university)
        {
            //Check the last education recoed has been edited
            string checkEditedCountry = educationPageObj.GetEditedEducationCountry();
            string checkEditedUniversity = educationPageObj.GetEditedEducationUniversity();
            Assert.AreEqual(country, checkEditedCountry, "Actual and expected skill record do not match.");
            Assert.AreEqual(university, checkEditedUniversity,  "Actual and expected skill record do not match.");
        }

        [When(@"I update '([^']*)','([^']*)' on an existing certification record")]
        public void WhenIUpdateOnAnExistingCertificationRecord(string certificatename, string certificatefrom)
        {
            //Edit certificate
            certificatePageObj.EditCertification(certificatename,certificatefrom);
        }

        [Then(@"The certification reocrd should have updated '([^']*)','([^']*)'")]
        public void ThenTheCertificationReocrdShouldHaveUpdated(string certificatename, string certificatefrom)
        {
            //Check the last certification record has been updated successfullt
            string checkEditedCertificateName = certificatePageObj.GetEditedCertificateName();
            string checkEditedCertificateFrom = certificatePageObj.GetEditedCertificateFrom();
            Assert.AreEqual(certificatename, checkEditedCertificateName,  "Actual and expected skill record do not match.");
            Assert.AreEqual(certificatefrom, checkEditedCertificateFrom, "Actual and expected skill record do not match.");
        }

        [Given(@"I delete an existing language record")]
        public void GivenIDeleteAnExistingLanguageRecord()
        {
            //Delete the last language record
            languagePageObj.DeleteLanguage();
        }

        [Then(@"The language reocrd should be deleted successfully")]
        public void ThenTheLanguageReocrdShouldBeDeletedSuccessfully()
        {
            //Check if the language record has been deleted successfully
            string lastDeletedLanguage = languagePageObj.GetLastLanguage();
            String checkPopUpMeaasge = languagePageObj.GetPopUpMessage();
           

            Assert.AreEqual(checkPopUpMeaasge, lastDeletedLanguage + " has been deleted from your languages", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing skill record")]
        public void WhenIDeleteAnExistingSkillRecord()
        {
            //Delete the last skill record
            skillPageObj.DeleteSkill();
        }

        [Then(@"The skill record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            //Check if the skill record has been deleted successfully
            string lastDeletedSkill = skillPageObj.GetLastSkill();
            string checkPopUpMessage = languagePageObj.GetPopUpMessage();
            Assert.AreEqual(checkPopUpMessage, lastDeletedSkill + " has been deleted", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing education record")]
        public void WhenIDeleteAnExistingEducationRecord()
        {
            //Delete the last education record
            educationPageObj.DeleteEducation();
        }

        [Then(@"The education record should be deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            string lastDeletedEducation = educationPageObj.GetLastEducation();
            string checkPopUpMessage = languagePageObj.GetPopUpMessage();
            Assert.AreEqual(checkPopUpMessage, "Education entry successfully removed", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            //Delete the last certification record
            certificatePageObj.DeleteCertification();

        }

        [Then(@"The new education should be deleted successfully")]
        public void ThenTheNewEducationShouldBeDeletedSuccessfully()
        {
            string lastDeletedCertification = certificatePageObj.GetLastCertification();
            string checkPopUpMessage = languagePageObj.GetPopUpMessage();
            Assert.AreEqual(checkPopUpMessage, lastDeletedCertification + " has been deleted from your certification", "Actual and expected skill record do not match.");
        }



    }
}
