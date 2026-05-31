using System;
using System.Collections.Generic;
using System.Linq;
 
class Reference
{
    private string    _book;
    private int       _chapter;
    private List<int> _verses;
 
    public Reference(string book, int chapter, int verse)
    {
        _book    = book;
        _chapter = chapter;
        _verses  = new List<int> { verse };
    }
 
    public Reference(string book, int chapter, List<int> verses)
    {
        _book    = book;
        _chapter = chapter;
        _verses  = new List<int>(verses);
    }
 
    public void Display()
    {
        if (_verses.Count == 1)
            Console.Write($"{_book} {_chapter}:{_verses[0]}");
        else
            Console.Write($"{_book} {_chapter}:{_verses.First()}-{_verses.Last()}");
    }
}