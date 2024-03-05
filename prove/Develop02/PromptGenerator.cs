public class PromptGenerator
{
    public string[] _prompts;
    public Random _random;

    public PromptGenerator(string[] prompts)
    {
        this._prompts = prompts;
        _random = new Random();
    }
    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Length)];
    }
}