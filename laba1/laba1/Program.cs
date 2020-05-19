using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fat_dialog
{
    class Program
    {
        public static string[] answers =
    {
                "Dank as duck",
                "WeSmart",
                "MonkaHmm",
                "LUL",
                "BibleThump",
                "KEKWait",
                "BlessRNG",
                "CoolStoryBob",
                "Kappa",
                "Jebaited",
                "SMOrc",
            };
        public static string[] questions =
          {
                "Was ist das?",
                "Do you know de way?",
                "Where you've been to?",
                "If life is unfair to everyone, does that make it fair?",
                "Do you really think so?",
                "What do you think about that?",
                "If we can't see air, do fish see water?",
                "Is it true?",
                "Who's Elon Musk?",
                "Ein Volk, Ein... zwei, Polizei?",
                "Pizza time",
            };
        public static string[] generalAnswer = { "Yes, I ", "Nope, I not " };
        public static string[] time = { "months", "years", "weeks" };
        public static string[] whyanswers = {
            "Cosmic fluke.",
            "Eror 404.",
            "Because.",
            "wat?"
        };

        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Master Yoda: May the force be with you");
            string result = "";
            while (true)
            {
                result = "BabyYoda: ";
                string s = Console.ReadLine();
                string[] words = s.Split(' ');
                if (string.IsNullOrWhiteSpace(s))
                    Console.WriteLine("BabyYoda: What`s new?");
                else
                {
                    if (s.Contains("?"))
                    {
                        if (s.Contains("Do") || s.Contains("Did") || s.Contains("Will") || s.Contains("Have"))
                        {
                            result += generalAnswer[r.Next(generalAnswer.Length)];
                            for (int i = 2; i < words.Length; i++)
                                result += words[i].Replace('?', '.') + " ";
                            result += "And you?";

                        }
                        else if (s.Contains("Why"))
                            result += whyanswers[r.Next(whyanswers.Length)];
                        else if (s.Contains("How long") || s.Contains("How often"))
                            result += "Hmmmm. Near " + r.Next(10) + " " + time[r.Next(time.Length)];
                        else if (s.Contains("How"))
                            result += "O, I`m perfect.";
                        else result = answers[r.Next(answers.Length)];
                    }
                    else result += questions[r.Next(questions.Length)];
                    Console.WriteLine(result);
                }
            }
        }
    }
}
