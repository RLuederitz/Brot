using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Flour
  {
    // Felder
    private string particleSize;
    private string colour;
    private int amountPerUnit;
    private int nutritionValue;

    // Konstruktoren
    internal Flour(string particleSize, string colour, int amountPerUnit, int nutritionValue)
    {
      this.particleSize = particleSize;
      this.colour = colour;
      this.amountPerUnit = amountPerUnit;
      this.nutritionValue = nutritionValue;
    }

    // Methoden
    public string GetParticleSize()
    { 
      return particleSize;
    }
    public string GetColour()
    {
      return colour;
    }
    public int GetAmountPerUnit()
    {
      return amountPerUnit;
    }
    public int GetNutritionValue()
    {
      return nutritionValue;
    }
  }
}
