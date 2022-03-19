using UnityEngine;
public abstract class AdsBase<T> : MonoBehaviour
{
    // Fields
    public static AdsBase<T> Instance;
    public static string TAG;
    public string sdkKey;
    protected string appIdANDROID;
    protected string interIdANDROID;
    protected string rewardIdANDROID;
    protected string bannerIdANDROID;
    protected string appIdIPHONE;
    protected string interIdIPHONE;
    protected string rewardIdIPHONE;
    protected string bannerIdIPHONE;
    protected static string AppKeyId;
    protected static string InterUnitId;
    protected static string RewardUnitId;
    protected static string BannerUnitId;
    protected int interCountMax;
    private string interPlacemenetName;
    private string interItemId;
    private System.Action<AdEvent> onInterShowSuccess;
    public static int InterCountTry;
    private static bool <InterIsReady>k__BackingField;
    protected int rewardCountMax;
    private string rewardPlacementName;
    private string rewardItemId;
    protected System.Action<AdEvent> onRewardShowSuccess;
    protected AdEvent rewardEvent;
    protected int bannerCountMax;
    public static int BannerCountTry;
    public static int RewardCountTry;
    private static bool <RewardIsReady>k__BackingField;
    protected bool isInit;
    protected static T instance;
    
    // Properties
    public static bool InterIsReady { get; set; }
    public static bool RewardIsReady { get; set; }
    
    // Methods
    public static bool get_InterIsReady()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
        {
                return (bool)__RuntimeMethodHiddenParam + 24 + 192 + 184 + 52;
        }
        
