using UnityEngine;
public struct Feature_LEVEL_STATUS
{
    // Fields
    private Feature_LEVEL_STATUS.EVENT_NAME <EventName>k__BackingField;
    private string <Level>k__BackingField;
    private string <FailCount>k__BackingField;
    private Feature_LEVEL_STATUS.USE_HINT <UseHint>k__BackingField;
    
    // Properties
    public Feature_LEVEL_STATUS.EVENT_NAME EventName { get; set; }
    public string Level { get; set; }
    public string FailCount { get; set; }
    public Feature_LEVEL_STATUS.USE_HINT UseHint { get; set; }
    
    // Methods
    public Feature_LEVEL_STATUS.EVENT_NAME get_EventName()
    {
        return (EVENT_NAME)new Feature_LEVEL_STATUS();
    }
    public void set_EventName(Feature_LEVEL_STATUS.EVENT_NAME value)
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
    public Feature_LEVEL_STATUS.USE_HINT get_UseHint()
    {
        return (USE_HINT)this.<UseHint>k__BackingField;
    }
    public void set_UseHint(Feature_LEVEL_STATUS.USE_HINT value)
    {
        this.<UseHint>k__BackingField = value;
    }

}
