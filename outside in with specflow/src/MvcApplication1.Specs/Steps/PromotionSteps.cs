using System;
using System.Linq;
using System.Text;
using Moq;
using MvcApplication1.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MvcApplication1.Specs.Steps
{
    [Binding]
    public class PromotionSteps
    {
        [Given(@"the following promotions exist")]
        public void GivenTheFollowingPromotionsExist(Table table)
        {
            var promotions = table.CreateSet<Promotion>();

            var promotionRepository = new Mock<IPromotionRepository>();
            promotionRepository.Setup(x => x.GetPromotions())
                .Returns(promotions);

            ScenarioContext.Current.Set(promotionRepository.Object);
        }
    }
}
