using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SortByYearComparator : IComparer
    {
        /// <summary>
        /// Метод, сравнивающий два объекта
        /// </summary>
        public int Compare(object? x, object? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            if (x is Transport transportX && y is Transport transportY)
            {
                return transportX.Year.CompareTo(transportY.Year);
            }
            throw new ArgumentException("Некорректные типы сравниваемых объектов.");
        }
    }
}
