﻿using System;

namespace wholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var guess = 47;
      var thinking = true;
      var numOfGuesses = 0;
      string name;

      //test line
      Console.WriteLine("Welcome to my first C# program, enter your name to start");
      name = Console.ReadLine();
      Console.WriteLine($"{name}, Think of a number between {min} and {max}");
      while (thinking == true)
      {
        Console.WriteLine($"")

      }
    }
  }
}
