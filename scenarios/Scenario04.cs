using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightNunitDemo.lib;

namespace PlaywrightNunitDemo
{
    [Parallelizable(ParallelScope.Self)]
    public class Scenario04 : PageTest
    {
        [Test]
        public async Task CanUseXPathSelectors()
        {
            await AppHelpers.VisitURL(Page);
            await Page.WaitForSelectorAsync("//span[contains(., \"Scissors\")]");
            await Page.ClickAsync("//span[contains(., \"Scissors\")]");
            await Page.WaitForSelectorAsync("//div[contains(., \"Scissors clicked!\")]");
        }
    }
}
