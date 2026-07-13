using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "How to Bake Bread";
        v1._author = "ChefMike";
        v1._length = 720;
        v1._comments.Add(new Comment { _name = "Sara", _text = "This looks amazing!" });
        v1._comments.Add(new Comment { _name = "Tom", _text = "Tried it, turned out great." });
        v1._comments.Add(new Comment { _name = "Priya", _text = "Can I use whole wheat flour?" });
        v1._comments.Add(new Comment { _name = "Ted", _text = "Fake!" });
        videos.Add(v1);

        Video v2 = new Video();
        v2._title = "C# Basics for Beginners";
        v2._author = "CodeWithAnna";
        v2._length = 1500;
        v2._comments.Add(new Comment { _name = "Jake", _text = "Super clear explanation." });
        v2._comments.Add(new Comment { _name = "Lily", _text = "Finally understand classes now." });
        v2._comments.Add(new Comment { _name = "Marcus", _text = "More videos please!" });
        videos.Add(v2);

        Video v3 = new Video();
        v3._title = "Mountain Biking Trail Guide";
        v3._author = "OutdoorDan";
        v3._length = 900;
        v3._comments.Add(new Comment { _name = "Kevin", _text = "That trail looks brutal." });
        v3._comments.Add(new Comment { _name = "Nina", _text = "Great scenery!" });
        v3._comments.Add(new Comment { _name = "Larry", _text = "Are you okay that crash was crazy?" });
        v3._comments.Add(new Comment { _name = "Owen", _text = "What bike do you use?" });
        v3._comments.Add(new Comment { _name = "Jerry", _text = "Ouch!!!" });
        videos.Add(v3);

        Video v4 = new Video();
        v4._title = "10 Minute Home Workout";
        v4._author = "FitWithJess";
        v4._length = 600;
        v4._comments.Add(new Comment { _name = "Chris", _text = "Did this every morning this week." });
        v4._comments.Add(new Comment { _name = "Ana", _text = "Short but tough!" });
        v4._comments.Add(new Comment { _name = "Devon", _text = "Love that no equipment is needed." });
        videos.Add(v4);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}