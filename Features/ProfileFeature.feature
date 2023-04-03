Feature: ProfileFeature

As a seller, I'd like to add language, skill, education and certifictation details to profile.
As a seller, I'd like to edit description, language, skill, education and certifictation details to profile.
As a seller, I'd like to  description language, skill, education and certifictation details to profile.


@tag1


Scenario: I add new language record with valid details
    Given I logged in Mars portal successfully
	When I add new language record with valid details
	Then The new language record should be added successfully

Scenario: I add new skill record with valid details 
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I add add new skills record with valid details
	Then The new skill record should be added successfully

Scenario: I add new education record with valid details
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I add a new education record with valid details
	Then The new education record should be added successfully

Scenario: I add new certification record with valid details
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I add new certification record with valid details
	Then The new certification should be added successfully

Scenario: I edit description details 
	Given I logged in Mars portal successfully
	When I edit description with valid details
	Then The description should be edited successfully

Scenario Outline: I edit an existing language record with valid details
    Given I logged in Mars portal successfully
	And I update '<LanguageName>','<LanguageLevel>' on an existing language record
	Then The language record should have updated '<LanguageName>','<LanguageLevel>'

	Examples: 
	| LanguageName | LanguageLevel |
	| German       | Basic         |
	| French       | Fluent        |

Scenario Outline: I edit an existing skill record with valid details 
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I update '<SkillName>','<SkillLevel>' on an existing skill record
	Then The skill record should have updated '<SkillName>','<SkillLevel>'

	Examples: 
	| SkillName | SkillLevel   |
	| Writing   | Beginner     |
	| Singing   | Intermediate |

Scenario Outline: I edit an existing education record with valid details
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I update'<Country>','<University>' on an existing education record
	Then The education record should have updated'<Country>','<University>'

	Examples: 
	| Country | University            |
	| Japan   | Tokyo University      |
	| Canada  | University of Toronto |

Scenario Outline: I edit an existing certification with valid details
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I update '<CertificateName>','<From>' on an existing certification record 
	Then The certification reocrd should have updated '<CertificateName>','<From>'

	Examples: 
	| CertificateName         | From      |
	| Dancing Certification   | Hongkong  |
	| Speaking Certification  | China     |


Scenario: I delete an existing language record
    Given I logged in Mars portal successfully
	And I delete an existing language record
	Then The language reocrd should be deleted successfully

Scenario: I delete an existing skill record
	Given I logged in Mars portal successfully
	When I navigate to skills feature
	And I delete an existing skill record
	Then The skill record should be deleted successfully

Scenario: I delete an existing education record
	Given I logged in Mars portal successfully
	When I navigate to education feature
	And I delete an existing education record
	Then The education record should be deleted successfully

Scenario: I delete an existing certification record
    Given I logged in Mars portal successfully
	When I navigate to certification feature
	And I delete an existing certification record
	Then The new education should be deleted successfully

