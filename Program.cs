namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] questions = new Questions[]
            {
                new Questions(
                   "What is The Capital city Of Albania",
                   new string[] {"Paris","Tirane","Rome","Berlin"},
                   1
                   )
            };
            

           Quiz myQuiz=new Quiz(questions);
           myQuiz.DisplaySetting(questions[0]);
           
          
            Console.ReadKey();

           
        }
    }
}
