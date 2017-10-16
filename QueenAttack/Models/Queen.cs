using System.Collections.Generic;
// using System;

namespace QueenAttack.Models
{
  public class QueenAttackGenerator
  {

    public bool CanAttack(int QueenX, int QueenY, int ChessX, int ChessY)
    {
      if(QueenX == ChessX)
      {
        return true;
      }
      else if(QueenY == ChessY)
      {
        return true;
      }
      else if((ChessX - QueenX) == (ChessY - QueenY))
      {
        return true;
      }
      else if((QueenX - ChessX) == (QueenY - ChessY))
      {
        return true;
      }
      else if((QueenX - ChessX) == (ChessY - QueenY))
      {
        return true;
      }
      else if((ChessX - QueenX) == (QueenY - ChessY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
