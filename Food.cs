using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Food
  {
    // Felder
    private int nutritionValue;

    // Methoden
    public int GetNutritionValue()
    {
      return nutritionValue;
    }
    protected void SetNutritionValue(int nutritionValue)
    {
      this.nutritionValue = nutritionValue;
    }
  }
}
