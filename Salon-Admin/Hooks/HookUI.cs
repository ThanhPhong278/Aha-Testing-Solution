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
        public static IPlaywright Playwright { get; private set; }
        public static IBrowser Browser { get; private set; }
        public static IBrowserContext Context { get; private set; }
        public static IPage Page { get; private set; }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            try
            {
                Playwright = await Microsoft.Playwright.Playwright.CreateAsync();
                Browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
                Context = await Browser.NewContextAsync();
                Page = await Context.NewPageAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in BeforeScenario: {ex.Message}");
                throw; 
            }
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            if (Browser != null)
            {
                await Browser.CloseAsync();
                Playwright.Dispose();
            }
        }
    }
}
