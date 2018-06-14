using System;

namespace csTesting2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] groceryList = { "eggs", "milk", "cheese" };
            int[] numList = { 1, 5, 7, 89, 23, 34 };

            // for loop- looping the number of items in array
            for (int i = 0; i < groceryList.Length; i++)
            {
                // below writes the number in i
                Console.WriteLine(i);
                // below writes the groceryList item based on index
                // if you need to access an array use the below example with square brackets with a number
                Console.WriteLine(groceryList[i]);

            }

            // foreach loop
            foreach (string i in groceryList)
            {
                Console.WriteLine(i);
            }

            foreach (string x in groceryList)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

            // user input
            Console.Write("Is the light on? ");
            string isLightOn = Console.ReadLine();
            // when considering the below if statement, "yes" needs to be typed as case sensitive or you can use
            // || as an "or" operation to include more acceptable answers
            if (isLightOn == "yes" || isLightOn == "Yes" || isLightOn == "y")
            {
                Console.WriteLine("It sure is!");
            } else if (isLightOn == "no" || isLightOn == "No" || isLightOn == "n")
            {
                Console.WriteLine("Nope!");
            } else
            {
                Console.WriteLine("I'm not sure what you're saying.");
            }

            Console.ReadKey();

            // switching the string to number to reflect the input
            Console.Write("What is the secret number? ");
            string secNum = Console.ReadLine();

            // convert and place into int variable, Parse is a grabber
            int secNumInt = int.Parse(secNum);

            switch (secNumInt)
            {
                case 0:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                case 3:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                case 6:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                case 9:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                case 12:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                case 34:
                    Console.WriteLine("Your secret number is {0}", secNumInt);
                    break;
                default:
                    Console.WriteLine("You didn't guess the secret number");
                    break;
            }

            string[] starWars = { "Leia", "Luke", "Solo", "Chewie" };

            for (int i = 0; i < starWars.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(starWars[i]);
            }

            foreach (string i in starWars)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            Console.Write("Do you want to enter the deep, dark room? ");
            string darkRoom = Console.ReadLine();

            if (darkRoom == "yes" || darkRoom == "Yes" || darkRoom == "y" || darkRoom == "Y")
            {
                Console.WriteLine("Well that sounds like a really great idea!");
            }
            else if (darkRoom == "no" || darkRoom == "No" || darkRoom == "n" || darkRoom == "N")
            {
                Console.WriteLine("Then leave coward!");
            }
            else
            {
                Console.WriteLine("Wow, you suck at following directions.");
            }

            Console.ReadKey();

            Console.Write("How many pies did you eat? ");
            string pieNum = Console.ReadLine();

            int pieNumInt = int.Parse(pieNum);

            switch (pieNumInt)
            {
                case 0:
                    Console.WriteLine("{0}, really?! Fine no pie for you!", pieNumInt);
                    break;
                case 1:
                    Console.WriteLine("{0}, well that's conservative.", pieNumInt);
                    break;
                case 2:
                    Console.WriteLine("{0}, alright you know how to party!", pieNumInt);
                    break;
                case 3:
                    Console.WriteLine("{0}, maybe you should cut yourself off.", pieNumInt);
                    break;
                case 4:
                    Console.WriteLine("{0}, ummm ok...", pieNumInt);
                    break;
                case 5:
                    Console.WriteLine("{0}, yea you are totally going to die. You should call 911 now.", pieNumInt);
                    break;
                default:
                    Console.WriteLine("Yet again you can't follow directions, you're such a disappointment.");
                    break;
            }

            Bus();
            Glue();
            Marker();
            Console.ReadKey();
        }

        // Methods Homework 14, I guess...
        public static void Bus()
        {
            Console.WriteLine("I took the bus to work today.");
        }

        private static void Glue()
        {
            Console.WriteLine("This is a private method.");
        }

        public static string Marker()
        {
            string word = "Look its a string";
            return word;
        }

        public void Pen(int num1, int num2)
        {
            
            Console.WriteLine("{0} is a big number and {1} is a small number.", num1, num2);

        }
}
