using System;
using System.Collections.Generic;
using System.Linq;
 
class Scripture
{
    private List<Word> _scriptText;
    private Reference  _Reference;
    private Random     _random = new Random();
 
    public Scripture(string text, string book, int chapter, int verse)
    {
        _Reference  = new Reference(book, chapter, verse);
        _scriptText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(w => new Word(w))
                          .ToList();
    }
 
    public Scripture(string text, string book, int chapter, List<int> verses)
    {
        _Reference  = new Reference(book, chapter, verses);
        _scriptText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(w => new Word(w))
                          .ToList();
    }
 
    public void HideWords(int count)
    {
        List<Word> visible = _scriptText.Where(w => w.IsVisible()).ToList();
 
        int toHide = Math.Min(count, visible.Count);
        for (int i = visible.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            (visible[i], visible[j]) = (visible[j], visible[i]);
        }
        for (int i = 0; i < toHide; i++)
            visible[i].Hide();
    }
 
    public void ShowWords()
    {
        foreach (Word w in _scriptText)
            w.Show();
    }
 
    public void Display()
    {
        _Reference.Display();
        Console.WriteLine();
        for (int i = 0; i < _scriptText.Count; i++)
        {
            _scriptText[i].DisplayText();
            if (i < _scriptText.Count - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
 
    public bool IsCompletelyHidden() => _scriptText.All(w => !w.IsVisible());
}
 