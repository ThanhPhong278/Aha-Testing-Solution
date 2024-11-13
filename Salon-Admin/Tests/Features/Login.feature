Feature: Login Test

  Background:
    Given the user navigates to the application

  Scenario: Login should be successful
    Given the user enters the username from test data
    And the user enters the password from test data
    When the user clicks on the login button
    Then the login should be successful