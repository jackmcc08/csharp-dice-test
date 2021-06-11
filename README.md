
## Simple Dice 
A TDD exercise to get familiar with C# and the .net testing suite

## To use

- git clone the repo
- in root folder, in terminal run `dotnet run --project ./simpleDice/`


## User Stories

As a board game player,
So that I can play a game
I want to be able to roll a dice
**DONE** - Player can roll a dice

As a board game player,
So that I know how many steps I should move
Rolling a dice should give me a number between 1 and 6
**DONE** - Dice roll is random between 1 & 6

As a dice app developer,
So that I give players a good game experience
If it is not already random, I want the dice roll to be randomly picked
**DONE**

As a board game player,
So that I can play many types of games
I want to be able to roll any number of dice at the same time
**DONE** player can indicate how many dice they want to roll each time

As a board game player,
So that I can keep track of past and previous rolls
I want to record each dice roll
**DONE** each roll is stored

As a board game player,
So that I know what my score is after I have rolled several dice
I want to be able to get my current score
**DONE** after each roll the roll score is provided and the total score of all rolls is provided.