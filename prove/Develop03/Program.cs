using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {


        List<String> _verses = new List<String>();
        List<String> _verses2 = new List<String>();
        
        _verses.Add("Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding.");
        _verses.Add("In all thy ways acknowledge him, and he shall bdirect thy cpaths.");
        _verses2.Add("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Scripture s1 = new Scripture("Proverbs 3:5-6",_verses);
        Scripture s2 = new Scripture("1 Nephi 3:7",_verses2);

        // ShowScripture(s1);
        // ShowScripture(s2);
        

        DataSet d1 = new DataSet();

        for (int i = 0; i < d1.GetRefList().Count(); i++)
        {
            Console.Write(d1.GetRefList().[i]);
            Console.Write(d1.GetVerse_numList()[i]);
            Console.Write(d1.GetVerse_textList()[i]);
            Console.WriteLine(" ");
        }


        static void ShowScripture(Scripture s)
        {
            while (!s.IsAllVersesHidden)
            {
                Console.WriteLine($"{s.GetVerses()}");

                String answer = Console.ReadLine();
                    if(answer == "quit")
                    {
                        break;
                    }
                Console.Clear();
            }
        }

    }
}