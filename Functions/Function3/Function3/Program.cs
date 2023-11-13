/*
 Name: Ahmed Javed Kamal
 class: comp sci 20
 description: summary of functions lesson
 */

using System.ComponentModel.Design;

namespace Function3
{

    public class functionsLesson
    {


        //to declare a function 
        //static <data type> <function name (input_data_type variable_name)
       static int sum(int num1, int num2) { 
        
        return num1 + num2;


        }




        static string burgerOrder(String order, bool extraCheese = false)
        {
            if (extraCheese)
            {

                return (order + "with extra cheese");
            }
            else
            {

                return order + "without extra cheese";

            }



            }
        }


        public static void Main()
        {



        }


    }

}

 