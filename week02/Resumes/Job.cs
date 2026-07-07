using System.Security.AccessControl;
using System.Globalization;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        //for capitalize descriptions
        _company = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_company);
        _jobTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_jobTitle);

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}