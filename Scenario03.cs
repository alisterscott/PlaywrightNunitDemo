using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightNunitDemo.lib;

namespace PlaywrightNunitDemo
{
    [Parallelizable(ParallelScope.Self)]
    public class Scenario03 : PageTest
    {
        [Test]
        public async Task CanHandleAlerts()
        {
            Page.Dialog += (_, dialog) => dialog.AcceptAsync();
            await AppHelpers.VisitURL(Page, "/leave");
            await Page.ClickAsync("#homelink");
            await Page.WaitForSelectorAsync("#elementappearsparent", new PageWaitForSelectorOptions { State = WaitForSelectorState.Visible, Timeout = 5000 });
        }
    }
}
