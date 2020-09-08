Feature: MarsRover
As a Nasa operative I want to control the Rovers
So I can see what the surrounding terrain in Mars is like


Scenario Outline:Initialize Mars Rover
Given Rover is initialized with following position
| x                  | y                  |
| <InitialPositionX> | <InitialPositionY> |
When Rover position is set to the following position
| x              | y              | facing      |
| <SetPositionX> | <SetPositionY> | <SetFacing> |
Then Rover is at the following position
| x                | y                | facing        |
| <FinalPositionX> | <FinalPositionY> | <FinalFacing> |
Examples:
| TestCase | InitialPositionX | InitialPositionY | SetPositionX | SetPositionY | SetFacing | FinalPositionX | FinalPositionY | FinalFacing |
| North    | 0                | 0                | 1            | 2            | 1         | 1              | 2              | N           |
| East     | 5                | 5                | 3            | 4            | 2         | 3              | 4              | E           |
| South    | 100              | 200              | 1            | 2            | 3         | 1              | 2              | S           |
| West     | 250              | 230              | 11           | 32           | 4         | 11             | 32             | W           |


Scenario Outline:Turn Rover Right
Given Rover is initialized with following position
| x   | y   |
| 500 | 500 |
When Rover position is set to the following position
| x              | y              | facing      |
| <SetPositionX> | <SetPositionY> | <SetFacing> |
And Rover is moved with following command
| Command   |
| <Command> |
Then Rover is at the following position
| x                | y                | facing        |
| <FinalPositionX> | <FinalPositionY> | <FinalFacing> |
Examples:
| TestCase               | SetPositionX | SetPositionY | SetFacing | Command | FinalPositionX | FinalPositionY | FinalFacing |
| Turns_Right_Once       | 0            | 0            | 1         | R       | 0              | 0              | E           |
| Turns_Right_Twice      | 0            | 0            | 1         | RR      | 0              | 0              | S           |
| Turns_Right_ThreeTimes | 0            | 0            | 1         | RRR     | 0              | 0              | W           |
| Turns_Right_FourTimes  | 0            | 0            | 1         | RRRR    | 0              | 0              | N           |


Scenario: Move Rover With Input Command And Verify Final Position
Given Rover is initialized with following position
| x | y |
| 5 | 5 |
When Rover position is set to the following position
| x | y | facing |
| 1 | 2 | 1      |
And Rover is moved with following command
| Command   |
| LMLMLMLMM |
Then Rover is at the following position
| x | y | facing |
| 1 | 3 | N      |
