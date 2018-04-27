using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {

            string data;
            string PigEnd;
            string start;
            string data2;
            string vowels = "aeiou";


            //Prompt user to enter word
            Console.WriteLine("Enter a word into the Pig Latin Converter!");

            //convert word to "data"
            data = (Console.ReadLine().ToLower());

            //provide string used for pig latin ending
            PigEnd = "way";

            //isolate end of way for consonants
            start = PigEnd.Substring(1, 2);

            //if data is vowel
            if (data[0] == 'a' || data[0] == 'e' || data[0] == 'i' || data[0] == 'o' || data[0] == 'u')
            {
                Console.WriteLine("Your new word is:" + data + PigEnd);
            }
            else
            {

                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {

                        if (data[i] == vowels[j])
                        {
                            string end = data.Substring(i, data.Length -i);
                            string start1 = data.Substring(0,i);

                            Console.WriteLine(end + start1 + "ay");
                            j = vowels.Length;
                            i = data.Length;
                        }
                    }

                }


    
            }
        }
    }
}
