using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ParseRegex
{
    class Parser
    {

        public Parser(string parse)
        {
            Parse(parse);
        }
        public void Parse(string _parseString)
        {
            //
            Regex regex = new Regex("([0-9]{9})(.+\")(.+[^0-9][^\"])",RegexOptions.IgnoreCase);
            var groups = regex.Match(_parseString).Groups;
            Console.WriteLine(groups[0] + "\n");
            Console.WriteLine(groups[1] + "\n");
            Console.WriteLine(groups[2] + "\n");
            Console.WriteLine(groups[3] + "\n");

        }
    }
}
