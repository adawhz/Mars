Feature: LoginFeature

As a user, I'd like to login Mars portal with valid email and password.

@tag1
Scenario: Login Mars portal with valid details
	Given Launch Mars portal
	When Input valid email and password
	Then I logged in Mars portal successfully
