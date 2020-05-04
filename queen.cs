using System;

class QueenAttack
{
  static void Main()
  {
    Console.WriteLine("Enter Queen X coordinate:");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Queen Y coordinate:");
    int queenY = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Foe X coordinate:");
    int foeX = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Foe Y coordinate:");
    int foeY = int.Parse(Console.ReadLine());

    if (queenX == foeX || queenY == foeY || (Math.Abs(queenX - foeX) == Math.Abs(queenY - foeY)))
    {
      Console.WriteLine("Attack is valid!");
    }
    else
    {
      Console.WriteLine("Noep.");
    }
  }
}




/* TEST BOARD

  - - - - -
  - - - T - 1, 3
  - - - - -
  - Q - - - 3, 1
  - - - - -

  T - - - - 0, 0
  - Q - - -
  - - - - -
  - - - - -
  - - - - - 1,1
  
  - - T - - 0, 2
  - Q - - - 1, 1
  - - - - -
  - - - - -
  - - - - - 

*/
