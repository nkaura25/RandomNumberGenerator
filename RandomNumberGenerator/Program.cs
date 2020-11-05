using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberGenerator
{
    class Program
    {
        // Intialize random number generator
        public static Random randomObject = new Random();
         
        //minimum and maximum value used to generate random number and list 
        public const int minNumberValue = 1;
        public const int maxNumberValue = 10000;

        static void Main(string[] args)
        {          

            // Generate the list of integers from 1 to 10000 
            List<int> tempNumberList = Enumerable.Range(minNumberValue, maxNumberValue).ToList();

            // Generating unique random number in between minimum and maximum numbers
            List<int> primaryNumberList = SwapIndexValue(tempNumberList);

            foreach (int number in primaryNumberList)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }

        //Create two random number and swap value of those two index in list
        public static List<int> SwapIndexValue(List<int> nList)
        {
            for(int index=0; index <= nList.Count; index++)
            {
                int generate1stRandomNumber = randomObject.Next(minNumberValue-1, maxNumberValue);
                int generate2ndRandonNumber = randomObject.Next(minNumberValue-1, maxNumberValue);
                int value1stListIndex = nList[generate1stRandomNumber];
                int value2ndListIndex = nList[generate2ndRandonNumber];
                nList[generate1stRandomNumber] = value2ndListIndex;
                nList[generate2ndRandonNumber] = value1stListIndex;
            }
            return nList;
        }
    
    
    }
}
