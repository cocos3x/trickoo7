using UnityEngine;
public class IronHelper : AdsBase<IronHelper>
{
    // Fields
    private bool bannerIsLoaded;
    
    // Methods
    public static void Init(bool isDebug)
    {
        null = null;
        AdsBase<T>.instance.__il2cppRuntimeField_8 = "[IRON] ";
    }
    public override void RewardInit()
    {
    
    }
    public override void RewardLoad()
    {
    
    }
    public override void RewardOnReady()
    {
    
    }
    public static void ShowRewarded(System.Action<AdEvent> onSuccess, string placementName, string itemId, float waitAvaibale = 3)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        .onSuccess = onSuccess;
        .placementName = placementName;
        .itemId = itemId;
        if((UnityEngine.Application.platform == 7) || (UnityEngine.Application.platform == 0))
        {
            goto label_3;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) == false)
        {
            goto label_8;
        }
        
        val_11 = null;
        UnityEngine.Coroutine val_7 = AdsBase<T>.instance.__il2cppRuntimeField_48.StartCoroutine(routine:  IronHelper.WaitToShowRewarded(onAvaiable:  new System.Action(object:  new IronHelper.<>c__DisplayClass4_0(), method:  System.Void IronHelper.<>c__DisplayClass4_0::<ShowRewarded>b__0()), waitAvaibale:  waitAvaibale));
        return;
        label_3:
        if(((IronHelper.<>c__DisplayClass4_0)[1152921513325251776].onSuccess) == null)
        {
                return;
        }
        
        (IronHelper.<>c__DisplayClass4_0)[1152921513325251776].onSuccess.Invoke(obj:  3);
        return;
        label_8:
        val_12 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    private static System.Collections.IEnumerator WaitToShowRewarded(System.Action onAvaiable, float waitAvaibale)
    {
        .<>1__state = 0;
        .onAvaiable = onAvaiable;
        .waitAvaibale = waitAvaibale;
        return (System.Collections.IEnumerator)new IronHelper.<WaitToShowRewarded>d__5();
    }
    public static void ShowRewardedDoNotWait(System.Action<AdEvent> onSuccess, string placementName, string itemId)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) != false)
        {
                if(onSuccess == null)
        {
                return;
        }
        
            onSuccess.Invoke(obj:  0);
            return;
        }
        
        if(onSuccess != null)
        {
                onSuccess.Invoke(obj:  0);
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    public override void InterInit()
    {
    
    }
    public override void InterLoad()
    {
    
    }
    public override void InterOnReady()
    {
    
    }
    public static void ShowInterstitial(System.Action<AdEvent> onSuccess, string placementName, string itemId, float waitAvaibale = 1)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        .onSuccess = onSuccess;
        .placementName = placementName;
        .itemId = itemId;
        if((UnityEngine.Application.platform == 7) || (UnityEngine.Application.platform == 0))
        {
            goto label_3;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) == false)
        {
            goto label_8;
        }
        
        val_11 = null;
        UnityEngine.Coroutine val_7 = AdsBase<T>.instance.__il2cppRuntimeField_48.StartCoroutine(routine:  IronHelper.WaitToShowInterstitial(onAvaiable:  new System.Action(object:  new IronHelper.<>c__DisplayClass10_0(), method:  System.Void IronHelper.<>c__DisplayClass10_0::<ShowInterstitial>b__0()), waitAvaibale:  waitAvaibale));
        return;
        label_3:
        if(((IronHelper.<>c__DisplayClass10_0)[1152921513326064064].onSuccess) == null)
        {
                return;
        }
        
        (IronHelper.<>c__DisplayClass10_0)[1152921513326064064].onSuccess.Invoke(obj:  3);
        return;
        label_8:
        val_12 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    private static System.Collections.IEnumerator WaitToShowInterstitial(System.Action onAvaiable, float waitAvaibale)
    {
        .<>1__state = 0;
        .onAvaiable = onAvaiable;
        .waitAvaibale = waitAvaibale;
        return (System.Collections.IEnumerator)new IronHelper.<WaitToShowInterstitial>d__11();
    }
    public static void ShowInterstitialDoNotWait(System.Action<AdEvent> onSuccess, string placementName, string itemId)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsBase<T>.instance.__il2cppRuntimeField_48)) != false)
        {
                if(onSuccess == null)
        {
                return;
        }
        
            onSuccess.Invoke(obj:  0);
            return;
        }
        
        if(onSuccess != null)
        {
                onSuccess.Invoke(obj:  0);
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Debug.LogError(message:  AdsBase<T>.instance.__il2cppRuntimeField_8(AdsBase<T>.instance.__il2cppRuntimeField_8) + "instance NULL");
    }
    public override void InitBanner()
    {
    
    }
    public override void LoadBanner()
    {
    
    }
    private void OnBannerAdLoadedEvent()
    {
        var val_1;
        AdsManager.SetStatus(adType:  2, adEvent:  3, placementName:  "", itemId:  "");
        this.bannerIsLoaded = true;
        val_1 = null;
        val_1 = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventName:  "show_ads_banner");
    }
    public IronHelper()
    {
    
    }

}
