// using System;

// /* Author:     Trishla Khandelwal
// * Filename:    dataFilter.cs
// * Version:     Version 1
// * Description: This is a base class which is using inheritance and dependency injection to
// *              encapsulate the prime number, mode, and internal sequence.


// /*Class invariant : dataFilter object encapsulate the prime number for input, mode, and internal sequence.
//  * num = If the prime number input is not prime number, set the default value as 41.
//  * mode = If mode is not "large" or "small", set the default mode as "large"
//  * sequence = Set internal sequence to sequence input by the user
//  * 
//  * Interface invariant :
//  * filter() = returns a subset of an encapsulated integer sequence by mode
//  *          if "large" mode, return the list of number greater than encapnum
//  *          if "small" mode, return the list of number less than encapnum
//  *          if list is null or there is no number greater or less than encapmun, return the list that contain only encapnum
//  * scramble(int[] seq) = updates the encapsulated sequence with seq if seq is not null, and returns a reordered integer sequence based on mode
//  *      In "large" mode exchanges the values in pair, if a[0] is more than a[1] then it swaps the values and returns reordered integer sequence
//  *      In "small" mode exchanges the values in pair, if a[0] is less than a[2] then it swaps the values and returns reordered integer sequence
//  *      if seq is null, it throws ArgumentNullException
//  */

// class dataFilter
// {
//     protected int num; //encapsulated prime number
//     protected string mode; //mode can be large or small
//     protected const int size = 10; //size of the sequence
//     public int[] sequence; //internal sequence of intergers
//     private int[] result = new int[size]; //array to store result returned by the functions

//     //Constructor which ecapsulates the prime number, mode, and sequence by Dependency Injection
//     public dataFilter(int p, string inputMode, int[] seq)
//     {
//         int pCheck = Check_Prime(p);
//         if (pCheck == 0) //if p is not a prime number
//             num = 41; //set a default value which is a prime number
//         else
//             num = p;

//         if (inputMode != "large" && inputMode != "small")
//             mode = "large"; //set default mode
//         else
//             mode = inputMode;

//         sequence = seq; //set sequence to seq
//     }

//     //postconditions : returns 1 if the input number is prime, and 0 if non-prime
//     protected int Check_Prime(int p)
//     {
//         int i, number = p;
//         for (i = 2; i <= number - 1; i++)
//         {
//             if (number % i == 0)
//             {
//                 return 0;
//             }
//         }
//         if (i == number) //if number is prime
//         {
//             return 1;
//         }
//         return 0;
//     }

//     //postconditions : returns a subset of encapsulated integer sequence
//     public virtual int[] filter()
//     {
//         if (sequence == null) //checking if internal sequence is null
//         {
//             result[0] = num; //add encapsulated prime number to the result array
//         }
//         else if (mode == "large")
//         {   
//             p3.largeCounter++;
//             int j = 0;
//             for (int i = 0; i < sequence.Length; i++)
//             {
//                 if (num < sequence[i])
//                 {
//                     result[j] = sequence[i];
//                     j++;
//                 }
//             }
//         }
//         else
//         {
//             int j = 0;
//             for (int i = 0; i < sequence.Length; i++)
//             {
//                 if (num > sequence[i])
//                 {
//                     result[j] = sequence[i];
//                     j++;
//                 }
//             }
//         }
//         return result;
//     }

//     //postconditions : 
//     //throws ArgumentNullException if seq is null
//     //otherwise returns a subset of encapsulated integer sequence
//     public virtual int[] scramble(int[] seq)
//     {
//         if (seq == null)
//         {
//             throw new ArgumentNullException("Sequence is null, please provide a valid sequence");
//         }
//         //if seq is not null
//         if (seq != null)
//         {
//             //update sequence[] with seq[]
//             sequence = seq;
//         }
//         int temp;
//         if (mode == "large")
//         {
//             p3.largeCounter++;
//             // traverse 0 to array length
//             for (int i = 0; i < sequence.Length - 1; i++)
//             {
//                 // traverse i+1 to array length
//                 for (int j = i + 1; j < sequence.Length; j++)
//                 {
//                     // compare all array elements with the corresponding next element
//                     // compare sequence[0] with sequence[1], then sequence[1] with sequence[2] and so on
//                     if (sequence[i] < sequence[j])
//                     {
//                         temp = sequence[i];
//                         sequence[i] = sequence[j];
//                         sequence[j] = temp;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // traverse 0 to array length
//             for (int i = 0; i < sequence.Length - 1; i++)
//             {
//                 // traverse i+1 to array length
//                 for (int j = i + 1; j < sequence.Length; j++)
//                 {
//                     // compare all array elements with the corresponding next element
//                     // compare sequence[0] with sequence[1], then sequence[1] with sequence[2] and so on
//                     if (sequence[i] > sequence[j])
//                     {
//                         temp = sequence[i];
//                         sequence[i] = sequence[j];
//                         sequence[j] = temp;
//                     }
//                 }
//             }
//         }
//         return sequence;
//     }
// }
// /* Implementation invariant : 
//  This class returns subset of the encapsulated integer sequence, by using the
// * filter() and scramble methods, based on the two different modes (large and small)
// */