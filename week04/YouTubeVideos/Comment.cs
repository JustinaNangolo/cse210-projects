public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _text = text;
    }

    public string GetCommenterName() => _commenterName;
    public string GetText() => _text;
}