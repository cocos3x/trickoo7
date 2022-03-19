using UnityEngine;
public class FirebaseManager : MonoBehaviour
{
    // Fields
    private static FirebaseManager <Instance>k__BackingField;
    private bool firebaseIsReady;
    private int _typeDefault;
    public static System.Action OnDataLoaded;
    private System.Reflection.PropertyInfo[] propertyInfo;
    private System.Collections.Generic.List<string> parameterName;
    private System.Collections.Generic.List<string> parameterValue;
    private object stringCache;
    private string _null;
    public bool enableLog;
    
    // Properties
    public static FirebaseManager Instance { get; set; }
    
    // Methods
    public static FirebaseManager get_Instance()
    {
        null = null;
        return (FirebaseManager)FirebaseManager.<Instance>k__BackingField;
    }
    public static void set_Instance(FirebaseManager value)
    {
        null = null;
        FirebaseManager.<Instance>k__BackingField = value;
    }
    private void Awake()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if((FirebaseManager.<Instance>k__BackingField) != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        val_7 = null;
        val_7 = null;
        FirebaseManager.<Instance>k__BackingField = this;
        this.parameterName = new System.Collections.Generic.List<System.String>();
        this.parameterValue = new System.Collections.Generic.List<System.String>();
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void Init(System.Action complete)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        FirebaseManager.OnDataLoaded = complete;
        if(val_1.isSetupRemoteConfig != false)
        {
                val_6 = null;
            val_6 = null;
            FirebaseManager.OnDataLoaded.Invoke();
        }
        else
        {
                LazySingleton<DataManager>.Instance.InitializeFirebase();
        }
        
        System.Threading.Tasks.Task val_4 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  this, method:  System.Void FirebaseManager::<Init>b__14_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)));
    }
    public System.Threading.Tasks.Task FetchDataAsync()
    {
        return Firebase.Extensions.TaskExtension.ContinueWithOnMainThread(task:  Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.FetchAsync(cacheExpiration:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero}), continuation:  new System.Action<System.Threading.Tasks.Task>(object:  this, method:  System.Void FirebaseManager::FetchComplete(System.Threading.Tasks.Task obj)));
    }
    private void FetchComplete(System.Threading.Tasks.Task obj)
    {
        int val_56;
        int val_57;
        int val_58;
        var val_59;
        Firebase.RemoteConfig.ConfigInfo val_2 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.Info;
        Firebase.RemoteConfig.LastFetchStatus val_3 = val_2.LastFetchStatus;
        if(val_3 == 1)
        {
            goto label_5;
        }
        
        if(val_3 != 0)
        {
            goto label_11;
        }
        
        System.Threading.Tasks.Task<System.Boolean> val_5 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.ActivateAsync();
        DataManager val_6 = LazySingleton<DataManager>.Instance;
        val_6.isSetupRemoteConfig = true;
        goto label_11;
        label_5:
        Firebase.RemoteConfig.FetchFailureReason val_7 = val_2.LastFetchFailureReason;
        label_11:
        Firebase.RemoteConfig.ConfigValue val_9 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "type_map");
        string val_10 = val_9.<Data>k__BackingField.StringValue;
        if((System.String.op_Equality(a:  val_10, b:  "")) == false)
        {
            goto label_15;
        }
        
        val_56 = this._typeDefault;
        if((LazySingleton<DataManager>.Instance) != null)
        {
            goto label_16;
        }
        
        label_15:
        val_56 = val_10;
        label_16:
        val_11.typeMap = System.Int32.Parse(s:  val_56);
        DataManager val_14 = LazySingleton<DataManager>.Instance;
        UnityEngine.Debug.Log(message:  "[FireBase] TypeMap: "("[FireBase] TypeMap: ") + val_14.typeMap);
        Firebase.RemoteConfig.ConfigValue val_17 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "time_show_ad");
        string val_18 = val_17.<Data>k__BackingField.StringValue;
        DataManager val_19 = LazySingleton<DataManager>.Instance;
        if((System.String.op_Equality(a:  val_18, b:  "")) == false)
        {
            goto label_26;
        }
        
        DataManager val_21 = LazySingleton<DataManager>.Instance;
        val_57 = val_21.gameConfig.timePlayToShowAds;
        if(val_19.gameConfig != null)
        {
            goto label_29;
        }
        
        label_26:
        val_57 = val_18;
        label_29:
        val_19.gameConfig.timePlayToShowAds = System.Int32.Parse(s:  val_57);
        Firebase.RemoteConfig.ConfigValue val_24 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "rating_config");
        DataManager val_28 = LazySingleton<DataManager>.Instance;
        val_28.gameConfig.isShowRate = System.Int32.Parse(s:  val_24.<Data>k__BackingField.StringValue).Equals(obj:  1);
        Firebase.RemoteConfig.ConfigValue val_31 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "is_show_aoa");
        DataManager val_35 = LazySingleton<DataManager>.Instance;
        val_35.gameConfig.isShowAOA = System.Int32.Parse(s:  val_31.<Data>k__BackingField.StringValue).Equals(obj:  1);
        Firebase.RemoteConfig.ConfigValue val_38 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "is_use_brain_point");
        DataManager val_42 = LazySingleton<DataManager>.Instance;
        val_42.gameConfig.isUseBrainPoint = System.Int32.Parse(s:  val_38.<Data>k__BackingField.StringValue).Equals(obj:  1);
        Firebase.RemoteConfig.ConfigValue val_45 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "level_show_ads");
        string val_46 = val_45.<Data>k__BackingField.StringValue;
        DataManager val_47 = LazySingleton<DataManager>.Instance;
        if((System.String.op_Equality(a:  val_46, b:  "")) == false)
        {
            goto label_45;
        }
        
        DataManager val_49 = LazySingleton<DataManager>.Instance;
        val_58 = val_49.gameConfig.levelPlayToShowAds;
        if(val_47.gameConfig != null)
        {
            goto label_48;
        }
        
        label_45:
        val_58 = val_46;
        label_48:
        val_47.gameConfig.levelPlayToShowAds = System.Int32.Parse(s:  val_58);
        DataManager val_51 = LazySingleton<DataManager>.Instance;
        val_51.gameConfig.isUseBrainPoint = false;
        DataManager val_52 = LazySingleton<DataManager>.Instance;
        UnityEngine.Debug.Log(message:  "[FireBase] TimeShowAds: "("[FireBase] TimeShowAds: ") + val_52.gameConfig.timePlayToShowAds);
        DataManager val_54 = LazySingleton<DataManager>.Instance;
        UnityEngine.Debug.Log(message:  "[FireBase] LevelShowAds: "("[FireBase] LevelShowAds: ") + val_54.gameConfig.levelPlayToShowAds);
        val_59 = null;
        val_59 = null;
        FirebaseManager.OnDataLoaded.Invoke();
    }
    private void InitializeFirebase()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "type_map", value:  1);
        val_1.Add(key:  "rating_config", value:  0);
        val_1.Add(key:  "time_show_ad", value:  20);
        val_1.Add(key:  "is_show_aoa", value:  1);
        val_1.Add(key:  "is_use_brain_point", value:  0);
        val_1.Add(key:  "level_show_ads", value:  3);
        System.Threading.Tasks.Task val_3 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.SetDefaultsAsync(defaults:  val_1);
    }
    public void LogEvent(object eventType)
    {
        string val_8;
        System.Collections.Generic.List<System.String> val_9;
        if(this.firebaseIsReady == false)
        {
                return;
        }
        
        this.propertyInfo = eventType.GetType().GetProperties();
        this.parameterName.Clear();
        this.parameterValue.Clear();
        val_8 = 1152921507999092496;
        var val_13 = 4;
        label_19:
        if((val_13 - 4) >= this.propertyInfo.Length)
        {
            goto label_7;
        }
        
        object val_4 = this.propertyInfo[0].GetValue(obj:  eventType);
        this.stringCache = val_4;
        if(val_4 != null)
        {
                if((val_4.Equals(value:  this._null)) != true)
        {
                this.parameterName.Add(item:  this.propertyInfo[0]);
            this.parameterValue.Add(item:  this.stringCache);
        }
        
        }
        
        val_13 = val_13 + 1;
        if(this.propertyInfo != null)
        {
            goto label_19;
        }
        
        label_7:
        System.Collections.Generic.List<System.String> val_14 = this.parameterName;
        System.Collections.Generic.List<System.String> val_6 = val_14 - 1;
        Firebase.Analytics.Parameter[] val_7 = new Firebase.Analytics.Parameter[0];
        val_9 = this.parameterName;
        var val_15 = 0;
        label_31:
        var val_8 = val_15 + 1;
        if(val_8 >= val_14)
        {
            goto label_23;
        }
        
        val_14 = val_14 & 4294967295;
        if(val_8 >= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_8 >= 1152921506247497440)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = mem[typeof(System.Collections.Generic.List<T>).SyncRoot + 40];
        var val_10 = val_8 - 1;
        mem2[0] = new Firebase.Analytics.Parameter(parameterName:  typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_28, parameterValue:  val_8);
        val_9 = this.parameterName;
        val_15 = val_15 + 1;
        if(val_9 != null)
        {
            goto label_31;
        }
        
        throw new NullReferenceException();
        label_23:
        if(val_7.Length == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "[{0}: {1}]", parameters:  val_7);
    }
    public void LogEvent(string eventName)
    {
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  eventName);
    }
    public FirebaseManager()
    {
        this._typeDefault = 2;
        this.enableLog = true;
        this._null = "NONE";
    }
    private static FirebaseManager()
    {
    
    }
    private void <Init>b__14_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
    {
        var val_5;
        var val_6;
        val_5 = this;
        Firebase.DependencyStatus val_1 = task.Result;
        if(val_1 != 0)
        {
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Could not resolve all Firebase dependencies: {0}", arg0:  val_1));
            val_5 = 1152921504888262656;
            val_6 = null;
            val_6 = null;
            FirebaseManager.OnDataLoaded.Invoke();
            return;
        }
        
        this.firebaseIsReady = true;
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        if(val_3.isSetupRemoteConfig != false)
        {
                return;
        }
        
        System.Threading.Tasks.Task val_4 = this.FetchDataAsync();
    }

}
