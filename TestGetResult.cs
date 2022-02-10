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
            // TODO(jcollard 2022-02-05): Try a list with different values than your previous test
            scores2.Add(0);
            scores2.Add(3);

            List<string> results2 = new List<string>();
            results2.Add("grape");
            results2.Add("strawberry");
            string result2 = Program.GetResult(scores, results);
            if (result != "strawberry")
            {
                Console.Error.WriteLine($"Expected result to be 'strawberry' but was {0}");
                return false;
            }

            List<int> scores3 = new List<int>();
            // TODO(jcollard 2022-02-05): Try a list with different values than your previous test
            scores3.Add(1);
            scores3.Add(2);
            scores3.Add(3);

            List<string> results3 = new List<string>();
            results3.Add("soccer");
            results.Add("football");
            results3.Add("baseball");
            string result3 = Program.GetResult(scores, results);
            if (result3 != "baseball")
            {
                Console.Error.WriteLine($"Expected result to be 'baseball' but was {0}");
                return false;
            }



            List<int> scores4 = new List<int>();
            // TODO(jcollard 2022-02-05): The length of this list should match the length of the results list.
            scores4.Add(1); // question 1
            scores4.Add(4); // question 2
            scores.Add(3); // question 3
            scores.Add(4); // question 4


            List<string> results4 = new List<string>();
            results4.Add("face");
            results4.Add("hands");
            results4.Add("butt");
            results4.Add("toe");
            string result4 = Program.GetResult(scores, results);
            if (result4 != "toe")
            {
                Console.Error.WriteLine($"Expected result to be 'toe' but was {0}");
                return false;
            }

            return true;
        }
    }

}