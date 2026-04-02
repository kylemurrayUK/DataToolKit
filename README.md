# Data Tool Kit:
Basic command line data processor

## Overview:
Takes user input and returns processed data depending on the tool chosen. 

## Features:
Calculator - Takes in two doubles and performs one of 4 operations; add, subtract, divide or multiply.
TextAnalyzer - Takes in a string and returns various metrics. For example, word count, longest word, etc.
Number Statistics - Takes in a sequence of integers and returns various metrics such as minimum, maximum, average, etc.

## Technical Highlights:
Separation of concerns with features contained within classes
Reusable utility classes such as validation
Handling tuples
Use of dictionary to track frequency of words in TextAnalyzer
Menu driven which keeps the Program.cs clean

## How to run:
Currently not deployed as a standalone application - so once you have pulled the repo run dotnet build then dotnet run. Menu takes integers for commands. Hopefully error messages make any issues clear.

## Project Structure:
├── Program.cs          # Entry point
├── Menu.cs             # Main menu and routing logic
├── Calculator.cs       # Calculator tool
├── TextAnalyzer.cs     # Text analysis tool
├── NumberStatistics.cs # Number statistics tool
├── GeneralUtils.cs     # Shared utility methods
└── ValidationUtils.cs  # Input validation logic