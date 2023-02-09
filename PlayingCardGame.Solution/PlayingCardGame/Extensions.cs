using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public static class Extensions
    {
        /// <summary>
        /// 判斷List中重複數字的數量分布  
        /// 此方法可用來判斷撲克牌牌型
        /// </summary>
        /// <param name="values"></param>
        /// <returns>例如若傳入 {5, 6, 5, 6, 13} 則傳回 {1, 2, 2}</returns>
        public static List<int> GetValueDistribution(this List<int> values)
        {
            List<int> valDist = values.Distinct().ToList();

            List<int> countDist = new List<int>();
            for (int idx = 0; idx < valDist.Count; idx++)
            {
                int count = values.Count(v => v == valDist[idx]);
                countDist.Add(count);
            }

            return countDist.OrderBy(v => v).ToList();
        }
    }
}
