using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightNunitDemo.lib;

namespace PlaywrightNunitDemo
{
    [Parallelizable(ParallelScope.Self)]
    public class Scenario01 : PageTest
    {
        [Test]
        public async Task CanWaitForAnElementToAppear()
        {
            await AppHelpers.VisitURL(Page);
            await Page.WaitForSelectorAsync("#elementappearschild", new PageWaitForSelectorOptions{ State = WaitForSelectorState.Visible, Timeout = 5000 });
        }

        [Test]
        public async Task AutomaticallyWaitsForElementsThatAppearAfterOnLoad()
        {
            await AppHelpers.VisitURL(Page);
            string text = await Page.TextContentAsync("#loadedchild");
            Assert.AreEqual("Loaded!", text);
        }
    }
}
