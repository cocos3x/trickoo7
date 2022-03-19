using UnityEngine;
public class AdsManager : MonoBehaviour
{
    // Fields
    private AdMobile adNetWork;
    public static bool isAdShowing;
    public static bool latestAdsIsReward;
    private bool initAtStart;
    protected bool useBanner;
    protected UnityEngine.UI.Button interstitialButton;
    protected UnityEngine.UI.Button videoRewarded;
    protected UnityEngine.RectTransform parrentTransform;
    protected float bannerHeight;
    protected BannerPos bannerPos;
    protected UnityEngine.GameObject bannerBackground;
    private static float <TotalTimePlay>k__BackingField;
    private static int <TotalSuccess>k__BackingField;
    private static System.DateTime <LastTimeShowAd>k__BackingField;
    public static bool isShowCheckAOA;
    protected UIToggle isRemoveAds;
    public static AdsManager.AdsDelegate OnStateChanged;
    private static AdsManager instance;
    private static AdType <currentType>k__BackingField;
    private static AdEvent <currentEvent>k__BackingField;
    private static string <currentPlacement>k__BackingField;
    private static string <currentItem>k__BackingField;
    public static bool isInit;
    
    // Properties
    public static AdMobile AdNetwork { get; }
    public static bool UseBanner { get; }
    public static bool IsDebugMode { get; }
    public static float TotalTimePlay { get; set; }
    public static int TotalSuccess { get; set; }
    public static System.DateTime LastTimeShowAd { get; set; }
    private static UserData userData { get; }
    private static GameConfig gameConfig { get; }
    public static bool IsRemoveAds { get; }
    public static bool IsTimeToShowAds { get; }
    public static AdType currentType { get; set; }
    public static AdEvent currentEvent { get; set; }
    public static string currentPlacement { get; set; }
    public static string currentItem { get; set; }
    public static bool InterstitialIsReady { get; }
    public static bool VideoRewaredIsReady { get; }
    public static bool IsConnected { get; }
    
