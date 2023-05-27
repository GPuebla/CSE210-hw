using System;

class Program
{
    static void Main(string[] args)
    {

        List<Word> words = new List<Word>();

        Word w1 = new Word("Hello");
        Word w2 = new Word("World!");
        Word w3 = new Word("How");
        Word w4 = new Word("are");
        Word w5 = new Word("you?");

        words.Add(w1);
        words.Add(w2);
        words.Add(w3);
        words.Add(w4);
        words.Add(w5);

        foreach (var w in words)
        {
            Console.Write($"{w.GetWord()} ");
        }

        foreach (var w in words)
        {
            w.HideWord();
            Console.Write($"{w.GetWord()} ");
        }
        

    }
}