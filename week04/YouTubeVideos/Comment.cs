using System;
using System.Collections.Generic;

public class Comment
{
    // track names of the comment and the text from the comment
    public string _name;
    public string _text;

    public void DisplayComments()
    {
        Console.WriteLine($"> {_name}: {_text}");

    }


}

