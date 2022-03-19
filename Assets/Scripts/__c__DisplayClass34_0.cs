using UnityEngine;
private sealed class UIIngame.<>c__DisplayClass34_0
{
    // Fields
    public UIIngame <>4__this;
    public string RewardAdPosition;
    
    // Methods
    public UIIngame.<>c__DisplayClass34_0()
    {
    
    }
    internal void <HandleHintWithAds>b__0(AdEvent status)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        AdsManager.isAdShowing = false;
        if((status - 7) < 2)
        {
            goto label_3;
        }
        
        if(status == 1)
        {
            goto label_4;
        }
        
        if(status != 3)
        {
            goto label_18;
        }
        
        val_4 = null;
        val_4 = null;
        AdsManager.latestAdsIsReward = true;
        this.<>4__this.ShowHintWithAds();
        this.<>4__this.isHintRemain = false;
        val_5 = null;
        val_5 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  4.24399158193054E-314);
        AppsflyerHelper.Log(id:  0);
        goto label_18;
        label_3:
        if(Util.InternetConnection() == true)
        {
            goto label_18;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this.<>4__this, eventID:  22, param:  null);
        goto label_18;
        label_4:
        val_6 = null;
        val_6 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  2.12199579096527E-314);
        label_18:
        this.<>4__this.HandleBtnHintInteractable();
    }
    internal void <HandleHintWithAds>b__1(AdEvent status)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        AdsManager.isAdShowing = false;
        if((status - 7) < 2)
        {
            goto label_3;
        }
        
        if(status == 1)
        {
            goto label_4;
        }
        
        if(status != 3)
        {
            goto label_18;
        }
        
        val_4 = null;
        val_4 = null;
        AdsManager.latestAdsIsReward = true;
        this.<>4__this.ShowHintWithAds();
        this.<>4__this.isHintRemain = false;
        val_5 = null;
        val_5 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  4.24399158193054E-314);
        AppsflyerHelper.Log(id:  1);
        goto label_18;
        label_3:
        if(Util.InternetConnection() == true)
        {
            goto label_18;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this.<>4__this, eventID:  22, param:  null);
        goto label_18;
        label_4:
        val_6 = null;
        val_6 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  2.12199579096527E-314);
        label_18:
        this.<>4__this.HandleBtnHintInteractable();
    }

}
