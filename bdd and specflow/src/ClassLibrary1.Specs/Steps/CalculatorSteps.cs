using Should;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Specs.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            ScenarioContext.Current.Set(new Calculator());
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            var calculator = ScenarioContext.Current.Get<Calculator>();
            var result = calculator.Subtract();

            ScenarioContext.Current["Result"] = result;
        }

        [Given("I have entered (.*) into the calculator")]
        public void x(int number)
        {
            var calculator = ScenarioContext.Current.Get<Calculator>();
            calculator.Enter(number);
        }

        [When("I press add")]
        public void y()
        {
            var calculator = ScenarioContext.Current.Get<Calculator>();
            var result = calculator.Add();

            ScenarioContext.Current["Result"] = result;
        }

        [Then("the result should be (.*) on the screen")]
        public void z(int expected)
        {
            var result = (int) ScenarioContext.Current["Result"];

            result.ShouldEqual(expected);
        }
    }
}