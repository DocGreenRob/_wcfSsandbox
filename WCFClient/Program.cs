using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClient.HelloUniverseServiceReference;

namespace WCFClient
{
	class Program
	{
		static void Main(string[] args)
		{
			HumanClient client = new HumanClient("NetTcpBinding_IHuman");
			Human human = new Human
			{
				Race = "African",
				BirthDate = new DateTime(1979, 8, 28),
				Gender = "Male",
				FirstName = "Robert",
				LastName = "Green"
			};
			Console.WriteLine(client.Speak(human));
			Console.ReadKey();
		}
	}
}
