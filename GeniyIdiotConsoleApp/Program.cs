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
                Console.WriteLine($"Question № {i+1}");
                Console.WriteLine(questions[i]);

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                int rightAnswer = answers[i];
                if (userAnswer==rightAnswer)
                {
                    countRightAnswers++;
                }
            }
            Console.WriteLine($"You answered {countRightAnswers} questions correctly");

            //string diagnos = "";
            //if (countRightAnswers == 0)
            //{
            //    diagnos = "But you can read, that's not bad!";
            //}
            //if (countRightAnswers == 1)
            //{
            //    diagnos = "You are on the right track, don't stop!";
            //}
            //if (countRightAnswers == 2)
            //{
            //    diagnos = "Did you definitely go to school?";
            //}
            //if (countRightAnswers == 3)
            //{
            //    diagnos = "Don't worry, statistics are on your side";
            //}
            //if (countRightAnswers == 4)
            //{
            //    diagnos = "You're a talent!";
            //}
            //if (countRightAnswers == 5)
            //{
            //    diagnos = "Genius. Just a genius.";
            //}

            //switch (countRightAnswers)
            //{
            //    case 0: diagnos = "But you can read, that's not bad!"; break;
            //    case 1: diagnos = "You are on the right track, don't stop!"; break;
            //    case 2: diagnos = "Did you definitely go to school?"; break;
            //    case 3: diagnos = "Don't worry, statistics are on your side"; break;
            //    case 4: diagnos = "You're a talent!"; break;
            //    case 5: diagnos = "Genius. Just a genius."; break;       
                                   
            //}

            string[] diagnoses = new string[6];

            diagnoses[0] = "But you can read, that's not bad!"; 
            diagnoses[1] = "You are on the right track, don't stop!";
            diagnoses[2] = "Did you definitely go to school?";
            diagnoses[3] = "Don't worry, statistics are on your side"; 
            diagnoses[4] = "You're a talent!"; 
            diagnoses[5] = "Genius. Just a genius."; 
        }
    }
}
