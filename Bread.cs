using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Bread : Food
  {
    // Eigenschaften
    private string typeOfBread;
    private int weight;

    // Konstruktoren
    public Bread(string typeOfBread, int weight, int nutritionValue)
    {
      this.typeOfBread = typeOfBread;
      this.weight = weight;
      SetNutritionValue(nutritionValue);
    }
  }
}
