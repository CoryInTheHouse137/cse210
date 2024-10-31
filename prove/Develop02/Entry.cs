public class Entry
{
    
    public string _userEntry;
    public DateTime _timeStamp;

    public string _promptHolder;

    public Entry(string arg_userEntry, string arg_promptHolder)
    {

        _userEntry = arg_userEntry;

        _promptHolder = arg_promptHolder;

        _timeStamp = DateTime.Now; //captures time of entry
    }





}