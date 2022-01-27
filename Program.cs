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

        
public static int GetValidAnswer(List answers)
{
    return null;
    // 1. ensure that there is one possible answer[answer.Length<1]
    // <summary>
    // 2. throw new exception("Must have at least one answer.")
    // 3. Display $"Select an option 1 to {answer.Lenght}"
    // 4. store the response [int choice = int.Parse(ReadLine())]
    // 5. validate the choice is one of possible answers given[choice > 0 AND choice <= answers.Length]
    // 6. return choice if yes
    // 7. if no, Display error message: "Invalid choice", then go to number 3
}

public static string GetResult(List<int>scores, List<string>results)
{
    //1. initialize highest score to 0 [int highest = 0]
    //2. initialize highest score to 0: int highets Ix = 0
    //3.Loop through each score in scores, tracking the index in variable currentIx
    //    * If score>highest score
    //          * update highest to store the score from answer[score=highest]
    //          * update highestix to store the current ix[highestix=currentix]
    //4. After each score is checked highestix should be the highest score[currIx=currIx+1]
    //5.return results[highestIx]
    return null;
    }

public static int AskQuestion(Question q)
{
    //1. display question [e.g. q.Question]
    //2. Loop through each answer and display it
    //      * Foreach question display answers
    /// given the question, the answers are displayed 
    //3. Use the GetValidAnswer(q.Answers) to get the response
    //4. return the response
    /// <summary>
    /// the question is displayed and then the answers are displayed.The user puts in their answer choice,
    /// but if the user does not enter a positive answer choice then an error message is displayed and the player 
    /// is prompted to put in a actuall answer. Otherwise, the user's input is returned.
    /// <summary>
    /// <param name="error"> The message to potray an invalid answer
    /// <returns>The valid answer the user chose</returns>
    return null;
}


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

