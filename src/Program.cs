using System;

namespace FunctionChallenges
{
    class Program
    {
        // Challenge 1: String and Number Processor
        public static void StringNumberProcessor(object param1, object param2, object param3, object param4)
        {
            object[] values = { param1, param2, param3, param4 };
            double sum = 0;
            string concatenate = "";
            foreach (object value in values)
            {
                switch (value)
                {
                    case int:
                        sum += (int)value;
                        break;
                    case double:
                        sum += Convert.ToDouble(value);
                        break;
                    case string:
                        concatenate += value + " ";
                        break;
                    default:
                        Console.WriteLine("Unknown type");
                        break;
                }
            }
            Console.WriteLine($"\"{concatenate}; {sum}\"");
        }


        // Challenge 3: Guessing Game
        public static void GuessingGame()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 100);
            //Console.WriteLine($"{randomNum}");
            do
            {
                try
                {
                    Console.WriteLine($"Choose a number between 0 and 100: (To quit, enter Quit)");
                    string input = Console.ReadLine() ?? "";
                    if (input.ToLower() == "quit")
                    {
                        return;
                    }
                    if (Convert.ToInt32(input) != randomNum)
                    {
                        Console.WriteLine($"Try again!\n");
                        continue;
                    }
                    Console.WriteLine($"Yes you got it!\nEnd of the game.");
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer number between 0 and 100.\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            } while (true);
        }


        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("\n*****************************************");
            Console.WriteLine("Challenge 1: String and Number Processor");
            Console.WriteLine("*****************************************");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"


            // // Challenge 2: Object Swapper
            // Console.WriteLine("\nChallenge 2: Object Swapper");
            // int num1 = 25, num2 = 30;
            // int num 3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";

            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");


            // Challenge 3: Guessing Game
            Console.WriteLine("\n*****************************************");
            Console.WriteLine("Challenge 3: Guessing Game");
            Console.WriteLine("*****************************************");
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`


            // // Challenge 4: Simple Word Reversal
            // Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            // string sentence = "This is the original sentence!";
            // string reversed = ReverseWords(sentence);
            // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }
    }
}
