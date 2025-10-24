using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Water
  {
    // Felder
    private int amountPerUnit;
    int age = 0;
    private bool isFresh;

    // Konstruktoren
    public Water(int unitSize)
    {
      amountPerUnit = unitSize;
      isFresh = true;
    }

    // Methoden
    public bool CheckIfIsFresh()
    {
      return isFresh;
    }
    public void Decay(int amountOfHours)
    {
      if (amountOfHours > 0)
      {
        SetAge(amountOfHours);
        isFresh = age < 4;
      }
    }
    protected void SetAge(int value)
    {
      age += value;
    }
  }
}
