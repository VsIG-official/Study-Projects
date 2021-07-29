using System;
using System.Text;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            MaxIndex(array);
        }
        public static int MaxIndex(double[] array)
        {
            var max = double.MinValue;
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
