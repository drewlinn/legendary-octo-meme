using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    public string Compare(string Player1, string Player2)
    {
      if (Player1 == "Rock" && Player2 == "Paper" || Player2 == "Rock" && Player1 == "Paper")
      {
        return "Paper is winner";
      }
      else if (Player1 == "Scissors" && Player2 == "Rock" || Player2 == "Scissors" && Player1 == "Rock")
      {
        return "Rock is winner";
      }
      else if (Player1 == "Paper" && Player2 == "Scissors" || Player2 == "Paper" && Player1 == "Scissors")
      {
        return "Scissors is winner";
      }
      else
      {
        return "Draw";
      }
    }
  }
}
