﻿namespace Tyuiu.GalimovaAS.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] num0ne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = num0ne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
