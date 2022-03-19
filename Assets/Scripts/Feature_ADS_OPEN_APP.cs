using UnityEngine;
public struct Feature_ADS_OPEN_APP
{
    // Fields
    private Feature_ADS_OPEN_APP.EVENT_NAME <EventName>k__BackingField;
    private Feature_ADS_OPEN_APP.STATUS_RESULT <AdsStatus>k__BackingField;
    private string <AdsPosition>k__BackingField;
    
    // Properties
    public Feature_ADS_OPEN_APP.EVENT_NAME EventName { get; set; }
    public Feature_ADS_OPEN_APP.STATUS_RESULT AdsStatus { get; set; }
    public string AdsPosition { get; set; }
    
    // Methods
    public Feature_ADS_OPEN_APP.EVENT_NAME get_EventName()
    {
        return (EVENT_NAME)new Feature_ADS_OPEN_APP();
    }
    public void set_EventName(Feature_ADS_OPEN_APP.EVENT_NAME value)
    {
        this = value;
    }
    public Feature_ADS_OPEN_APP.STATUS_RESULT get_AdsStatus()
    {
        return (STATUS_RESULT)this.<AdsStatus>k__BackingField;
    }
    public void set_AdsStatus(Feature_ADS_OPEN_APP.STATUS_RESULT value)
    {
        this.<AdsStatus>k__BackingField = value;
    }
    public string get_AdsPosition()
    {
        return (string)this.<AdsPosition>k__BackingField;
    }
    public void set_AdsPosition(string value)
    {
        this.<AdsPosition>k__BackingField = value;
    }

}
