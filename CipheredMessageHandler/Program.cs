using System;
using System.Text;

namespace CipheredMessageHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("Enter character to convert: ");
            char userChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Enter one-time pad character: ");
            char otpChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            encipher(userChar, otpChar);
            Console.ReadLine();
            }  
        }
        static void encipher (Char userCharacter, char oneTimePadCharacter)
        {
            int userCharacterInt = 0;
            int padCharacterInt = 0;
            userCharacterInt = userCharacter - 65; //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            padCharacterInt = oneTimePadCharacter - 65;  //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            int dencipheredCharacter = userCharacterInt + padCharacterInt;
                if (dencipheredCharacter < 0 )
                {
                    dencipheredCharacter += 26;
                }
                if (dencipheredCharacter > 26)
                {
                    dencipheredCharacter -= 26;
                }
            Console.WriteLine($"Enciphered character =  {(char)(dencipheredCharacter +65)}.");
                
         
        }
    }
}
