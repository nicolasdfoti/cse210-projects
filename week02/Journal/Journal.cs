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

}