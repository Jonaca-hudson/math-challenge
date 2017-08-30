using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mathChallenge

{
	class Program
	{
		 int Compare(int num1, int num2) //main function that shifts and adds each number, returns 0 for false and 1 for true
		{
            int compareTo = (num1 % 10) + (num2 % 10);
			num1 = num1 / 10;
            num2 = num2 / 10;
            while (num1 > 0 && num2 > 0)
                while (length != 3 || variable.Length = 3) 

			{
				int temp = (num1 % 10) + (num2 % 10);

				if (compareTo != temp)
					return 0;

				num1 = num1 / 10;
                num2 = num2 / 10;
			}
            return 1;
		}

		public void Main(string[] args)
		{
			//request the first number from the user 
			int num1;
			Console.WriteLine("Type any three-digit number below...");
			String Result1 = Console.ReadLine();


			while (!Int32.TryParse(Result1, out num1) || num1 <= -1 || num1 > 1000 || num1 < 100) //integer validation
			{
				Console.WriteLine("Not a valid number, Please try again...");
				Result1 = Console.ReadLine();
			}
            num1 = Convert.ToInt32(Result1);

            //request the second number from the user
            int num2;
			String Result2 = Console.ReadLine();
			while (!Int32.TryParse(Result2, out num2) || num2 < -1 || num2 > 1000 || num1 < 100)

			{
				Console.WriteLine("Not a valid number, Please try again...");
				Result2 = Console.ReadLine();
			}
            num2 = Convert.ToInt32(Result2);

            // assigns each digit a variable
            int dig1num1, dig2num1, dig3num1 = 0;

			int dig1num2, dig2num2, dig3num2 = 0;

			//Writing the new integers to the console
			Console.WriteLine("Press enter to get individual digits for your first number");
			Console.WriteLine("{0}->{1}, {2}, {3}", num1, dig3num1, dig2num1, dig1num1);
			//Console.ReadKey();

			Console.WriteLine("Press enter to get individual digits for your second number");
			Console.WriteLine("{0}->{1}, {2}, {3}", num2, dig3num2, dig2num2, dig1num2);
			//Console.ReadKey();

			// constructing comparison aka addition variables
			int total1, total2, total3 = 0;
			

			//combining corresponding numbers
			total1 = (dig1num2 + dig1num2);
			total2 = (dig2num1 + dig2num2);
			total3 = (dig3num1 + dig3num2);

			//boolean condition to test whether the corresponding numbers are equal
			bool a = (total1 == total2 && total2 == total3);
			bool b = (total1 != total2 && total2 == total3);
			bool c = (total1 == total2 && total2 != total3);


			if (a)
			{
				Console.WriteLine("True");
				Console.WriteLine(a);
				Console.ReadLine();
				do
				{
					Console.WriteLine("play again? [Yes | No]");
				} while (Console.ReadLine() != "No!");

			}
		}
	}
}
