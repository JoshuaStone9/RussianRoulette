# Russian Roulette CLI (C#)

A small C# console application that simulates a game of Russian Roulette using randomization and user input. The program allows the player to choose a chamber and then uses shuffled chamber logic to determine survival or death.

---

## Table of Contents
- [Overview](#overview)
- [High Level Architecture](#high-level-architecture)
- [Data Model](#data-model)
- [Control Flow](#control-flow)
- [Randomization Logic](#randomization-logic)
- [Console Interface](#console-interface)
- [How to Run](#how-to-run)
- [Potential Improvements](#potential-improvements)
- [Personal Development](#personal-development)

---

## Overview

Russian Roulette CLI is a simple console based game designed to practice control flow arrays randomness and user interaction in C#.

The player is presented with six chambers chooses one and then faces an outcome decided by logic and randomness. Some choices resolve immediately while others introduce suspense through a second randomized check.

---

## High Level Architecture

The program is implemented as a single C# console application with one entry point.

The logic is divided conceptually into:

Input Layer  
Handles user prompts and reads player choices  

Game Logic Layer  
Evaluates player choices and determines outcomes  

Randomization Layer  
Shuffles chamber values to simulate unpredictability  

Output Layer  
Displays dramatic results and game messages to the console  

---

## Data Model

The application uses simple built in types:

string[]  
Represents the revolver chambers numbered 1 through 6  

string  
Stores user input  

No external models or classes are used which keeps the program easy to reason about and ideal for beginners.

---

## Control Flow

Program Start  
Displays welcome message and active chambers  

Player Input  
Prompts the user to select a chamber  

Immediate Resolution  
If the player selects a specific chamber the outcome is resolved instantly  

Secondary Chance  
Certain selections trigger a randomized chamber shuffle before resolving  

Program End  
Displays final result and exits  

---

## Randomization Logic

The game uses a shuffle function to randomize chamber order.

The shuffle algorithm:
- Iterates through the array
- Selects a random index
- Swaps values until fully randomized

This ensures each playthrough produces different results and simulates uncertainty.

---

## Console Interface

Russian Roulette CLI

- Displays all active chambers
- Prompts the user for a chamber choice
- Adds tension through pauses and messages
- Outputs survival or death messages
- Ends cleanly after the outcome

---

## How to Run

Requirements  
.NET SDK installed  

Run the program  
```
dotnet run
```

Follow the prompts in the console to play.

---

## Potential Improvements

- Input validation for invalid numbers
- Loop to allow multiple rounds
- Difficulty modes with additional bullets
- Score or survival tracking
- Refactor logic into classes for scalability

---

## Personal Development

This project helped reinforce:

- Array manipulation
- Random number generation
- Conditional logic
- User input handling
- Writing readable console output
- Structuring simple game logic

It served as a solid foundation for moving toward more complex state driven applications and object oriented designs.
