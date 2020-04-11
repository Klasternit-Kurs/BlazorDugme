using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Server
{
	public class Hab : Hub
	{
		public void Foo()
		{
			Console.WriteLine("Ping");
			Clients.Caller.SendAsync("NekaMetoda", "od haba with love :) ");
		}

		public void Bar(string s)
		{
			Console.WriteLine(s);
		}
	}
}
