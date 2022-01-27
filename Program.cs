using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feedback(jcollard 2022-01-27): 
            // Here is an example of how you would create a question:

            // First create a new Question()
            Question simpleQuestion = new Question();

            // Next, set the question to be an actual question.
            simpleQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";

            // Next, add answers to the question
            simpleQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            simpleQuestion.answers.Add("Uh... 14?");
            simpleQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");

            // Finally, you can display the question and answers
            Console.WriteLine(simpleQuestion.question);

            // For your final solution, you will loop through these rather than manually selecting each one.
            Console.WriteLine($"1. {simpleQuestion.answers[0]}");
            Console.WriteLine($"2. {simpleQuestion.answers[1]}");
            Console.WriteLine($"3. {simpleQuestion.answers[2]}");

        }

        // TODO(jcollard 2022-01-27): Add documentation comment
        public static int GetValidAnswer(List<string> answers)
        {
            // TODO(jcollard 2022-01-27): Add step-by-step list of 
            // things to accomplish
            return -1;
        }

        // TODO(jcollard 2022-01-27): 
        // Add method stubs for remaining methods
    }

    // Feedback(jcollard 2022-01-27): I've added in the Question class for you.
    // This class stores both a question string and a list of answers together!
    class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}
