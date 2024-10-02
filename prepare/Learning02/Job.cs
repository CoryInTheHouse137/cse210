public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} \nCompany: {_company} \n{_startYear} - {_endYear}");
    }

}