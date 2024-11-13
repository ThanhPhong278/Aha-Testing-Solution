using Newtonsoft.Json;
using Salon_Admin.Hooks;
using Salon_Admin.Pages;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Salon_Admin.Tests.Steps
{
    [Binding]
    public class LoginTestStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly Salon_Admin.Utils.JsonReader _jsonReader;

        public LoginTestStepDefinitions()
        {
            _loginPage = new LoginPage(HookUI.Page);
            _jsonReader = new Salon_Admin.Utils.JsonReader();
        }

        [Given("the user navigates to the application")]
        public async Task GivenTheUserNavigatesToTheApplication()
        {
            var baseUrl = _jsonReader.GetEnvironmentConfig("BaseUrl");
            await HookUI.Page.GotoAsync(baseUrl);
        }

        [Given("the user enters the username from test data")]
        public async Task GivenTheUserEntersTheUsernameFromTestData()
        {
            var username = _jsonReader.GetLoginData("username");
            await _loginPage.EnterUserNameAsync(username);
        }

        [Given("the user enters the password from test data")]
        public async Task GivenTheUserEntersThePasswordFromTestData()
        {
            var password = _jsonReader.GetLoginData("password");
            await _loginPage.EnterPasswordAsync(password);
        }

        [When("the user clicks on the login button")]
        public async Task WhenTheUserClicksOnTheLoginButton()
        {
            await _loginPage.ClickLoginButtonAsync();
        }

        [Then("the login should be successful")]
        public async Task ThenTheLoginShouldBeSuccessful()
        {
        }
    }
}
