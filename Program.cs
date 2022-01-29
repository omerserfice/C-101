using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("İsmini gir:");
            string name = Console.ReadLine();
            Console.WriteLine("soyadını gir:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba"+name+" "+surname);
            // degişkenler 

             int deger = 2;
            string degisken = null;
            string Degisken = null;
           
           byte b = 5;
           sbyte c = 6;

           short s = 5;
            
            Console.WriteLine(deger+degisken);
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 4;
            // string ifadeler

            string str1 = string.Empty;
            str1 = "Ömer Serfice";
        
             int d2 = -2147483648;
             byte d3 = 255;
             sbyte  d4 = -128;
             
    
    }
    }
}
