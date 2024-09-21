namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)//The Main Class
        {
            Questions[] questions = new Questions[] //Object Created Based on the Type Class Questions[] 
            {
                new Questions(//Input The Data of Class Questions
                   "What is The Capital city Of Albania",
                   new string[] {"Paris","Tirane","Rome","Berlin"},
                   1
                   ),
                new Questions(//Input The Data of Class Questions
                   "What is The Capital city Of Germany",
                   new string[] {"Paris","Tirane","Rome","Berlin"},
                   3
                   ),
                new Questions(//Input The Data of Class Questions
                   "What is The Capital city Of France",
                   new string[] {"Paris","Tirane","Rome","Berlin"},
                   0
                   )
            };
            

           Quiz myQuiz=new Quiz(questions);//Pass in from Quiz Class the object Data
            myQuiz.StartQuiz();
           
          
            Console.ReadKey();

           
        }
    }
}
