using System.Collections.Concurrent;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    
    private int _endVerse;

    public Reference(string book, int charpter, int verse)
    {
        _book = book;
        _chapter = charpter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int charpter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = charpter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        
        return _verse == _endVerse ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";
        
        
    }
}
