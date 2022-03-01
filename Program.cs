using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class Program
    {
        private static int response;

        static void Main(string[] args)
        {

            // Checks if the user added a command line argument 
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }


            // TODO(jcollard 2022-02-12): 
            // You're so close to being done! All that is left is to complete your main method.
            // When you run `dotnet run` in the terminal, your questions should be asked and then
            // your result should be displays.

            // 1. Create a List<int> to store your scores:
            //List<int> scores = new List<int>();

            // 2. Initialize each score to 0
            // scores.Add(0); // How many times do you need to do this? (once for each score)

            // 3. Create a question
            // Question dogQuestion = new Question();
            // dogQuestion.question = "What is your favorite kind of dog?";
            // dogQuestion.answers.Add("Poodle");
            // dogQuestion.answers.Add("Chow-Chow");
            // dogQuestion.answers.Add("Husky");

            // 4. Ask the question
            // int result = AskQuestion(dogQuestion);

            // 5. Update the score based on the result:
            // scores[result] = scores[result] + 1;

            // Repeat Steps 3, 4, and 5 for each of your questions.

            // 6. Create a results lists:
            // List<string> results = new List<string>();
            // 7. Add elements to the results list

            // 8. Call GetResult:
            // string finalResult = GetResult(scores, results);

            // 9. Display the results
            // Console.WriteLine($"You are a {finalResult}");

            List<Question> questions = new List<Question>();
            Question relationshipQuestion = new Question();
            relationshipQuestion.question = "What is your relationship status?";
            relationshipQuestion.answers.Add("newly taken");
            relationshipQuestion.answers.Add("taken");
            relationshipQuestion.answers.Add("married");
            relationshipQuestion.answers.Add("extra-single");
            relationshipQuestion.answers.Add("single and ready to mingle");
            relationshipQuestion.answers.Add("take + pda");
            relationshipQuestion.answers.Add("single");
            questions.Add(relationshipQuestion);

            Question drinkQuestion = new Question();
            drinkQuestion.question = "What is your favorite drink?";
            drinkQuestion.answers.Add("green juice");
            drinkQuestion.answers.Add("lemonade");
            drinkQuestion.answers.Add("weird sleep drink");
            drinkQuestion.answers.Add("shirley temple");
            drinkQuestion.answers.Add("coffee");
            drinkQuestion.answers.Add("pina colada");
            drinkQuestion.answers.Add("strawberry, java chip frappe");
            questions.Add(drinkQuestion);

            Question foodQuestion = new Question();
            foodQuestion.question = "What is your favorite food?";
            foodQuestion.answers.Add("sushi");
            foodQuestion.answers.Add("chicken");
            foodQuestion.answers.Add("pasta");
            foodQuestion.answers.Add("acai bowl");
            foodQuestion.answers.Add("thai");
            foodQuestion.answers.Add("peanut butter cups");
            foodQuestion.answers.Add("bagels");
            questions.Add(foodQuestion);

            Question movieQuestion = new Question();
            movieQuestion.question = "What is your favorite movie?";
            movieQuestion.answers.Add("Shrek");
            movieQuestion.answers.Add("I don't like movies");
            movieQuestion.answers.Add("Twilight");
            movieQuestion.answers.Add("Deadpool");
            movieQuestion.answers.Add("How to lose a guy in 10 days");
            movieQuestion.answers.Add("The Notebook");
            movieQuestion.answers.Add("10 things I hate about you");
            questions.Add(movieQuestion);

            Question artistQuestion = new Question();
            artistQuestion.question = "Who is your favorite artist";
            artistQuestion.answers.Add("Kendrick");
            artistQuestion.answers.Add("Kanye");
            artistQuestion.answers.Add("Mac Miller");
            artistQuestion.answers.Add("Rihanna");
            artistQuestion.answers.Add("Gretchen");
            artistQuestion.answers.Add("Doja Cat");
            artistQuestion.answers.Add("Justin Bieber");
            questions.Add(artistQuestion);



            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);

            List<string> results = new List<string>();
            results.Add("Gretchen");
            results.Add("Kailey");
            results.Add("Gabi");
            results.Add("Zoe");
            results.Add("Ella");
            results.Add("Avery");
            results.Add("Annie");

            foreach (Question q in questions)
            {
                int response;
                response = AskQuestion(q);
                scores[response] = scores[response] + 1;
            }

            string result = GetResult(scores, results);
            Console.WriteLine($"Your result was {result}");



        }

        public static void TestAll()
        {
            // bool testAskQuestion = TestAskQuestion.RunTest();
            // Console.WriteLine($"Test AskQuestion(question q): {testAskQuestion}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"Test GetResult(scores): {testGetResult}");

            // bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            // Console.WriteLine($"Test GetValidAnswer(answers): {testGetValidAnswer}");

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
            }
            while (userChoice <= 0 || userChoice > answers.Count);

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

            if (scores == null || results == null) throw new Exception("Scores and Result Lists may not be null");
            if (scores.Count == 0) throw new Exception("Can not process an empty list");
            if (results.Count != scores.Count) throw new Exception("Scores and Results list need to be the same length");
            int largestScore = scores[0];
            string result = results[0];
            int ix = 0;



            foreach (int score in scores)
            {
                if (score > largestScore)
                {

                    result = results[ix];
                    largestScore = scores[ix];
                }
                ix = ix + 1;
            }
            Console.WriteLine($"You are {result}");
            return result;

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
            Console.WriteLine(q.question);
            int ix = 1;
            foreach (string answer in q.answers)
            {

                Console.WriteLine($"{ix}. {answer}");
                ix = ix + 1;
            }
            return GetValidAnswer(q.answers);


        }





        //1. initialize highest score to 0 [int highest = 0]
        //2. initialize highest score to 0: int highest Ix = 0
        //3.Loop through each score in scores, tracking the index in variable currentIx
        //    * If score>highest score
        //          * update highest to store the score from answer[score=highest]
        //          * update highestIx to store the current ix[highestIx=currentIx]
        //4. After each score is checked highestIx should be the highest score[currIx=currIx+1]
        //5.return results[highestIx]

    }







    class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }


}


