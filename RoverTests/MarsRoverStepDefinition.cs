using System;
using TechTalk.SpecFlow;

namespace RoverTests
{
    [Binding]
    public class MarsRoverStepDefinition
    {
        [Given(@"Rover is initialized with following position")]
        public void GivenRoverIsInitializedWithFollowingPosition(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Rover position is set to the following position")]
        public void WhenRoverPositionIsSetToTheFollowingPosition(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Rover is moved with following command")]
        public void WhenRoverIsMovedWithFollowingCommand(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Rover is at the following position")]
        public void ThenRoverIsAtTheFollowingPosition(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
