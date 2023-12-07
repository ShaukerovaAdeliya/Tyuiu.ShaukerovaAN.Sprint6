﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double divisor = (2 * x) - 2;
                if (Math.Abs(divisor) < 0.000001)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(4 - (2 * x) + ((2 + Math.Cos(x)) / divisor), 2);
                }

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
