using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void AddEvent(Entry newEntry) {

        _journal.Add(newEntry);

    }

    public void DisplayJournal() {

        foreach (Entry entry in _journal) {

            entry.DisplayEntry();

        }
    }

    public string SaveToFile(string fileName) {

        using (StreamWriter writer = new StreamWriter(fileName)) {

            foreach (Entry entry in _journal) {

                writer.WriteLine($"Prompt: {entry._prompt} - Memory: {entry._memory} - Date: {entry._date}");

            }
        }

        return fileName;

    }

    public string LoadFile(string fileName) {

        using (StreamReader reader = new StreamReader(fileName)) {
        
            Entry entry = new Entry();
            _journal.Add(entry);

        }
    
        return fileName;

    }

}