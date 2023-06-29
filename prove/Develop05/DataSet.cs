public class DataSet
{
    private List<Goal> goals = new List<Goal>();
    private String _fileNameToSave;
    private bool _isUpdated = true;
    private int _score;
    
 
    public void SaveData()
    {   
        Console.WriteLine("Insert the name of the file where your data will be saved");
        String name = Console.ReadLine();

        _fileNameToSave = $"{name}.txt";
        
        using (StreamWriter outputFile = new StreamWriter(_fileNameToSave))
        {
            
            outputFile.WriteLine(_score);

            for (int i = 0; i < goals.Count(); i++)
            {
                outputFile.WriteLine(goals[i].ConcatenateAttribute());
            }
        }
    }

    public void ReadData(String fileName)
    {
        String name = "";
        String description = "";
        int points = 0;
        bool isgoalAchieved = false;
        int bonus = 0;
        int timeToAchieve = 0;
        int timeAcomplished = 0;
        int score = 0;

        string filename =$"{fileName}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;


            foreach (string line in lines)
            {
                i++;
                string[] parts = line.Split("**");
                String colum1Value = parts[0];

                if(parts.Count() == 6)
                {
                   name = parts[1];
                   description = parts[2];
                   points = int.Parse(parts[3]);
                   isgoalAchieved = bool.Parse(parts[4]);
                   score = int.Parse(parts[5]);

                }
                if(parts.Count() == 9)
                {
                   name = parts[1];
                   description = parts[2];
                   points = int.Parse(parts[3]);
                   bonus = int.Parse(parts[4]);
                   timeAcomplished = int.Parse(parts[6]);
                   timeToAchieve = int.Parse(parts[5]);
                   isgoalAchieved = bool.Parse(parts[7]);
                }


                if(i==1)
                {
                    _score = int.Parse(colum1Value);
                }
                else
                {
                    if(colum1Value == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(name,description,points,isgoalAchieved,score));
                    }
                    else if(colum1Value == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(name,description,points,isgoalAchieved,score));
                    }
                    else if(colum1Value == "CheckListGoal")
                    {
                        goals.Add(new CheckListGoal(name,description,points,bonus,timeToAchieve,timeAcomplished,isgoalAchieved,score));
                    }
                }
                
            }
    }

    public void DisplayGoalList()
    {
        updateScore();
        Console.WriteLine("\n------------------------------------ List of Goals: ------------------------------------ ");
        Console.WriteLine($"Total Score: {_score}\n");
        int i = 1;
        foreach (var goal in goals)
        {   
            goal.CheckIfIsAcomplished();
            Console.WriteLine($"{i}. {goal.GetInfo()}");
            i++;
        }   
    }

    public void AddGoal(Goal g)
    {
        goals.Add(g);
    }

    public List<Goal> GetGoalList()
    {
        return goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public void updateScore()
    {
        int totalScore = 0;

        foreach (var goal in goals)
        {
           totalScore += goal.GetScore();
        }

        _score = totalScore;
    }


}