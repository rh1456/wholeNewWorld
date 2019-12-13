using System;

namespace wholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var numberToGuess = 47;
      var game = true;
      var numOfGuesses = 0;
      string name;


      //test line
      Console.WriteLine("Welcome to my first C# program");
      name = Console.ReadLine();
      Console.WriteLine($"{name}, I'm guessing a number between {min} and {max}")
    }
  }
}
