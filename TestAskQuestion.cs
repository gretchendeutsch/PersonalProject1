using System;
using System.IO;

namespace PersonalProject1
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {


            Question testQuestion = new Question();
            int testResult = Program.AskQuestion(testQuestion);
            testQuestion.question = "Who let the dogs out?";
            testQuestion.answers.Add("Zoe.");
            testQuestion.answers.Add("You did!");
            testQuestion.answers.Add("He let himself out.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");
            int expected = 1;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 1 but it was {testResult}");
                return false;
            }


            // TODO(jcollard 2022-02-03): Your setup looks great! Now, you need to call the method here:

            // int result = Program.AskQuestion(testQuestion);

            // Then, you should write an if statement to check the result. When the user types 1, what should the variable
            // result store? I believe the variable should be storing the number 0 (e.g. Zoe). This is because in C#, the
            // index starts at 0. But, you are displaying 1. Zoe to the user. Does this make sense?

            // if (result != 0) // We check if it is **NOT** equal to 0 because we are checking if the test should fail
            // {
            //     Console.Error.WriteLine($"Failure: Expected result to be 0 but it was {result}.");
            //     return false;
            // }  

            // Next, create a new question. You're actually just updating the previous question here. 
            // If you use `testQuestion` again, you will keep all of the answers and you're just adding 
            // to the end of the list


            Question testQuestion2 = new Question();
            int testResult2 = Program.AskQuestion(testQuestion2);
            testQuestion2.question = "What is the weather outside?"; // TODO: Change these to `testQuestion2`
            testQuestion2.answers.Add("Sunny.");
            testQuestion2.answers.Add("Rainy.");
            testQuestion2.answers.Add("snowing.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 2. This should be a valid option. By selecting 2, the method should return 2.");
            int expected2 = 1;
            if (testResult != expected2) // TODO(jcollard 2022-02-05): typo on this line
            {
                Console.Error.WriteLine($"Failure: Expected result to be 2 but it was {testResult} ");
                return false;
            }




            Question testQuestion3 = new Question();
            int testResult3 = Program.AskQuestion(testQuestion3);
            testQuestion3.question = "What flavor candy?";
            testQuestion3.answers.Add("vanilla");
            testQuestion3.answers.Add("grape");
            testQuestion3.answers.Add("poop");

            Console.WriteLine("Expected: the output to contain three options");
            Console.WriteLine("First type 5. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");
            int expected3 = 1;
            if (testResult != expected3)// TODO(jcollard 2022-02-05): typo on this line
            {
                Console.Error.WriteLine($"Failure: Expected result to be 1 but it was {testResult}");
                return false;
            }

            // Feedback(jcollard 2022-02-05): YES! This test is perfect! Great job!
            try
            {
                testResult3 = Program.AskQuestion(null);
                Console.Error.WriteLine($"Failure: Expected the program to crash. But it did not.");
                return false;
            }
            catch
            {
                
            }










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

            return true;
        }
    }
}