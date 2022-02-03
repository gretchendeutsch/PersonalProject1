using System;
using System.Collections.Generic;
using System.IO;

namespace PersonalProject1
{
    class TestGetResult
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(4);

            List<string> results = new List<string>();
            results.Add("Kanye");
            results.Add("Bob the Builder");
            string result = Program.GetResult(scores, results);
            if (result != "Bob the Builder")
            {
                Console.Error.WriteLine($"Expected result to be 'Bob the Builder' but was {0}");
                return false;
            }

            List<int> scores2 = new List<int>();
            scores.Add(0);
            scores.Add(4);

            List<string> results2 = new List<string>();
            results.Add("grape"); // TODO: Change to results2
            results.Add("strawberry"); // TODO: Change to results2
            string result2 = Program.GetResult(scores, results); // TODO: Change to results2
            if (result != "strawberry")
            {
                Console.Error.WriteLine($"Expected result to be 'strawberry' but was {0}");
                return false;
            }

            List<int> scores3 = new List<int>();
            scores.Add(0);
            scores.Add(4);

            List<string> results3 = new List<string>();
            results.Add("soccer");
            results.Add("football");
            string result3 = Program.GetResult(scores, results);
            if (result != "strawberry") // TODO: Change to football
            {
                Console.Error.WriteLine($"Expected result to be 'football' but was {0}");
                return false;
            }

            
            // TODO(jcollard 2022-02-03): These look good. But, you want to test a different
            // situation with the scores. What should happen if you have a list of scores
            // with 4 different elements? Then you need a list with 4 different results.
            // You should write another test case with situations that test the nuances of
            // the method.

            return false;
        }
    }

}