using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            //please don't type "|", "·", or "—" as it's part of the translation and has no morse equivalent
            Console.WriteLine("Please write something...");
            string morse = Console.ReadLine();
            string translate = morse.Replace("a", "|·—").Replace("b", "|—···").Replace("c", "|—·—·")
                .Replace("d", "|—··").Replace("e", "|·").Replace("f", "|··—·").Replace("g", "|——·")
                .Replace("h", "|····").Replace("i", "|··").Replace("j", "|·———").Replace("k", "|—·—")
                .Replace("l", "|·—··").Replace("m", "|——").Replace("n", "|—·").Replace("o", "|———")
                .Replace("p", "|·——·").Replace("q", "|——·—").Replace("r", "|·—·").Replace("s", "|···")
                .Replace("t", "|—").Replace("u", "|··—").Replace("v", "|···—").Replace("w", "|·——")
                .Replace("x", "|—··—").Replace("y", "|—·——").Replace("z", "|——··").Replace("1", "|·————")
                .Replace("2", "|··———").Replace("3", "|···——").Replace("4", "|····—").Replace("5", "|·····")
                .Replace("6", "|—····").Replace("7", "|——···").Replace("8", "|———··").Replace("9", "|————·")
                .Replace("0", "|—————").Replace("A", "|·—").Replace("B", "|—···").Replace("C", "|—·—·")
                .Replace("D", "|—··").Replace("E", "|·").Replace("F", "|··—·").Replace("G", "|——·")
                .Replace("H", "|····").Replace("I", "|··").Replace("J", "|·———").Replace("K", "|—·—")
                .Replace("L", "|·—··").Replace("M", "|——").Replace("N", "|—·").Replace("O", "|———")
                .Replace("P", "|·——·").Replace("Q", "|——·—").Replace("R", "|·—·").Replace("S", "|···")
                .Replace("T", "|—").Replace("U", "|··—").Replace("V", "|···—").Replace("W", "|·——")
                .Replace("X", "|—··—").Replace("Y", "|—·——").Replace("Z", "|——··").Replace(",", "|——··——")
                .Replace("?", "|··——··").Replace("'", "|·————·").Replace("!", "|—·—·——").Replace("(", "|—·——·")
                .Replace(")", "|—·——·—").Replace("&", "|·—···").Replace(":", "|———···").Replace(";", "|—·—·—·")
                .Replace("=", "|—···—").Replace("+", "|·—·—·").Replace("_", "|··——·—").Replace("\"", "|·—··—·")
                .Replace("$", "|···—··—").Replace("@", "|·——·—·") .Replace("/", "|—··—·").Replace("-", "|—····—")
                .Replace("à", "|·——·—") .Replace("À", "|·——·—").Replace("ä", "|·—·—").Replace("ć", "|—·—··")
                .Replace("Ć", "|—·—··").Replace("é", "|··—··").Replace("É", "|··—··") .Replace("è", "|·—··—")
                .Replace("È", "|·—··—") .Replace("ö", "|———·").Replace("Ö", "|———·").Replace("ü", "|··——")
                .Replace("Ü", "|··——").Replace("ź", "|——··—·").Replace("Ź", "|——··—·").Replace(".", "|·—·—·—")
                ;
            Console.WriteLine(translate);

            Console.WriteLine("The original text...");
            string back = translate.Replace("|···—··—", "$").Replace("|——··——", ",").Replace("|··——··", "?")
                .Replace("|·————·", "'").Replace("|—·—·——", "!").Replace("|—·——·—", ")").Replace("|———···", ":")
                .Replace("|—·—·—·", ";").Replace("|··——·—", "_").Replace("|·—··—·", "\"").Replace("|·——·—·", "@")
                .Replace("|——··—·", "ź").Replace("|—····—", "-").Replace("|·—·—·—", ".")
                .Replace("|—————", "0").Replace("|·————", "1").Replace("|··———", "2").Replace("|···——", "3")
                .Replace("|····—", "4").Replace("|·····", "5").Replace("|—····", "6").Replace("|——···", "7")
                .Replace("|———··", "8").Replace("|————·", "9").Replace("|—·——·", "(").Replace("|·—···", "&")
                .Replace("|—···—", "=").Replace("|·—·—·", "+").Replace("|·——·—", "à").Replace("|—·—··", "ć")
                .Replace("|··—··", "é").Replace("|·—··—", "è").Replace("|—··—·", "/")
                .Replace("|—···", "b").Replace("|—·—·", "c").Replace("|··—·", "f").Replace("|····", "h")
                .Replace("|·———", "j").Replace("|·—··", "l").Replace("|·——·", "p").Replace("|——·—", "q")
                .Replace("|···—", "v").Replace("|—··—", "x").Replace("|—·——", "y").Replace("|——··", "z")
                .Replace("|·—·—", "ä").Replace("|———·", "ö").Replace("|··——", "ü")
                .Replace("|—··", "d").Replace("|——·", "g").Replace("|—·—", "k").Replace("|———", "o")
                .Replace("|·—·", "r").Replace("|···", "s").Replace("|··—", "u").Replace("|·——", "w")
                .Replace("|·—", "a").Replace("|··", "i").Replace("|——", "m").Replace("|—·", "n")
                .Replace("|·", "e").Replace("|—", "t");
            Console.WriteLine(back);
            Console.ReadLine();
        }
    }
}
