using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightNunitDemo.lib;

namespace PlaywrightNunitDemo
{
    [Parallelizable(ParallelScope.Self)]
    public class Scenario02 : PageTest
    {
        [Test]
        public async Task CanCheckForErrors()
        { 
            string errors = await AppHelpers.VisitURLGetErrors(Page, "/error");
            Assert.AreEqual(": Purple Monkey Dishwasher Error", errors);
        }

        [Test]
        public async Task CanCheckForNoErrors()
        {
            string errors = await AppHelpers.VisitURLGetErrors(Page);
            Assert.AreEqual(string.Empty, errors);
        }
    }
}
