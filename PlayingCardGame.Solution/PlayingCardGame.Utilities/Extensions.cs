using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public static class Extensions
    {
        public static List<int> GetValueDistribution(this List<int> values)
        {
            List<int> valDist = values.Distinct().ToList();

            List<int> countDist = new List<int>();
            for (int idx = 0; idx < valDist.Count; idx++)
            {
                int count = values.Count(v => v == valDist[idx]);
                countDist.Add(count);
            }

            return countDist;
        }
    }
}
