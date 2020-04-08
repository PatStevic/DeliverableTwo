using System;
using System.Linq;

namespace pStevicDeliverablesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLet's create secret messages!\nGive me a word and I'll encrypt it into a secret code!\n");
            string inputMessage = Console.ReadLine();
            string lowercaseValue = inputMessage.ToLower();
            System.Collections.Generic.List<string> stringList = lowercaseValue.Split("")
                .ToList();

            int[] encodedMessage = stringList.Select(letter => Enum.Parse(letterValues, letter))

        }    
    }
}
