public class ListingActivity
{
    List<String> QuestionsList = new List<String>();
    List<String> AnswersList = new List<String>();
    List<String> IndexAnswersSelected = new List<String>();

    public ListingActivity()
    {

        
    }

    public void AddAnswers( String answer)
    {
        AnswersList.Add(answer);
    }



}