//Console app that calculates the number of prime numbers defined by the user from a given positive number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<int> prime = new List<int>(); 

            int length = 0; //Number of values in the list of prime numbers
            int num = 20; //Total number of prime numbers included in the list
            int i = 2; //First number that the calculation of prime numbers starts

            Console.WriteLine("Please define the number of prime numbers");
            
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please define the first positive number");

            i = int.Parse(Console.ReadLine());

            
            while (length < num) //Stop the loop when the list contains the total number of prime numbers
            {

                
                for (int z = 2; z < i || i == 2; z++) //Include the case of i = 2
                {

                    if (i % z == 0 && i != 2)
                    {   
                     break;
                    }
                    else if (z == i - 1 || i == 2) 
                    {
                        prime.Add(i);
                        length = prime.Count();
                        if (i == 2) { break;}
                    }

                   
                }

                i++;
                
            }
            //Print the list of prime numbers

            Console.WriteLine($"-------{num} first Prime numbers------");
            Console.WriteLine("--------------START---------------");
            for (int x = 0; x < length; x++)
            {
                Console.WriteLine($"{prime[x]}");
            }

            Console.WriteLine("---------------END----------------");


        }
    }
}
