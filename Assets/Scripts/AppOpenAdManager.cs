using UnityEngine;
public class AppOpenAdManager : MonoBehaviour
{
    // Fields
    private const string AD_UNIT_ID = "ca-app-pub-9819920607806935/6798296380";
    private static AppOpenAdManager instance;
    private GoogleMobileAds.Api.AppOpenAd ad;
    private bool isShowingAd;
    public string adsPosition;
    private System.DateTime pauseTime;
    private bool skipOnApplicationPause;
    private System.DateTime startLoad;
    private System.Action callbackShowAds;
    
    // Properties
    public static AppOpenAdManager Instance { get; }
    public bool IsAdAvailable { get; }
    
    // Methods
    public static AppOpenAdManager get_Instance()
    {
        AppOpenAdManager val_3 = AppOpenAdManager.instance;
        if(val_3 != 0)
        {
                return (AppOpenAdManager)AppOpenAdManager.instance;
        }
        
        AppOpenAdManager val_2 = null;
        val_3 = val_2;
        .skipOnApplicationPause = true;
        val_2 = new AppOpenAdManager();
        AppOpenAdManager.instance = val_3;
        return (AppOpenAdManager)AppOpenAdManager.instance;
    }
    public bool get_IsAdAvailable()
    {
        return (bool)(this.ad != 0) ? 1 : 0;
    }
    private void Awake()
    {
        var val_2;
        System.Action<GoogleMobileAds.Api.InitializationStatus> val_4;
        AppOpenAdManager.instance = this;
        val_2 = null;
        val_2 = null;
        val_4 = AppOpenAdManager.<>c.<>9__11_0;
        if(val_4 == null)
        {
                System.Action<GoogleMobileAds.Api.InitializationStatus> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action<GoogleMobileAds.Api.InitializationStatus>(object:  AppOpenAdManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AppOpenAdManager.<>c::<Awake>b__11_0(GoogleMobileAds.Api.InitializationStatus initStatus));
            AppOpenAdManager.<>c.<>9__11_0 = val_4;
        }
        
        GoogleMobileAds.Api.MobileAds.Initialize(initCompleteAction:  val_1);
        this.LoadAd(_callback:  0);
    }
    private void OnApplicationPause(bool pause)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = this;
        if(pause != false)
        {
                System.DateTime val_1 = System.DateTime.Now;
            this.pauseTime = val_1;
            return;
        }
        
        if(this.skipOnApplicationPause != false)
        {
                this.skipOnApplicationPause = false;
            return;
        }
        
