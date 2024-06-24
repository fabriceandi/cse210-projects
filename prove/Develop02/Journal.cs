using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry e in _entries)
        {
            e.Display();
        }
    }   
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {   
            foreach(Entry e in _entries)
            {
                  outputFile.WriteLine($"{e._date}|{e._hour}|{e._promptText}|{e._entryText}");
            }
        } 
    } 
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            Entry anEntry = new Entry();
            anEntry._date = parts[0];
            anEntry._hour = parts[1];
            anEntry._promptText = parts[2];
            anEntry._entryText = parts[3];
            _entries.Add(anEntry);
        }  
    }
}
