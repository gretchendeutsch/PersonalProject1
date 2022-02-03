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
            answers.Add("phone");// TODO: user answers2
            answers.Add("laptop");// TODO: user answers2
            answers.Add("grape");// TODO: user answers2

            answers.Add("strawberry");

            Console.WriteLine("You should expect to see 4 options: phone, laptop, grape, and strawberry. Enter 6. This should produce an invalid response. Then enter 3.");

            int result2 = Program.GetValidAnswer(answers); // TODO: user answers2

            if (result2 != 2)
            {
                Console.Error.WriteLine($"Expected result to be 2 but was {result2}");
                return false;
            }

            List<string> answers3 = new List<string>();
            answers.Add("laugh");// TODO: user answers3
            answers.Add("cry");// TODO: user answers3
            answers.Add("burp");// TODO: user answers3
            answers.Add("die");// TODO: user answers3

            Console.WriteLine("You should expect to see 4 options: laugh, cry, burp, and die. Enter 6. This should produce an invalid response. Then enter 3.");

            int result3 = Program.GetValidAnswer(answers); // TODO: user answers3

            if (result3 != 3) // This should be 2 (e.g. 3 - 1) OR you need to ask the user to enter 4.
            {
                Console.Error.WriteLine($"Expected result to be 2 but was {result3}");
                return false;
            }


           
           



            return false; // TODO(jcollard 2022-02-03): Return true
        }
    }

}