using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace RegularExpressionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string girls = @"Kitty is 16 years old\n
                       Kelly is 18 years old\n
                       Merry is 19 years old\n
                       Karen is 22 years old\n";
            
            Regex expression = new Regex(@"K.... is 1\d years old");
            MatchCollection matches = expression.Matches(girls);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

            string boys = "Vitor-1979 Verne-1982 Regan-1988 Robin-2008";
            Regex expression2 = new Regex(@"[VR][a-z][a-z][a-z][a-z]-19[89][0-9]");
            MatchCollection matches2 = expression2.Matches(boys);
            foreach (Match match in matches2)
            {
                Console.WriteLine(match);
            }

            string sentence = "there is a bee in the tree";
            Regex expression3 = new Regex(@"(tr|b)ee");
            MatchCollection matches3 = expression3.Matches(sentence);
            foreach (Match match in matches3)
            {
                Console.WriteLine(match);

            }

            string words = "year1998 year2008 year2018";
            Regex expression4 = new Regex(@"^year\d\d\d\d");
            foreach (Match match in expression4.Matches(words))
            {
                Console.WriteLine(match);
            }

            Regex expression5 = new Regex(@"year\d\d\d\d$");
            foreach (Match match in expression5.Matches(words))
            {
                Console.WriteLine(match);
            }
        }

    }
}