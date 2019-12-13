using System;

namespace wholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      Random random = new Random();
      var guess = random.Next(100);
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
        numOfGuesses++; //add 1 to the variable each time answer is no
        if (answer == "no")
        {
          Console.WriteLine("Oops is it higher or lower");
          if (answer == "higher")
          {
            min = guess;
            guess = (min + max) / 2; //binary search 
          }
          else if (answer == "lower")
          {
            max = guess;
            guess = (min + max) / 2; //binary search 
          }
        }
        else if (answer == "yes")
        {
          thinking = false;
        }

      }
    }






