using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {

            List<string> answers = new List<string>();
            answers.Add("Banana");
            answers.Add("Cat");
            Console.WriteLine("You should expect to see 2 options: Banana and Cat. Enter 5. This should produce an invalid response. Then enter 2.");

            int result = Program.GetValidAnswer(answers);

            if (result != 1)
            {
                Console.Error.WriteLine($"Expected result to be 1 but was {result}");
                return false;
            }

            List<string> answers2 = new List<string>();
            answers.Add("phone");
            answers.Add("laptop");
            answers.Add("grape");

            answers.Add("strawberry");

            Console.WriteLine("You should expect to see 4 options: ???. Enter 6. This should produce an invalid response. Then enter 3.");

            int result2 = Program.GetValidAnswer(answers);

            if (result2 != 2)
            {
                Console.Error.WriteLine($"Expected result to be 2 but was {result2}");
                return false;
            }


            // if answer = none
            // {
            //     catch(Exception e)
            // {
            //     //ignore the error
            // }

            // Console.WriteLine("Chose an answer");

            // if answer = 1
            // {
            //     store.
            // }

            // }




            return false;
        }
    }

}