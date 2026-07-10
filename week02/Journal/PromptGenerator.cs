using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>()
    {
        "What made you happy today?",
        "What did you learn today?",
        "What was the best part of your day?",
        "What challenged you today?",
        "What are you grateful for today?",
        "What scripture verse that you have read today?",
        "What was the moment of spiritual clarity, you have felt today"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

}