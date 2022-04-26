// using System;

// /* Author:     Trishla Khandelwal
// * Filename:    dataCut.cs
// * Version:     Version 1
// * Description: This is a derived class from dataFilter. It is using inheritance and dependency injection
// *              Encapsulate the prime number, mode, and ineternal sequence that inherit from base class

// /*Class invariant :dataCut object is inherited and operates from dataFilter
//  *                 -> encapsulates the prime number, mode, and internal sequence
//  * Interface invariant :
//  * filter() = inherited from dataFilter, returns a subset of an encapsulated integer sequence based on mode
//  *          if "large" mode, remove the maximum number in sequence before returns it
//  *          if "small" mode, remove the minimum number in sequence before returns it
//  * scramble(List<int> seq) = inherited from dataFilter, but removes any number that occurred in the previous scramble
//  *                           calls then returns a reordered integer sequence
//  */
// class dataCut : dataFilter //dataCut is derived class from dataFilter
// {
//     public dataCut(int p, string inputMode, int[] seq) : base(p, inputMode, seq)
//     {
//         //automatically inherit from base class
//     }

//     //postconditions : returns a subset of encapsulated integer sequence
//     public override int[] filter() //override base class's method
//     {
//         int[] result = base.filter(); //call the dataFilter class's filter() method
//         int max = result[0], min = result[0];

//         if (mode == "large")
//         {
//             for (int i = 1; i < result.Length; i++)
//             {
//                 if (result[i] > max)
//                     max = result[i];
//             }
//             //deleting the maximum element
//             result = result.Where((e => e != max)).ToArray();
//         }
//         else
//         {
//             for (int i = 1; i < result.Length; i++)
//             {
//                 if (result[i] < min && result[i] != 0)
//                     min = result[i];
//             }
//             //deleting the minimum element
//             result = result.Where((e => e != min)).ToArray();
//         }
//         return result;
//     }

//     //postconditions :
//     //removes any number that occurred in the previous scramble request before scrambling
//     //returns a reordered integer sequence
//     public override int[] scramble(int[] seq) //override base class's method
//     {
//         int[] temp = new int[seq.Length]; //temporary array used for calculations
//         for (int i = 0; i < seq.Length; i++)
//         {
//             if (seq[i] != p3.arr2[i]) //compare elements from the array passed in previous scramble calls
//                 temp[i] = seq[i]; //store the elements that have not occured in previous scramble calls in a different array
//         }
//         int[] answer = base.scramble(temp); //call the dataFilter class's scramble(int[]) method
//         return answer; //return the reordered integer sequence
//     }
// }
// /*   Implementation invariant : 
// This is derived class from dataFilter. It is using inheritance and dependency injection
// Encapsulates the prime number, mode, and internal sequence that is inherited from base class.
// */