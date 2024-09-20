using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Questions
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }

        public int CorrectAnswers { get; set; }


        public  Questions(string questions, string[] answers,int correctAnswers)
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
