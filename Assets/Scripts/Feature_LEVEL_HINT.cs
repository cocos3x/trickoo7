using UnityEngine;
public struct Feature_LEVEL_HINT
{
    // Fields
    private Feature_LEVEL_HINT.EVENT_NAME <EventName>k__BackingField;
    private string <Level>k__BackingField;
    
    // Properties
    public Feature_LEVEL_HINT.EVENT_NAME EventName { get; set; }
    public string Level { get; set; }
    
    // Methods
    public Feature_LEVEL_HINT.EVENT_NAME get_EventName()
    {
        return (EVENT_NAME)new Feature_LEVEL_HINT();
    }
    public void set_EventName(Feature_LEVEL_HINT.EVENT_NAME value)
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

}
