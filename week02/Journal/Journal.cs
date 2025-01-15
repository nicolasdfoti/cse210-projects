using System.IO;
using System.Security.Cryptography.X509Certificates;

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

            string line;

            while ((line = reader.ReadLine()) != null) {

                string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);

                if (parts.Length == 3) {

                    Entry entry = new Entry
                    {
                        _prompt = parts[0].Replace("Prompt: ", "").Trim(),
                        _memory = parts[1].Replace("Memory: ", "").Trim(),
                        _date = parts[2].Replace("Date: ", "").Trim()
                    };

                    _journal.Add(entry);
                }
            }
        }

        return fileName;
        
    }
}