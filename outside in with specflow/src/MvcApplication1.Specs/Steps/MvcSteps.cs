using System.Web.Mvc;
using Should;
using TechTalk.SpecFlow;

namespace MvcApplication1.Specs.Steps
{
    [Binding]
    public class MvcSteps
    {
        [Then(@"I should be sent to the (.*) page")]
        public void ThenIShouldBeSentToTheConfirmationPage(string action)
        {
            var result = ScenarioContext.Current.Get<ActionResult>();

            result.ShouldBeType(typeof (RedirectToRouteResult));
            ((RedirectToRouteResult) result).RouteValues["action"].ShouldEqual(action);
        }
    }
}