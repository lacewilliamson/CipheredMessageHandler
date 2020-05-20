using System;
using System.Text;

namespace CipheredMessageHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputPlain;
            string userInputOTP;
            string encipheredString = "";

            Console.WriteLine("Enter string to convert:");
            userInputPlain = Console.ReadLine();
            Console.WriteLine("Enter one time pad string: ");
            userInputOTP = Console.ReadLine();
            //userInputPlain = "MAYIM";
            //userInputOTP = "LACEW";
            userInputPlain = prepareForHandling(userInputPlain);
            userInputOTP = prepareForHandling(userInputOTP);

                for (int i = 0; i < userInputPlain.Length; i++)
                {
                    encipheredString += (Encipher(userInputPlain[i], userInputOTP[i]));
                }
                Console.WriteLine(encipheredString);
                userInputPlain = "";
                userInputOTP = "";
                encipheredString = "";
        }
        static char Encipher (Char userCharacter, char oneTimePadCharacter)
        {
            int userCharacterInt;
            int padCharacterInt;
            userCharacterInt = userCharacter - 65; //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            padCharacterInt = oneTimePadCharacter - 65;  //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            int dencipheredCharacter = userCharacterInt + padCharacterInt;
                if (dencipheredCharacter < 0 )
                {
                    dencipheredCharacter += 26;
                }
                if (dencipheredCharacter >= 26)
                {
                    dencipheredCharacter -= 26;
                }
            return ((char)(dencipheredCharacter + 65));
        }
        static char Decipher(Char userCharacter, char oneTimePadCharacter)
        {
            int userCharacterInt;
            int padCharacterInt;
            userCharacterInt = userCharacter - 65; //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            padCharacterInt = oneTimePadCharacter - 65;  //This is done to make the math simpler to figure out, from ASCII to base 26 systems.
            int dencipheredCharacter = userCharacterInt - padCharacterInt;
            if (dencipheredCharacter < 0)
            {
                dencipheredCharacter += 26;
            }
            if (dencipheredCharacter > 26)
            {
                dencipheredCharacter -= 26;
            }
            return (char)(dencipheredCharacter + 65);
        }
        
        static string prepareForHandling(string userString)
        {
            userString.Replace(" ", "");
            return userString;
        }
    }
}
