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
            if( result != "Bob the Builder")
            {
                Console.Error.WriteLine($"Expected result to be 'Bob the Builder' but was {0}");
                return false; 
            }

            List<int> scores = new List<int>();
            scores.Add(1);
            scores.Add(3);

            List<string> results = new List<string>();
            results.Add("Fruit");
            results.Add("Chocolate");
            string result = Program.GetResult(scores, results);
            if( result != "Bob the Builder")
            {
                Console.Error.WriteLine($"Expected result to be 'Chocolate' but was {1}");
                return false; 
            }
            

            // List<string> score = Program.GetResult("text_scores.txt").ToList();

            // Score testscore = new Score();

            // score[highestIx] = 0;
            // score.initial = new score.highest; 

            // Result score.highest = new Result();
            // // initialize highest score to be 0


            // return results[highestIx];
            return false;
        }
    }

}