using System;

namespace Arrays_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {

            //requests the nums from user
            Console.WriteLine("Hey user, today im goin to add a bunch of numbers you give me together, im thinking... 8? Yeah give me 8 numbers");

            //This be the array
            int[] intArray = { 0, 0, 0, 0, 0, 0, 0, 0 };

            //this be the sum
            int addedNum = 0;

            //used for setting the numbers
            int intIndex = 0;

            //loops throught the array assigning the ints
            foreach (int num in intArray)
            {
                intArray[intIndex] = Convert.ToInt32(Console.ReadLine());
                intIndex++;
            }

            //loops through afterward and adds the digits
            foreach (int num in intArray)
            {
                addedNum += num
;
            }
            //prints to the console
            Console.WriteLine($"{addedNum} is the sum of the inputted numbers! \n")
;
            //sorts the array
            Array.Sort(intArray);

            //print out the items
            foreach(int num in intArray)
            {
                Console.Write($"{num} ");
            }

            //last sentence
            Console.WriteLine("And I even sorted your inputs for you!");
        }    
    }
}
