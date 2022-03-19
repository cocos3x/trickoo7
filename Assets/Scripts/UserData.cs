using UnityEngine;
[Serializable]
public class UserData
{
    // Fields
    private bool _isRemovedAds;
    private int _brainPoint;
    private int _currentIndexReward;
    private string _dayReceiveDailyReward;
    private string _dayOpenApp;
    private bool _isReceivedDailyReward;
    private bool _isLockCheckIndex;
    
    // Properties
    public bool isRemovedAds { get; set; }
    public int brainPoint { get; set; }
    public int currentIndexReward { get; set; }
    public string dayReceiveDailyReward { get; set; }
    public string dayOpenApp { get; set; }
    public bool isReceivedDailyReward { get; set; }
    public bool isLockCheckIndex { get; set; }
    
    // Methods
    public bool get_isRemovedAds()
    {
        return (bool)this._isRemovedAds;
    }
    public void set_isRemovedAds(bool value)
    {
        var val_1 = (this._isRemovedAds == true) ? 1 : 0;
        val_1 = val_1 ^ value;
        if(val_1 == false)
        {
                return;
        }
        
        this._isRemovedAds = value;
        AdsManager.UpdateBannerArea();
    }
    public int get_brainPoint()
    {
        return (int)this._brainPoint;
    }
    public void set_brainPoint(int value)
    {
        this._brainPoint = value;
    }
    public int get_currentIndexReward()
    {
        return (int)this._currentIndexReward;
    }
    public void set_currentIndexReward(int value)
    {
        this._currentIndexReward = value;
    }
    public string get_dayReceiveDailyReward()
    {
        return (string)this._dayReceiveDailyReward;
    }
    public void set_dayReceiveDailyReward(string value)
    {
        this._dayReceiveDailyReward = value;
    }
    public string get_dayOpenApp()
    {
        return (string)this._dayOpenApp;
    }
    public void set_dayOpenApp(string value)
    {
        this._dayOpenApp = value;
    }
    public bool get_isReceivedDailyReward()
    {
        return (bool)this._isReceivedDailyReward;
    }
    public void set_isReceivedDailyReward(bool value)
    {
        this._isReceivedDailyReward = value;
    }
    public bool get_isLockCheckIndex()
    {
        return (bool)this._isLockCheckIndex;
    }
    public void set_isLockCheckIndex(bool value)
    {
        this._isLockCheckIndex = value;
    }
    public UserData()
    {
        this._currentIndexReward = 0;
        this._dayReceiveDailyReward = "";
        this._dayOpenApp = "";
    }

}
