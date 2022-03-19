using UnityEngine;
public class GameCoreManager : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject maskCollider;
    private Level currentLevel;
    private StageData currentLevelData;
    private bool useHint;
    private bool isWin;
    private int popupShow;
    private System.DateTime pauseTime;
    private System.DateTime startTime;
    
    // Methods
    private void OnEnable()
    {
        System.DateTime val_1 = System.DateTime.Now;
        this.pauseTime = val_1;
        System.Action<System.Object> val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelHandler(object obj)), eventID:  10, callback:  val_2, eventType:  1);
        System.Action<System.Object> val_3 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelInfoHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_3 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelInfoHandler(object obj)), eventID:  11, callback:  val_3, eventType:  1);
        System.Action<System.Object> val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::OnCheckLevelPassHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::OnCheckLevelPassHandler(object obj)), eventID:  1, callback:  val_4, eventType:  1);
        System.Action<System.Object> val_5 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::ShowHintHandler(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_5 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::ShowHintHandler(object obj)), eventID:  13, callback:  val_5, eventType:  1);
        System.Action<System.Object> val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj)), eventID:  14, callback:  val_6, eventType:  1);
        System.Action<System.Object> val_7 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_7 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj)), eventID:  15, callback:  val_7, eventType:  1);
        System.Action<System.Object> val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj)), eventID:  16, callback:  val_8, eventType:  1);
        System.Action<System.Object> val_9 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_9 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj)), eventID:  17, callback:  val_9, eventType:  1);
        System.Action<System.Object> val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj)), eventID:  60, callback:  val_10, eventType:  1);
        System.Action<System.Object> val_11 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_11 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj)), eventID:  61, callback:  val_11, eventType:  1);
        System.Action<System.Object> val_12 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
        EventDispatcherExtension.RegisterListener(listener:  val_12 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj)), eventID:  100, callback:  val_12, eventType:  1);
    }
    private void OnDisable()
    {
        System.Action<System.Object> val_23;
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                System.Action<System.Object> val_2 = null;
            val_23 = val_2;
            val_2 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelHandler(object obj));
            val_1.RemoveListener(eventID:  10, callback:  val_2);
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 != null)
        {
                System.Action<System.Object> val_4 = null;
            val_23 = val_4;
            val_4 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::InitLevelInfoHandler(object obj));
            val_3.RemoveListener(eventID:  11, callback:  val_4);
        }
        
        EventDispatcher val_5 = LazySingleton<EventDispatcher>.Instance;
        if(val_5 != null)
        {
                System.Action<System.Object> val_6 = null;
            val_23 = val_6;
            val_6 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::OnCheckLevelPassHandler(object obj));
            val_5.RemoveListener(eventID:  1, callback:  val_6);
        }
        
        EventDispatcher val_7 = LazySingleton<EventDispatcher>.Instance;
        if(val_7 != null)
        {
                System.Action<System.Object> val_8 = null;
            val_23 = val_8;
            val_8 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::ShowHintHandler(object obj));
            val_7.RemoveListener(eventID:  13, callback:  val_8);
        }
        
        EventDispatcher val_9 = LazySingleton<EventDispatcher>.Instance;
        if(val_9 != null)
        {
                System.Action<System.Object> val_10 = null;
            val_23 = val_10;
            val_10 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
            val_9.RemoveListener(eventID:  14, callback:  val_10);
        }
        
        EventDispatcher val_11 = LazySingleton<EventDispatcher>.Instance;
        if(val_11 != null)
        {
                System.Action<System.Object> val_12 = null;
            val_23 = val_12;
            val_12 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
            val_11.RemoveListener(eventID:  15, callback:  val_12);
        }
        
        EventDispatcher val_13 = LazySingleton<EventDispatcher>.Instance;
        if(val_13 != null)
        {
                System.Action<System.Object> val_14 = null;
            val_23 = val_14;
            val_14 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
            val_13.RemoveListener(eventID:  16, callback:  val_14);
        }
        
        EventDispatcher val_15 = LazySingleton<EventDispatcher>.Instance;
        if(val_15 != null)
        {
                System.Action<System.Object> val_16 = null;
            val_23 = val_16;
            val_16 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
            val_15.RemoveListener(eventID:  17, callback:  val_16);
        }
        
        EventDispatcher val_17 = LazySingleton<EventDispatcher>.Instance;
        if(val_17 != null)
        {
                System.Action<System.Object> val_18 = null;
            val_23 = val_18;
            val_18 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupShow(object obj));
            val_17.RemoveListener(eventID:  60, callback:  val_18);
        }
        
        EventDispatcher val_19 = LazySingleton<EventDispatcher>.Instance;
        if(val_19 != null)
        {
                System.Action<System.Object> val_20 = null;
            val_23 = val_20;
            val_20 = new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj));
            val_19.RemoveListener(eventID:  61, callback:  val_20);
        }
        
        EventDispatcher val_21 = LazySingleton<EventDispatcher>.Instance;
        if(val_21 == null)
        {
                return;
        }
        
        val_21.RemoveListener(eventID:  100, callback:  new System.Action<System.Object>(object:  this, method:  System.Void GameCoreManager::PopupHide(object obj)));
    }
    private void OnApplicationPause(bool pause)
    {
    
    }
    private void OnApplicationFocus(bool hasFocus)
    {
        var val_13;
        FirebaseManager val_14;
        string val_15;
        var val_17;
        var val_18;
        if(hasFocus != false)
        {
                val_13 = null;
            val_13 = null;
            val_14 = FirebaseManager.<Instance>k__BackingField;
            StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
            val_15 = val_2.level.ToString();
            StageData val_5 = LazySingleton<DataManager>.Instance.CurrentStage;
            string val_6 = val_5.failCount.ToString();
            val_17 = 1152921504887144448;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            val_14 = FirebaseManager.<Instance>k__BackingField;
            StageData val_8 = LazySingleton<DataManager>.Instance.CurrentStage;
            val_15 = val_8.level.ToString();
            StageData val_11 = LazySingleton<DataManager>.Instance.CurrentStage;
            string val_12 = val_11.failCount.ToString();
            val_17 = 1152921504887570432;
        }
        
        val_14.LogEvent(eventType:  0);
    }
    private void InitLevelHandler(object obj)
    {
        System.DateTime val_1 = System.DateTime.Now;
        this.startTime = val_1;
        this.isWin = false;
        this.HandleCanPlay();
    }
    private void InitLevelInfoHandler(object obj)
    {
        this.currentLevel = obj;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        this.currentLevelData = System.Linq.Enumerable.FirstOrDefault<StageData>(source:  obj, predicate:  new System.Func<StageData, System.Boolean>(object:  this, method:  System.Boolean GameCoreManager::<InitLevelInfoHandler>b__13_0(StageData x)));
        this.useHint = false;
    }
    private void OnCheckLevelPassHandler(object obj)
    {
        if(this.isWin != false)
        {
                return;
        }
        
        this.WinHandle();
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  12, param:  this.currentLevel);
        this.isWin = true;
        this.HandleCanPlay();
    }
    private void ShowHintHandler(object obj)
    {
        this.useHint = true;
    }
    private void WinHandle()
    {
        System.Collections.Generic.List<System.Int32> val_22;
        var val_23;
        var val_24;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        DataManager val_2 = LazySingleton<DataManager>.Instance;
        val_22 = val_2.needUpdateLevel;
        StageData val_3 = val_1.stagesAsset.Current;
        val_22.Add(item:  228976672);
        StageData val_4 = val_1.stagesAsset.Current;
        StageData val_5 = val_1.stagesAsset.GetNext(index:  228976672);
        if((val_5 != null) && ((public StageData BaseAsset<StageData>::GetNext(int index)) == 0))
        {
                StageData val_7 = LazySingleton<DataManager>.Instance.CurrentStage;
            val_23 = null;
            val_23 = null;
            val_22 = FirebaseManager.<Instance>k__BackingField;
            string val_8 = val_7.level.ToString();
            StageData val_10 = LazySingleton<DataManager>.Instance.CurrentStage;
            string val_11 = val_10.failCount.ToString();
            var val_12 = (this.useHint == false) ? (1 + 1) : 1;
            val_22.LogEvent(eventType:  0);
        }
        
        StageData val_14 = LazySingleton<DataManager>.Instance.CurrentStage;
        int val_21 = val_14.winCount;
        val_21 = val_21 + 1;
        val_14.winCount = val_21;
        StageData val_16 = LazySingleton<DataManager>.Instance.CurrentStage;
        if(val_16.level == 15)
        {
                StageData val_18 = LazySingleton<DataManager>.Instance.CurrentStage;
            if(val_18.winCount == 1)
        {
                val_24 = null;
            val_24 = null;
            LogEvent(eventName:  "pass_level_15");
            AppsflyerHelper.Log(id:  3);
        }
        
        }
        
        if(val_5 != null)
        {
                mem2[0] = 1;
            LazySingleton<DataManager>.Instance.CurrentStage = val_5;
        }
        
        LazySingleton<DataManager>.Instance.Save();
    }
    private void PopupShow(object obj)
    {
        int val_1 = this.popupShow;
        val_1 = val_1 + 1;
        this.popupShow = val_1;
        this.HandleCanPlay();
    }
    private void PopupHide(object obj)
    {
        int val_1 = this.popupShow;
        val_1 = val_1 - 1;
        this.popupShow = val_1;
        this.HandleCanPlay();
    }
    private void HandleCanPlay()
    {
        if(this.popupShow == 0)
        {
                if(this.isWin == false)
        {
            goto label_2;
        }
        
        }
        
        label_11:
        this.maskCollider.gameObject.SetActive(value:  true);
        if(this.currentLevel == 0)
        {
                return;
        }
        
        var val_3 = (this.popupShow != 0) ? 1 : 0;
        this = ???;
        goto typeof(Level).__il2cppRuntimeField_1D0;
        label_2:
        UnityEngine.GameObject val_8 = this.maskCollider.gameObject;
        goto label_11;
    }
    public GameCoreManager()
    {
        this.popupShow = 1;
    }
    private bool <InitLevelInfoHandler>b__13_0(StageData x)
    {
        return System.String.op_Equality(a:  X19, b:  this.currentLevel.name);
    }

}
