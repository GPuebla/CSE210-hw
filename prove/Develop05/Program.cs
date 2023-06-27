using System;

class Program
{
    static void Main(string[] args)
    {
        DataSet dataset = new DataSet();

        // SimpleGoal sGoal1 = new SimpleGoal("Simple Goal Example 1","This goal, is just an example",30);
        // EternalGoal eGoal1 = new EternalGoal("Eternal Goal Example 1","This goal, is just an example",15);
        // CheckListGoal cGoal1 = new CheckListGoal("CheckList Goal Example 1","This goal, is just an example",50,500,5);

        // List<Goal> goals = new List<Goal>();
        // goals.Add(new SimpleGoal("Simple Goal Example 2","This goal, is just an example 2",50));
        // // goals.Add(eGoal1);
        // // goals.Add(cGoal1);

        // Console.WriteLine($"Total de Goals: {dataset.GetGoalList().Count()}");

        // dataset.ReadData("my_goal");

        // goals.AddRange(dataset.GetGoalList());

        
        // // dataset.AddGoal(sGoal1);
        // // dataset.AddGoal(eGoal1);
        // // dataset.AddGoal(cGoal1);

        // Console.WriteLine($"Total de Goals: {dataset.GetGoalList().Count()}");

        // foreach (var goal in dataset.GetGoalList())
        // {
        //     Console.WriteLine($"{goal.ConcatenateAttribute()}");
        // } 

        // Console.WriteLine(dataset.GetScore());

        // dataset.AddGoal(new SimpleGoal("Simple Goal Example 2","This goal, is just an example 2",50));

        // dataset.SaveData();

        DisplayMenu(dataset);


    }

    public static void DisplayMenu(DataSet d)
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                // Console.Clear();
                Console.WriteLine(" \n-------------------------------------- Menu Options: -------------------------------------- ");
                Console.WriteLine("\n1) Creat New Goal. \n2) List Goals. \n3) Save Goals. \n4) Load Goals. \n5) Record Event. \n6) Quit.");
                Console.Write(" \n Please, select the option number that you want: ");
                menuOption = int.Parse(Console.ReadLine());
                // Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  
                    Console.WriteLine("Option 1");
                    CreatNewGoal(d);

                    break;
                case 2:
                    defaultMode = false;
                    d.DisplayGoalList();
                    
                    break;
                case 3:
                    defaultMode = false;
                    d.SaveData();

                    break;
                case 4:
                    defaultMode = false;
                    Console.Write("Insert the name of the file you want to upload: ");
                    d.ReadData(Console.ReadLine());
                    
                    break;
                case 5:
                    defaultMode = false;
                    d.DisplayGoalList();
                    Console.Write("Which goal did you accomplish? ");
                    int choose = int.Parse(Console.ReadLine());

                    Goal goalChoose = d.GetGoalList()[choose-1];
                    goalChoose.IncreaseScore();

                    Console.Write($"\nCongratulations! You have earned {goalChoose.GetValueOfPoints()} points!\n");
                    
                    break;
                case 6:
                    defaultMode = false;
                    Console.WriteLine("Thank you for using this program");
                    
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                      Console.WriteLine("The entered character isn't found among the options. Try again: ");
                      menuOption = int.Parse(Console.ReadLine());  

                      if (menuOption >0 && menuOption < 6)
                      {
                        break;
                      }

                      if(i==2)
                      {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                      }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 6);

    }

    public static void CreatNewGoal(DataSet d)
    {
        bool defaultMode = false; 
        int menuOption = 0;
        
        do
        {   
            if(!defaultMode)
            {   
                Console.Clear();
                Console.WriteLine(" -------------------------------------- The types of goals are: -------------------------------------- ");
                Console.WriteLine("\n1) Simple Goal. \n2) Eternal Goal. \n3) Checklist Goal.");
                Console.Write("\nWhich type of goal would you like to creat? ");
                menuOption = int.Parse(Console.ReadLine());
            }
            
            switch (menuOption)
            {
                case 1:
                    defaultMode = false;  
                    
                    List<String> info = GetGoalInfomation(1);
                    d.AddGoal(new SimpleGoal(info[0],info[1],int.Parse(info[2])));
                    
                    
                    
                    menuOption= -1;
                    break;
                case 2:
                    defaultMode = false;
                    
                    List<String> info2 = GetGoalInfomation(1);
                    d.AddGoal(new EternalGoal(info2[0],info2[1],int.Parse(info2[2])));
                    
                    menuOption= -1;
                    break;
                case 3:
                    defaultMode = false;
                    
                    List<String> info3 = GetGoalInfomation(2);
                    d.AddGoal(new CheckListGoal(info3[0],info3[1],int.Parse(info3[2]),int.Parse(info3[4]),int.Parse(info3[3])));
                    
                    menuOption= -1;
                    break;
                default:
                    defaultMode = true;
                    for (int i = 0; i < 3; i++)
                    {
                      Console.WriteLine("The entered character isn't found among the options. Try again: ");
                      menuOption = int.Parse(Console.ReadLine());  

                      if (menuOption >0 && menuOption < 4)
                      {
                        break;
                      }

                      if(i==2)
                      {
                        Console.WriteLine("Sorry, your attempts have been exhausted.");
                      }
                    }
                    break;
            }

        } while (menuOption >0 && menuOption < 4);

    }

    public static List<String> GetGoalInfomation(int typeOfGoal)
    {
        List<String> information = new List<string>();
        
        Console.Write("What is the name of your goal? ");
        information.Add(Console.ReadLine());
        Console.Write("What is a short description of it? ");
        information.Add(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        information.Add(Console.ReadLine());

        if(typeOfGoal == 2)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            information.Add(Console.ReadLine());
            Console.Write("What is the bonus for the accomplishing it that many times? ");
            information.Add(Console.ReadLine());
        }

        return information;
    }

    public static void DisplayGoals(Goal g)
    {
        g.IncreaseScore();
        Console.WriteLine($"{g.ConcatenateAttribute()} // Score: {g.GetScore()}");
        Console.WriteLine("----------------------------------------------------------------------------\n");
    }
}