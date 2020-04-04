using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> students = new Stack<string>();
			while (true)
			{
				Console.WriteLine("1. Чтобы сдать работу введите Send \n"+
								  "2. Чтобы получить кофе введите Coffee \n");
				var action = Console.ReadLine();
				switch (action)
				{
					case "Coffee":
						{
							try
							{
								Console.WriteLine($"{students.Pop()} got a cup of coffee");
								break;
							}
							catch (Exception)
							{
								Console.WriteLine("Все работы проверены и кофе роздан. Введите команду:");
								break;
							}
						}
					case "Send":
						{
							Console.WriteLine("Введите свои данные");
							var name = Console.ReadLine();
							students.Push(name);
							break;
						}


				}

			}
		}
	}
}
