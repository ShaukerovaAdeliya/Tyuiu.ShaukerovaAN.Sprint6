using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V13
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
                y = Math.Round(3 * Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);  // округляем значение до 2 знаков после запятой 
                valueArray[count] = y; // присваеваем значение в массив с индексом count
                count++;

            }
            return valueArray;
        }
    }
}
