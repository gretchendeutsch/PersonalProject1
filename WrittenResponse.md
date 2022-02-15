# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.


A person would run my program to find out what character they are most like for entertainment. 

**TODO: Complete this section**

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can perform a personality quiz. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

For each question, the program accepts user input in the form of numbers from the keyboard, which are correlated to different answers to questions. The player enters their answer and hits enter. Then after the few questions, it outputs their result personality based on their answer choices. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (int score in scores)
            {
                if (score > largestScore)
                {

                    result = results[ix];
                    largestScore = scores[ix];
                }
                ix = ix + 1;
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {scores}.

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the different scores for each of the options the user selects. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity because it easily allows me to add more questions to my personality quiz without having to add more code. Otherwise, I would have to create additional variables each time I wanted to add a new question. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int GetValidAnswer(List<string> answers)
        {
            if (answers.Count == 0)
            {
                throw new Exception("Unable to get a answer for a list of 0.");
            }
            int userChoice;

            do
            {
                Console.WriteLine("Enter a number greater than 0:");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number");
                }
                else if (userChoice <= 0 || userChoice > answers.Count)
                {
                    Console.Error.WriteLine($"That number is not greater than 0 or less than {answers.Count}.");
                }
            }
            while (userChoice <= 0 || userChoice > answers.Count);
            return -1 
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
return GetValidAnswer(q.answers);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

The GetValidAnswer method validates that there is at least one possible answer 
and prompts the user to answer the question. 


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

 1. ensure that there is one possible answer[answer.Length<1]
 2. throw new exception("Must have at least one answer.")
 3. Display $"Select an option 1 to {answer.Length}"
 4. store the response [int choice = int.Parse(ReadLine())]
 5. validate the choice is one of possible answers given[choice > 0 AND choice <= answers.Length]
 6. return choice if yes
 7. if no, Display error message: "Invalid choice", then go to number 3

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

GetValidAnswer(null);

Second call:

List<string> answers3 = new List<string>();

            answers3.Add("cry");
            answers3.Add("burp");
            answers3.Add("die");

            
            Console.WriteLine("You should expect to see 3 options: cry, burp, and die. Enter 6. This should produce an invalid response. Then enter 2.");

            int result3 = Program.GetValidAnswer(answers3); 

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

This tests that the method will fail when the input is null by throwing an exception.

Condition(s) tested by the second call:

This will test that the method will run when the input is not null. 

### 3d iii.

Result of the first call:

The result is an exception is thrown

Result of the second call:

The result is an answers being displayed and prompting the user to enter their answer. 