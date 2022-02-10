using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Checks if the user added a command line argument 
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program 
            }




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

            Question food = new Question();
            food.question = "What is your favorite food?";
            food.answers.Add("I don't eat.");
            food.answers.Add("Water");

            Question color = new Question();

            AskQuestion(food);


        }

        public static void TestAll()
        {
            bool testAskQuestion = TestAskQuestion.RunTest();
            Console.WriteLine($"Test AskQuestion(question q): {testAskQuestion}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"Test GetResult(scores): {testGetResult}");

            bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            Console.WriteLine($"Test GetValidAnswer(answers): {testGetValidAnswer}");

        }




        /// <summary>
        /// The GetValidAnswer method validates that there is at least one possible answer. If the list of answers is empty the method throws an exception.
        /// Then a message is displayed asking the user to select an answer. Once a valid answer is selected,
        /// the user's response is stored. If the answer is not valid then 
        /// </summary>
        /// <param name="answers"> This message shows an invalid answer choice
        /// <returns>The valid answer the player chose</returns>
        public static int GetValidAnswer(List<string> answers)
        {
            if (answers.Count == 0)
            {
                throw new Exception("Unable to get a answer for a list of 0.");
            }
            int userChoice;

            do
            {
                Console.WriteLine("Enter a number greater than 0:");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number");
                }
                else if (userChoice <= 0 || userChoice > answers.Count)
                {
                    Console.Error.WriteLine($"That number is not greater than 0 or less than {answers.Count}.");
                }
            } while (userChoice <= 0 || userChoice > answers.Count);

            return userChoice - 1;


            // 1. ensure that there is one possible answer[answer.Length<1]
            // <summary>
            // 2. throw new exception("Must have at least one answer.")
            // 3. Display $"Select an option 1 to {answer.Length}"
            // 4. store the response [int choice = int.Parse(ReadLine())]
            // 5. validate the choice is one of possible answers given[choice > 0 AND choice <= answers.Length]
            // 6. return choice if yes
            // 7. if no, Display error message: "Invalid choice", then go to number 3

        }

        /// <summary>
        /// The GetResult method initializes the start score of to be 0. It then loops through the each score in 
        /// scores that were determined by the users answers. It tracks which score is the highest, and each time a 
        /// user answers a question the score updates appropriately. At the end of the game the highest score is checked 
        /// and the results are shown. 
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="results"></param>
        /// <returns>the highest result</returns>
        public static string GetResult(List<int> scores, List<string> results)
        {
            //1. initialize highest score to 0 [int highest = 0]
            //2. initialize highest score to 0: int highest Ix = 0
            //3.Loop through each score in scores, tracking the index in variable currentIx
            //    * If score>highest score
            //          * update highest to store the score from answer[score=highest]
            //          * update highestIx to store the current ix[highestIx=currentIx]
            //4. After each score is checked highestIx should be the highest score[currIx=currIx+1]
            //5.return results[highestIx]

            // TODO(jcollard 2022-02-10): This is a tricky method to write. Each
            // of the lists is associated with the other. I've created an
            // example showing how to use a foreach loop to search a list for a
            // value. You can find it here:
            // https://jcollard.github.io/IntroToCSharpSite/examples/association-list

            return null;
        }

        /// <summary>
        /// the question is displayed and then the answers are displayed.The user puts in their answer choice,
        /// but if the user does not enter a positive integer/answer choice then an error message is displayed and the player 
        /// is prompted to put in an actual answer. Otherwise, the user's input is returned.
        /// </summary>
        /// <param name="q"> The message to potray an invalid answer</param>
        /// <returns>The valid answer the user chose</returns>
        public static int AskQuestion(Question q)
        {

            if (q.answers == null) throw new ArgumentNullException("List of options may not be null");
            if (q.answers.Count == 0) throw new ArgumentException("The List of options must contain at least 1 option.");
            int ix = 1;
            foreach (string answer in q.answers)
            {
             
                Console.WriteLine($"{ix}. {answer}");
                ix = ix + 1;
            }
            //1. display question [e.g. q.Question]
            //2. Loop through each answer and display it
            //      * Foreach question display answers
            /// given the question, the answers are displayed 
            //3. Use the GetValidAnswer(q.Answers) to get the response
            //4. return the response

            // TODO(jcollard 2022-02-10): You're off to a great start. Next, you
            // need to get the users response to the question. You already have
            // a method that does this: GetValidAnswer. You just need to call it
            // here.

            return -1;
        }
    }




    class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }


}


