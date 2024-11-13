using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Salon_Admin.Pages
{
    public class LoginPage : BasePage
    {
        private string UserInputPlaceholder = "아이디 입력";
        private string PasswordInputPlaceholder = "비밀번호 입력";
        private string LoginButtonRole = "button";
        private string LoginButtonName = "로그인";
        public LoginPage(IPage page) : base(page){ }
        public async Task EnterUserNameAsync(string userName)
        {
            await page.GetByPlaceholder(UserInputPlaceholder).FillAsync(userName);
        }

        public async Task EnterPasswordAsync(string password)
        {
            await page.GetByPlaceholder(PasswordInputPlaceholder).FillAsync(password);
        }
        public async Task ClickLoginButtonAsync()
        {
            await page.GetByRole(AriaRole.Button, new() { Name = LoginButtonName }).ClickAsync();
        }
        public async Task LoginUserAsync(string username, string password)
        {
            await EnterUserNameAsync(username);
            await EnterPasswordAsync(password);
            await ClickLoginButtonAsync();
        }
    }
}
