using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] randomArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(randomArray);

            //TODO: Print the first number of the array

            Console.WriteLine($"The first number of the array is: {randomArray[0]}");

            //TODO: Print the last number of the array

            Console.WriteLine($"The last number of the array is: {randomArray[49]}");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Original:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(randomArray);
            

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            // First Way
            //int[] reversedRandom = randomArray;
            //Array.Reverse(reversedRandom);

            // Second Way
            int[] reversedRandom = ReverseArray(randomArray);
            NumberPrinter(reversedRandom);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            int[] eliminateThrees = ThreeKiller(randomArray);
            NumberPrinter(eliminateThrees);
            Console.WriteLine("-------------------");


            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(eliminateThrees);
            NumberPrinter(eliminateThrees);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var intList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"Initial capacity: {intList.Capacity}");
            //Console.WriteLine(intList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(intList);

            //TODO: Print the new capacity

            Console.WriteLine($"New capacity: {intList.Capacity}");
            //Console.WriteLine(intList.Count + "\n");

            //NumberPrinter(intList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool isInt = false;
            int isNum = 0;
            while (isInt == false)
            {
                Console.WriteLine("What number will you search for in the number list?");
                var userNum = Console.ReadLine();
                if (int.TryParse(userNum, out int number))
                {
                    isNum = int.Parse(userNum);
                    isInt = true;
                }
                else
                {
                    Console.WriteLine("Please enter an integer!");
                }
            }
            NumberChecker(intList,isNum);

            //Console.WriteLine(isNum);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            List <int> noOddsList = OddKiller(intList);
            NumberPrinter(noOddsList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results

            Console.WriteLine("Sorted Evens!!");
            noOddsList.Sort();
            NumberPrinter(noOddsList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] evensToArray = noOddsList.ToArray();

            var hasArray = evensToArray;



            //TODO: Clear the list

            noOddsList.Clear();

            #endregion
        }

        private static int[] ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            var evenList = new List<int>();
            foreach (int num in numberList)
            {
                if (num%2 != 1)
                {
                 evenList.Add(num);
                }
            }
            //Console.WriteLine(numberList);
            return evenList;
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isInList = false;
            foreach (int item in numberList)
            {
                if (searchNumber == item)
                {
                    isInList = true;
                }
                    
            }
            if (isInList = false)
            {
                Console.WriteLine($"Sorry! {searchNumber} is not in the list...");
            }
            else
            {
                Console.WriteLine($"Congrats! {searchNumber} is in the list!!");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(51);
            }

        }        

        private static int[] ReverseArray(int[] array)
        {
            var reversedArray = new int[50];
            int revIndex = 0;
            for (int i = array.Length - 1; i >= 0;i--)
            { 
                reversedArray[revIndex] = array[i];
                revIndex += 1;
            }
            return reversedArray;
        
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
