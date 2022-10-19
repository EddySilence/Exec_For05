using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* 題目：
			   用迴圈呈現指定右側的結果	
			   ++++1
			   +++22
			   ++333
			   +4444
			   55555
			 */

			for (int i = 1; i <= 5; i++)
			{
				char c = Convert.ToChar(48+i);
				Console.WriteLine(new string('+', 5 - i) + new string(c, i));
			}

		}
	}
}
