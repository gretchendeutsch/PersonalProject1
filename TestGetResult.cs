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
            results.Add("grape");
            results.Add("strawberry");
            string result2 = Program.GetResult(scores, results);
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
            if (result != "strawberry")
            {
                Console.Error.WriteLine($"Expected result to be 'football' but was {0}");
                return false;
            }

            
            

            return false;
        }
    }

}