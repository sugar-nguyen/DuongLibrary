using System;
using System.Collections.Generic;
using System.Linq;

namespace DuongLibrary
{
    /// <summary>
    /// 1 số kiểu random thiết yếu
    /// </summary>
    public static class SpecialRandom
    {
      
        /// <summary>
        /// Tạo mã ngẫu nhiên từ Aa-9
        /// </summary>
        /// <param name="charNumber">Số lượng kí tự khởi tạo</param>
        /// <returns>string</returns>
        public static string CreateRandomCode(uint charNumber)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, (int)charNumber).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Random không trùng 1 danh sách số nguyên cho trước
        /// </summary>
        /// <param name="ienumerableInt">Danh sách các số nguyên</param>
        /// <param name="take">Số phần tử cần lấy</param>
        /// <returns>Danh sách phần tử integer</returns>
        public static List<int> RandomNotDuplicate(IEnumerable<int> ienumerableInt, uint take)
        {
            if (take > ienumerableInt.Count())
            {
                throw new Exception("Số lượng phần tử cần lấy không thể lớn hơn số phần tử của danh sách");
            }
            else if (ienumerableInt.Count() == 0)
            {
                return new List<int>();
            }
            var _temp = ienumerableInt.ToList();
            List<int> rs = new List<int>();
            for (int i = 1; i <= take; i++)
            {
                int? n = RandomOnList(_temp, rs);
                if (n == null) break;
                rs.Add((int)n);
                _temp.RemoveAll(x => x == n);
            }
            return rs;
        }
        private static int? RandomOnList(IEnumerable<int> ienumerableInt, List<int> includes)
        {
            Random random = new Random();
            if (includes.Count == ienumerableInt.Count() || ienumerableInt.Count() == 0)
            {
                return null;
            }
            return ienumerableInt.ElementAt(random.Next(ienumerableInt.Count() - 1));
        }


        /// <summary>
        /// sắp xếp ngẫu nhiên, extention của list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random random = new Random();
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    
}
