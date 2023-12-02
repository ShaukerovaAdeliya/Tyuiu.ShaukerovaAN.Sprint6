using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; // создаем массив с указанной длиной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2); ; // округляем значение до 2 знаков после запятой 
                valueArray[count] = y; // присваеваем значение в массив с индексом count
                count++;

            }
            return valueArray;
        }
    }
}
