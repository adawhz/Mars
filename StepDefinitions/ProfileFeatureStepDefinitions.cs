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
        LoginPage logininPageObj = new LoginPage();
        HomePage homepageObj = new HomePage();  
        ProfilePage profilePageObj = new ProfilePage();


        [Given(@"I logged in Mars portal successfully")]
        public void GivenILoggedInMarsPortalSuccessfully()
        {
          
            //Login page object initialization and definition
            logininPageObj.LoginAction(driver);
        }

        [When(@"I add new language record with valid details")]
        public void WhenIAddNewLanguageRecordWithValidDetails()
        {
            //Create language record
            profilePageObj.CreateLanguage(driver);
        }

        [Then(@"The new language record should be added successfully")]
        public void ThenTheNewLanguageRecordShouldBeAddedSuccessfully()
        {
            //Check new language record has been added
            string newLanguage = profilePageObj.GetLastLanguage(driver);
            Assert.AreNotEqual(newLanguage, "Chinese", "Actual and expected result are not equal.");
        }



        [When(@"I navigate to skills feature")]
        public void WhenINavigateToSkillsFeature()
        {
            //Go to skill tab
            homepageObj.GoToSkills(driver);
        }

        [When(@"I add add new skills record with valid details")]
        public void WhenIAddAddNewSkillsRecordWithValidDetails()
        {
            //Create skill record
            profilePageObj.CreateSkill(driver);
        }

        [Then(@"The new skill record should be added successfully")]
        public void ThenTheNewSkillRecordShouldBeAddedSuccessfully()
        {
            //Check new skill record has been added
            string newSkill = profilePageObj.GetLastSkill(driver);
            Assert.AreEqual(newSkill, "Editing", "Actual and expected skill record do not match.");
        }


        [When(@"I navigate to education feature")]
        public void WhenINavigateToEducationFeature()
        {
           //Go to education tab
           homepageObj.GoToEducation(driver);
        }

        [When(@"I add a new education record with valid details")]
        public void WhenIAddANewEducationRecordWithValidDetails()
        {
            //Create education record
            profilePageObj.CreateEducation(driver);
        }

        [Then(@"The new education record should be added successfully")]
        public void ThenTheNewEducationRecordShouldBeAddedSuccessfully()
        {
            //Check new education record has been added
            string newEducation = profilePageObj.GetLastEducation(driver);
            Assert.AreEqual(newEducation, "Tianjin ForeignStudies University", "Actual and expected skill record do not match.");
        }


        [When(@"I navigate to certification feature")]
        public void WhenINavigateToCertificationFeature()
        {
           //Go to certification
           homepageObj.GoToCertification(driver);
        }

        [When(@"I add new certification record with valid details")]
        public void WhenIAddNewCertificationRecordWithValidDetails()
        {
            //Create new certification record
            profilePageObj.CreateCertification(driver);
        }

        [Then(@"The new certification should be added successfully")]
        public void ThenTheNewCertificationShouldBeAddedSuccessfully()
        {
            //Check new certification record has been added
           string newCertification = profilePageObj.GetLastCertification(driver);
           Assert.AreEqual(newCertification, "ISTQB Certified Tester Foundation Level", "Actual and expected skill record do not match.");

        }

        [When(@"I edit description with valid details")]
        public void WhenIEditDescriptionWithValidDetails()
        {
            //Edit description
            profilePageObj.EditDescription(driver);
        }

        [Then(@"The description should be edited successfully")]
        public void ThenTheDescriptionShouldBeEditedSuccessfully()
        {
            //Check description has been edited
           string newDescription = profilePageObj.GetDescription(driver);
            Assert.AreEqual(newDescription, "I like playing badminton in my spare time.", "Actual and expected skill record do not match.");
        }

        [Given(@"I update '([^']*)','([^']*)' on an existing language record")]
        public void GivenIUpdateOnAnExistingLanguageRecord(string languagename, string languagelevel)
        {
            //Edit language
            profilePageObj.EditLanguage(driver,languagename,languagelevel);
        }

        [Then(@"The language record should have updated '([^']*)','([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string languagename, string languagelevel)
        {
            //Check the last language record has been edited
            string checkEditedLanguageName = profilePageObj.GetEditedLanguageName(driver);
            string checkEditedLanguageLevel = profilePageObj.GetEditedLanguageLevel(driver);
            Assert.AreEqual(checkEditedLanguageName, languagename, "Actual and expected skill record do not match.");
            Assert.AreEqual(checkEditedLanguageLevel, languagelevel, "Actual and expected skill record do not match.");

        }

        [When(@"I update '([^']*)','([^']*)' on an existing skill record")]
        public void WhenIUpdateOnAnExistingSkillRecord(string skillname, string skilllevel)
        {
            //Edit skill
            profilePageObj.EditSkill(driver,skillname,skilllevel);
        }

        [Then(@"The skill record should have updated '([^']*)','([^']*)'")]
        public void ThenTheSkillRecordShouldHaveUpdated(string skillname, string skilllevel)
        {
            //Check the last skill record has been edited
            string checkEditedSkillName = profilePageObj.GetEditedSkillName(driver);
            String checkEditedSkillLevel = profilePageObj.GetEditedSkillLevel(driver);

            Assert.AreEqual(checkEditedSkillName, skillname, "Actual and expected skill record do not match.");
            Assert.AreEqual(checkEditedSkillLevel, skilllevel, "Actual and expected skill record do not match.");
        }

        [When(@"I update'([^']*)','([^']*)' on an existing education record")]
        public void WhenIUpdateOnAnExistingEducationRecord(string country, string university)
        {

            //Edit education
            profilePageObj.EditEducation(driver, country, university);

        }

        [Then(@"The education record should have updated'([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string country, string university)
        {
            //Check the last education recoed has been edited
            string checkEditedCountry = profilePageObj.GetEditedEducationCountry(driver);
            string checkEditedUniversity = profilePageObj.GetEditedEducationUniversity(driver);
            Assert.AreEqual(checkEditedCountry, country, "Actual and expected skill record do not match.");
            Assert.AreEqual(checkEditedUniversity, university, "Actual and expected skill record do not match.");
        }

        [When(@"I update '([^']*)','([^']*)' on an existing certification record")]
        public void WhenIUpdateOnAnExistingCertificationRecord(string certificatename, string certificatefrom)
        {
            //Edit certificate
            profilePageObj.EditCertification(driver,certificatename,certificatefrom);
        }

        [Then(@"The certification reocrd should have updated '([^']*)','([^']*)'")]
        public void ThenTheCertificationReocrdShouldHaveUpdated(string certificatename, string certificatefrom)
        {
            //Check the last certification record has been updated successfullt
            string checkEditedCertificateName = profilePageObj.GetEditedCertificateName(driver);
            string checkEditedCertificateFrom = profilePageObj.GetEditedCertificateFrom(driver);
            Assert.AreEqual(checkEditedCertificateName, certificatename, "Actual and expected skill record do not match.");
            Assert.AreEqual(checkEditedCertificateFrom, certificatefrom, "Actual and expected skill record do not match.");
        }

        [Given(@"I delete an existing language record")]
        public void GivenIDeleteAnExistingLanguageRecord()
        {
            //Delete the last language record
            profilePageObj.DeleteLanguage(driver);
        }

        [Then(@"The language reocrd should be deleted successfully")]
        public void ThenTheLanguageReocrdShouldBeDeletedSuccessfully()
        {
            //Check if the language record has been deleted successfully
            string lastDeletedLanguage = profilePageObj.GetLastLanguage(driver);
            String checkPopUpMeaasge = profilePageObj.GetPopUpMessage(driver);
           

            Assert.AreEqual(checkPopUpMeaasge, lastDeletedLanguage + " has been deleted from your languages", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing skill record")]
        public void WhenIDeleteAnExistingSkillRecord()
        {
            //Delete the last skill record
            profilePageObj.DeleteSkill(driver);
        }

        [Then(@"The skill record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            //Check if the skill record has been deleted successfully
            string lastDeletedSkill = profilePageObj.GetLastSkill(driver);
            string checkPopUpMessage = profilePageObj.GetPopUpMessage(driver);
            Assert.AreEqual(checkPopUpMessage, lastDeletedSkill + " has been deleted", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing education record")]
        public void WhenIDeleteAnExistingEducationRecord()
        {
            //Delete the last education record
            profilePageObj.DeleteEducation(driver);
        }

        [Then(@"The education record should be deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            string lastDeletedEducation = profilePageObj.GetLastEducation(driver);
            string checkPopUpMessage = profilePageObj.GetPopUpMessage(driver);
            Assert.AreEqual(checkPopUpMessage, "Education entry successfully removed", "Actual and expected skill record do not match.");
        }

        [When(@"I delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            //Delete the last certification record
            profilePageObj.DeleteCertification(driver);

        }

        [Then(@"The new education should be deleted successfully")]
        public void ThenTheNewEducationShouldBeDeletedSuccessfully()
        {
            string lastDeletedCertification = profilePageObj.GetLastCertification(driver);
            string checkPopUpMessage = profilePageObj.GetPopUpMessage(driver);
            Assert.AreEqual(checkPopUpMessage, lastDeletedCertification + " has been deleted from your certification", "Actual and expected skill record do not match.");
        }


        [When(@"I share skill in mars portal")]
        public void WhenIShareSkillInMarsPortal()
        {
            throw new PendingStepException();
        }
        [Then(@"The skill should be shared successfully")]
        public void ThenTheSkillShouldBeSharedSuccessfully()
        {
            throw new PendingStepException();
        }

    }
}
