using System;
using Rovers;
using TechTalk.SpecFlow;

namespace RoverTests
{
    [Binding]
    public class MarsRoverStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        Rover myRover;

        public MarsRoverStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Rover is initialized with following position")]
        public void GivenRoverIsInitializedWithFollowingPosition(Table table)
        {
            var row = table.Rows[0];
            var x = Convert.ToInt32(row["x"]);
            var y = Convert.ToInt32(row["y"]);

            Rover rover = new Rover(x, y);
            myRover = rover;
        }


        [When(@"Rover position is set to the following position")]
        public void WhenInitialPositionIsSetToTheFollowingPosition(Table table)
        {
            var row = table.Rows[0];
            var x = Convert.ToInt32(row["x"]);
            var y = Convert.ToInt32(row["y"]);
            var facing = Convert.ToInt32(row["facing"]);
            myRover.SetPosition(x, y, facing);
        }

        [Then(@"Rover is at the following position")]
        public void ThenRoverIsInitializedWithNoErrorsWithFollowingPosition(Table table)
        {
            var row = table.Rows[0];
            var x = row["x"];
            var y = row["y"];
            var facing = row["facing"];
            var position = x + "," + y + "," + facing;

            Assert.AreEqual(position, myRover.GetPosition());
        }

        [When(@"Rover is moved with following command")]
        public void WhenRoverIsMovedWithFollowingCommand(Table table)
        {
            var row = table.Rows[0];
            var command = row["Command"];
            myRover.Process(command);
        }
    }
}