public class ListingActivity:Activity
{
    List<String> QuestionsList = new List<String>();
    List<String> AnswersList = new List<String>();
    List<String> IndexAnswersSelected = new List<String>();

    public ListingActivity()
    {
        QuestionsList.Add("Who are people that you appreciate?");
        QuestionsList.Add("What are personal strengths of yours?");
        QuestionsList.Add("Who are people that you have helped this week?");
        QuestionsList.Add("When have you felt the Holy Ghost this month?");
        QuestionsList.Add("Who are some of your personal heroes?");
        
        SetNameActivity("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void AddAnswers( String answer)
    {
        AnswersList.Add(answer);
    }

    public void DisplayPromptQuestions()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation(5);
        Console.WriteLine("\nList as many responses you can to the following prompt: \n");


        List<string> Choose = new List<string>(ChooseRandomListElement( QuestionsList ));

        Console.WriteLine($"--- {Choose[0]} ----");
        Console.Write($"Yoy may begin in: \n");
        ShowCountdown(5);

        for (int i = 0; i < GetTimeDuration() ; i ++)
        {
            Console.Write("> ");
            AnswersList.Add(Console.ReadLine());
            i += 4;
        }
        
        Console.WriteLine($"You listed {AnswersList.Count} items");
        ShowSpinnerAnimation(5);

    }



}