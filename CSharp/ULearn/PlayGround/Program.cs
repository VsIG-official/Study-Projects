using System;

namespace PlayGround
{
	class Program
	{
		static void Main(string[] args)
		{
           Console.WriteLine(ShouldFire2(true, "boss", 10));
           Console.WriteLine(ShouldFire2(true, "boss", 50));
           Console.WriteLine(ShouldFire2(false, "boss", 50));
           Console.WriteLine(ShouldFire2(false, "boss", 10));
        }

        private static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && (enemyName == "boss"
                && robotHealth >= 50 || enemyName != "boss");
        }
    }
}
