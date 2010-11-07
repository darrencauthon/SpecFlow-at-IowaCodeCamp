using MvcApplication1.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MvcApplication1.Specs.Steps
{
    [Binding]
    public class PromotionFormSteps
    {
        [Given(@"I entered the following values into the promotion form")]
        public void GivenIEnteredTheFollowingValuesIntoThePromotionForm(Table table)
        {

            var promotionForm = table.CreateInstance<PromotionForm>();

            ScenarioContext.Current.Set(promotionForm);
        }
    }
}