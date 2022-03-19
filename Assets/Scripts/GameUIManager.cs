using UnityEngine;
public class GameUIManager : MonoBehaviour
{
    // Fields
    private UIListLevel UIListLevel;
    private UISetting UISetting;
    private UIPopupRate UIPopupRate;
    private UIAnimation UIPopupInternet;
    private UIPopupLanguage UIPopupLanguage;
    private UIPopupVictory UIPopupVictory;
    private UIPopupHint UIPopupHint;
    private UIDailyReward UIDailyReward;
    private UISplash UISplash;
    private UnityEngine.GameObject btnShowHideUI;
    private int countdownCheckInternet;
    private bool internetConnection;
    private bool isSplashLoading;
    private float minPercent;
    private float maxPercent;
    private float time;
    private float totalLoadTime;
    private bool aoaIsShowing;
    
    // Methods
    private void Awake()
    {
        null = null;
        System.Delegate val_2 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void GameUIManager::DataManager_OnLoaded()));
        if(val_2 != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        DataManager.OnDataLoaded = val_2;
        this.btnShowHideUI.SetActive(value:  false);
        return;
        label_4:
    }
    private void OnEnable()
    {
        System.Action<System.Object> val_1 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowListLevelHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_1 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowListLevelHandler(object obj)), eventID:  14, callback:  val_1, eventType:  1);
        System.Action<System.Object> val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideListLevelHandle(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideListLevelHandle(object obj)), eventID:  15, callback:  val_2, eventType:  1);
        System.Action<System.Object> val_3 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowSettingHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_3 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowSettingHandler(object obj)), eventID:  16, callback:  val_3, eventType:  1);
        System.Action<System.Object> val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideSettingHandle(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideSettingHandle(object obj)), eventID:  17, callback:  val_4, eventType:  1);
        System.Action<System.Object> val_5 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InitLevelHandle(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_5 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InitLevelHandle(object obj)), eventID:  10, callback:  val_5, eventType:  1);
        System.Action<System.Object> val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InternetHandle(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InternetHandle(object obj)), eventID:  22, callback:  val_6, eventType:  1);
        System.Action<System.Object> val_7 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowLanguageHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_7 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowLanguageHandler(object obj)), eventID:  23, callback:  val_7, eventType:  1);
        System.Action<System.Object> val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideLanguageHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideLanguageHandler(object obj)), eventID:  24, callback:  val_8, eventType:  1);
        System.Action<System.Object> val_9 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::FinishLevelHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_9 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::FinishLevelHandler(object obj)), eventID:  12, callback:  val_9, eventType:  1);
        System.Action<System.Object> val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HintTextContentHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HintTextContentHandler(object obj)), eventID:  41, callback:  val_10, eventType:  1);
        System.Action<System.Object> val_11 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::OpenDailyHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_11 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::OpenDailyHandler(object obj)), eventID:  90, callback:  val_11, eventType:  1);
    }
    private void OnDisable()
    {
        System.Action<System.Object> val_19;
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                System.Action<System.Object> val_2 = null;
            val_19 = val_2;
            val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowListLevelHandler(object obj));
            val_1.RemoveListener(eventID:  14, callback:  val_2);
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 != null)
        {
                System.Action<System.Object> val_4 = null;
            val_19 = val_4;
            val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HideListLevelHandle(object obj));
            val_3.RemoveListener(eventID:  15, callback:  val_4);
        }
        
        EventDispatcher val_5 = LazySingleton<EventDispatcher>.Instance;
        if(val_5 != null)
        {
                System.Action<System.Object> val_6 = null;
            val_19 = val_6;
            val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowSettingHandler(object obj));
            val_5.RemoveListener(eventID:  16, callback:  val_6);
        }
        
        EventDispatcher val_7 = LazySingleton<EventDispatcher>.Instance;
        if(val_7 != null)
        {
                System.Action<System.Object> val_8 = null;
            val_19 = val_8;
            val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::ShowSettingHandler(object obj));
            val_7.RemoveListener(eventID:  17, callback:  val_8);
        }
        
        EventDispatcher val_9 = LazySingleton<EventDispatcher>.Instance;
        if(val_9 != null)
        {
                System.Action<System.Object> val_10 = null;
            val_19 = val_10;
            val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InitLevelHandle(object obj));
            val_9.RemoveListener(eventID:  10, callback:  val_10);
        }
        
        EventDispatcher val_11 = LazySingleton<EventDispatcher>.Instance;
        if(val_11 != null)
        {
                System.Action<System.Object> val_12 = null;
            val_19 = val_12;
            val_12 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::InternetHandle(object obj));
            val_11.RemoveListener(eventID:  22, callback:  val_12);
        }
        
        EventDispatcher val_13 = LazySingleton<EventDispatcher>.Instance;
        if(val_13 != null)
        {
                System.Action<System.Object> val_14 = null;
            val_19 = val_14;
            val_14 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::FinishLevelHandler(object obj));
            val_13.RemoveListener(eventID:  12, callback:  val_14);
        }
        
        EventDispatcher val_15 = LazySingleton<EventDispatcher>.Instance;
        if(val_15 != null)
        {
                System.Action<System.Object> val_16 = null;
            val_19 = val_16;
            val_16 = new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::HintTextContentHandler(object obj));
            val_15.RemoveListener(eventID:  41, callback:  val_16);
        }
        
        EventDispatcher val_17 = LazySingleton<EventDispatcher>.Instance;
        if(val_17 == null)
        {
                return;
        }
        
        val_17.RemoveListener(eventID:  90, callback:  new System.Action<System.Object>(object:  this, method:  System.Void GameUIManager::OpenDailyHandler(object obj)));
    }
    private void ShowListLevelHandler(object obj)
    {
        if(this.UIListLevel != null)
        {
                this.UIListLevel.Show();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void HideListLevelHandle(object obj)
    {
        if(this.UIListLevel != null)
        {
                this.UIListLevel.Hide();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void ShowSettingHandler(object obj)
    {
        if(this.UISetting != null)
        {
                this.UISetting.Show(onDone:  0);
            return;
        }
        
        throw new NullReferenceException();
    }
    private void HideSettingHandle(object obj)
    {
        if(this.UISetting != null)
        {
                this.UISetting.Hide();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void ShowLanguageHandler(object obj)
    {
        if(this.UIPopupLanguage != null)
        {
                this.UIPopupLanguage.Show(onDone:  0);
            return;
        }
        
        throw new NullReferenceException();
    }
    private void HideLanguageHandler(object obj)
    {
        if(this.UIPopupLanguage != null)
        {
                this.UIPopupLanguage.Hide();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void FinishLevelHandler(object obj)
    {
        GameUIManager.<>c__DisplayClass20_0 val_1 = new GameUIManager.<>c__DisplayClass20_0();
        .<>4__this = this;
        .level = obj;
        DG.Tweening.Tween val_3 = DG.Tweening.DOVirtual.DelayedCall(delay:  0f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void GameUIManager.<>c__DisplayClass20_0::<FinishLevelHandler>b__0()), ignoreTimeScale:  true);
        StageData val_6 = LazySingleton<DataManager>.Instance.CurrentStage;
        DataManager val_7 = LazySingleton<DataManager>.Instance;
        if((UnityEngine.PlayerPrefs.GetInt(key:  "rate", defaultValue:  0)) == 1)
        {
                return;
        }
        
        if((val_6.level - 1) != val_7.gameConfig.showRateLevel)
        {
                return;
        }
        
        DataManager val_9 = LazySingleton<DataManager>.Instance;
        if(val_9.gameConfig.isShowRate == false)
        {
                return;
        }
        
        DG.Tweening.Tween val_11 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void GameUIManager.<>c__DisplayClass20_0::<FinishLevelHandler>b__1()), ignoreTimeScale:  true);
    }
    private void HintTextContentHandler(object obj)
    {
        if(this.UIPopupHint != null)
        {
                this.UIPopupHint.Show();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void OpenDailyHandler(object obj)
    {
        if(this.UIDailyReward != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }
    private void InitLevelHandle(object obj)
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        DataManager val_2 = LazySingleton<DataManager>.Instance;
        StageData val_3 = val_2.stagesAsset.StageStatus(index:  val_1.gameConfig.levelStartCheck);
        if(val_1.gameConfig == null)
        {
                return;
        }
        
        int val_6 = this.countdownCheckInternet;
        val_6 = val_6 - 1;
        this.countdownCheckInternet = val_6;
        if()
        {
                return;
        }
        
        if(Util.InternetConnection() != true)
        {
                EventDispatcherExtension.PostEvent(listener:  null, eventID:  22, param:  null);
        }
        
        DataManager val_5 = LazySingleton<DataManager>.Instance;
        this.countdownCheckInternet = val_5.gameConfig.levelCountdown;
    }
    private void InternetHandle(object obj)
    {
        var val_4;
        var val_6;
        var val_7;
        if(null != null)
        {
                this.UIPopupInternet.Hide();
            val_4 = null;
            val_6 = 0;
        }
        else
        {
                this.UIPopupInternet.Show();
            return;
        }
        
        if(AdsManager.isInit == false)
        {
            goto label_8;
        }
        
        if(AdsManager.InterstitialIsReady != true)
        {
                AdsManager.InterLoad();
        }
        
        val_7 = null;
        if(AdsManager.VideoRewaredIsReady == false)
        {
            goto label_16;
        }
        
        return;
        label_8:
        AdsManager.Init();
        return;
        label_16:
        AdsManager.RewardLoad();
    }
    private void OnApplicationFocus(bool focus)
    {
        var val_3;
        if(this.internetConnection == true)
        {
                return;
        }
        
        bool val_1 = Util.InternetConnection();
        bool val_2 = val_1;
        this.internetConnection = val_2;
        if(val_1 != false)
        {
                EventDispatcherExtension.PostEvent(listener:  val_2, eventID:  22, param:  val_2);
            return;
        }
        
        val_3 = null;
        val_3 = null;
        LogEvent(eventName:  "no_internet");
    }
    private void DataManager_OnLoaded()
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        this.totalLoadTime = 7f;
        this.isSplashLoading = true;
        this.countdownCheckInternet = val_1.gameConfig.levelCountdown;
        UnityEngine.PlayerPrefs.SetInt(key:  "isFirstOpen", value:  0);
        UnityEngine.PlayerPrefs.Save();
        if((UnityEngine.PlayerPrefs.GetInt(key:  "isFirstOpen", defaultValue:  1)) == 1)
        {
                return;
        }
        
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        if(val_3.gameConfig.isShowAOA == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.ShowAOAInTime(timeStart:  3f));
    }
    private System.Collections.IEnumerator ShowAOAInTime(float timeStart)
    {
        .<>4__this = this;
        .timeStart = timeStart;
        return (System.Collections.IEnumerator)new GameUIManager.<ShowAOAInTime>d__28(<>1__state:  0);
    }
    private void Update()
    {
        if(this.isSplashLoading == false)
        {
                return;
        }
        
        float val_3 = this.time;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 / this.totalLoadTime;
        val_3 = val_3 + val_1;
        this.time = val_3;
        float val_2 = UnityEngine.Mathf.Lerp(a:  this.minPercent, b:  this.maxPercent, t:  val_3);
        this.UISplash.Setpercent(percent:  val_2);
        if(val_2 < 1f)
        {
                return;
        }
        
        this.HideSplash(force:  false);
        this.isSplashLoading = false;
    }
    private void HideSplash(bool force = False)
    {
        if(force != true)
        {
                if(this.aoaIsShowing == true)
        {
                return;
        }
        
        }
        
        if(this.UISplash.gameObject.activeSelf == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.UISplash.gameObject;
        val_3.SetActive(value:  false);
        EventDispatcherExtension.PostEvent(sender:  val_3, eventID:  100);
        DataManager val_4 = LazySingleton<DataManager>.Instance;
        if(val_4.gameConfig.isUseBrainPoint == false)
        {
                return;
        }
        
        DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameUIManager::<HideSplash>b__36_0()), ignoreTimeScale:  true);
    }
    public void ShowHideUI()
    {
    
    }
    public GameUIManager()
    {
        this.internetConnection = true;
        this.maxPercent = 1f;
    }
    private void <ShowAOAInTime>b__28_1()
    {
        this.HideSplash(force:  true);
    }
    private void <HideSplash>b__36_0()
    {
        if(this.UIDailyReward.IsAutoShowDailyReward() == false)
        {
                return;
        }
        
        goto typeof(UIDailyReward).__il2cppRuntimeField_180;
    }

}
