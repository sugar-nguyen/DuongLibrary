using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongLibrary.Interface
{
    interface IComment
    {
        /// <summary>
        /// Tạo mã ngẫu nhiên từ Aa-9
        /// </summary>
        /// <param name="charNumber">Số lượng kí tự khởi tạo</param>
        /// <returns>string</returns>
        string CreateRandomCode(int charNumber);
        /// <summary>
        /// Random không trùng 1 danh sách số nguyên cho trước
        /// </summary>
        /// <param name="ienumerableInt">Danh sách các số nguyên</param>
        /// <param name="take">Số phần tử cần lấy</param>
        /// <returns>Danh sách phần tử integer</returns>
        List<int> RandomNotDuplicate(IEnumerable<int> ienumerableInt, int take);
    }
}
