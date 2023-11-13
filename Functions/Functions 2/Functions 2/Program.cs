/*
 Name: Ahmed Javed Kamak
 Subject: Comp Sci 20
 Description: This code deals with optional parameters (input)
 */


using System;

namespace Function2
{

    public class functionClass
    {
        //when ritting the function, if the variable does not have
        //an initial value like string word, it is mandatory
        // if the variable hasan initial value like bool showStars=false
        //it is optional
       /* static void customMessege(String word, bool showStars = false)
        {
               if (showStars)
            {

                Console.WriteLine("****" +word+ "*****");
            }
        
            else { 
            Console.WriteLine(word);

                  }
        
        }*/



        static void burgerOrder(String order, bool extraCheese=false)
       {    
               if(extraCheese)

            { 
                Console.WriteLine("With extra cheese" +order );



                    }
            

                else{

                Console.WriteLine("without extra cheese" + order);
      }


        }
      





        public static void Main()
        {
            Console.WriteLine("What type of burger do you want");
            String burgertype = Console.ReadLine();

            Console.WriteLine("You want extra cheese (yes/not)");
            String choice = Console.ReadLine();

            if  
            /*
            customMessege(input);
            customMessege(input, extraCheese: true);*/


        }
    }
}