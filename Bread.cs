using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Bread
  {
    // Eigenschaften
    private string typeOfBread;
    private int weight;
    private int nutritionValue;

    // Konstruktoren
    public Bread(string typeOfBread, int weight, int nutritionValue)
    {
      this.typeOfBread = typeOfBread;
      this.weight = weight;
      this.nutritionValue = nutritionValue;
    }

    // Methoden
    public int GetNutritionValue()
    {
      return nutritionValue;
    }
  }
}
