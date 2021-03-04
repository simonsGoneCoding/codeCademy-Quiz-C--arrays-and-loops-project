using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            // Tools.SetUpInputStream(entry);

            /* ------ Setup Arrays ------ */
            string[] questions = { "Sun is closest to Earth in January.", "Merkury is the hottest planet in our solar system.", "The universe is 13.8 billion years old." };

            bool[] answers = { true, false, true };
            bool[] responses = new bool[questions.Length];

            if(questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! questions and answers arrays are not equal in length");
            }


            /* ------- Ask Questions ------ */
            int askingIndex = 0; 

            foreach(string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("true or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            /* check responses
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }
            */

            /*----- Calculate Score ------*/
            int scoringIndex = 0;
            int score = 0; 

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
                if(response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");

        }
    }
}