        return (bool)__RuntimeMethodHiddenParam + 24 + 192 + 184 + 52;
    }
    public static void set_InterIsReady(bool value)
    {
        var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = value;
    }
    public static bool get_RewardIsReady()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
        {
                return (bool)__RuntimeMethodHiddenParam + 24 + 192 + 184 + 64;
        }
        
        return (bool)__RuntimeMethodHiddenParam + 24 + 192 + 184 + 64;
    }
    public static void set_RewardIsReady(bool value)
    {
        var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = value;
    }
    public virtual void Awake()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = __RuntimeMethodHiddenParam;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = ???;
        mem2[0] = ???;
        mem2[0] = ???;
        mem2[0] = ???;
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        if(X0 == false)
        {
            goto label_11;
        }
        
        mem2[0] = X0;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        if(X0 == false)
        {
            goto label_14;
        }
        
        mem2[0] = X0;
        return;
        label_11:
        label_14:
    }
    public abstract void RewardInit(); // 0
    public abstract void RewardLoad(); // 0
    public abstract void RewardOnReady(); // 0
    public virtual void RewardOnLoadFailed(string error, object obj)
    {
        object val_6;
        object val_7;
        var val_8;
        var val_9;
        var val_10;
        int val_11;
        var val_12;
        int val_13;
        int val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        val_6 = obj;
        val_7 = error;
        AdsManager.SetStatus(adType:  1, adEvent:  0, placementName:  X24, itemId:  26890240);
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_8 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if(this != null)
        {
                this.Invoke(obj:  0);
        }
        
        mem[1152921513311633688] = 0;
        val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_9 & 1) == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 60) >= W9)
        {
                return;
        }
        
        if(val_6 != null)
        {
                object[] val_1 = new object[11];
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
            if((val_10 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
            val_11 = val_1.Length;
            val_1[0] = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8;
            val_11 = val_1.Length;
            val_1[1] = "RewardOnLoadFailed ";
            if(val_7 != null)
        {
                val_11 = val_1.Length;
        }
        
            val_1[2] = val_7;
            val_11 = val_1.Length;
            val_1[3] = " rewardIsReady: ";
            val_12 = 0;
            val_13 = val_1.Length;
            val_1[4] = (__RuntimeMethodHiddenParam + 24 + 192 + 32) & 1.ToString();
            val_13 = val_1.Length;
            val_1[5] = " ";
            val_14 = val_1.Length;
            val_1[6] = val_6;
            val_14 = val_1.Length;
            val_1[7] = " re-trying in 3 seconds count ";
            val_7 = 1152921504619307008;
            val_15 = val_1.Length;
            val_1[8] = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 60;
            val_15 = val_1.Length;
            val_1[9] = "/";
            val_1[10] = "/";
            UnityEngine.Debug.LogError(message:  +val_1);
        }
        
        val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_16 & 1) == 0)
        {
                val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        val_17 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        val_18 = val_6;
        if((val_17 & 1) == 0)
        {
                val_18 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_18 = __RuntimeMethodHiddenParam + 24 + 192;
            val_17 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = (__RuntimeMethodHiddenParam + 24 + 192 + 184 + 60) + 1;
        this.Invoke(methodName:  "RewardLoad", time:  3f);
    }
    public virtual void RewardOnShowFailed(string error, object obj)
    {
        var val_1;
        var val_2;
        AdsManager.SetStatus(adType:  1, adEvent:  0, placementName:  X22, itemId:  26890240);
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((val_2 & 512) != 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 224) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        }
        
        if(this != null)
        {
                this.Invoke(obj:  0);
        }
        
        mem[1152921513311782648] = 0;
    }
    public virtual void RewardOnShowSuscess(object obj)
    {
        object val_4 = obj;
        if(val_4 != null)
        {
                val_4 = "ADS RewardOnShowSuscess: "("ADS RewardOnShowSuscess: ") + val_4;
            UnityEngine.Debug.Log(message:  val_4);
        }
        
        mem[1152921513311919360] = 3;
        AdsManager.SetStatus(adType:  1, adEvent:  3, placementName:  26890240, itemId:  val_4);
        UnityMainThreadDispatcher.Instance().Enqueue(action:  new System.Action(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 40));
    }
    public virtual void RewardOnClick(object obj)
    {
        AdsManager.SetStatus(adType:  1, adEvent:  4, placementName:  26890240, itemId:  this);
    }
    public virtual void RewardOnClose()
    {
        mem[1152921513312167936] = 0;
        goto typeof(AdsBase<T>).__il2cppRuntimeField_190;
    }
    protected void RewardShow(System.Action<AdEvent> status, string placementName, string itemId)
    {
        var val_1;
        mem[1152921513312292224] = 2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = 0;
        mem[1152921513312292200] = placementName;
        mem[1152921513312292208] = itemId;
        mem[1152921513312292216] = status;
        AdsManager.SetStatus(adType:  1, adEvent:  2, placementName:  placementName, itemId:  itemId);
        goto __RuntimeMethodHiddenParam + 24 + 192 + 24;
    }
    public abstract void InterInit(); // 0
    public abstract void InterLoad(); // 0
    public abstract void InterOnReady(); // 0
    public virtual void InterOnLoadFailed(object obj)
    {
        object val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        int val_9;
        int val_10;
        int val_11;
        var val_12;
        var val_13;
        var val_14;
        val_4 = obj;
        AdsManager.SetStatus(adType:  0, adEvent:  0, placementName:  X23, itemId:  26890240);
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if(this != null)
        {
                this.Invoke(obj:  0);
        }
        
        mem[1152921513312437352] = 0;
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_6 & 1) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 48) >= W9)
        {
                return;
        }
        
        if(val_4 != null)
        {
                val_7 = 7;
            object[] val_1 = new object[7];
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
            if((val_8 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
            val_9 = val_1.Length;
            val_1[0] = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8;
            val_9 = val_1.Length;
            val_1[1] = "InterOnLoadFailed ";
            val_10 = val_1.Length;
            val_1[2] = val_4;
            val_10 = val_1.Length;
            val_1[3] = " re-trying in 3 seconds ";
            val_11 = val_1.Length;
            val_1[4] = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 48;
            val_11 = val_1.Length;
            val_1[5] = "/";
            val_1[6] = "/";
            UnityEngine.Debug.LogError(message:  +val_1);
        }
        
        val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_12 & 1) == 0)
        {
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        val_13 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        val_14 = val_4;
        if((val_13 & 1) == 0)
        {
                val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_14 = __RuntimeMethodHiddenParam + 24 + 192;
            val_13 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_13 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = (__RuntimeMethodHiddenParam + 24 + 192 + 184 + 48) + 1;
        this.Invoke(methodName:  "InterLoad", time:  3f);
    }
    public virtual void InterOnShowFailed(object obj)
    {
        var val_1;
        var val_2;
        AdsManager.SetStatus(adType:  0, adEvent:  0, placementName:  X22, itemId:  26890240);
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((val_2 & 512) != 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 224) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        }
        
        if(this != null)
        {
                this.Invoke(obj:  0);
        }
        
        mem[1152921513312573992] = 0;
        goto typeof(AdsBase<T>).__il2cppRuntimeField_210;
    }
    public virtual void InterOnShowSuscess()
    {
        AdsManager.SetStatus(adType:  0, adEvent:  3, placementName:  X21, itemId:  26890240);
        if(0 != 0)
        {
                0.Invoke(obj:  3);
        }
        
        mem[1152921513312690088] = 0;
    }
    public virtual void InterOnClick()
    {
        AdsManager.SetStatus(adType:  0, adEvent:  4, placementName:  26890240, itemId:  this);
    }
    public virtual void InterOnClose()
    {
        AdsManager.SetStatus(adType:  0, adEvent:  5, placementName:  X22, itemId:  26890240);
        goto __RuntimeMethodHiddenParam + 24 + 192 + 24;
    }
    protected void InterShow(System.Action<AdEvent> status, string placementName, string itemId)
    {
        mem[1152921513313038368] = itemId;
        mem[1152921513313038376] = status;
        mem[1152921513313038360] = placementName;
        AdsManager.SetStatus(adType:  0, adEvent:  2, placementName:  placementName, itemId:  itemId);
        goto __RuntimeMethodHiddenParam + 24 + 192 + 24;
    }
    private void PauseApp(bool pause)
    {
        if(pause != false)
        {
                UnityEngine.Time.timeScale = 0f;
            MusicManager.AudioSourceReal.Pause();
            return;
        }
        
        UnityEngine.Time.timeScale = 1f;
        MusicManager.AudioSourceReal.UnPause();
    }
    public abstract void InitBanner(); // 0
    public abstract void LoadBanner(); // 0
    protected AdsBase<T>()
    {
        mem[1152921513313290952] = "";
        mem[1152921513313290960] = "";
        mem[1152921513313290968] = "";
        mem[1152921513313290976] = "";
        mem[1152921513313290984] = "";
        mem[1152921513313290992] = "";
        mem[1152921513313291000] = "";
        mem[1152921513313291008] = "";
        mem[1152921513313291016] = "";
        mem[1152921513313291024] = 3;
        mem[1152921513313291056] = 3;
        mem[1152921513313291032] = "Default";
        mem[1152921513313291040] = "Default";
        mem[1152921513313291064] = "Default";
        mem[1152921513313291072] = "Default";
        mem[1152921513313291088] = 8;
    }
    private static AdsBase<T>()
    {
        mem2[0] = "[ADS] ";
        mem2[0] = "UnSupport";
        mem2[0] = "";
        mem2[0] = "";
        mem2[0] = "";
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
    }
    private void <RewardOnShowSuscess>b__44_0()
    {
        string val_1 = "ADS RewardOnShowSuscess: "("ADS RewardOnShowSuscess: ") + 388;
        UnityEngine.Debug.Log(message:  val_1);
        if(val_1 != null)
        {
                val_1.Invoke(obj:  3);
        }
        
        mem[1152921513313519352] = 0;
    }

}
