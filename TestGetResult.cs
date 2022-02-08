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
            scores2.Add(4);

            List<string> results2 = new List<string>();
            results2.Add("grape");
            results2.Add("strawberry");
            string result2 = Program.GetResult(scores, results);

            //TODO(jcollard 2022-02-05): Missing if statement
            {
                Console.Error.WriteLine($"Expected result to be 'strawberry' but was {0}");
                return false;
            }

            List<int> scores3 = new List<int>();
            // TODO(jcollard 2022-02-05): Try a list with different values than your previous test
            scores3.Add(0);
            scores3.Add(4);

            List<string> results3 = new List<string>();
            results3.Add("soccer");
            results.Add("football");
            string result3 = Program.GetResult(scores, results);
            if (result3 != "football")
            {
                Console.Error.WriteLine($"Expected result to be 'football' but was {0}");
                return false;
            }


            List<int> scores4 = new List<int>();
            // TODO(jcollard 2022-02-05): The length of this list should match the length of the results list.
            scores4.Add(0);
            scores4.Add(4);

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

            
            // You should write another test case with situations that test the nuances of
            // the method.

            return true;
        }
    }

}