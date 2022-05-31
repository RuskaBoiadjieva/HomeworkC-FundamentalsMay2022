using System;

namespace _12._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType=string.Empty;
            int valueInt;
            float valueFloat;
            char valueChar;
            bool valueBool;
            string valueString;

            while (input!="END")
            {

                if (int.TryParse(input, out valueInt))
                {
                    dataType = "integer";
                }
                else if(float.TryParse(input, out valueFloat))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out valueChar))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input, out valueBool))
                {
                    dataType = "boolean";
                }
                else 
                {
                    dataType = "string";
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}
