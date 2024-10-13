public class Entry
{
    
    public string _userEntry{ get; set; }
    public DateTime _timeStamp{ get; set; }

    public Entry(string arg_userEntry)
    {
        _userEntry = arg_userEntry;

        _timeStamp = DateTime.Now; //captures time of entry
    }





}