    // Methods
    public static AdMobile get_AdNetwork()
    {
        null = null;
        return (AdMobile)AdsManager.instance.adNetWork;
    }
    public static bool get_UseBanner()
    {
        var val_4;
        AdsManager val_5;
        val_4 = null;
        val_4 = null;
        val_5 = AdsManager.instance;
        if(val_5 != null)
        {
                System.Nullable<System.Boolean> val_1 = new System.Nullable<System.Boolean>(value:  AdsManager.instance.useBanner);
            val_5 = val_1.HasValue;
            return (bool)val_5.Value;
        }
        
        return (bool)val_5.Value;
    }
    public static bool get_IsDebugMode()
    {
        return false;
    }
    public static float get_TotalTimePlay()
    {
        null = null;
        return (float)AdsManager.<TotalTimePlay>k__BackingField;
    }
    public static void set_TotalTimePlay(float value)
    {
        null = null;
        AdsManager.<TotalTimePlay>k__BackingField = value;
    }
    public static int get_TotalSuccess()
    {
        null = null;
        return (int)AdsManager.<TotalSuccess>k__BackingField;
    }
    private static void set_TotalSuccess(int value)
    {
        null = null;
        AdsManager.<TotalSuccess>k__BackingField = value;
    }
    public static System.DateTime get_LastTimeShowAd()
    {
        null = null;
        return (System.DateTime)AdsManager.<LastTimeShowAd>k__BackingField;
    }
    private static void set_LastTimeShowAd(System.DateTime value)
    {
        null = null;
        AdsManager.<LastTimeShowAd>k__BackingField = value.dateData;
    }
    private static UserData get_userData()
    {
        UserData val_2;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        if((val_1.<gameData>k__BackingField) != null)
        {
                val_2 = val_1.<gameData>k__BackingField.user;
            return (UserData)val_2;
        }
        
        val_2 = 0;
        return (UserData)val_2;
    }
    private static GameConfig get_gameConfig()
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        return (GameConfig)val_1.gameConfig;
    }
    public static bool get_IsRemoveAds()
    {
        var val_10;
        AdsManager val_11;
        var val_12;
        var val_13;
        val_10 = null;
        val_10 = null;
        val_11 = AdsManager.instance;
        if(val_11 != 0)
        {
                if(AdsManager.userData == null)
        {
                return (bool)val_12;
        }
        
            val_13 = null;
            val_13 = null;
            val_11 = mem[AdsManager.instance + 72];
            val_11 = AdsManager.instance.isRemoveAds;
            if((UnityEngine.Object.op_Implicit(exists:  val_11)) != false)
        {
                UserData val_4 = AdsManager.userData;
            if(val_4._isRemovedAds != true)
        {
                val_11 = AdsManager.userData;
            val_11.isRemovedAds = isOn;
        }
        
        }
        
            UserData val_8 = AdsManager.userData;
            var val_9 = (val_8._isRemovedAds == true) ? 1 : 0;
            return (bool)val_12;
        }
        
        val_12 = 0;
        return (bool)val_12;
    }
    public static bool get_IsTimeToShowAds()
    {
        ulong val_11;
        var val_12;
        var val_13;
        object val_14;
        var val_15;
        val_11 = 1152921504875589632;
        if(AdsManager.userData == null)
        {
                return (bool)val_12;
        }
        
        if(AdsManager.gameConfig == null)
        {
                return (bool)val_12;
        }
        
        val_13 = null;
        if(AdsManager.IsRemoveAds != false)
        {
                UserData val_4 = AdsManager.userData;
            val_11 = " isRemovedAds: "(" isRemovedAds: ") + val_4._isRemovedAds.ToString();
            val_14 = val_11;
        }
        else
        {
                val_15 = null;
            val_15 = null;
            GameConfig val_7 = AdsManager.gameConfig;
            System.DateTime val_8 = AdsManager.<LastTimeShowAd>k__BackingField.AddSeconds(value:  (double)val_7.timePlayToShowAds);
            val_11 = val_8.dateData;
            System.DateTime val_9 = System.DateTime.Now;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_11}, t2:  new System.DateTime() {dateData = val_9.dateData})) != false)
        {
                UnityEngine.Debug.Log(message:  "Time to show Ads!");
            val_12 = 1;
            return (bool)val_12;
        }
        
            val_14 = "Not time to show Ads!";
        }
        
        UnityEngine.Debug.Log(message:  val_14);
        val_12 = 0;
        return (bool)val_12;
    }
    public static AdType get_currentType()
    {
        null = null;
        return (AdType)AdsManager.<currentType>k__BackingField;
    }
    private static void set_currentType(AdType value)
    {
        null = null;
        AdsManager.<currentType>k__BackingField = value;
    }
    public static AdEvent get_currentEvent()
    {
        null = null;
        return (AdEvent)AdsManager.<currentEvent>k__BackingField;
    }
    private static void set_currentEvent(AdEvent value)
    {
        null = null;
        AdsManager.<currentEvent>k__BackingField = value;
    }
    public static string get_currentPlacement()
    {
        null = null;
        return (string)AdsManager.<currentPlacement>k__BackingField;
    }
    private static void set_currentPlacement(string value)
    {
        null = null;
        AdsManager.<currentPlacement>k__BackingField = value;
    }
    public static string get_currentItem()
    {
        null = null;
        return (string)AdsManager.<currentItem>k__BackingField;
    }
    private static void set_currentItem(string value)
    {
        null = null;
        AdsManager.<currentItem>k__BackingField = value;
    }
    public static void InterLoad()
    {
        var val_5;
        var val_6;
        if(AdsManager.AdNetwork != 2)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(AdsManager.isInit == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        goto typeof(T).__il2cppRuntimeField_210;
    }
    public static void RewardLoad()
    {
        var val_5;
        var val_6;
        if(AdsManager.AdNetwork != 2)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(AdsManager.isInit == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        goto typeof(T).__il2cppRuntimeField_190;
    }
    public static bool get_InterstitialIsReady()
    {
        var val_7;
        var val_8;
        val_7 = 1152921504875589632;
        if(AdsManager.AdNetwork == 0)
        {
                return (bool)val_8;
        }
        
        if(AdsManager.AdNetwork == 1)
        {
                val_7 = ???;
        }
        
        if(AdsManager.AdNetwork == 2)
        {
                if(((public static System.Boolean AdsBase<MaxHelper>::get_InterIsReady()) & 1) != 0)
        {
                val_8 = 1;
            return (bool)val_8;
        }
        
            AdsManager.InterLoad();
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public static bool get_VideoRewaredIsReady()
    {
        var val_9;
        var val_10;
        if((UnityEngine.Application.platform == 7) || (UnityEngine.Application.platform == 0))
        {
            goto label_2;
        }
        
        val_9 = 1152921504875589632;
        if(AdsManager.AdNetwork == 0)
        {
                return (bool)val_10;
        }
        
        if(AdsManager.AdNetwork == 1)
        {
                val_9 = ???;
        }
        
        if(AdsManager.AdNetwork != 2)
        {
                return (bool)val_10;
        }
        
        if(((public static System.Boolean AdsBase<MaxHelper>::get_RewardIsReady()) & 1) == 0)
        {
            goto label_16;
        }
        
        label_2:
        val_10 = 1;
        return (bool)val_10;
        label_16:
        AdsManager.RewardLoad();
        return (bool)val_10;
    }
    private void Awake()
    {
        var val_5;
        var val_6;
        UnityEngine.Events.UnityAction<System.Boolean> val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        AdsManager.instance = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.isRemoveAds)) != false)
        {
                val_6 = null;
            val_6 = null;
            val_8 = AdsManager.<>c.<>9__64_0;
            if(val_8 == null)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  AdsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AdsManager.<>c::<Awake>b__64_0(bool isOn));
            AdsManager.<>c.<>9__64_0 = val_8;
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        System.Delegate val_4 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void AdsManager::DataManager_OnLoaded()));
        if(val_4 != null)
        {
                if(null != null)
        {
                throw new NullReferenceException();
        }
        
        }
        
        DataManager.OnDataLoaded = val_4;
    }
    private void DataManager_OnLoaded()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = this;
        if(this.initAtStart == true)
        {
            goto label_8;
        }
        
        if(Util.InternetConnection() == false)
        {
            goto label_2;
        }
        
        val_2 = 1152921504875589632;
        val_3 = null;
        val_3 = null;
        if(AdsManager.isInit == true)
        {
            goto label_8;
        }
        
        AdsManager.Init();
        goto label_8;
        label_2:
        val_2 = 1152921504888262656;
        val_4 = null;
        val_4 = null;
        LogEvent(eventName:  "no_internet");
        label_8:
        AdsManager.UpdateBannerArea();
    }
    private void Start()
    {
        object val_4;
        var val_5;
        val_4 = this;
        if(this.interstitialButton != null)
        {
                this.interstitialButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AdsManager::TestInterstitial()));
        }
        
        if(this.videoRewarded != null)
        {
                this.videoRewarded.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void AdsManager::TestVideoReward()));
        }
        
        if(this.initAtStart == false)
        {
                return;
        }
        
        if(Util.InternetConnection() == false)
        {
                return;
        }
        
        val_4 = 1152921504875589632;
        val_5 = null;
        val_5 = null;
        if(AdsManager.isInit != false)
        {
                return;
        }
        
        AdsManager.Init();
    }
    public static void Init()
    {
        var val_7;
        object val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsManager.instance)) == false)
        {
            goto label_5;
        }
        
        if(AdsManager.AdNetwork == 0)
        {
            goto label_8;
        }
        
        if(AdsManager.AdNetwork != 1)
        {
            goto label_11;
        }
        
        IronHelper.Init(isDebug:  false);
        return;
        label_5:
        val_8 = "[AdsManager] NULL";
        goto label_16;
        label_8:
        val_8 = "Admob.Init(); Not implement!!";
        label_16:
        UnityEngine.Debug.LogError(message:  val_8);
        return;
        label_11:
        if(AdsManager.AdNetwork != 2)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        UnityEngine.Coroutine val_6 = AdsManager.instance.StartCoroutine(routine:  initMaxDelay(delay:  2f));
    }
    public System.Collections.IEnumerator initMaxDelay(float delay)
    {
        .<>1__state = 0;
        .delay = delay;
        return (System.Collections.IEnumerator)new AdsManager.<initMaxDelay>d__69();
    }
    public void TestInterstitial()
    {
        var val_3;
        var val_4;
        System.Action<AdEvent> val_6;
        System.DateTime val_1 = new System.DateTime(year:  207, month:  1, day:  1);
        val_3 = null;
        val_3 = null;
        AdsManager.<LastTimeShowAd>k__BackingField = val_1.dateData;
        val_3 = null;
        val_3 = null;
        AdsManager.<TotalTimePlay>k__BackingField = 9999f;
        val_4 = null;
        val_4 = null;
        val_6 = AdsManager.<>c.<>9__70_0;
        if(val_6 == null)
        {
                System.Action<AdEvent> val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action<AdEvent>(object:  AdsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AdsManager.<>c::<TestInterstitial>b__70_0(AdEvent s));
            AdsManager.<>c.<>9__70_0 = val_6;
        }
        
        AdsManager.ShowInterstitial(onSuccess:  val_2, placementName:  "TestInterstitialName", itemId:  "TestInterstitialId", userWanted:  false);
    }
    public static void ShowInterstitial(System.Action<AdEvent> onSuccess, string placementName, string itemId, bool userWanted = False)
    {
        var val_15;
        AdsManager val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_15 = null;
        val_15 = null;
        AdsManager.isAdShowing = true;
        val_16 = AdsManager.instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
        {
            goto label_5;
        }
        
        val_17 = null;
        if(userWanted == false)
        {
            goto label_6;
        }
        
        label_45:
        if(AdsManager.InterstitialIsReady == false)
        {
            goto label_9;
        }
        
        AdsManager.ShowNoticeOnLoading();
        if(AdsManager.AdNetwork == 0)
        {
            goto label_14;
        }
        
        val_19 = null;
        if(AdsManager.AdNetwork != 1)
        {
            goto label_17;
        }
        
        val_19 = null;
        AdsManager.isShowCheckAOA = true;
        IronHelper.ShowInterstitial(onSuccess:  onSuccess, placementName:  placementName, itemId:  itemId, waitAvaibale:  1f);
        return;
        label_5:
        UnityEngine.Debug.LogError(message:  "[AdsManager] NULL");
        label_62:
        val_20 = 1152921513311587488;
        val_21 = 8;
        goto label_24;
        label_6:
        if(AdsManager.IsTimeToShowAds == false)
        {
            goto label_42;
        }
        
        val_23 = null;
        val_23 = null;
        val_16 = 1152921513314619296;
        DataManager val_6 = LazySingleton<DataManager>.Instance;
        System.DateTime val_7 = AdsManager.<LastTimeShowAd>k__BackingField.AddSeconds(value:  (double)val_6.gameConfig.timePlayToShowAds);
        System.DateTime val_8 = System.DateTime.Now;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_7.dateData}, t2:  new System.DateTime() {dateData = val_8.dateData})) == true)
        {
            goto label_42;
        }
        
        StageData val_11 = LazySingleton<DataManager>.Instance.CurrentStage;
        DataManager val_12 = LazySingleton<DataManager>.Instance;
        if((val_11.level - 1) < val_12.gameConfig.levelPlayToShowAds)
        {
            goto label_42;
        }
        
        val_24 = null;
        val_24 = null;
        if(AdsManager.latestAdsIsReward == false)
        {
            goto label_45;
        }
        
        val_25 = 1152921504875593729;
        AdsManager.latestAdsIsReward = false;
        label_42:
        val_20 = 1152921513311587488;
        val_21 = 9;
        label_24:
        onSuccess.Invoke(obj:  9);
        return;
        label_9:
        onSuccess.Invoke(obj:  8);
        AdsManager.SetStatus(adType:  0, adEvent:  8, placementName:  placementName, itemId:  itemId);
        return;
        label_14:
        UnityEngine.Debug.LogError(message:  "AdmobInterstitial.Show(onSuccess, placementName); Not implement!!");
        return;
        label_17:
        if(AdsManager.AdNetwork == 2)
        {
                val_26 = null;
            val_26 = null;
            AdsManager.isShowCheckAOA = true;
            MaxHelper.ShowInterstitial(onSuccess:  onSuccess, placementName:  placementName, itemId:  itemId, waitAvaibale:  1f);
            return;
        }
        
        if(onSuccess != null)
        {
            goto label_62;
        }
    
    }
    public void TestVideoReward()
    {
        var val_3;
        var val_4;
        System.Action<AdEvent> val_6;
        System.DateTime val_1 = new System.DateTime(year:  207, month:  1, day:  1);
        val_3 = null;
        val_3 = null;
        AdsManager.<LastTimeShowAd>k__BackingField = val_1.dateData;
        val_3 = null;
        val_3 = null;
        AdsManager.<TotalTimePlay>k__BackingField = 9999f;
        val_4 = null;
        val_4 = null;
        val_6 = AdsManager.<>c.<>9__72_0;
        if(val_6 == null)
        {
                System.Action<AdEvent> val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action<AdEvent>(object:  AdsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AdsManager.<>c::<TestVideoReward>b__72_0(AdEvent s));
            AdsManager.<>c.<>9__72_0 = val_6;
        }
        
        AdsManager.ShowVideoReward(onSuccess:  val_2, placementName:  "TestVideoRewardName", itemId:  "TestVideoRewardId");
    }
    public static void ShowVideoReward(System.Action<AdEvent> onSuccess, string placementName = "", string itemId = "")
    {
        var val_7;
        var val_8;
        var val_9;
        AdEvent val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        if((UnityEngine.Object.op_Implicit(exists:  AdsManager.instance)) == false)
        {
            goto label_5;
        }
        
        if((UnityEngine.Application.internetReachability - 1) >= 2)
        {
            goto label_8;
        }
        
        AdsManager.ShowNoticeOnLoading();
        if(AdsManager.AdNetwork == 0)
        {
            goto label_11;
        }
        
        val_8 = null;
        if(AdsManager.AdNetwork != 1)
        {
            goto label_14;
        }
        
        val_8 = null;
        AdsManager.isShowCheckAOA = true;
        IronHelper.ShowRewarded(onSuccess:  onSuccess, placementName:  placementName, itemId:  itemId, waitAvaibale:  3f);
        return;
        label_5:
        UnityEngine.Debug.LogError(message:  "[AdsManager] NULL");
        label_33:
        val_9 = 1152921513311587488;
        val_10 = 8;
        goto label_20;
        label_8:
        UnityEngine.Debug.Log(message:  "Connection Error - Failed to connect to server. Please check your internet connection and try again!");
        AdsManager.SetStatus(adType:  1, adEvent:  7, placementName:  placementName, itemId:  itemId);
        val_9 = 1152921513311587488;
        val_10 = 7;
        label_20:
        onSuccess.Invoke(obj:  val_10);
        return;
        label_11:
        UnityEngine.Debug.LogError(message:  "AdmobVideoReward.Show(onSuccess, placement);  Not implement!!");
        return;
        label_14:
        if(AdsManager.AdNetwork == 2)
        {
                val_11 = null;
            val_11 = null;
            AdsManager.isShowCheckAOA = true;
            MaxHelper.ShowRewarded(onSuccess:  onSuccess, placementName:  placementName, itemId:  itemId, waitAvaibale:  3f);
            return;
        }
        
        if(onSuccess != null)
        {
            goto label_33;
        }
    
    }
    public static void DestroyBanner()
    {
        if(AdsManager.AdNetwork != 0)
        {
                if(AdsManager.AdNetwork == 1)
        {
                return;
        }
        
            if(AdsManager.AdNetwork != 2)
        {
                return;
        }
        
            MaxHelper.DestroyBaner();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Admob DestroyBanner  Not implement!!");
    }
    public static void SetStatus(AdType adType, AdEvent adEvent, string placementName = "", string itemId = "")
    {
        string val_9;
        AdType val_10;
        var val_11;
        AdsManager val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        int val_19;
        var val_20;
        int val_21;
        var val_22;
        int val_23;
        var val_24;
        val_9 = itemId;
        val_10 = adType;
        val_11 = null;
        val_11 = null;
        val_12 = AdsManager.instance;
        if((UnityEngine.Object.op_Implicit(exists:  val_12)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        AdsManager.<currentType>k__BackingField = val_10;
        val_13 = null;
        val_13 = null;
        AdsManager.<currentEvent>k__BackingField = adEvent;
        val_13 = null;
        val_13 = null;
        AdsManager.<currentPlacement>k__BackingField = placementName;
        val_13 = null;
        val_13 = null;
        AdsManager.<currentItem>k__BackingField = val_9;
        if(adEvent == 5)
        {
            goto label_20;
        }
        
        if(adEvent != 3)
        {
            goto label_42;
        }
        
        if(val_10 == 0)
        {
                System.DateTime val_2 = System.DateTime.Now;
            val_14 = null;
            val_14 = null;
            AdsManager.<LastTimeShowAd>k__BackingField = val_2.dateData;
        }
        
        val_15 = null;
        val_15 = null;
        AdsManager.<TotalTimePlay>k__BackingField = 0f;
        val_16 = null;
        val_16 = null;
        val_16 = null;
        val_16 = null;
        AdsManager.<TotalSuccess>k__BackingField = (AdsManager.<TotalSuccess>k__BackingField) + 1;
        goto label_42;
        label_20:
        if(val_10 == 0)
        {
                System.DateTime val_4 = System.DateTime.Now;
            val_16 = null;
            val_16 = null;
            AdsManager.<LastTimeShowAd>k__BackingField = val_4.dateData;
        }
        
        label_42:
        val_16 = null;
        if(AdsManager.OnStateChanged != null)
        {
                val_17 = null;
            val_17 = null;
            val_17 = null;
            val_17 = null;
            val_17 = null;
            val_17 = null;
            val_17 = null;
            val_17 = null;
            AdsManager.OnStateChanged.Invoke(currentType:  AdsManager.<currentType>k__BackingField, currentEvent:  AdsManager.<currentEvent>k__BackingField, currentPlacement:  AdsManager.<currentPlacement>k__BackingField, currentItemId:  AdsManager.<currentItem>k__BackingField);
        }
        
        string[] val_5 = new string[7];
        val_18 = null;
        val_18 = null;
        val_19 = val_5.Length;
        val_5[0] = AdsManager.<currentType>k__BackingField.ToString();
        val_19 = val_5.Length;
        val_5[1] = " ";
        val_20 = null;
        val_20 = null;
        val_9 = AdsManager.<currentEvent>k__BackingField;
        val_21 = val_5.Length;
        val_5[2] = AdsManager.<currentEvent>k__BackingField.ToString();
        val_21 = val_5.Length;
        val_5[3] = " ";
        val_22 = null;
        val_22 = null;
        val_23 = val_5.Length;
        val_5[4] = AdsManager.<currentPlacement>k__BackingField;
        val_23 = val_5.Length;
        val_5[5] = " ";
        val_24 = null;
        val_24 = null;
        val_5[6] = AdsManager.<currentItem>k__BackingField;
        val_10 = +val_5;
        UnityEngine.Debug.Log(message:  val_10);
    }
    public static bool get_IsConnected()
    {
        UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
        if(val_1 == 1)
        {
                return (bool)(val_1 == 2) ? 1 : 0;
        }
        
        return (bool)(val_1 == 2) ? 1 : 0;
    }
    public static void ShowNoticeOnLoading()
    {
        UnityEngine.Debug.Log(message:  "Time to show ads... please wait!");
    }
    public static void ShowNoticeOnFail(AdEvent onSuccess)
    {
        if(onSuccess != 1)
        {
                if(onSuccess != 8)
        {
                if(onSuccess != 7)
        {
                return;
        }
        
            UnityEngine.Debug.LogError(message:  "Please check your internet connection...!");
            return;
        }
        
            UnityEngine.Debug.LogError(message:  "Video not ready, please try again...!");
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Something wrong, please try again...!");
    }
    public static void UpdateBannerArea()
    {
        var val_2 = null;
        if(AdsManager.IsRemoveAds == false)
        {
                return;
        }
        
        AdsManager.DestroyBanner();
    }
    private void OnApplicationPause(bool isPaused)
    {
    
    }
    public AdsManager()
    {
        this.initAtStart = true;
        this.useBanner = true;
        this.bannerHeight = 68f;
        this.bannerPos = 2;
    }
    private static AdsManager()
    {
    
    }

}
