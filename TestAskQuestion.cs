using System;
using System.IO;

namespace PersonalProject1
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {


            Question testQuestion = new Question();
            testQuestion.question = "Who let the dogs out?";
            testQuestion.answers.Add("Zoe.");
            testQuestion.answers.Add("You did!");
            testQuestion.answers.Add("He let himself out.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");


          
            testQuestion.question = "What is the weather outside?";
            testQuestion.answers.Add("Sunny.");
            testQuestion.answers.Add("Rainy.");
            testQuestion.answers.Add("snowing.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            testQuestion.question = "What flavor candy?";
            testQuestion.answers.Add("vanilla");
            testQuestion.answers.Add("grape");
            testQuestion.answers.Add("poop");

            Console.WriteLine("Expected: the output to contain three options");
            Console.WriteLine("First type 5. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

           
    
             int result = Program.AskQuestion(testQuestion);

            
      






            // TODO(jcollard 2022-02-01): These look great.
            // Now, figure out how to call your methods. In this case you would do the following:
            //
            // 1. Start by setting up a Question object
            // We do this because your method AskQuestion takes 1 parameter which must be a Question
            //
            // Question testQuestion = new Question();
            // testQuestion.question = "Some question here";
            // testQuestion.answers.Add("Some answer");
            // testQuestion.answers.Add("Some other8 answer");
            //
            // Then, create a message to be displayed to the tester. What should the method
            // write to the console when you pass testQuestion as an argument?
            //
            // Console.WriteLine("Expected: the output to contain 3 options.");
            // Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            // Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.")
            //
            // int result = Program.AskQuestion(testQuestion);
            //
            // Then we check that the result is equal to 1 because that is what we told the tester to enter.
            // 
            // Think of a few more tests you could do. What should happen if the question has no answers?
            // What should happen if the question has more than 3 answers?

            return false;
        }
    }
}