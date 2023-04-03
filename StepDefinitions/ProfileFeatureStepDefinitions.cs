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
        public void WhenIUpdateOnAnExistingEducationRecord(string japan, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"The education record should have updated'([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldHaveUpdated(string japan, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)','([^']*)' on an existing certification record")]
        public void WhenIUpdateOnAnExistingCertificationRecord(string p0, string hongkong)
        {
            throw new PendingStepException();
        }

        [Then(@"The certification reocrd should have updated '([^']*)','([^']*)'")]
        public void ThenTheCertificationReocrdShouldHaveUpdated(string p0, string hongkong)
        {
            throw new PendingStepException();
        }

        [Given(@"I delete an existing language record")]
        public void GivenIDeleteAnExistingLanguageRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The language reocrd should be deleted successfully")]
        public void ThenTheLanguageReocrdShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I delete an existing skill record")]
        public void WhenIDeleteAnExistingSkillRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The skill record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I delete an existing education record")]
        public void WhenIDeleteAnExistingEducationRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The education record should be deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The new education should be deleted successfully")]
        public void ThenTheNewEducationShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
