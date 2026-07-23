using System;

class Program
{
    static void Main(string[] args)
    // Display the details of those videos and comments
    {
        // Video #1  
        Comment _c1 = new Comment();
        _c1._name = "Jack Sparrow";
        _c1._text = "I knew it! it was there all along!";

        Comment _c2 = new Comment();
        _c2._name = "Gold D. Roger";
        _c2._text = "It was mine but now it's yours.";

        Comment _c3 = new Comment();
        _c3._name = "Son Goku";
        _c3._text = "Hey Luffy, can I have some of your fruit?";

        Video v1 = new Video();
        v1._title = "How to find a treasure called One Piece";
        v1._author = "Monkey D. Luffy";
        v1._length = 60;
        v1._videos.Add(v1);
        v1._comments.Add(_c1);
        v1._comments.Add(_c2);
        v1._comments.Add(_c3);
        v1.Display();


        //Video #2
        Comment _2c1 = new Comment();
        _2c1._name = "Judy Hopps";
        _2c1._text = "I tried to do that but it doesn't work with my friend Nick";

        Comment _2c2 = new Comment();
        _2c2._name = "Kurama";
        _2c2._text = "Why did you post that without my permission?";

        Comment _2c3 = new Comment();
        _2c3._name = "Hinata Hyuga";
        _2c3._text = "Wow, you're so awesome, Naruto!";

        Video v2 = new Video();
        v2._title = "How to tame a fox with nine tails";
        v2._author = "Uzumaki Naruto";
        v2._length = 360;
        v2._videos.Add(v2);
        v2._comments.Add(_2c1);
        v2._comments.Add(_2c2);
        v2._comments.Add(_2c3);
        v2.Display();


        //Video #3
        Comment _3c1 = new Comment();
        _3c1._name = "Saitama";
        _3c1._text = "Do you also have a tutorial how to grow hair?";

        Comment _3c2 = new Comment();
        _3c2._name = "Vegeta";
        _3c2._text = "Goku, that only works with us Saiyans";

        Comment _3c3 = new Comment();
        _3c3._name = "Deku";
        _3c3._text = "Thanks, I also want to make my hair yellow like Almight";

        Video v3 = new Video();
        v3._title = "How to color your hair without dyeing it";
        v3._author = "Son Goku";
        v3._length = 45;
        v3._videos.Add(v3);
        v3._comments.Add(_3c1);
        v3._comments.Add(_3c2);
        v3._comments.Add(_3c3);
        v3.Display();


    }
}