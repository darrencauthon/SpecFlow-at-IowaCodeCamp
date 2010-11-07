using Moq;
using MvcApplication1.Models;
using TechTalk.SpecFlow;

namespace MvcApplication1.Specs.Steps
{
    [Binding]
    public class PrizeWinningRecorderSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            var fake = new Mock<IPrizeWinningRecorder>();

            ScenarioContext.Current.Set(fake);
            ScenarioContext.Current.Set(fake.Object);
        }

        [Then(@"the name '(.*)' and the email '(.*)' and the promotion code '(.*)' should be passed to the prize winning recorder")]
        public void x(string name, string email, string promotionCode)
        {
            var fake = ScenarioContext.Current.Get<Mock<IPrizeWinningRecorder>>();
            fake.Verify(x => x.RecordWin(name, email, promotionCode), Times.Once());
        }

        [Then(@"my information should not be recorded as a win")]
        public void ThenMyInformationShouldNotBeRecordedAsAWin()
        {
            var fake = ScenarioContext.Current.Get<Mock<IPrizeWinningRecorder>>();
            fake.Verify(x=>x.RecordWin(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never());

        }
    }
}