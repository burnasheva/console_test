using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123456");
            Console.WriteLine("http://user:123456@jetbrains.com");
            
            Console.WriteLine("All Environment Variables:");
            foreach(DictionaryEntry e in System.Environment.GetEnvironmentVariables())
            {
                Console.WriteLine(e.Key  + ":" + e.Value);
                
            }
        }
    }
}
