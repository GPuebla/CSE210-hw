public class ReflectionActivity : Activity
{
    List<String> QuestionsList = new List<String>();
    List<String> PromptList = new List<String>();
    List<int> IndexAnswersSelected = new List<int>();

    private String _prompt;

    public ReflectionActivity()
    {
        PromptList.Add("Think of a time when you stood up for someone else");
        PromptList.Add("Think of a time when you did something really difficult.");
        PromptList.Add("Think of a time when you helped someone in need.");
        PromptList.Add("Think of a time when you did something truly selfless.");

        QuestionsList.Add("Why was this experience meaningful to you?");
        QuestionsList.Add("Have you ever done anything like this before?");
        QuestionsList.Add("How did you get started?");
        QuestionsList.Add("How did you feel when it was complete?");
        QuestionsList.Add("What made this time different than other times when you were not as successful?");
        QuestionsList.Add("What is your favorite thing about this experience?");
        QuestionsList.Add("What could you learn from this experience that applies to other situations?");
        QuestionsList.Add("What did you learn about yourself through this experience?");
        QuestionsList.Add("How can you keep this experience in mind in the future?");
        
        SetNameActivity("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void DisplayPrompt()
    {
        int index;
        bool isIndexSelected = false;

        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation(5);
        Console.WriteLine("\nConsider the following prompt:");

        do
        {
           List<string> Choose = new List<string>(ChooseRandomListElement( PromptList ));
           index = int.Parse(Choose[1]);

           if(!IndexAnswersSelected.Contains(index))
           {
                _prompt = Choose[0];
                IndexAnswersSelected.Add(index);
                isIndexSelected = true;
           }
           
        } while (isIndexSelected == false || !(IndexAnswersSelected.Count == PromptList.Count));

        Console.WriteLine($"--- {_prompt} ----");

        Console.WriteLine($"When you have something in mind, press enter to continue.");

        if (IndexAnswersSelected.Count == PromptList.Count)
        {
            IndexAnswersSelected.Clear();
        }
            
    }

    



}