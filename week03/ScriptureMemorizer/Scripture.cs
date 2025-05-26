public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, String text)
    {
        _reference = Reference;
       _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        var wordsToHide = _words.Where(word => !word.IsHidden()).ToList();
        Random random = new Random();
        for (int i = 0; i < numberToHide && wordsToHide.Count > 0; i++)
        {
            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index);
        }
            
    
        
    }
    public string GetDisplayText()
    {

        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
        
    }
        
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }



}   