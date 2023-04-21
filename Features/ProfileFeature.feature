Feature: ProfileFeature

As a seller, I'd like to login Mars portal with valid email and password.
As a seller, I'd like to add language, skill, education and certifictation details to profile.
As a seller, I'd like to edit description, language, skill, education and certifictation details to profile.
As a seller, I'd like to  delete language, skill, education and certifictation details to profile.
As a seller, I'd like to  edit availability, hours, earn target to profile and share skill profile.


@tag1



Scenario: 01) I add new language record with valid details
    Given I logged in Mars portal successfully
	When I add new language record with valid details
	Then The new language record should be added successfully

Scenario: 02) I add new skill record with valid details 
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I add add new skills record with valid details
	Then The new skill record should be added successfully

Scenario: 03) I add new education record with valid details
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I add a new education record with valid details
	Then The new education record should be added successfully

Scenario: 04) I add new certification record with valid details
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I add new certification record with valid details
	Then The new certification should be added successfully


Scenario Outline: 05) I edit an existing language record with valid details
    Given I logged in Mars portal successfully
	And I update '<LanguageName>','<LanguageLevel>' on an existing language record
	Then The language record should have updated '<LanguageName>','<LanguageLevel>'

	Examples: 
	| LanguageName | LanguageLevel |
	| German       | Basic         |
	| French       | Fluent        |

Scenario Outline: 06) I edit an existing skill record with valid details 
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I update '<SkillName>','<SkillLevel>' on an existing skill record
	Then The skill record should have updated '<SkillName>','<SkillLevel>'

	Examples: 
	| SkillName | SkillLevel   |
	| Writing   | Beginner     |
	| Singing   | Intermediate |

Scenario Outline: 07) I edit an existing education record with valid details
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I update'<Country>','<University>' on an existing education record
	Then The education record should have updated'<Country>','<University>'

	Examples: 
	| Country | University            |
	| Japan   | Tokyo University      |
	| Canada  | University of Toronto |

Scenario Outline: 08) I edit an existing certification with valid details
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I update '<CertificateName>','<From>' on an existing certification record 
	Then The certification reocrd should have updated '<CertificateName>','<From>'

	Examples: 
	| CertificateName         | From      |
	| Dancing Certification   | Hongkong  |
	| Speaking Certification  | China     |


Scenario: 09) I delete an existing language record
    Given I logged in Mars portal successfully
	And I delete an existing language record
	Then The language reocrd should be deleted successfully

Scenario: 10) I delete an existing skill record
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I delete an existing skill record
	Then The skill record should be deleted successfully

Scenario: 11) I delete an existing education record
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I delete an existing education record
	Then The education record should be deleted successfully

Scenario: 12) I delete an existing certification record
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I delete an existing certification record
	Then The new education should be deleted successfully
    
Scenario: I edit description details 
	Given I logged in Mars portal successfully
	When I edit description with valid details
	Then The description should be edited successfully

	
Scenario: I can share skill in mars portal
    Given I logged in Mars portal successfully
    When  I share skill in mars portal
    Then  The skill should be shared successfully

   Scenario:I can edit availability in mars portal
    Given I logged in Mars portal successfully
    When  I edit edit availability in mars portal
    Then  The availability should be edited successfully

   Scenario:I can edit hours in mars portal
    Given I logged in Mars portal successfully
    When  I edit hours in mars portal
    Then  The hours should be edited successfully

   Scenario:I can edit earn target in mars portal
    Given I logged in Mars portal successfully
    When  I edit earn target in mars portal
    Then  The earn target should be edited successfully


Scenario:I can't update description with empty input
    Given I logged in Mars portal successfully
    When  I edit description with empty input
    Then  The description can't be saved

Scenario:I can't add language record with empty language
    Given I logged in Mars portal successfully
    When  I add language record with empty language 
    Then  The language record can't be added

Scenario:I can't add language record with empty language level
    Given I logged in Mars portal successfully
    When  I add language record with empty language level
    Then  The language record can't be added


Scenario:I can't update language record with empty language 
    Given I logged in Mars portal successfully
    When  I edit language record with empty language 
    Then  The language record can't be updated

Scenario:I can't update language record with empty language level
    Given I logged in Mars portal successfully
    When  I edit language record with empty language level
    Then  The language record can't be updated


Scenario:I can't add skill record with empty skill in mars portal
    Given I logged in Mars portal successfully
    When  I add skill record with empty skill 
    Then  The language record can't be added

Scenario:I can't add skill record with empty skill level
    Given I logged in Mars portal successfully
    When  I add skill record with empty skill level
    Then  The skill record can't be added

Scenario:I can't update skill record with empty skill in mars portal
    Given I logged in Mars portal successfully
    When  I edit skill record with empty skill 
    Then  The skill record can't be updated

Scenario:I can't update skill record with empty skill level in mars portal
    Given I logged in Mars portal successfully
    When  I edit skill record with empty skill level
    Then  The skill record can't be updated

Scenario:I can't add education record with empty university in mars portal
    Given I logged in Mars portal successfully
    When  I add education record with empty university 
    Then  The education record can't be added

Scenario:I can't add education record with empty country of college
    Given I logged in Mars portal successfully
    When  I add education record with empty country of college
    Then  The education record can't be added

Scenario:I can't add education record with empty title
    Given I logged in Mars portal successfully
    When  I add education record with empty title
    Then  The education record can't be added

Scenario:I can't add education record with empty degree
    Given I logged in Mars portal successfully
    When  I add education record with empty degree
    Then  The education record can't be added

Scenario:I can't add education record with empty year of graduation
    Given I logged in Mars portal successfully
    When  I add education record with empty year of graduation
    Then  The education record can't be added

Scenario:I can't update education record with empty university
    Given I logged in Mars portal successfully
    When  I edit education record with empty university 
    Then  The education record can't be updated

Scenario:I can't update education record with empty country of college
    Given I logged in Mars portal successfully
    When  I edit education record with empty country of college
    Then  The education record can't be updated

Scenario:I can't update education record with empty title
    Given I logged in Mars portal successfully
    When  I edit education record with empty title
    Then  The education record can't be updated

Scenario:I can't update education record with empty degree
    Given I logged in Mars portal successfully
    When  I edit education record with empty degree
    Then  The education record can't be updated

Scenario:I can't update education record with empty year of graduation
    Given I logged in Mars portal successfully
    When  I edit education record with empty year of graduation
    Then  The education record can't be updated

Scenario:I can't add certification record with empty certificate award
    Given I logged in Mars portal successfully
    When  I add certification record with empty certificate award
    Then  The certification record can't be added

Scenario:I can't add certification record with certified from
    Given I logged in Mars portal successfully
    When  I add certification record with empty certified from
    Then  The certification record can't be added

Scenario:I can't add certification record with empty year
    Given I logged in Mars portal successfully
    When  I add certification record with empty year
    Then  The certification record can't be added

Scenario:I can't update certification record with empty certificate name
    Given I logged in Mars portal successfully
    When  I edit certification record with empty certificate name
    Then  The certification record can't be updated

Scenario:I can't update certification record with certified from
    Given I logged in Mars portal successfully
    When  I edit certification record with empty certified from
    Then  The certification record can't be updated

Scenario:I can't update certification record with empty year
    Given I logged in Mars portal successfully
    When  I edit certification record with empty year
    Then  The certification record can't be updated



