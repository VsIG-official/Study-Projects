using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
	class FriendlyKid : Kid
	{
		public override void PrintMessage()
		{
			Console.WriteLine("Beep, Beep, I'm a friendly kid");
		}
	}
}
