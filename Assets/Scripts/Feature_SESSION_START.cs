using UnityEngine;
public struct Feature_SESSION_START
{
    // Fields
    private Feature_SESSION_START.EVENT_NAME <EventName>k__BackingField;
    private string <Level>k__BackingField;
    private string <FailCount>k__BackingField;
    
    // Properties
    public Feature_SESSION_START.EVENT_NAME EventName { get; set; }
    public string Level { get; set; }
    public string FailCount { get; set; }
    
    // Methods
    public Feature_SESSION_START.EVENT_NAME get_EventName()
    {
        return (EVENT_NAME)new Feature_SESSION_START();
    }
    public void set_EventName(Feature_SESSION_START.EVENT_NAME value)
    {
        this = value;
    }
    public string get_Level()
    {
        return (string)this.<Level>k__BackingField;
    }
    public void set_Level(string value)
    {
        this.<Level>k__BackingField = value;
    }
    public string get_FailCount()
    {
        return (string)this.<FailCount>k__BackingField;
    }
    public void set_FailCount(string value)
    {
        this.<FailCount>k__BackingField = value;
    }

}
