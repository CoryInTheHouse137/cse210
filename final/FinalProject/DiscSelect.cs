public class DiscSelect
{

    private string _driver;
    private string _midrange;
    private string _putter;
    private string _stability;

    public void Driver(string driver, string stability)
    {
        _driver = driver;
        _stability = stability;
    }

    public void Midrange(string midrange, string stability1)
    {
        _midrange = midrange;
        _stability = stability1;
    }

    public void Putter(string putter,string stability2)
    {
        _putter = putter;
        _stability = stability2;
    }



}