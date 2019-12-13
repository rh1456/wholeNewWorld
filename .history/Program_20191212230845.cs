using System;

namespace wholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {

      var lower = 0;
      var upper = 0;
      Random random = new Random();
      var guess = random.Next(1, 100); //generate pseudo random number between 1 and 100
      var thinking = true;
      var numOfGuesses = 0;
      string name;
      string answer;
      //test line
      Console.WriteLine("Welcome to my first C# program, enter your name to start and press enter");
      name = Console.ReadLine();
      Console.WriteLine($"{name}, Think of a number between {lower} and {upper}");
      //   string waitTime = int.ToString();
      Console.WriteLine($"Alright great I'm gunna guess");
      //   var response = Console.ReadLine();
      //   if (response == "yup")
      //   {
      //     Console.WriteLine("okay great here we go");
      //   }
      //   else;
      //   {
      //     thinking = false;
      //     Console.WriteLine($"Don't have all day I picked {guess} anyway");
      //   }
      while (thinking == true)
      {
        Console.WriteLine($"I think your number is {guess}, how'd I do?");
        answer = Console.ReadLine();
        numOfGuesses++;
        if (answer == "no")
        {
          Console.WriteLine("Oops is it higher or lower");
          answer = Console.ReadLine();
          if (answer == "higher") //when the user types string do this
          {
            lower = min;
            guess = (lower + upper) / 2; //binary search to change guess
          }
          else if (answer == "lower")
          {
            upper = guess - 1;
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

static void startGame()
{

}





