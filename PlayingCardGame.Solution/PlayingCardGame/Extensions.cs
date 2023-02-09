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
        /// 計算List中每種數字的出現次數
        /// 此方法可用來判斷撲克牌牌型
        /// </summary>
        /// <param name="source"></param>
        /// <returns>例如若傳入 { 5, 6, 5, 6, 13 } 則傳回 { 1, 2, 2 }</returns>
        public static List<int> GetValueAppearances(this List<int> source)
        {
            List<int> distincts = source.Distinct().ToList();

            // 計算source中 每個數字各出現幾次
            List<int> appearances = new List<int>();
            for (int idx = 0; idx < distincts.Count; idx++)
            {
                int count = source.Count(v => v == distincts[idx]);
                appearances.Add(count);
            }

            return appearances.OrderBy(v => v).ToList();
        }
    }
}
