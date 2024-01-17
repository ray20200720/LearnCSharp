using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypeExample
{
    public enum SomeRootVegetables
    {
        HorseRadish,
        Radish,
        Turnip
    }

    // A bit field or flag enumeration of harvesting seasons.
    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autum = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autum | Winter | Spring
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<SomeRootVegetables, Seasons> AvailableIn = new Dictionary<SomeRootVegetables, Seasons>();

            AvailableIn[SomeRootVegetables.HorseRadish] = Seasons.All;
            AvailableIn[SomeRootVegetables.Radish] = Seasons.Spring;
            AvailableIn[SomeRootVegetables.Turnip] = Seasons.Spring | Seasons.Autum;

            Seasons[] theSeasons = new Seasons[] { Seasons.Summer, Seasons.Autum, Seasons.Winter, Seasons.Spring };

            // Print information of what vegetables are available each season.
            foreach (Seasons season in theSeasons)
            {
                Console.Write(String.Format(
                  "The following root vegetables are harvested in {0}:\n",
                  season.ToString("G")));
                foreach (KeyValuePair<SomeRootVegetables, Seasons> item in AvailableIn)
                {
                    // A bitwise comparison.
                    if (((Seasons)item.Value & season) > 0)
                        Console.Write(String.Format("  {0:G}\n",
                             (SomeRootVegetables)item.Key));
                }
            }

            Console.ReadKey();
        }
    }
}
