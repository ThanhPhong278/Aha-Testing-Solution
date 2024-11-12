using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Salon_Admin.Pages
{
    public class BasePage
    {
        protected readonly IPage page;

        public BasePage(IPage page)
        {
            this.page = page;
        }
    }
}
