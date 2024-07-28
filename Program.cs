using System;
using System.Linq;
using System.Collections.Generic;

namespace NavvTacAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Initialise array  
            int[] number = new int[8] { 15, -9, 0, 45, 87, 98, 23, 56 };
            char order = 'A';
            //Print Array Method Call
            PrintData();
            //array Print Method
            int[] PrintData()
            {
                foreach (var item in number)
                {
                    Console.WriteLine(item);
                }
                return number;
            }
            //Console.WriteLine("Enter A if You want accending order or D for decending order ");
            //Sort array method with parameters 

            Console.WriteLine($"Sorted Array in {(order == 'A' ? "ascending" : "descending")} order:");
            int[] SortedArray = SortData(number, order);
            //Call method in which is print the sorted data 
            PrintArray(SortedArray);
            //Method for Sorting Data 
            int[] SortData(int[] data, char? order = 'D')
            {
                int TotalArryNumber = data.Length;
                for (int i = 0; i < TotalArryNumber - i - 1; i++)
                {
                    for (int j = 0; j < TotalArryNumber - i - 1; j++)
                    {
                        //Use turnary operator for a condition if Order id 'A' show asc orders otherwise 'D' is Default desc orders
                        bool condition = order == 'A' ? data[j] > data[j + 1] : data[j] < data[j + 1];
                        if (condition)
                        {
                            int temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                return data;

            }
            static void PrintArray(int[] number)
            {
                int PrintNumberAscOrDesc = number.Length;
                for (int i = 0; i < PrintNumberAscOrDesc; i++)
                {
                    Console.WriteLine(number[i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter Your Number : ");
            int UserEnteredNumber = int.Parse(Console.ReadLine());
            if (UserEnteredNumber >= 0)
            {
                IsItemFound(number, UserEnteredNumber);
            }
            else
            {
                Console.WriteLine("Input number must be positive");
            }


            int IsItemFound(int[] number, int UserEnteredNumber)
            {
               
                bool result = false;
                int index = -1;
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == UserEnteredNumber)
                    {
                        result = true;
                        index = i;
                        break;
                    }


                }
                if (result)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                return UserEnteredNumber;



            }
            SearchData(UserEnteredNumber);
            int SearchData(int UserEnteredNumber)
            {
                int index = -1;
                for (int i = 0; i < number.Length; i++)
                {
                    if(number[i] == UserEnteredNumber)
                    {
                        index = i;
                        break;
                    }

                }
                if(index!= -1)
                {
                    Console.WriteLine($"Item found at index {index}");
                }
                else
                {
                    Console.WriteLine("Item not found");
                }
                return index;
            }

            FindMax();

            void FindMax()
            {
                int MaxNumber = number[0];
                for (int i = 0; i < number.Length; i++)
                {
                    if(number[i] > MaxNumber)
                    {
                        MaxNumber = number[i];
                       
                    }
                    //return ;
                }
                Console.WriteLine($"Maximum Number = {MaxNumber}");
            }

            FindMin();

            void FindMin()
            {
                int MinNumber = number[0];
                for (int i = 0; i < number.Length; i++)
                {
                    if(number[i]< MinNumber)
                    {
                        MinNumber = number[i];
                    }
                }
                Console.WriteLine($"Minimun Number is = {MinNumber}");
            }
            ReverseNumber();
            void ReverseNumber()
            {
                Console.WriteLine("Array in reverse order:");
                for (int i= number.Length-1; i>=0; i--) 
                {
                    Console.WriteLine(number[i] + " ");
                }
                
            }
            ComputeAverage();
            void ComputeAverage()
            {
                int sum = 0;
                foreach (var item in number)
                {
                    //sun += item[];
                }
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i];
                }
                Console.WriteLine($"Average of number: {sum}");
            }

            //123456
            int[] ArrayNumber = { 1, 2, 4, 6, 8, 7, 6, 8, 9, 8, 7, 9, 6 };
            double MedianValue = FindMedian(ArrayNumber);
            Console.WriteLine($"Median of number is {MedianValue}");
            static double FindMedian(int[] ArrayNumber)
            {
               
                Array.Sort(ArrayNumber);
                int length = ArrayNumber.Length;
                if (length % 2 == 1)
                {
                    
                    return ArrayNumber[length / 2];
                }
                else
                {
                    return (ArrayNumber[(length / 2) - 1] + ArrayNumber[length / 2]) / 2.0;
                }
            }
            //2
            double[] arrayName = { 1, 2, 3, 4, 5, 6, 7 };
            double standardDeviation = ComputeStandardDeviation(arrayName);
            Console.WriteLine($"Standard Deviation is: {standardDeviation}");
            static double ComputeStandardDeviation(double[] arrayName)
            {
                double mean = arrayName.Average();

                
                double sumOfSquaresOfDifferences = arrayName.Select(val => (val - mean) * (val - mean)).Sum();

                double variance = sumOfSquaresOfDifferences / arrayName.Length;

                return Math.Sqrt(variance);
            }
            //3
           int[] UniqueArray = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
            List<int> uniqueValues = FindUniqueValues(UniqueArray);
            Console.WriteLine("Unique values:");
            foreach (var value in uniqueValues)
            {
                Console.Write(value + " ");
            }
            static List<int> FindUniqueValues(int[] UniqueArray)
            {
                List<int> uniqueValues = new List<int>();
                HashSet<int> seenValues = new HashSet<int>();

                foreach (int value in UniqueArray)
                {
                    if (!seenValues.Contains(value))
                    {
                        uniqueValues.Add(value);
                        seenValues.Add(value);
                    }
                }

                return uniqueValues;
            }

            //5
            List<int> sortlist1 = new List<int> { 3, 1, 4, 1, 5 };
            List<int> sortlist2 = new List<int> { 9, 2, 6, 5, 3, 5 };

            List<int> sortedList = Sort(sortlist1, sortlist2);

            Console.WriteLine("Sorted list:");
            foreach (int value in sortedList)
            {
                Console.Write(value + " ");
            }
            static List<int> Sort(List<int> sortlist1, List<int> sortlist2)
            {
                List<int> combinedList = new List<int>();

               
                combinedList.AddRange(sortlist1);
                combinedList.AddRange(sortlist2);

              
                combinedList.Sort();

                return combinedList;
            }

            //6
            List<int> merglist1 = new List<int> { 3, 1, 4, 1, 5 };
            List<int> merglist2 = new List<int> { 9, 2, 6, 5, 3, 5 };

            List<int> mergedAndSortedList = Merge(merglist1, merglist2);

            Console.WriteLine("Merged and sorted list:");
            foreach (int value in mergedAndSortedList)
            {
                Console.Write(value + " ");
            }
            static List<int> Merge(List<int> merglist1, List<int> merglist2)
            {
                List<int> mergedList = new List<int>();

                mergedList.AddRange(merglist1);
                mergedList.AddRange(merglist2);

                mergedList.Sort();

                return mergedList;
            }
        }

    }
}
