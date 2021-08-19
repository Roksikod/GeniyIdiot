using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] questions = new string [5];
            questions[0] = "2 + 2 * 2 = ?";
            questions[1] = "How many months in a year have 28 days?";
            questions[2] = "How many cuts do you need to cut a log into 10 pieces?";
            questions[3] = "There are 10 fingers on two hands. How many fingers are there on 5 hands?";
            questions[4] = "Five candles were burning. Two went out. How many candles are left?";

            int[] answers = new int[5];
            answers[0] = 6;
            answers[1] = 12;
            answers[2] = 9;
            answers[3] = 25;
            answers[4] = 2;

            int countRightAnswers = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(questions[i]);
            }


        }
    }
}