        System.DateTime val_2 = System.DateTime.Now;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_2.dateData}, d2:  new System.DateTime() {dateData = this.pauseTime});
        DataManager val_5 = LazySingleton<DataManager>.Instance;
        if(val_3._ticks.TotalSeconds >= (double)val_5.gameConfig.timePlayToShowAds)
        {
                val_7 = null;
            val_7 = null;
            if(AdsManager.isShowCheckAOA != true)
        {
                this.CheckThenShow();
        }
        
        }
        
        val_6 = 1152921504875589632;
        val_8 = null;
        val_8 = null;
        AdsManager.isShowCheckAOA = false;
    }
    private void CheckThenShow()
    {
        this.adsPosition = "application_pause";
        this.ShowAdIfAvailable(callback:  0);
    }
    public void LoadAd(System.Action _callback)
    {
        .<>4__this = this;
        ._callback = _callback;
        System.DateTime val_2 = System.DateTime.Now;
        UnityEngine.Debug.Log(message:  "[AOA] start load: "("[AOA] start load: ") + val_2);
        System.DateTime val_4 = System.DateTime.Now;
        this.startLoad = val_4;
        GoogleMobileAds.Api.AppOpenAd.LoadAd(adUnitID:  "ca-app-pub-9819920607806935/6798296380", orientation:  1, request:  new AdRequest.Builder().Build(), adLoadCallback:  new System.Action<GoogleMobileAds.Api.AppOpenAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs>(object:  new AppOpenAdManager.<>c__DisplayClass15_0(), method:  System.Void AppOpenAdManager.<>c__DisplayClass15_0::<LoadAd>b__0(GoogleMobileAds.Api.AppOpenAd appOpenAd, GoogleMobileAds.Api.AdFailedToLoadEventArgs error)));
    }
    public void ShowAdIfAvailable(System.Action callback)
    {
        UnityEngine.Object val_15 = LazySingleton<DataManager>.Instance;
        if(val_15 == 0)
        {
            goto label_6;
        }
        
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        if(val_3.gameConfig.isShowAOA == false)
        {
            goto label_6;
        }
        
        val_15 = this.ad;
        if(val_15 == null)
        {
            goto label_7;
        }
        
        if(this.isShowingAd == true)
        {
                return;
        }
        
        val_15.add_OnAdDidDismissFullScreenContent(value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void AppOpenAdManager::HandleAdDidDismissFullScreenContent(object sender, System.EventArgs args)));
        this.ad.add_OnAdFailedToPresentFullScreenContent(value:  new System.EventHandler<GoogleMobileAds.Api.AdErrorEventArgs>(object:  this, method:  System.Void AppOpenAdManager::HandleAdFailedToPresentFullScreenContent(object sender, GoogleMobileAds.Api.AdErrorEventArgs args)));
        this.ad.add_OnAdDidPresentFullScreenContent(value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void AppOpenAdManager::HandleAdDidPresentFullScreenContent(object sender, System.EventArgs args)));
        this.ad.add_OnAdDidRecordImpression(value:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void AppOpenAdManager::HandleAdDidRecordImpression(object sender, System.EventArgs args)));
        val_15 = this.ad;
        val_15.add_OnPaidEvent(value:  new System.EventHandler<GoogleMobileAds.Api.AdValueEventArgs>(object:  this, method:  System.Void AppOpenAdManager::HandlePaidEvent(object sender, GoogleMobileAds.Api.AdValueEventArgs args)));
        this.ad.Show();
        this.callbackShowAds = callback;
        System.DateTime val_9 = System.DateTime.Now;
        UnityEngine.Debug.Log(message:  "[AOA] is show: "("[AOA] is show: ") + val_9);
        System.DateTime val_11 = System.DateTime.Now;
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_11.dateData}, d2:  new System.DateTime() {dateData = this.startLoad});
        double val_13 = val_12._ticks.TotalMilliseconds;
        val_13 = val_13 * 0.00100000004749745;
        UnityEngine.Debug.Log(message:  "[AOA] time to show: "("[AOA] time to show: ") + val_13);
        return;
        label_6:
        if(callback == null)
        {
                return;
        }
        
        callback.Invoke();
        return;
        label_7:
        this.LoadAd(_callback:  0);
    }
    private void HandleAdDidDismissFullScreenContent(object sender, System.EventArgs args)
    {
        UnityEngine.Debug.Log(message:  "Closed app open ad");
        this.ad = 0;
        this.isShowingAd = false;
        this.LoadAd(_callback:  0);
        if(this.callbackShowAds == null)
        {
                return;
        }
        
        this.callbackShowAds.Invoke();
    }
    private void HandleAdFailedToPresentFullScreenContent(object sender, GoogleMobileAds.Api.AdErrorEventArgs args)
    {
        var val_3;
        object[] val_1 = new object[1];
        val_1[0] = args.<AdError>k__BackingField.GetMessage();
        UnityEngine.Debug.LogFormat(format:  "Failed to present the ad (reason: {0})", args:  val_1);
        this.ad = 0;
        this.LoadAd(_callback:  0);
        val_3 = null;
        val_3 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  2.12199579096527E-314);
        if(this.callbackShowAds == null)
        {
                return;
        }
        
        this.callbackShowAds.Invoke();
    }
    private void HandleAdDidPresentFullScreenContent(object sender, System.EventArgs args)
    {
        UnityEngine.Debug.Log(message:  "Displayed app open ad");
        this.isShowingAd = true;
    }
    private void HandleAdDidRecordImpression(object sender, System.EventArgs args)
    {
        var val_1;
        UnityEngine.Debug.Log(message:  "Recorded ad impression");
        val_1 = null;
        val_1 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  4.24399158193054E-314);
        AppsflyerHelper.Log(id:  2);
        if(this.callbackShowAds == null)
        {
                return;
        }
        
        this.callbackShowAds.Invoke();
    }
    private void HandlePaidEvent(object sender, GoogleMobileAds.Api.AdValueEventArgs args)
    {
        object[] val_1 = new object[2];
        val_1[0] = args.<AdValue>k__BackingField.<CurrencyCode>k__BackingField;
        val_1[1] = args.<AdValue>k__BackingField.<Value>k__BackingField;
        UnityEngine.Debug.LogFormat(format:  "Received paid event. (currency: {0}, value: {1}", args:  val_1);
    }
    public AppOpenAdManager()
    {
        this.skipOnApplicationPause = true;
    }

}
