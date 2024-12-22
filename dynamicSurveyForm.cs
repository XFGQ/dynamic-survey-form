using System;
using System.Collections.Generic;

class Program
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string AnswerType { get; set; }
        public Dictionary<string, int> NextQuestion { get; set; }
    }
 
    static void Main(string[] args)
    {
        List<Question> questions = new List<Question>
        {
            new Question
            {
                ID = 1,
                Text = "Do you use a phone?",
                AnswerType = "radio",
                NextQuestion = new Dictionary<string, int>
                {
                    { "Yes", 2 },
                    { "No", 3 }
                }
            },
            new Question
            {
                ID = 2,
                Text = "What brand of phone do you use?",
                AnswerType = "textbox",
                NextQuestion = new Dictionary<string, int>
                {
                    {"Samsung",4 },
                    {"Apple",5 },
                    {"Xiaomi",6 }
                }
            },
            new Question
            {
                ID = 3,
                Text = "What is the reason for not using a phone?",
                AnswerType = "textbox",
                NextQuestion = new Dictionary<string, int>()
            },
            new Question
            {
                ID = 4,
                Text = "Do you use Samsung because it is better?",
                AnswerType = "radio",
                NextQuestion = new Dictionary<string, int>
                {
                     { "Yes", 6 },
                    { "No", 7 }
                }
            }
        };
 
        int currentQuestionID = 1;
 
        Dictionary<int, string> userAnswers = new Dictionary<int, string>();
 
        while (currentQuestionID != 0)
        {
            var currentQuestion = questions.Find(q => q.ID == currentQuestionID);
 
            Console.WriteLine(currentQuestion.Text);
 
            string answer = Console.ReadLine();
            userAnswers[currentQuestionID] = answer;
 
            if (currentQuestion.NextQuestion.ContainsKey(answer))
            {
                currentQuestionID = currentQuestion.NextQuestion[answer];
            }
            else
            {
                currentQuestionID = 0;
            }
        }
 
        Console.WriteLine("\nSurvey Completed. Your answers:");
        foreach (var answer in userAnswers)
        {
            Console.WriteLine($"Question {answer.Key}: {answer.Value}");
        }
     }
}
 