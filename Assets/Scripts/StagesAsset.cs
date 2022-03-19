using UnityEngine;
public class StagesAsset : BaseAsset<StageData>
{
    // Fields
    public string associatedSheetId;
    public string associatedWorksheet;
    
    // Properties
    public System.Collections.Generic.List<StageData> stageSaveList { get; }
    
    // Methods
    public System.Collections.Generic.List<StageData> get_stageSaveList()
    {
        var val_3;
        System.Func<StageData, StageData> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = StagesAsset.<>c.<>9__3_0;
        if(val_5 != null)
        {
                return System.Linq.Enumerable.ToList<StageData>(source:  System.Linq.Enumerable.Select<StageData, StageData>(source:  this, selector:  System.Func<StageData, StageData> val_1 = null));
        }
        
        val_5 = val_1;
        val_1 = new System.Func<StageData, StageData>(object:  StagesAsset.<>c.__il2cppRuntimeField_static_fields, method:  StageData StagesAsset.<>c::<get_stageSaveList>b__3_0(StageData x));
        StagesAsset.<>c.<>9__3_0 = val_5;
        return System.Linq.Enumerable.ToList<StageData>(source:  System.Linq.Enumerable.Select<StageData, StageData>(source:  this, selector:  val_1));
    }
    public StagesAsset(System.Collections.Generic.List<StageData> data)
    {
        this.associatedSheetId = "";
        this.associatedWorksheet = "";
        mem[1152921513425653936] = data;
    }
    public StageData Next()
    {
        StageData val_2 = System.Linq.Enumerable.FirstOrDefault<StageData>(source:  26865664, predicate:  new System.Func<StageData, System.Boolean>(object:  this, method:  System.Boolean StagesAsset::<Next>b__5_0(StageData x)));
        if(val_2 == null)
        {
                return this.Current;
        }
        
        this.Current = val_2;
        return this.Current;
    }
    public StageData StageSelect(int index)
    {
        .index = index;
        StageData val_3 = System.Linq.Enumerable.FirstOrDefault<StageData>(source:  index, predicate:  new System.Func<StageData, System.Boolean>(object:  new StagesAsset.<>c__DisplayClass6_0(), method:  System.Boolean StagesAsset.<>c__DisplayClass6_0::<StageSelect>b__0(StageData x)));
        if(val_3 == null)
        {
                return this.Current;
        }
        
        this.Current = val_3;
        return this.Current;
    }
    public StageData MaxStageUnlock()
    {
        var val_3;
        System.Func<StageData, System.Boolean> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = StagesAsset.<>c.<>9__7_0;
        if(val_5 == null)
        {
                System.Func<StageData, System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<StageData, System.Boolean>(object:  StagesAsset.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StagesAsset.<>c::<MaxStageUnlock>b__7_0(StageData x));
            StagesAsset.<>c.<>9__7_0 = val_5;
        }
        
        StageData val_2 = System.Linq.Enumerable.LastOrDefault<StageData>(source:  26865664, predicate:  val_1);
        if(val_2 == null)
        {
                return this.Current;
        }
        
        return val_2;
    }
    public StageData StageStatus(int index)
    {
        .index = index;
        return System.Linq.Enumerable.FirstOrDefault<StageData>(source:  index, predicate:  new System.Func<StageData, System.Boolean>(object:  new StagesAsset.<>c__DisplayClass8_0(), method:  System.Boolean StagesAsset.<>c__DisplayClass8_0::<StageStatus>b__0(StageData x)));
    }
    public StageData FindStage(string name, int indexMin, int indexMax)
    {
        .name = name;
        .indexMin = indexMin;
        .indexMax = indexMax;
        return System.Linq.Enumerable.FirstOrDefault<StageData>(source:  indexMax, predicate:  new System.Func<StageData, System.Boolean>(object:  new StagesAsset.<>c__DisplayClass9_0(), method:  System.Boolean StagesAsset.<>c__DisplayClass9_0::<FindStage>b__0(StageData x)));
    }
    public void AddLevel(int maxLevel)
    {
        StageData val_4;
        object val_4 = 24135;
        if(val_4 > maxLevel)
        {
                return;
        }
        
        do
        {
            StageData val_1 = null;
            val_4 = val_1;
            mem[1152921513426492056] = 2.12199579294153E-314;
            val_1 = new StageData();
            mem[1152921513426492024] = "Level_" + val_4;
            string val_3 = "Level_" + val_4;
            mem[1152921513426492016] = val_3;
            .level = val_4;
            val_3.Add(item:  val_1);
            val_4 = val_4 + 1;
        }
        while(val_4 <= maxLevel);
    
    }
    public override void ResetData()
    {
        this.ResetData();
        var val_9 = 0;
        label_17:
        if(val_9 > ((X22 + 24) - 1))
        {
            goto label_2;
        }
        
        if((X22 + 24) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = X22 + 16;
        val_4 = val_4 + 0;
        mem2[0] = val_9;
        if((X23 + 24) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = X23 + 16;
        val_5 = val_5 + 0;
        mem2[0] = val_9 + 1;
        if((X23 + 24) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = X23 + 16;
        val_6 = val_6 + 0;
        mem2[0] = (val_9 == 0) ? 1 : 0;
        if((X23 + 24) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = X23 + 16;
        val_7 = val_7 + 0;
        mem2[0] = 0;
        if((X23 + 24) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = X23 + 16;
        val_8 = val_8 + 0;
        mem2[0] = 0;
        val_9 = val_9 + 1;
        if(0 != 0)
        {
            goto label_17;
        }
        
        throw new NullReferenceException();
        label_2:
        UnityEngine.Debug.Log(message:  "Reset Level ");
    }
    public void LoadLevelFromData(StageData stage)
    {
        object val_6;
        StagesAsset.<>c__DisplayClass12_0 val_1 = null;
        val_6 = val_1;
        val_1 = new StagesAsset.<>c__DisplayClass12_0();
        .stage = stage;
        if((System.Linq.Enumerable.FirstOrDefault<StageData>(source:  stage, predicate:  new System.Func<StageData, System.Boolean>(object:  val_1, method:  System.Boolean StagesAsset.<>c__DisplayClass12_0::<LoadLevelFromData>b__0(StageData x)))) == null)
        {
                return;
        }
        
        mem2[0] = 1;
        mem2[0] = (StagesAsset.<>c__DisplayClass12_0)[1152921513426783776].stage;
        val_3.failCount = (StagesAsset.<>c__DisplayClass12_0)[1152921513426783776].stage.failCount;
        val_3.winCount = (StagesAsset.<>c__DisplayClass12_0)[1152921513426783776].stage.winCount;
        if(((StagesAsset.<>c__DisplayClass12_0)[1152921513426783776].stage) == null)
        {
                return;
        }
        
        val_6 = "SELECTED ROW: "("SELECTED ROW: ") + val_3.level;
        UnityEngine.Debug.Log(message:  val_6);
        StageData val_5 = this.StageSelect(index:  0);
    }
    public void UpdateData(int id, string level)
    {
        string val_5 = level;
        .id = id;
        if((System.Linq.Enumerable.FirstOrDefault<StageData>(source:  id, predicate:  new System.Func<StageData, System.Boolean>(object:  new StagesAsset.<>c__DisplayClass13_0(), method:  System.Boolean StagesAsset.<>c__DisplayClass13_0::<UpdateData>b__0(StageData x)))) != null)
        {
                mem2[0] = val_5;
            mem2[0] = val_5;
            return;
        }
        
        val_5 = "Update Failed Level " + (StagesAsset.<>c__DisplayClass13_0)[1152921513426962336].id((StagesAsset.<>c__DisplayClass13_0)[1152921513426962336].id);
        UnityEngine.Debug.Log(message:  val_5);
    }
    private bool <Next>b__5_0(StageData x)
    {
        var val_3;
        if(true != 0)
        {
                StageData val_1 = this.Current;
            var val_2 = (x > 1152921513425758240) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }

}
