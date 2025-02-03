public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string name = GetName();
        string topic = GetTopic();

        return $"{name} - {topic} - {_title}";
    }
}