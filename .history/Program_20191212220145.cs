﻿using System;

namespace wholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var lower = 1;
      var upper = 100;
      Random random = new Random();
      var guess = random.Next(1, 100); //generate pseudo random number between 1 and 100
      var thinking = true;
      var numOfGuesses = 0;
      string name;
      string answer;
      //test line
      Console.WriteLine("Welcome to my first C# program, enter your name to start and press enter");
      name = Console.ReadLine();
      Console.WriteLine($"{name}, Think of a number between {min} and {max}");
      while (thinking == true)
      {
        Console.WriteLine($"I think your number is {guess}, how'd I do?");
        answer = Console.ReadLine();
        numOfGuesses++; //add 1 to the variable declared
        if (answer == "no")
        {
          Console.WriteLine("Oops is it higher or lower");
          answer = Console.ReadLine();
          if (answer == "higher")
          {
            lower = guess;
            guess = (lower + upper) / 2; //binary search 
          }
          else if (answer == "lower")
          {
            upper = guess;
            guess = (lower + upper) / 2; //binary search 
          }
        }
        else if (answer == "yes")
        {
          thinking = false;
        }

      }

      Console.WriteLine($"HAH {guess} so obvious,  only took me {numOfGuesses} tries ");
    }
  }
}






