using Microsoft.Playwright;
using Newtonsoft.Json;
using Salon_Admin.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Salon_Admin.Hooks
{
    [Binding]
    public class HookUI
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IPlaywright _playwright;
        private readonly IBrowser _browser;
        private IPage _page;
        private readonly LoginPage _loginPage;
        public HookUI(ScenarioContext scenarioContext, IPlaywright playwright, IBrowser browser, IPage page, LoginPage loginPage)
        {
            _scenarioContext = scenarioContext;
            _playwright = playwright;
            _browser = browser;
            _page = page;
            _loginPage = loginPage;
        }
        [BeforeTestRun]
        public async Task BeforeAll()
        {
            
        }
    }   
}
