using System;
using Antlr4.Runtime;

namespace ParseadorAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "5*6+9*3-1";
            Console.WriteLine("Input: {0}\n", input);
            ICharStream stream = CharStreams.fromString(input);
            aritmeticaLexer lexer = new aritmeticaLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            aritmeticaParser parser = new aritmeticaParser(tokens);
            aritmeticaParser.AritmeticaContext tree  = parser.aritmetica();
            Aritmetica aritmetica = new Aritmetica();
            int res = aritmetica.Visit(tree);
        }
    }
}
