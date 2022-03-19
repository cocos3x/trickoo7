using UnityEngine;
public struct STATUS_ADS_INTER_LOAD
{
    // Fields
    private STATUS_ADS_INTER_LOAD.EVENT_NAME <EventName>k__BackingField;
    private STATUS_ADS_INTER_LOAD.STATUS_RESULT <AdsStatus>k__BackingField;
    
    // Properties
    public STATUS_ADS_INTER_LOAD.EVENT_NAME EventName { get; set; }
    public STATUS_ADS_INTER_LOAD.STATUS_RESULT AdsStatus { get; set; }
    
    // Methods
    public STATUS_ADS_INTER_LOAD.EVENT_NAME get_EventName()
    {
        return (EVENT_NAME)new STATUS_ADS_INTER_LOAD();
    }
    public void set_EventName(STATUS_ADS_INTER_LOAD.EVENT_NAME value)
    {
        this = value;
    }
    public STATUS_ADS_INTER_LOAD.STATUS_RESULT get_AdsStatus()
    {
        return (STATUS_RESULT)this.<AdsStatus>k__BackingField;
    }
    public void set_AdsStatus(STATUS_ADS_INTER_LOAD.STATUS_RESULT value)
    {
        this.<AdsStatus>k__BackingField = value;
    }

}
