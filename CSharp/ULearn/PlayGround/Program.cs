using System;
using System.Text;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFirstEvenNumbers(3);
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] arr = new int[count];
            for (var i = 0; i < count; i++)
            {
                arr[i] = (i + 1) * 2;
            }
            return arr;
        }
    }
}
