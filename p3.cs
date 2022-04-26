// using System;

// /* Author:     Trishla Khandelwal
// * Filename:    p3.cs
// * Version:     Version 1
// * Description: This is driver to test dataFilter, dataMod, dataCut
// */

// class p3
// {
//     const int size = 10; //used to set size of interanl sequence
//     static int[] res = new int[size]; //array to store results from the methods
//     static int[] sequence = new int[size]; //internal sequence
//     static int[] arr = null; //creating a null array to test exception if sequence is null
//     public static int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // sequence used for scramble
//     public static int[] arr3 = { 44, 2, 3, 53, 11, 65, 7, 88, 99, 10 }; //sequence used for scramble
//     static int n = 31; //encapsulated prime number
//     static int n1 = 10; //encapsulated non-prime number

//     static string invalidMode = "hello";
//     static string large = "large";
//     static string small = "small";

//     public static int largeCounter = 0;
//     public static int maxLargeCounter = 2;
//     public static void Main(string[] args)
//     {
//         sequence = generateSequence(); //generating sequence

//         //heterogeneous collection 
//         dataFilter[] collection = new dataFilter[size];
//         collection[0] = new dataFilter(n, large, sequence);
//         collection[1] = new dataFilter(n, small, sequence);
//         collection[2] = new dataMod(n, large, sequence);
//         collection[3] = new dataMod(n, small, sequence);
//         collection[4] = new dataCut(n, large, sequence);
//         collection[5] = new dataCut(n, small, sequence);
//         collection[6] = new dataFilter(n1, large, arr); //passing a non-prime number on a null sequence
//         collection[7] = new dataFilter(n, invalidMode, sequence); //passing invalid mode
//         collection[8] = new dataFilter(n, large, sequence); //object for testing trigger changes



//         //try block for exception
//         try
//         {
//             Console.WriteLine("\n ***** Testing MODE changes from large to small *****");

//             while (largeCounter < maxLargeCounter)
//             {
//                 res = collection[8].filter(); //calling filter repeatedly on the same  object with same mode(large)
//                 Console.WriteLine("Filter in large mode:");
//                 printSequence(res);
//                 Console.WriteLine("Mode Count is " + largeCounter);
//             }
//             string newMode;
//             if (largeCounter == maxLargeCounter)
//             {
//                 Console.WriteLine("Mode has now changed");
//                 newMode = small;   //changing mode to small when it reaches max limit
//                 collection[8] = new dataFilter(n, newMode, sequence); //overriding the previous object with new mode
//                 res = collection[8].filter(); //calling filter again on new mode
//                 Console.WriteLine("Filter in small mode:");
//                 printSequence(res);
//             }

//             Console.WriteLine("\n ***** Testing DataFilter Class *****");
//             Console.Write("Sequence: ");
//             printSequence(sequence);
//             Console.Write("Filter in large mode: ");
//             res = collection[0].filter();
//             printSequence(res);

//             Console.Write("Filter in small mode: ");
//             res = collection[1].filter();
//             printSequence(res);

//             Console.Write("Sequence for Scramble: ");
//             printSequence(arr2);
//             Console.Write("Scramble in large mode: ");
//             res = collection[0].scramble(arr2);
//             printSequence(res);

//             Console.Write("Scramble in small mode: ");
//             res = collection[1].scramble(arr2);
//             printSequence(res);

//             Console.WriteLine("\n ***** Testing DataMod Class *****");
//             Console.Write("Filter in large mode on the same sequence: ");
//             res = collection[2].filter();
//             printSequence(res);

//             Console.Write("Filter in small mode on the same sequence: ");
//             res = collection[3].filter();
//             printSequence(res);

//             Console.Write("Sequence for Scramble: ");
//             printSequence(arr2);
//             Console.Write("Scramble in large mode ");
//             res = collection[2].scramble(arr2);
//             printSequence(res);

//             Console.Write("Scramble in small mode ");
//             res = collection[3].scramble(arr2);
//             printSequence(res);

//             Console.WriteLine("\n ***** Testing DataCut Class *****");
//             Console.Write("Filter in large mode on the same sequence: ");
//             res = collection[4].filter();
//             printSequence(res);

//             Console.Write("Filter in small mode on the same sequence: ");
//             res = collection[5].filter();
//             printSequence(res);

//             Console.Write("Previous Sequence for Scramble: ");
//             printSequence(arr2);
//             Console.Write("New Sequence for Scramble: ");
//             printSequence(arr3);
//             Console.Write("After removing numbers that occurred in the previous scramble request: ");
//             Console.Write("Scramble in large mode: ");
//             res = collection[4].scramble(arr3);
//             printSequence(res);

//             Console.Write("Scramle in small mode: ");
//             res = collection[5].scramble(arr3);
//             printSequence(res);

//             Console.WriteLine("\n ***** Testing Non-prime number using dataFilter *****");
//             Console.Write("Sequence: ");
//             printSequence(sequence);
//             Console.Write("Filter in large mode: ");
//             res = collection[6].filter(); //here encapsulated number is not prime, so filter should return the default prime number 41
//             printSequence(res);

//             Console.WriteLine("\n ***** Testing Invalid Mode Change using dataFilter *****");
//             Console.Write("Sequence: ");
//             printSequence(sequence);
//             Console.Write("Scramble in large mode: ");
//             res = collection[7].scramble(arr2); //here mode is "hello", so filter should be executed in default mode i.e.large 
//             printSequence(res);

//             Console.WriteLine("\n ***** Testing Exception Handling for Null sequence *****");
//             Console.Write("Sequence: ");
//             printSequence(arr);
//             Console.Write("Scramble in large mode: ");
//             res = collection[7].scramble(arr); //here arr is null, so an exception should be thrown
//             printSequence(res);

//         }

//         //catch block to catch exception thrown by the methods in try block
//         catch (ArgumentException e)
//         {
//             Console.WriteLine(e.ToString());
//         }
//     }

//     //method to generate a sequence of random numbers
//     static int[] generateSequence()
//     {
//         int maxRange = 100;
//         int minRange = 1;
//         Random rnd = new Random();
//         for (int i = 0; i < size; i++)
//         {
//             sequence[i] = rnd.Next(minRange, maxRange); //generating random numbers within 1-100
//         }
//         return sequence;
//     }

//     //method to print an array
//     static void printSequence(int[] res)
//     {
//         //check if res[] is not null
//         if (res != null)
//         {
//             Console.Write("[");
//             for (int i = 0; i < res.Length; i++)
//             {
//                 //since res[] is an integer array, any element may have 0 as a default value,
//                 //so printing only the indexes that have value and are not 0
//                 if (res[i] != 0)
//                     Console.Write(res[i] + " ");
//             }
//             Console.WriteLine("]");
//         }
//     }

// }