using task;


List<Question> questions = new List<Question>
{
new Question{Id=1,
    question= "What's the capital of Jordan?", 
    answers= new string[4]{"Amman", "Petra","Aqaba","Jerash"}, 
    CorrectAnswer="Amman" },
new Question{Id=2,
    question= "What's the capital capital of Lebanon?",
    answers= new string[4]{ "Tripoli", "Beirut", "Sidon", "Baalbek"},
    CorrectAnswer="Beirut" },
new Question{Id=3,
    question= "What's the capital of Egypt?",
    answers= new string[4]{ "Cairo", "Alexandria", "Luxor", " Aswan"},
    CorrectAnswer="Cairo" },

};

int score = 0;
foreach (var ques in questions)
{
    Console.WriteLine($"the question {ques.Id}");
    Console.WriteLine("-" + ques.question);
    foreach (var item in ques.answers)
    {
        Console.WriteLine("-" + item);
    }
    Console.WriteLine($"Enter the Correct Answer");
    string Answer = Console.ReadLine();

    string correct = ques.CorrectAnswer == Answer ? $"Correct Answer" : $"Incorrect answer \nThe Correct Answer is {ques.CorrectAnswer}";
    Console.WriteLine(correct);

    int updateScore = ques.CorrectAnswer == Answer ? score++ : score;
    Console.WriteLine("the score is " + score);

    Console.WriteLine("////////////////////////////////////////////////////////");
}
Console.WriteLine("The Total Score is  " + score);
