using System;
//using NUnit.Framework;
using System.Linq;
using System.Numerics;



//Define a function that takes in two non-negative integers aaa and bbb and returns the last decimal digit of aba^ba 
//b
// . Note that aaa and bbb may be very large!

//For example, the last decimal digit of 979^79 
//7
//  is 999, since 97=47829699^7 = 47829699 
//7
// =4782969. The last decimal digit of (2200)2300({ 2 ^{ 200} })^{ 2 ^{ 300} } (2
//200
// ) 
//2
//300

// , which has over 109210^{92}10
//92
//  decimal digits, is 666. Also, please take 000^00 
//0
//  to be 111.

//You may assume that the input will always be valid.

namespace Codewars7kata
{
    class LastDigit
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
           string last = n1.ToString();
            int myInt = int.Parse(last[last.Length-1].ToString());
            int y = (int)(n2 % 4);

           
             if (myInt == 0 && n2 != 0) { return 0; }
            else if (myInt == 1) { return 1; }
            else if (n2 == 0) { return 1; }
            else if (n2 == 1) { return myInt; }
            else if (myInt == 5 && n2 != 0) { return myInt; }
            else if (myInt == 6 && n2 != 0) { return myInt; }
            else
            return answer(myInt, y);

            
        }

        public static int answer(int n1, int n2)
        {
            if (n1 == 2)
            {
                if (n2 == 0)
                    return 6;
                else if (n2 == 1)
                    return 2;
                else if (n2 == 2)
                    return 4;
                else 
                    return 8;
            }

            else if (n1 == 8)
            {
                if (n2 == 0)
                    return 6;
                else if (n2 == 1)
                    return 8;
                else if (n2 == 2)
                    return 4;
                else
                    return 2;
            }

            else if (n1 == 3)
            {
                if (n2 == 0)
                    return 1;
                else if (n2 == 1)
                    return 3;
                else if (n2 == 2)
                    return 9;
                else 
                    return 7;
            }
            else if (n1 == 7)
            {
                if (n2 == 0)
                    return 1;
                else if (n2 == 1)
                    return 7;
                else if (n2 == 2)
                    return 9;
                else 
                    return 3;
            }

            else if (n1 == 4)
            {
                if (n2 == 0)
                    return 6;
                else if (n2 == 1)
                    return 4;
                else if (n2 == 2)
                    return 6;
                else 
                    return 4;

            }
            else
            {
                if (n2 == 0)
                    return 1;
                else if (n2 == 1)
                    return 9;
                else if (n2 == 2)
                    return 1;
                else 
                    return 9;

            }
        
            

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(LastDigit.GetLastDigit(4, 1));        // returns 4
            Console.WriteLine(LastDigit.GetLastDigit(4, 2));            // returns 6
            Console.WriteLine(LastDigit.GetLastDigit(9, 7));            // returns 9    
            Console.WriteLine(LastDigit.GetLastDigit(10, 10000000000)); // returns 0
        }
    }
}
