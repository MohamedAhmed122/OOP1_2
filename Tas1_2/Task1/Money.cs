using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1_1
{
	class Money
	{
		//Instantiate random number generator
		private Random random = new Random();

		private ulong integer;
		private ushort fraction;

		public ulong GetInteger()
		{

			return this.integer; // TODO: AM1
		}
		public ushort GetFraction()
		{
			return this.fraction; // TODO: AM2
		}

		public void DisplayToConsole()
		{
			Console.WriteLine("{0}.{1}", this.integer, this.fraction); // TODO: MD
		}
		public void SetInteger(ulong value)
		{
			integer = value; // TODO: MS1
		}
		public void SetFraction(ushort value)
		{
			fraction = value; // TODO: MS2
		}

		public void SetNumber(ulong integer, ushort fraction) // TODO: MS3
		{
			this.integer = integer;
			this.fraction = fraction;
		}
		public void addToFraction()
		{
			this.integer += (ushort)(this.fraction / 100);
			this.fraction = (ushort)(this.fraction % 100);
		}
		public Money() // TODO: C1
		{
			// In Random.Next(int min, int max) overload, min is inclusive, max is exclusive.
			this.integer = (ulong)random.Next(1, 112) - 4;
			this.fraction = (ushort)(random.Next(1, 156) * random.Next(3, 7));
			addToFraction();
		}

		public Money(ushort fraction) // TODO: C2
		{
			this.fraction = fraction;
			this.integer = (ulong)random.Next(6, 89);
		}
		public Money(ulong integer, ushort fraction) // TODO: C3
		{
			this.integer = integer;
			this.fraction = fraction;
		}

		public Money(Money money) // TODO: C4
		{
			this.integer = money.integer;
			this.fraction = money.fraction;
		}

		

		public void Addition(ulong integer, ushort fraction)  // TODO: MAdd
		{
			
			this.integer += integer;
			this.fraction += fraction;
			addToFraction();
		}

		public void Addition2(Money obj)   // TODO: MAdd2
		{
			
			this.integer += obj.integer;
			this.fraction += obj.fraction;
			addToFraction();

		}
		public bool checkString(String value)
		{
			for (int i = 0; i < value.Length; i++)
			{
				if ((value[i] >= '0' && value[i] <= '9') || value[i] == '.')
				{
					continue;
				}
				
					return false;
			}
			return true;  
		}
		public void Addition3(String value)   // TODO: MAdd3
		{
			
			if (checkString(value))
			{
				String[] newValue = value.Split('.');
				this.integer += Convert.ToUInt64(newValue[0]);
				this.fraction += Convert.ToUInt16(newValue[1]);
				addToFraction();
			}
			else
				Console.WriteLine("It contains a string");

		}

		public bool checkSubtraction(ulong integer, ushort fraction)
		{
			if (this.integer < integer)
			{
				return false;
			}
			else if (this.integer == integer)
			{
				if (this.fraction < fraction)
				{
					return false;
				}
			}
			return true;
		}
		public void Subtraction(ulong integer, ushort fraction)   // TODO: MSub
		{
			 // 25.18 - 10.75
			if (checkSubtraction(integer, fraction))
			{

				this.integer -= integer;
				this.fraction -= fraction;
				addToFraction();
			}
			else
				Console.WriteLine("Wrong");

		}

		public void Subtraction2(Money obj)       // TODO: MSub
		{
			
			if (checkSubtraction(obj.integer, obj.fraction))
			{

				this.integer -= obj.integer;
				this.fraction -= obj.fraction;
				addToFraction();
			}
			else
				Console.WriteLine("Wrong");
		}

		public void Subtraction3(String value)        // TODO: MSub3
		{
			
			if (checkString(value))
			{
				String[] newValue = value.Split('.');
				if (checkSubtraction(Convert.ToUInt64(newValue[0]), Convert.ToUInt16(newValue[1])))
				{
					this.integer -= Convert.ToUInt64(newValue[0]);
					this.fraction -= Convert.ToUInt16(newValue[1]);
					addToFraction();
				}
				else
					Console.WriteLine("Wrong");

			}
			else
				Console.WriteLine("It contains a string");
		}

		
		public bool MoneyEqual(Money obj)    // TODO: MEq
		{
			// compare fraction with fraction and integer with integer, if they are equal to each other return true else return false
			if (this.fraction
				== obj.fraction && this.integer == obj.integer)
			{
				return true;
			}
			return false;
		}

		public int MoneyCompare(Money obj)     // TODO: MComp
		{
			if (integer > obj.integer)
			{
				return 1;
			}
			else if (integer == obj.integer)
			{
				if (fraction > obj.fraction)
				{
					return 1;
				}
				else if (fraction == obj.fraction)
				{
					return -1;
				}
				else
				{
					return 0;
				}
			}
			else
			{
				return 0;
			}

		}
		
	}
}
