using System;

namespace FunctionChallenges
{
    class Program
    {
        // Challenge 1: String and Number Processor -------------------
        public static void StringNumberProcessor(params object[] values)
        {
            double sum = 0;
            string concatenate = "";
            foreach (object value in values)
            {
                switch (value)
                {
                    case int valueInt:
                        sum += valueInt;
                        break;
                    case double valueDouble:
                        sum += valueDouble;
                        break;
                    case string valueString:
                        concatenate += valueString + " ";
                        break;
                    default:
                        Console.WriteLine("Unknown type");
                        break;
                }
            }
            Console.WriteLine($"\"{concatenate}; {sum}\"");
        }

        // Challenge 2: Object Swapper --------------------------------
        // SwapObjects by ref
        public static void SwapObjects<T>(ref T x, ref T y)
        {
            if (x is string && y is string)
            {
                if (x.ToString()?.Length > 5 && y.ToString()?.Length > 5)
                {
                    T temp = x;
                    x = y;
                    y = temp;
                }
                else
                {
                    Console.WriteLine($"error");
                    //error
                }
            }

            if (x is int && y is int)
            {
                int num1 = Convert.ToInt32(x);
                int num2 = Convert.ToInt32(y);
                Console.WriteLine($"Inputs: num1 = {x}, num2= {y}");
                if (num1 > 18 && num2 > 18)
                {
                    T temp = x;
                    x = y;
                    y = temp;
                    Console.WriteLine($"Result: num1 = {x}, num2= {y}\n");
                }
                else
                {
                    Console.WriteLine($"Error: Value must be more than 18\n");
                }
            }
        }
        // SwapObjects by object
        public static void SwapObjects(object obj1, object obj2)
        {
            if (obj1 is bool || obj2 is bool)
            {
                Console.WriteLine($"Inputs: {obj1}, {obj2}");
                Console.WriteLine("Error: Unsupported type\n");
            }

            if (obj1 is string && obj2 is string)
            {
                Console.WriteLine($"Inputs: str1 = {obj1}, str2 = {obj2}");
                if (obj1.ToString()?.Length > 5 && obj2.ToString()?.Length > 5)
                {
                    object temp = obj1;
                    obj1 = obj2;
                    obj2 = temp;
                    Console.WriteLine($"Result: str1 = {obj1}, str2 = {obj2}\n");
                }
                else
                {
                    Console.WriteLine($"Error: Length must be more than 5\n");
                }
            }

            if ((obj1 is int && obj2 is int) || (obj1 is double && obj2 is double))
            {
                Console.WriteLine($"Inputs: num1 = {obj1}, num2 = {obj2}");
                if ((double)obj1 > 18 && (double)obj2 > 18)
                {
                    object temp = obj2;
                    obj1 = obj2;
                    obj2 = temp;
                    Console.WriteLine($"Result: num1 = {obj1}, num2 = {obj2}\n");
                }
                else
                {
                    Console.WriteLine($"Error: Value must be more than 18\n");
                }
            }
        }

        // Challenge 3: Guessing Game ---------------------------------
        public static void GuessingGame()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 100);
            //Console.WriteLine($"{randomNum}"); //show the random number
            do
            {
                try
                {
                    Console.WriteLine($"Choose a number between 0 and 100: (To exit, enter Quit)");
                    string input = Console.ReadLine() ?? "";
                    if (input.ToLower() == "quit")
                        return;
                    int num = Convert.ToInt32(input);
                    if (num < 0 || num > 100)
                        throw new ArgumentOutOfRangeException();
                    if (num != randomNum)
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
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be between 0 and 100.\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            } while (true);
        }

        // Challenge 4: Simple Word Reversal --------------------------
        public static string ReverseWords(string sentence)
        {
            string sentenceReversed = "";
            if (string.IsNullOrWhiteSpace(sentence))
                throw new ArgumentNullException(null, "No word or sentence was entered.");

            if (double.TryParse(sentence, out _))
                throw new FormatException("Invalid input. Please enter a word or a sentence.");

            string[] words = sentence.Split(" ");
            foreach (string word in words)
                sentenceReversed += new string(word.Reverse().ToArray()) + " ";

            return sentenceReversed;
        }


        static void Main(string[] args)
        {
            // // Challenge 1: String and Number Processor
            // Console.WriteLine("\n*****************************************");
            // Console.WriteLine("Challenge 1: String and Number Processor");
            // Console.WriteLine("*****************************************");
            // StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            //----------------------------------------------------------

            // // Challenge 2: Object Swapper
            // Console.WriteLine("\n*****************************************");
            // Console.WriteLine("Challenge 2: Object Swapper");
            // Console.WriteLine("*****************************************");
            // int num1 = 25, num2 = 30;
            // int num3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";

            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // //SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Numbers: {num3}, {num4}");
            // Console.WriteLine($"Strings: {str1}, {str2}");
            //----------------------------------------------------------

            // Challenge 3: Guessing Game
            Console.WriteLine("\n*****************************************");
            Console.WriteLine("Challenge 3: Guessing Game");
            Console.WriteLine("*****************************************");
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`
            //----------------------------------------------------------

            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\n*****************************************");
            Console.WriteLine("Challenge 4: Simple Word Reversal");
            Console.WriteLine("*****************************************");
            try
            {
                string sentence = "This is the original sentence!";
                //string sentence = "5";
                //string sentence = "";
                Console.WriteLine($"Input: {sentence}");
                string reversed = ReverseWords(sentence);
                Console.WriteLine($"Reversed: {reversed}\n"); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"{e.Message}\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}\n");
            }
        }
    }
}
