
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ders_tapsiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Eded daxil edin.");
            //int eded = Convert.ToInt32(Console.ReadLine());
            //IsOdd(eded);

            //2
            //Console.WriteLine(IsEven(8));

            //4
            //Console.WriteLine(GetValueIndex('a'));

            //3
            //Console.WriteLine("String daxil edin:");
            //string value = Console.ReadLine();
            //Console.WriteLine(IsContainDigit(value));

            //4
            //int[] netice = GetValueIndexes('a',"Salam");
            //foreach (int i in netice)
            //{ 
            //    Console.WriteLine(i);
            //}

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.Write("Eded daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());
            int[] netice = GetValueIndex(num, eded);
            foreach (int i in netice)
            {
                Console.WriteLine(i);
            }



        }

        //1
        //public static bool IsOdd(int x) 
        //{ bool odd = false;
        //    if (x % 2 == 1)
        //    {
        //        odd = true;
        //        Console.WriteLine("True");

        //    }
        //    else  
        //    { 
        //        Console.WriteLine("False"); 
        //    }
        //    return odd; 
        // }

        //2
        //  public static bool IsEven(int a)
        //  {

        //      if (a % 2 == 0)
        //      {
        //          return true;
        //      }
        //      else
        //      {
        //          return false;
        //      }

        //}

        //4
        //public static int GetValueIndex(char b)
        //{
        //    string name = "Lala";
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (b == name[i])
        //        {
        //            return i;
        //        }

        //    }
        //    return 0;
        //}


        //3
        // static bool IsContainDigit(string word)
        //{for (int i = 0; i<word.Length; i++)
        //    {
        //        if (word[i]>47 &&  word[i]<= 57)
        //       {
        //        return true;

        //       }

        //    }
        //    return false;


        //4
        //static int[] GetValueIndexes(char a, string b)
        //{
        //    int[] result = { };
        //    for (int i = 0; i<b.Length; i++) 
        //    {
        //        if (a == b[i])
        //        {
        //            result = result.Append(i).ToArray();
        //        }
        //    }
        //    return result;
        //} 


        static int[] GetValueIndex(int[] k, int h)
        {
            int[] result = { };
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] == h)
                {
                    result = result.Append(i).ToArray();
                }
            }
            return result;
        }

        



}   }