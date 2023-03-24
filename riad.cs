using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace riadnigim_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            string todayWord = getTodayWord();
            Console.WriteLine("Welcome to my game");
            char[] line = { '_', '_', '_', '_' };
            int heart = todayWord.Length;
            int flag = 0;

            while (heart > 0)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    Console.Write(line[i] + " ");

                }
                char c = askUser();
               int check= cheklettr(todayWord, c, line);
                if (check == -1) { 
                    heart--;
                    Console.WriteLine("You have"+ heart + "Heartsleft.");
                }
                else
                {
                    line[check] = c;
                }
                if (checkwin(line) == 1)
                {
                    flag = 1;
                    break;
                }
                
            }
            if(flag == 1)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lost");
            }

        }
        public static char askUser()
        {
            Console.WriteLine("please enter a char: ");
            char c = Console.ReadLine()[0];
            return c;   

        }
        public static string getTodayWord()
        {
            string[] words = { "neaw", "anaa", "bmw4", "evol", "mrx7", "home", "hoow","neww","fall","wall","n7no","riad","door" };
            Random rnd = new Random();
            int num = rnd.Next(0, words.Length);
            return words[num];
        }
        public static int cheklettr(string todayword,char ch, char[]lines)
        {
            for(int i=0;i< todayword.Length; i++)
            {
                if (todayword[i] == ch && lines[i] != ch)
                {
                    return i;
                      
                }
            }
            return -1;
        }
       
        public static int checkwin(char[] lines)
			{
            for (int i = 0; i <lines.Length; i++)
            {
                if (lines[i] == '_')
                {
                    return -1;
                }
            }
            return 1;
           }


    }
}
