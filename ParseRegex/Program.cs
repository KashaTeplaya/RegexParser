using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseRegex
{
    class Program
    {
        public string stringForParse = "\"123123123\":\"office-name\":\"Miriprochee\"";
       
        static void Main(string[] args)
        {
            Program p = new Program();
            p.getStart();
            Console.Read();
        }
        public void getStart()
        {
            Console.WriteLine(stringForParse);
            Parser parser = new Parser(stringForParse);
        }
    }
}
