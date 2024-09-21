using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Questions
    {
        public string Question { get; set; }//Get Question
        public string[] Answers { get; set; }//Get Answer Array

        public int CorrectAnswers { get; set; }//Index of COrrect Answer


        public  Questions(string questions, string[] answers,int correctAnswers)//Called a constructor with its parameters
        {
            Question = questions;
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }

        public bool correctChoice(int choice)
        {
            return CorrectAnswers == choice;
        }
    }
}
