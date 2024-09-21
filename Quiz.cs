using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {

        private Questions[] questions;//Member Type 
        private int score;
        public Quiz(Questions[] questions)//Constructor to pass in the Data from Questions Class
        {
            this.questions = questions;
            int score = 0;
        }

        public void StartQuiz()

        {

            int questionIndex = 0;
            foreach (Questions questions in questions)
            {
                Console.WriteLine($"This is The question Number: {questionIndex++}");
                DisplaySetting(questions);
                int userChoice = GetUserChoice();
                if (questions.correctChoice(userChoice)){
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Wrong! The Right Answer is {questions.Answers[questions.CorrectAnswers]}");
                }
                
            }
        }

        public void DisplaySetting(Questions question)//Method that pass in the Class Question Buil and data comes from main 
        {
            Console.WriteLine(question.Question);//Get Parameter Question

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"   {i + 1}. {question.Answers[i]}");
            }

            Console.ResetColor(); // Reset color after displaying answers

            // Store user's choice

            double percentage = (double)score / questions.Length;

            Console.WriteLine($"Congratulations!You got {percentage}");


        }




        public int GetUserChoice() {//Method to get The User Choice Used On Line 33
            Console.WriteLine("Input Your Answer");
            string input = Console.ReadLine();
            int choice = 0;

            while(!int.TryParse(input, out choice)||choice <1 || choice > 4)//While input is diffrent from integer or is less than 1 or higher than 4 answer is Invalid input another
            {
                Console.WriteLine("Your Answer Is Invalid ");
                input=Console.ReadLine();
            }
            return choice -1;

        }


        

    }
}
