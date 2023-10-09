using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibery
{
    public class ArrayClass
    {
        /// <summary>
        /// Тестдля вычисления произведения отрицательных элементов, расположеных после максимального
        /// </summary>
        /// <param name="number">На вхоже массив</param>
        /// <returns>На выходе мы получаем произведение отрицательных элементов</returns>
        public double ArrayString(int[] number)
        {
            int max = 0;
            int NumberMax = 0;
            

            for (int i = 0; i<number.Length;i++)
            {
                if (number[i] > max )
                {
                    max= number[i];
                    NumberMax = i; 
                }
            }
            double work = 1;
  
            for (int i = NumberMax;i<number.Length;i++)
            {
                if (number[i] < 0)
                {
                    work*= number[i];      
                }
           
            }
            return work;
        }

    }
}
