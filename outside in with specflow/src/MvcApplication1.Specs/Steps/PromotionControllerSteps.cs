using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MvcApplication1.Controllers;
using MvcApplication1.Models;
using Should;
using TechTalk.SpecFlow;

namespace MvcApplication1.Specs.Steps
{
    [Binding]
    public class PromotionControllerSteps
    {
        [When(@"I submit my promotion form")]
        public void WhenISubmitMyPromotionForm()
        {
            var promotionForm = ScenarioContext.Current.Get<PromotionForm>();
            var promotionRepository = ScenarioContext.Current.Get<IPromotionRepository>();
            var prizeWinningRecorder = ScenarioContext.Current.Get<IPrizeWinningRecorder>();

            var promotionController = new PromotionController(promotionRepository, prizeWinningRecorder);

            var result = promotionController.Index(promotionForm);

            ScenarioContext.Current.Set(result);
        }

        [Then(@"the prize name '(.*)' should be passed to the next page")]
        public void ThenThePrizeNameAFreeCoke_ShouldBePassedToTheConfirmationPages(string prizeName)
        {
            var actionResult = ScenarioContext.Current.Get<ActionResult>();

            ((RedirectToRouteResult) actionResult)
                .RouteValues["PrizeName"].ShouldEqual(prizeName);
        }
    }
}
