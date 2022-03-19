using UnityEngine;
private sealed class AppOpenAdManager.<>c__DisplayClass15_0
{
    // Fields
    public AppOpenAdManager <>4__this;
    public System.Action _callback;
    
    // Methods
    public AppOpenAdManager.<>c__DisplayClass15_0()
    {
    
    }
    internal void <LoadAd>b__0(GoogleMobileAds.Api.AppOpenAd appOpenAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs error)
    {
        if(error != null)
        {
                object[] val_1 = new object[1];
            val_1[0] = error.<LoadAdError>k__BackingField.GetMessage();
            UnityEngine.Debug.LogFormat(format:  "Failed to load the ad. (reason: {0})", args:  val_1);
            return;
        }
        
        this.<>4__this.ad = appOpenAd;
        if(this._callback == null)
        {
                return;
        }
        
        this._callback.Invoke();
    }

}
