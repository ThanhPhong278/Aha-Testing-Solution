using Salon_Admin.Pages;
using System;
using TechTalk.SpecFlow;

namespace Salon_Admin.Tests.Steps
{
    [Binding]
    public class LoginTestStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginTestStepDefinitions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }
        [Given(@"the user navigates to the application")]
        public void GivenTheUserNavigatesToTheApplication()
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters the username from test data")]
        public void GivenTheUserEntersTheUsernameFromTestData()
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters the password from test data")]
        public void GivenTheUserEntersThePasswordFromTestData()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"the login should be successful")]
        public void ThenTheLoginShouldBeSuccessful()
        {
            throw new PendingStepException();
        }
    }
}
