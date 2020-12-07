using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tas1_2
{
	class Program
	{
        static void Main(string[] args)
		{
            // --------Testing -----------// 
            
			Money a = new Money();
			Money b = new Money();
			a.SetInteger(0);
			a.SetFraction(3);

			a.Subtraction3("W2.1");

			b.SetInteger(0);			
			b.SetFraction(4);
			a.Subtraction2(b);


            // calculateSum
            Money[] arr = new Money[10];
			Money calculateSum = new Money(0, 0);

			// Intialize array with random numbers
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new Money();
				arr[i].DisplayToConsole();
				Thread.Sleep(500);
			}
			Console.WriteLine();

			// Add all the array elements
			for (int i = 0; i < arr.Length; i++)
			{
				calculateSum.Addition2(arr[i]);
			}


			Console.Write("After adding all real numbers: ");
			calculateSum.DisplayToConsole();
			Console.WriteLine();


            Console.Write("After adding all real numbers: ");
			CalcSum.DisplayToConsole();
			Console.WriteLine();


            // CalcEqal
			int temp = 0;

			// Compare each element with the whole array
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (i != j)
					{
						// if both objects are equal increment temp
						if (arr[i].MoneyEqual(arr[j]))
						{
							temp++;
						}
					}
				}
			}

			Console.Write("\nNumber of equal objects: {0}", temp);
			Console.WriteLine();

        }
    }
}