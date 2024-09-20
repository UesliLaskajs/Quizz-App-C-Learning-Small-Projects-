using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {

        private Questions[] questions;

        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }

        public void DisplaySetting(Questions question)
        {
            Console.WriteLine(question.Question);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"   {i + 1}. {question.Answers[i]}");
            }

            Console.ResetColor(); // Reset color after displaying answers

            // Store user's choice

            if (GetUserChoice() == question.CorrectAnswers)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }




        public int GetUserChoice() {
            Console.WriteLine("Input Your Answer");
            string input = Console.ReadLine();
            int choice = 0;

            while(!int.TryParse(input, out choice)||choice <1 || choice > 4)
            {
                Console.WriteLine("Your Answer Is Invalid ");
                input=Console.ReadLine();
            }
            return choice -1;

        }


        

    }
}
