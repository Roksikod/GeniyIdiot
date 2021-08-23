using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);
            int[] answers = GetAnswers(countQuestions);

            int countRightAnswers = 0;

            Random random = new Random();

            //a random question should not be repeated: option with shuffle

            for (int i = questions.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i);

                string tempQuestion = questions[randomIndex];
                questions[randomIndex] = questions[i];
                questions[i] = tempQuestion;

                int tempAnswer = answers[randomIndex];
                answers[randomIndex] = answers[i];
                answers[i] = tempAnswer;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Question № {i + 1}");                

                Console.WriteLine(i); 

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                int rightAnswer = answers[i]; 
                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
            }
            Console.WriteLine($"You answered {countRightAnswers} questions correctly");

            string[] diagnoses = GetDiagnose(countRightAnswers);
        }

        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[5];
            questions[0] = "2 + 2 * 2 = ?";
            questions[1] = "How many months in a year have 28 days?";
            questions[2] = "How many cuts do you need to cut a log into 10 pieces?";
            questions[3] = "There are 10 fingers on two hands. How many fingers are there on 5 hands?";
            questions[4] = "Five candles were burning. Two went out. How many candles are left?";
            return questions;
        }

        static int[] GetAnswers(int countQuestions)
        {
            int[] answers = new int[5];
            answers[0] = 6;
            answers[1] = 12;
            answers[2] = 9;
            answers[3] = 25;
            answers[4] = 2;
            return answers;
        }

        static string[] GetDiagnose(int countRightAnswers)
        {
            string[] diagnoses = new string[6];

            diagnoses[0] = "But you can read, that's not bad!";
            diagnoses[1] = "You are on the right track, don't stop!";
            diagnoses[2] = "Did you definitely go to school?";
            diagnoses[3] = "Don't worry, statistics are on your side";
            diagnoses[4] = "You're a talent!";
            diagnoses[5] = "Genius. Just a genius.";
            return diagnoses;
        }
    }
}
