using UnityEngine;
public class DataManager : LazySingleton<DataManager>
{
    // Fields
    private ThumbnailManager thumbnailAsset;
    private StagesAsset stagesAsset;
    private DailyRewardData dailyRewardData;
    private int sheetIndex;
    private GameConfig gameConfig;
    private int typeMap;
    private bool isSetupRemoteConfig;
    private GameData <gameData>k__BackingField;
    public System.Collections.Generic.List<int> needUpdateLevel;
    private System.Collections.Generic.Dictionary<string, GGLocalizationData> localizationDics;
    public static System.Action OnDataLoaded;
    
    // Properties
    public GameData gameData { get; set; }
    public ThumbnailManager ThumbnailAsset { get; }
    public StagesAsset StagesAsset { get; }
    public DailyRewardData DailyRewardData { get; }
    public GameConfig GameConfig { get; }
    public UserData UserData { get; }
    public int TypeMap { get; set; }
    public bool IsSetupRemoteConfig { get; set; }
    public StageData CurrentStage { get; set; }
    
    // Methods
    public GameData get_gameData()
    {
        return (GameData)this.<gameData>k__BackingField;
    }
    private void set_gameData(GameData value)
    {
        this.<gameData>k__BackingField = value;
    }
    public ThumbnailManager get_ThumbnailAsset()
    {
        return (ThumbnailManager)this.thumbnailAsset;
    }
    public StagesAsset get_StagesAsset()
    {
        return (StagesAsset)this.stagesAsset;
    }
    public DailyRewardData get_DailyRewardData()
    {
        return (DailyRewardData)this.dailyRewardData;
    }
    public GameConfig get_GameConfig()
    {
        return (GameConfig)this.gameConfig;
    }
    public UserData get_UserData()
    {
        if((this.<gameData>k__BackingField) == null)
        {
                return 0;
        }
        
        return (UserData)this.<gameData>k__BackingField.user;
    }
    public int get_TypeMap()
    {
        return (int)this.typeMap;
    }
    public void set_TypeMap(int value)
    {
        this.typeMap = value;
    }
    public bool get_IsSetupRemoteConfig()
    {
        return (bool)this.isSetupRemoteConfig;
    }
    public void set_IsSetupRemoteConfig(bool value)
    {
        this.isSetupRemoteConfig = value;
    }
    public StageData get_CurrentStage()
    {
        if(this.stagesAsset == null)
        {
                return (StageData)this.stagesAsset.Current;
        }
        
        return (StageData)this.stagesAsset.Current;
    }
    public void set_CurrentStage(StageData value)
    {
        this.stagesAsset.Current = value;
    }
    private void Start()
    {
        this.Load();
    }
    protected override void Awake()
    {
        this.Awake();
    }
    public void Save()
    {
        if((this.<gameData>k__BackingField) == null)
        {
                return;
        }
        
        System.DateTime val_1 = System.DateTime.Now;
        this.<gameData>k__BackingField.stages = System.Linq.Enumerable.ToList<StageData>(source:  this.stagesAsset.stageSaveList);
        System.DateTime val_4 = System.DateTime.Now;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4.dateData}, d2:  new System.DateTime() {dateData = val_1.dateData});
        UnityEngine.Debug.Log(message:  "ConvertData in " + val_5._ticks.TotalMilliseconds + "ms");
        FileExtend.SaveData<GameData>(fileName:  "GameData", data:  this.<gameData>k__BackingField);
        System.DateTime val_8 = System.DateTime.Now;
        System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_8.dateData}, d2:  new System.DateTime() {dateData = val_1.dateData});
        UnityEngine.Debug.Log(message:  "SaveData in " + val_9._ticks.TotalMilliseconds + "ms");
    }
    private void Load()
    {
        StageData val_6;
        double val_7;
        var val_14;
        ulong val_15;
        var val_16;
        object val_17;
        var val_18;
        var val_19;
        System.DateTime val_1 = System.DateTime.Now;
        val_14 = 1152921504886345728;
        val_15 = val_1.dateData;
        GameData val_2 = new GameData();
        val_16 = public static System.Object FileExtend::LoadData<GameData>(string fileName);
        object val_3 = FileExtend.LoadData<GameData>(fileName:  "GameData");
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(val_3 == null)
        {
            goto label_34;
        }
        
        val_16 = public static System.Boolean System.Linq.Enumerable::Any<StageData>(System.Collections.Generic.IEnumerable<TSource> source);
        bool val_4 = System.Linq.Enumerable.Any<StageData>(source:  val_3);
        if(val_4 == false)
        {
            goto label_34;
        }
        
        if(val_4 == false)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_5 = val_4.GetEnumerator();
        val_14 = 1152921513412095376;
        label_13:
        val_16 = public System.Boolean List.Enumerator<StageData>::MoveNext();
        if(val_7.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(val_6 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_6 + 64) == 0)
        {
            goto label_13;
        }
        
        this.stagesAsset.LoadLevelFromData(stage:  val_6);
        goto label_13;
        label_9:
        val_16 = public System.Void List.Enumerator<StageData>::Dispose();
        val_7.Dispose();
        label_34:
        if((public System.Void List.Enumerator<StageData>::Dispose()) != 0)
        {
                if(val_2 == null)
        {
                throw new NullReferenceException();
        }
        
            .user = 1152921513455505680;
        }
        
        System.DateTime val_9 = System.DateTime.Now;
        System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_9.dateData}, d2:  new System.DateTime() {dateData = val_15});
        val_7 = val_10._ticks.TotalMilliseconds;
        val_15 = "LoadData in " + val_7 + "ms";
        val_17 = val_15;
        val_16 = 0;
        UnityEngine.Debug.Log(message:  val_17);
        label_5:
        this.<gameData>k__BackingField = val_2;
        if(val_2 == null)
        {
                throw new NullReferenceException();
        }
        
        this.typeMap = (GameData)[1152921513455570992].typeMap;
        val_18 = null;
        val_18 = null;
        val_17 = FirebaseManager.<Instance>k__BackingField;
        if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
        val_17.Init(complete:  0);
        val_19 = null;
        val_19 = null;
        if(DataManager.OnDataLoaded != null)
        {
                DataManager.OnDataLoaded.Invoke();
        }
        
        UnityEngine.Application.targetFrameRate = 60;
    }
    public void ResetData()
    {
        DataManager.Reset();
        UnityEngine.Debug.Log(message:  "Reset and Update data to BUILD!!!");
    }
    public static void Reset()
    {
        FileExtend.Delete(path:  FileExtend.FileNameToPath(fileName:  "GameData.gd"));
        UnityEngine.PlayerPrefs.DeleteAll();
        UnityEngine.Debug.Log(message:  "Reset game data");
    }
    private void OnApplicationQuit()
    {
        this.Save();
    }
    public DataManager()
    {
        this.sheetIndex = 1;
        this.needUpdateLevel = new System.Collections.Generic.List<System.Int32>();
        this.localizationDics = new System.Collections.Generic.Dictionary<System.String, GGLocalizationData>();
    }
    private static DataManager()
    {
    
    }

}
