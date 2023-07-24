using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lab3_401
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Asking the user to input 3 numbers in the console while the user input is being read and stored in the variable "input" and splitting the string into an array of substrings. Also calculating the product and printing the string followed by the value to the console.
            Console.WriteLine("Enter Three Numbers");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(" ");
            double product = CalculateProduct(numberStrings);
            Console.WriteLine("Product: " + product);
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
            
        }
        //This method takes in an array of "numberStrings" as the input and returns a product as a "double" (a data type that can store decimals and occupies 8 bytes(64 bits)).
        static double CalculateProduct(string[] numberStrings)
        {
            //Check to see if number of elements in "numberStrings" is less than 3. If true then it returns 0 as the product since there are not enough numbers to multiply for our method.
            if (numberStrings.Length < 3)
                return 0;

            //Sets the product variable to 1.
            double product = 1;

            //For loop that iterates over the first 3 elements of the "numberStrings" array. Parse each element as a "double" and if it succeeds multiply number with the product.
            for (int i = 0; i < 3; i++) 
            {
                if (i >= numberStrings.Length)
                    break;

                if (double.TryParse(numberStrings[i], out double number))
                {
                    product *= number;
                }
                else
                {
                    product *= 1;
                }
            }
            return product;

         }
        public static void Challenge2()
        {
            Console.WriteLine("Choose a number between 2-10");
            string input = Console.ReadLine();
            int userNumber = Convert.ToInt32(input);

            int sum = 0;

            for (int i = 0; i < userNumber; i++) 
            {
                Console.WriteLine($"{i+1} of {userNumber} Enter a number");
                string numberEnter = Console.ReadLine();
                int userEnterNumber = Convert.ToInt32(numberEnter);

                sum += userEnterNumber;
            }

            int average = sum / userNumber;
            Console.WriteLine($"Average of these numbers:{average} ");
        }
        public static void Challenge3()
        {
            Console.WriteLine("*");
            Console.WriteLine("***");
            Console.WriteLine("*****");
            Console.WriteLine("*******");
            Console.WriteLine("*********");
            Console.WriteLine("*******");
            Console.WriteLine("*****");
            Console.WriteLine("***");
            Console.WriteLine("*");
        }
        public static void Challenge4()
        {
            int[] integerArray = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int mostSeen;
            int highScore = 0;

            for (int i = 0; i < integerArray.Length;i++) 
            {
                int currentNumber = integerArray[i];
                int timesSeen = 1;
                mostSeen = integerArray[0];

                for ( int j = 0; j < integerArray.Length;j++)
                {
                    if(currentNumber == integerArray[j]) 
                    {
                        timesSeen++;
                    }
                }
                
                if(timesSeen > highScore)
                {
                    mostSeen = currentNumber;
                    highScore = timesSeen;
                }
            }
            Console.WriteLine($"The most seen number: ");
        }
        public static void Challenge5() 
        {
            int[] numbers = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            int highestNumber = 0;
            for (int i = 0; i < numbers.Length ; i++) 
            {
                if (numbers[i] > highestNumber)
                {
                    highestNumber = numbers[i];
                }
            }
            Console.WriteLine($"Highest number: {highestNumber} ");
        }
        public static void Challenge6() 
        {
            Console.WriteLine("Type something");
            string word = Console.ReadLine();
            File.WriteAllText("C:\\Users\\Student-36\\OneDrive\\Desktop\\Projects\\Lab3-401\\Lab3-401\\words.txt", word);
        }
        public static void Challenge7() 
        {
            string contents = File.ReadAllText("C:\\Users\\Student-36\\OneDrive\\Desktop\\Projects\\Lab3-401\\Lab3-401\\words.txt");
            Console.WriteLine(contents);
        }
        public static void Challenge8()
        {
            string contents = File.ReadAllText("C:\\Users\\Student-36\\OneDrive\\Desktop\\Projects\\Lab3-401\\Lab3-401\\words.txt");
            string[] words = contents.Split(" ");
            words[words.Length - 1] = "";
            string updatedContents = "";

            foreach (string word in words) 
            {
                updatedContents += word;
            }
            File.WriteAllText("C:\\Users\\Student-36\\OneDrive\\Desktop\\Projects\\Lab3-401\\Lab3-401\\words.txt", contents);
        }
        public static void Challenge9() 
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            for (int i = 0; i < words.Length ; i++) 
            {
                int numberOfLetters = words[i].Length;
                words[i] = $"{words[i]}: {numberOfLetters}";
                Console.WriteLine($"{words} ");
            }
        }
         
    }
}