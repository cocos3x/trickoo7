using UnityEngine;
public class MaxHelper : AdsBase<MaxHelper>
{
    // Fields
    private bool bannerIsLoaded;
    
    // Methods
    private System.Collections.IEnumerator StartCoroutineWithDelay(System.Action action, float delay)
    {
        .<>1__state = 0;
        .action = action;
        .delay = delay;
        return (System.Collections.IEnumerator)new MaxHelper.<StartCoroutineWithDelay>d__0();
    }
    public static void Init(bool isDebug)
    {
        var val_11;
        var val_12;
        Application.AdvertisingIdentifierCallback val_14;
        var val_15;
        int val_16;
        var val_17;
        .isDebug = isDebug;
        val_11 = null;
        val_11 = null;
        AdsBase<T>.instance.__il2cppRuntimeField_8 = "[MAX] ";
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) != false)
        {
                val_12 = null;
            val_12 = null;
            val_14 = MaxHelper.<>c.<>9__1_0;
            if(val_14 == null)
        {
                Application.AdvertisingIdentifierCallback val_4 = null;
            val_14 = val_4;
            val_4 = new Application.AdvertisingIdentifierCallback(object:  MaxHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MaxHelper.<>c::<Init>b__1_0(string advertisingId, bool trackingEnabled, string error));
            MaxHelper.<>c.<>9__1_0 = val_14;
        }
        
            bool val_5 = UnityEngine.Application.RequestAdvertisingIdentifierAsync(delegateMethod:  val_4);
            MaxSdkCallbacks.add_OnSdkInitializedEvent(value:  new System.Action<SdkConfiguration>(object:  new MaxHelper.<>c__DisplayClass1_0(), method:  System.Void MaxHelper.<>c__DisplayClass1_0::<Init>b__1(MaxSdkBase.SdkConfiguration sdkConfiguration)));
            val_15 = null;
            val_15 = null;
            MaxSdkAndroid.SetSdkKey(sdkKey:  AdsBase<T>.instance.__il2cppRuntimeField_48 + 24);
            MaxSdkAndroid.InitializeSdk(adUnitIds:  0);
            string[] val_7 = new string[5];
            if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
            if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_16 = val_7.Length;
            if(val_16 == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
            val_7[0] = AdsBase<T>.instance.__il2cppRuntimeField_8;
            val_15 = "Init: ";
            if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_16 = val_7.Length;
            if(val_16 <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
            val_7[1] = "Init: ";
            if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_16 = val_7.Length;
            if(val_16 <= 2)
        {
                throw new IndexOutOfRangeException();
        }
        
            val_7[2] = AdsBase<T>.instance.__il2cppRuntimeField_48 + 24;
            val_15 = " - UserId: ";
            if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_16 = val_7.Length;
            if(val_16 <= 3)
        {
                throw new IndexOutOfRangeException();
        }
        
            val_7[3] = " - UserId: ";
            val_7[4] = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            UnityEngine.Debug.Log(message:  +val_7);
            return;
        }
        
        val_17 = null;
        val_17 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    public override void RewardInit()
    {
        MaxSdkCallbacks.Rewarded.add_OnAdLoadedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_0(string s, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Rewarded.add_OnAdLoadFailedEvent(value:  new System.Action<System.String, ErrorInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_1(string s, MaxSdkBase.ErrorInfo e)));
        MaxSdkCallbacks.Rewarded.add_OnAdDisplayFailedEvent(value:  new System.Action<System.String, ErrorInfo, AdInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_2(string s, MaxSdkBase.ErrorInfo e, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Rewarded.add_OnAdReceivedRewardEvent(value:  new System.Action<System.String, Reward, AdInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_3(string s, MaxSdkBase.Reward r, MaxSdkBase.AdInfo e)));
        MaxSdkCallbacks.Rewarded.add_OnAdHiddenEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_4(string s, MaxSdkBase.AdInfo i)));
        MaxSdkCallbacks.Rewarded.add_OnAdClickedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<RewardInit>b__2_5(string s, MaxSdkBase.AdInfo i)));
        UnityEngine.Debug.Log(message:  "[MAX]: RewardInit");
        goto typeof(MaxHelper).__il2cppRuntimeField_190;
    }
    public override void RewardLoad()
    {
        var val_3;
        var val_4;
        if(AdsManager.IsConnected == false)
        {
            goto label_3;
        }
        
        AdsManager.SetStatus(adType:  1, adEvent:  0, placementName:  "", itemId:  "");
        val_3 = null;
        val_3 = null;
        if((MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_20)) == false)
        {
            goto label_10;
        }
        
        return;
        label_3:
        AdsManager.SetStatus(adType:  1, adEvent:  7, placementName:  "", itemId:  "");
        return;
        label_10:
        val_4 = null;
        val_4 = null;
        MaxSdkAndroid.LoadRewardedAd(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_20);
    }
    public override void RewardOnReady()
    {
        null = null;
        bool val_2 = MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_20);
        AdsBase<T>.instance.__il2cppRuntimeField_3C = 0;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "RewardOnReady " + 0.ToString());
    }
    public static void ShowRewarded(System.Action<AdEvent> onSuccess, string placementName, string itemId, float waitAvaibale = 3)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        .onSuccess = onSuccess;
        .placementName = placementName;
        .itemId = itemId;
        val_7 = null;
        val_7 = null;
        val_8 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) != false)
        {
                val_9 = null;
            UnityEngine.Coroutine val_5 = AdsBase<T>.instance.__il2cppRuntimeField_48.StartCoroutine(routine:  MaxHelper.WaitToShowRewarded(onAvaiable:  new System.Action(object:  new MaxHelper.<>c__DisplayClass5_0(), method:  System.Void MaxHelper.<>c__DisplayClass5_0::<ShowRewarded>b__0()), waitAvaibale:  waitAvaibale));
            return;
        }
        
        val_10 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    private static System.Collections.IEnumerator WaitToShowRewarded(System.Action onAvaiable, float waitAvaibale)
    {
        .<>1__state = 0;
        .onAvaiable = onAvaiable;
        .waitAvaibale = waitAvaibale;
        return (System.Collections.IEnumerator)new MaxHelper.<WaitToShowRewarded>d__6();
    }
    public static void ShowRewardedDoNotWait(System.Action<AdEvent> onSuccess, string placementName, string itemId)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        AdEvent val_13;
        var val_14;
        val_6 = null;
        val_6 = null;
        val_7 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) == false)
        {
            goto label_5;
        }
        
        val_8 = null;
        val_9 = null;
        if((MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_20)) == false)
        {
            goto label_10;
        }
        
        val_10 = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "ShowRewarded -> Ready"("ShowRewarded -> Ready"));
        AdsBase<T>.instance.__il2cppRuntimeField_48.RewardShow(status:  onSuccess, placementName:  placementName, itemId:  itemId);
        MaxSdkAndroid.ShowRewardedAd(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_20, placement:  placementName);
        return;
        label_5:
        val_11 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
        return;
        label_10:
        val_12 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "ShowRewarded -> Not Ready"("ShowRewarded -> Not Ready"));
        val_13 = 8;
        AdsManager.SetStatus(adType:  1, adEvent:  val_13, placementName:  placementName, itemId:  itemId);
        if(onSuccess != null)
        {
                val_13 = 8;
            onSuccess.Invoke(obj:  val_13);
        }
        
        val_14 = null;
        val_14 = null;
        AdsBase<T>.instance.__il2cppRuntimeField_3C = 0;
        goto AdsBase<T>.instance.__il2cppRuntimeField_48 + 400;
    }
    public override void InterInit()
    {
        MaxSdkCallbacks.Interstitial.add_OnAdLoadedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_0(string s, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Interstitial.add_OnAdLoadFailedEvent(value:  new System.Action<System.String, ErrorInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_1(string s, MaxSdkBase.ErrorInfo error)));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_2(string s, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayFailedEvent(value:  new System.Action<System.String, ErrorInfo, AdInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_3(string s, MaxSdkBase.ErrorInfo error, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Interstitial.add_OnAdClickedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_4(string s, MaxSdkBase.AdInfo info)));
        MaxSdkCallbacks.Interstitial.add_OnAdHiddenEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void MaxHelper::<InterInit>b__8_5(string s, MaxSdkBase.AdInfo info)));
        UnityEngine.Debug.Log(message:  "[MAX]: InterInit");
        goto typeof(MaxHelper).__il2cppRuntimeField_210;
    }
    public override void InterLoad()
    {
        var val_3;
        var val_4;
        if(AdsManager.IsConnected == false)
        {
            goto label_3;
        }
        
        AdsManager.SetStatus(adType:  0, adEvent:  0, placementName:  "", itemId:  "");
        val_3 = null;
        val_3 = null;
        if((MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_18)) == false)
        {
            goto label_10;
        }
        
        return;
        label_3:
        AdsManager.SetStatus(adType:  0, adEvent:  7, placementName:  "", itemId:  "");
        return;
        label_10:
        UnityEngine.Debug.Log(message:  "[MAX]: InterLoad cuz not ready");
        val_4 = null;
        val_4 = null;
        MaxSdkAndroid.LoadInterstitial(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_18);
    }
    public override void InterOnReady()
    {
        null = null;
        bool val_2 = MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_18);
        AdsBase<T>.instance.__il2cppRuntimeField_30 = 0;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "InterOnReady " + 0.ToString());
    }
    public static void ShowInterstitial(System.Action<AdEvent> onSuccess, string placementName, string itemId, float waitAvaibale = 1)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        .onSuccess = onSuccess;
        .placementName = placementName;
        .itemId = itemId;
        val_7 = null;
        val_7 = null;
        val_8 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) != false)
        {
                val_9 = null;
            UnityEngine.Coroutine val_5 = AdsBase<T>.instance.__il2cppRuntimeField_48.StartCoroutine(routine:  MaxHelper.WaitToShowInterstitial(onAvaiable:  new System.Action(object:  new MaxHelper.<>c__DisplayClass11_0(), method:  System.Void MaxHelper.<>c__DisplayClass11_0::<ShowInterstitial>b__0()), waitAvaibale:  waitAvaibale));
            return;
        }
        
        val_10 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    private static System.Collections.IEnumerator WaitToShowInterstitial(System.Action onAvaiable, float waitAvaibale)
    {
        .<>1__state = 0;
        .onAvaiable = onAvaiable;
        .waitAvaibale = waitAvaibale;
        return (System.Collections.IEnumerator)new MaxHelper.<WaitToShowInterstitial>d__12();
    }
    public static void ShowInterstitialDoNotWait(System.Action<AdEvent> onSuccess, string placementName, string itemId)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_6 = null;
        val_6 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) == false)
        {
            goto label_5;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = null;
        if((MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_18)) == false)
        {
            goto label_10;
        }
        
        val_9 = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "ShowInterstitial -> Ready"("ShowInterstitial -> Ready"));
        AdsBase<T>.instance.__il2cppRuntimeField_48.InterShow(status:  onSuccess, placementName:  placementName, itemId:  itemId);
        MaxSdkAndroid.ShowInterstitial(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_18, placement:  placementName);
        return;
        label_5:
        if(onSuccess != null)
        {
                onSuccess.Invoke(obj:  0);
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
        return;
        label_10:
        val_11 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "ShowInterstitial -> Not Ready"("ShowInterstitial -> Not Ready"));
        AdsManager.SetStatus(adType:  0, adEvent:  8, placementName:  placementName, itemId:  itemId);
        if(onSuccess != null)
        {
                onSuccess.Invoke(obj:  8);
        }
        
        val_12 = null;
        val_12 = null;
        AdsBase<T>.instance.__il2cppRuntimeField_30 = 0;
        goto AdsBase<T>.instance.__il2cppRuntimeField_48 + 528;
    }
    public override void InitBanner()
    {
        null = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "BannerInit");
        goto typeof(MaxHelper).__il2cppRuntimeField_290;
    }
    public override void LoadBanner()
    {
        var val_4;
        var val_5;
        if(AdsManager.IsConnected != false)
        {
                AdsManager.SetStatus(adType:  2, adEvent:  0, placementName:  "", itemId:  "");
            val_4 = null;
            val_4 = null;
            UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "CreateBanner");
            MaxSdkAndroid.CreateBanner(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_28, bannerPosition:  7);
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            MaxSdkAndroid.SetBannerBackgroundColor(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_28, color:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            MaxSdkAndroid.ShowBanner(adUnitIdentifier:  AdsBase<T>.instance.__il2cppRuntimeField_28);
            val_5 = null;
            val_5 = null;
            FirebaseManager.<Instance>k__BackingField.LogEvent(eventName:  "show_ads_banner");
            return;
        }
        
        AdsManager.SetStatus(adType:  2, adEvent:  7, placementName:  "", itemId:  "");
    }
    internal static void DestroyBaner()
    {
    
    }
    public MaxHelper()
    {
    
    }
    private void <RewardInit>b__2_0(string s, MaxSdkBase.AdInfo info)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "AdLoadedEvent: "("AdLoadedEvent: ") + s);
        val_3 = null;
        val_3 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  8589934592);
    }
    private void <RewardInit>b__2_1(string s, MaxSdkBase.ErrorInfo e)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "AdLoadFailedEvent: "("AdLoadFailedEvent: ") + s);
        val_3 = null;
        val_3 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  4294967296);
    }
    private void <RewardInit>b__2_2(string s, MaxSdkBase.ErrorInfo e, MaxSdkBase.AdInfo info)
    {
        null = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "AdFailedToDisplayEvent: "("AdFailedToDisplayEvent: ") + s);
        goto typeof(MaxHelper).__il2cppRuntimeField_1B0;
    }
    private void <RewardInit>b__2_3(string s, MaxSdkBase.Reward r, MaxSdkBase.AdInfo e)
    {
        null = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "AdReceivedRewardEvent: "("AdReceivedRewardEvent: ") + s);
        goto typeof(MaxHelper).__il2cppRuntimeField_1D0;
    }
    private void <RewardInit>b__2_4(string s, MaxSdkBase.AdInfo i)
    {
        null = null;
        UnityEngine.Debug.Log(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + 19087060 + s);
        goto typeof(MaxHelper).__il2cppRuntimeField_1F0;
    }
    private void <RewardInit>b__2_5(string s, MaxSdkBase.AdInfo i)
    {
        goto typeof(MaxHelper).__il2cppRuntimeField_1E0;
    }
    private void <InterInit>b__8_0(string s, MaxSdkBase.AdInfo info)
    {
        null = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  8589934592);
    }
    private void <InterInit>b__8_1(string s, MaxSdkBase.ErrorInfo error)
    {
        null = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventType:  4294967296);
    }
    private void <InterInit>b__8_2(string s, MaxSdkBase.AdInfo info)
    {
        goto typeof(MaxHelper).__il2cppRuntimeField_250;
    }
    private void <InterInit>b__8_3(string s, MaxSdkBase.ErrorInfo error, MaxSdkBase.AdInfo info)
    {
        goto typeof(MaxHelper).__il2cppRuntimeField_230;
    }
    private void <InterInit>b__8_4(string s, MaxSdkBase.AdInfo info)
    {
        goto typeof(MaxHelper).__il2cppRuntimeField_260;
    }
    private void <InterInit>b__8_5(string s, MaxSdkBase.AdInfo info)
    {
        goto typeof(MaxHelper).__il2cppRuntimeField_270;
    }

}
