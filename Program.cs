using System;

namespace C_
{
    class Program
    {
        static string FizzRule(int num, string print)
        {
            if(num%3 == 0){
                print += "Fizz";
            }

            return print;
        }

        static string FezzRule(int num, string print)
        {
            if(num%13 == 0){
                print += "Fezz";
            }

            return print;
        }

        static string BuzzRule(int num, string print)
        {
            if(num%5 == 0){
                print += "Buzz";
            }

            return print;
        }

        static string BangRule(int num, string print)
        {
            if(num%7 == 0){
                print += "Bang";
            }

            return print;
        }
        static string BongRule(int num, string print)
        {
            if(num%11 == 0 && num%13 == 0){
                print += "Bong";
            } else if (num % 11 == 0){
                print = "Bong";
            }

            return print;
        }

        static void Main(string[] args)
        {
            for (int i=1; i<=145; i++)
            {
                string print = "";
                print = FizzRule(i, print);
                print = FezzRule(i, print);
                print = BuzzRule(i, print);
                print = BangRule(i, print);
                print = BongRule(i, print);
                Console.WriteLine(print == "" ? i : print);

                
            }
        }
    }
}

// create list 
// each method add to list
// console.log list