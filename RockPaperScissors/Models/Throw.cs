using System;
using RockPaperScissors;

namespace RockPaperScissors.Models
{
  public class Throw
  {
    // Randomizer
    public string Randomize()
    {
      Random ran = new Random();

      int num = ran.Next(3);

      if (num == 0)
      {
        return "Scissor";
      }
      else if (num == 1)
      {
        return "Rock";
      }
      else
      {
        return "Paper";
      }
    }

    // Compare
    public string Compare(string computer, string user)
    {
      if (computer == user)
      {
        return "Draw";
      }
      else if (computer == "Scissor")
      {
        if (user == "Rock")
        {
          return "User";
        }
        else
        {
          return "Computer";
        }
      }
      else if (computer == "Rock")
      {
        if (user == "Scissor")
        {
          return "Computer";
        }
        else
        {
          return "User";
        }
      }
      else if (computer == "Paper")
      {
        if (user == "Scissor")
        {
          return "User";
        }
        else
        {
          return "Computer";
        }
      }
      else 
      {
        return "Null";
      }
    }

    // Call 1 Random, 1 userInput, Compare, and return results
    public string Contest(string user)
    {
      string computer = Randomize();
      Console.WriteLine("Computer Throws a: " + computer);
      return Compare(computer, user);
    }
  }
}