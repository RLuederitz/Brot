
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brot
{
  internal class Baker
  {
    // Felder
    private List<Bread> storage;
    private bool hasWater = false;
    private bool hasFlour = false;

    // Konstruktoren
    public Baker()
    {
      storage = new List<Bread>();
    }

    // Methoden
    public void BakeBread()
    {
      if (storage.Count > 9 /* Lager voll */)
      {
        // Urlaub!
        Console.WriteLine("Das Lager ist voll - ich mach' erst mal Urlaub!");
      }
      else // Platz im Lager
      {
        if (!hasWater /* kein Wasser */)
        {
          // Hole Wasser
          FetchWater();
        }
        if (!hasFlour /* kein Mehl */)
        {
          // Hole Mehl
          FetchFlour();
        }
        // Brot backen
        Bread bread = new Bread("Roggenbrot", 1000, 3000);
        hasFlour = false;
        hasWater = false;

        // Brot einlagern
        storage.Add(bread);
        Console.WriteLine("Habe Brot gebacken. Brotvorrat: " + storage.Count);
      }
    }

    internal void FetchFlour()
    {
      hasFlour = true;
    }

    internal void FetchWater()
    {
      hasWater = true;
    }

    // Brot an Kunden abgeben?
  }
}
