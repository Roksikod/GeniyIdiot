using System;
using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {            
            var questions = GetQuestions();
            var countQuestions = questions.Count;
            var countRightAnswers = 0;

            var random = new Random ();
            for (int i = 0; i < countQuestions; i++)
            {
                Console.WriteLine($"Question № {i + 1}");

                var randomIndex = random.Next(0, questions.Count);

                Console.WriteLine(questions[randomIndex].Text);

                var userAnswer = GetUserAnswer();

                var rightAnswer = questions[randomIndex].Answer;
                if (userAnswer == rightAnswer)
                {
                    countRightAnswers++;
                }
                questions.RemoveAt(randomIndex);
                
            }
            Console.WriteLine($"You answered {countRightAnswers} questions correctly");

            string[] diagnoses = GetDiagnose(countRightAnswers);
        }

        private static int GetUserAnswer()
        {
            throw new NotImplementedException();
        }

        public static List<Question> GetQuestions()
        {
            var questions = new List <Question>();
            var newQuestion = new Question();
            questions. Add (new Question ("2 + 2 * 2 = ?"), 6);
            questions.Add (new Question ("How many months in a year have 28 days?"), 12);
            questions.Add(new Question("How many cuts do you need to cut a log into 10 pieces?"), 9);
            questions.Add(new Question("There are 10 fingers on two hands. How many fingers are there on 5 hands?"), 25);
            questions.Add(new Question("Five candles were burning. Two went out. How many candles are left?"), 2);
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
        private static void Shuffle(string[] questions, int[] answers)
        {
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
