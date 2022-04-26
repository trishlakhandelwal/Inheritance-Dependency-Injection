// using System;

// /* Author:     Trishla Khandelwal
// * Filename:    dataMod.cs
// * Version:     Version 1
// * Description: This is derived class from dataFilter. It is using inheritance and dependency injection
// *              Encapsulates the prime number, mode, and internal sequence that is inherited from base class.

// /*Class invariant : dataMod object is inherited and operates from dataFilter
//  *                 -> encapsulates the prime number, mode, and internal sequence
//  * Interface invariant :
//  * filter() = inherited from dataFilter, thus returns a reordered sequence like dataFilter class except that 
//  *          if "large" mode, increments each value returned by dataFilter's filter()
//  *          if "small" mode, decrements each value returned dataFilter's filter()
//  * scramble(int[] seq) = inherited from dataFilter, replaces all prime numbers with ‘2’ before scrambling
//  *                           then returns a reordered integer sequence 
//  */
// class dataMod : dataFilter //dataMod is derived class from dataFilter
// {
//     public dataMod(int p, string inputMode, int[] seq) : base(p, inputMode, seq)
//     {
//         //automatically inherit from base class
//     }

//     //postconditions : returns a subset of encapsulated integer sequence
//     public override int[] filter() //override base class's method
//     {
//         int[] result = base.filter(); //call the dataFilter class's filter() method
//         for (int i = 0; i < result.Length; i++)
//         {
//             if (result[i] != 0)
//             {
//                 if (base.mode == "large")
//                     result[i] = result[i] + 1; //increment value by 1 if in large mode
//                 else
//                     result[i] = result[i] - 1; //decrement value by 1 if in small mode
//             }
//         }
//         return result;
//     }

//     //postconditions :
//     //replaces all prime numbers with ‘2’ before scrambling
//     //returns a reordered integer sequence
//     public override int[] scramble(int[] seq) //override base class's method
//     {
//         int r;
//         int[] temp = new int[seq.Length]; //temporary array used for calculation
//         for (int i = 0; i < seq.Length; i++)
//         {
//             if (seq[i] != 0)
//                 temp[i] = seq[i];
//         }
//         for (int i = 0; i < temp.Length; i++)
//         {
//             r = base.Check_Prime(temp[i]); //check if the value is a prime number
//             if (r == 1) //means seq[i] is prime
//                 temp[i] = 2; //update all prime numbers in sequence with 2
//         }

//         int[] answer = base.scramble(temp); //call the dataFilter class's scramble(int[]) method
//         return answer; //return the reordered integer sequence
//     }
// }
// /*   Implementation invariant : 
// This is derived class from dataFilter. It is using inheritance and dependency injection
// Encapsulates the prime number, mode, and internal sequence that is inherited from base class.
// */
