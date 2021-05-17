using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
	class Program
	{
		static void Main()
		{
			Kid kid = new Kid();
			Kid friendlyKid = new FriendlyKid();
			Kid artisticKid = new ArtisticKid();

			kid.PrintMessage();
			friendlyKid.PrintMessage();
			artisticKid.PrintMessage();

			Console.ReadLine();
		}
	}
}
