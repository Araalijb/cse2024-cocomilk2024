public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date;
    public string _location;

    public Entry(string prompt, string response, string location)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
        _location = location; 
    }

    public override string ToString()
    {
        return $"{_location} {_date} {_prompt}: {_response}";
    }
} 