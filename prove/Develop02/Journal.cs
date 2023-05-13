using System;

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void addingNewEntry( Entry entry)
    {
        entries.Add(entry);
    }

    public void displayAllEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.getEntry());
        }
    }

    public void savingFile( String fileName )
    {
        Console.WriteLine("savingFile without code");
    }

    public void LoadFile( String fileName )
    {
        Console.WriteLine("loadFile without code");
    }
}