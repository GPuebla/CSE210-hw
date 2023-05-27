using System;

class Program
{
    static void Main(string[] args)
    {

        List<Word> words = new List<Word>();
        List<Word> words2 = new List<Word>();

        Word w1 = new Word("Hello");
        Word w2 = new Word("World!");
        Word w3 = new Word("How");
        Word w4 = new Word("are");
        Word w5 = new Word("you?");

        Word w6 = new Word("This");
        Word w7 = new Word("is");
        Word w8 = new Word("a");
        Word w9 = new Word("verse");
        Word w10 = new Word("example");


        words2.Add(w1);
        words2.Add(w2);
        words2.Add(w3);
        words2.Add(w4);
        words2.Add(w5);

        words2.Add(w6);
        words2.Add(w7);
        words2.Add(w8);
        words2.Add(w9);
        words2.Add(w10);

        Verse v1 = new Verse(1,"example1",words2);

        do
        {
            Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()}-- {v1.IsAllHidden}");
            Console.ReadLine();
            Console.Clear();
        } while (!v1.IsAllHidden);

        // Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()} -- {v1.IsAllHidden}");
        // Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()} -- {v1.IsAllHidden}");
        // Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()} -- {v1.IsAllHidden}");
        // Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()} -- {v1.IsAllHidden}");
        // Console.WriteLine($"{v1.WriteVerse()}, {v1.GetTotalWordsHide()},{v1.GetTotalWordsVisible()} -- {v1.IsAllHidden}");
    


        // Console.WriteLine(v1.WriteVerse()); 
        // Console.WriteLine(v1.WriteVerse()); 
        // Console.WriteLine(v1.WriteVerse()); 
        // Console.WriteLine(v1.WriteVerse()); 

    }
}