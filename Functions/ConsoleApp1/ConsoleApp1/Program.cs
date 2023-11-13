/*
 Thiscode deals with functions, mandatory and optional parameter
 name: Ahmed Javed Kamal
 Class: Comp sci 20s
 */










using System.Diagnostics.Tracing;
using System.Reflection.Metadata;


namespace Function
{

    public class Functionsclass
    {
        // void means empty return
        // a void function does not return anything
        static void customMessege(String word)
        {

            Console.WriteLine("*****" + word + "*****");

        }

        //this function takes num1 and num2
        // and returns their sum
        static int sum(int num1, int num2)
        {

            return num1 + num2;

        }


        static int product(int num1, int num2)
        {

            return num1 * num2;
        }




        static String toLowerOrUpper(String word, bool toLower)
        {

            if (toLower)
            {
                return word.ToLower();
            }

            else
            {
                {

                    return word.ToUpper();
                }
            }

        }


 

        public static void Main()
        {

           Console.WriteLine("please enter a word");
            String input = Console.ReadLine();

            //we call functions by there name and add to it
            // if the functions take input we put the input between ()
            customMessege(input);
            customMessege(input);
            // the function execute every time we call it


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            Console.WriteLine("Enter first number");
            int first = Convert.ToInt32(Console.ReadLine());





            Console.WriteLine("Enter second number");
            int second = Convert.ToInt32(Console.ReadLine());



            // when a functio returns a valau qwe need to store that value in a variable to use it
            // we can store thatvalue ina variable to use it later 
          int result =  sum(first, second);
            Console.WriteLine("The sum is " + result);


             result = product(first, second);
            Console.WriteLine("The product is " + result);


           result= product(first, second);
            Console.WriteLine("the product is " + result);
            //////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            Console.WriteLine("Enter a word");
            input = Console.ReadLine();
            String changeedWord = toLowerOrUpper(input, true);
            Console.WriteLine(changeedWord);    

            changeedWord = toLowerOrUpper(input, false);
            Console.WriteLine(changeedWord);










        }



    }
}