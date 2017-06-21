using System;

namespace Cat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Kitty");

            var info = new TipInfo
            {
                MadamAge = ReadDecimal("   MadamAge: "),
                NumberCats = ReadDecimal("  NumberCats: "),

            };
            Console.WriteLine("Количество кошек : {0}", info.NumberCats);
        }


        static decimal ReadDecimal (string prompt)
        {
            while (true)
            {
                string value = null;
                try
                {
                    Console.Write(prompt);
                    value = Console.ReadLine();
                    return Convert.ToDecimal(value);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to convert value '{0}' to a decimal: {1}", value, e.Message);
                }
            }
    }
}
}
