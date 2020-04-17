using System;
using System.Linq;
using System.Text;

namespace pStevicDeliverablesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLet's create secret messages!\nGive me a word and I'll encrypt it into a secret code!\n");
            string inputMessage = Console.ReadLine().ToUpper();
            var length = inputMessage.Length;
            var totalValues = 0;

            Console.WriteLine("Your secret code is: "); 
            for (int i = 0; i < length; i++)     
            {

                var value = (int)inputMessage[i];
                totalValues += value;

                Console.Write(value + " ");
            }

            Console.WriteLine("\nCheckcum: ");
            Console.WriteLine(totalValues);

            Console.WriteLine("\n\nCool Huh!\n\nWell see you later, goodbye."); 

            /*
           var byteArray = Encoding.ASCII.GetBytes(inputMessage);
           var length = byteArray.Length;

           for (int i = 0; i < length; i++)
           {

               Console.Write(byteArray[i] + " ");
           }


            Console.Write(byteArray[i]);

            string firstValue = inputMessage[0].ToString();
            string secondValue = inputMessage[1].ToString();
            string thirdValue = inputMessage[2].ToString();
            string forthValue = inputMessage[3].ToString();
            string fifthValue = inputMessage[4].ToString();
            string sixthValue = inputMessage[5].ToString();
            string seventhValue = inputMessage[6].ToString();

           int firstNumericValue = int.Parse(firstValue);
           int secondNumericValue = int.Parse(secondValue);
           int thirdNumericValue = int.Parse(thirdValue);
           int forthNumericValue = int.Parse(forthValue);
           int fifthNumericValue = int.Parse(fifthValue);
           int sixtNumericValue = int.Parse(sixthValue);
           int seventhNumericValue = int.Parse(seventhValue);


           Console.WriteLine(firstNumericValue + "" + secondNumericValue + "" + thirdNumericValue + "" + forthNumericValue + "" + fifthNumericValue + "" + seventhNumericValue);

           * nope

           char input = char.Parse(Console.ReadLine());
           Console.WriteLine((int)input);

           string inputMessage = Console.ReadLine();
           string firstValue = inputMessage[0].ToString();
           Console.WriteLine((int)input);

            */

        }
    }
}
