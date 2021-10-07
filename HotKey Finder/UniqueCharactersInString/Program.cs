using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharactersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            originalString =  originalString.ToLower();
            string UniqueChars = string.Empty ;
            for(int index = 0; index < originalString.Length; index++)
            {
                if (UniqueChars.Contains(originalString[index].ToString()) == false)
                    UniqueChars += originalString[index].ToString();
            }

            //open processed rc file where strings are defined
            string fileContents = File.ReadAllText(@"C:\Users\MNarayan\Desktop\RCFileContents.txt");
            fileContents = fileContents.ToLower();
            foreach(char c in UniqueChars)
            {
                if (fileContents.Contains("&" + c.ToString()) == false)
                    Console.WriteLine("This character can be used as a hotkey: " + c.ToString());
            }

            Console.WriteLine(UniqueChars);

            Console.Read();
        }
    }
}
