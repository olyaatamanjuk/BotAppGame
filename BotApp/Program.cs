using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BotApp
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			var Bot = new TelegramBot();
			Bot.StartBot();
			Console.ReadKey();
		}
	}
}
