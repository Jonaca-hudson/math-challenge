using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Redo
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            char doAgain;
            bool decision = true;

            while(decision==true)
            {


                //Ask the user for a 3 digit number
                Console.WriteLine("Please input a three digit number...");

            string input1 = Console.ReadLine();
            int.Parse(input1);


            int num = int.Parse(input1);

            //Ask user for second 3 digit number
            Console.WriteLine("Please input a second three digit number...");

            string input2 = Console.ReadLine();
            int.Parse(input2);

            int num2 = int.Parse(input2);

            //Checks if both inputs are the same amount of digits
            Console.WriteLine(input1.Length);
            Console.WriteLine(input2.Length);

            if (input1.Length == input2.Length)
            {
                Console.WriteLine("Input 1 & 2 match.");


                //Establishes the length restriction
                int i = 0;
                int[] mods = new int[3];

                while (i < input1.Length)

                {
                    //checks the inputs to make sure they add up to each other
                    int mod1 = num % 10;
                    int mod2 = num2 % 10;

                    num /= 10;
                    num2 /= 10;

                    mods[i] = mod1 + mod2;

                    Console.WriteLine(mod1 + mod2);
                    i++;
                }

                //prints true or false
                int total = mods[1];
                bool b = true;
                int j = 0;
                while (j < mods.Length)
                {
                    int k = mods[j];
                    if (k == total)
                    {
                        //Console.WriteLine(b);
                    }
                    else
                    {
                        b = false;
                        //Console.WriteLine(b);
                    }

                    j++;
                }
                Console.WriteLine(b);
            }
            else
            {
                //if the inputs don't add up, error message prints
                Console.WriteLine("Input 1 & 2 do not match, try again.");
            }
                Console.WriteLine("Would you like to run the program again? Y or N");
                doAgain = Convert.ToChar(Console.ReadLine());

                if(doAgain !='y' && doAgain != 'Y')
                {
                    decision = false;
                }
                    

            }
        }
    }
}
