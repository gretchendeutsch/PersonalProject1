using System;
using System.IO;

namespace PersonalProject1
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {


            Question testQuestion = new Question();
            int testResult = Program.AskQuestion(testQuestion); // TODO(jcollard 2022-02-10): This should come after your instructions. Right above `int expected = 1;`
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





            Question testQuestion2 = new Question();
            int testResult2 = Program.AskQuestion(testQuestion2); // TODO(jcollard 2022-02-10): This should come after your instructions. Right above `int expected = 1;`
            testQuestion2.question = "What is the weather outside?"; 
            testQuestion2.answers.Add("Sunny.");
            testQuestion2.answers.Add("Rainy.");
            testQuestion2.answers.Add("snowing.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 2. This should be a valid option. By selecting 2, the method should return 2.");
            int expected2 = 1;
            if (testResult != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 2 but it was {testResult} ");
                return false;
            }




            Question testQuestion3 = new Question();
            int testResult3 = Program.AskQuestion(testQuestion3); // TODO(jcollard 2022-02-10): This should come after your instructions. Right above `int expected = 1;`
            testQuestion3.question = "What flavor candy?";
            testQuestion3.answers.Add("vanilla");
            testQuestion3.answers.Add("grape");
            testQuestion3.answers.Add("poop");

            Console.WriteLine("Expected: the output to contain three options");
            Console.WriteLine("First type 5. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");
            int expected3 = 1;
            if (testResult != expected3)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 1 but it was {testResult}");
                return false;
            }
            try
            {
                testResult3 = Program.AskQuestion(null);
                Console.Error.WriteLine($"Failure: Expected the program to crash. But it did not.");
                return false;
            }
            catch
            {
                
            }

            return true;
        }
    }
}





