using UnityEngine;
public class BattleAsset : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<int> BattleLevel;
    
    // Methods
    public ProgressData getProgressData()
    {
        System.Collections.Generic.List<System.Int32> val_7;
        var val_8;
        System.Func<System.Int32, System.Int32> val_10;
        var val_11;
        int val_12;
        val_7 = this;
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        val_8 = null;
        val_8 = null;
        val_10 = BattleAsset.<>c.<>9__1_0;
        if(val_10 == null)
        {
                System.Func<System.Int32, System.Int32> val_3 = null;
            val_10 = val_3;
            val_3 = new System.Func<System.Int32, System.Int32>(object:  BattleAsset.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattleAsset.<>c::<getProgressData>b__1_0(int x));
            BattleAsset.<>c.<>9__1_0 = val_10;
        }
        
        this.BattleLevel = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  this.BattleLevel, keySelector:  val_3));
        val_11 = 0;
        label_12:
        if(val_11 >= 1152921513417006672)
        {
            goto label_9;
        }
        
        if(1152921513417006672 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((public static Spine.Unity.SkeletonAnimation Spine.Unity.SkeletonRenderer::AddSpineComponent<Spine.Unity.SkeletonAnimation>(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset)) > W23)
        {
            goto label_11;
        }
        
        val_11 = val_11 + 1;
        if(this.BattleLevel != null)
        {
            goto label_12;
        }
        
        throw new NullReferenceException();
        label_9:
        val_11 = 0;
        label_11:
        .current = ;
        if(1152921504883204096 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_7 = 1152921513256255375;
        .end = val_7;
        if(val_11 != 0)
        {
                val_7 = this.BattleLevel;
            val_11 = val_11 - 1;
            if(val_7 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (val_11 << 2);
            val_12 = mem[(1152921513256255375 + ((val_11 - 1)) << 2) + 32];
            val_12 = (1152921513256255375 + ((val_11 - 1)) << 2) + 32;
        }
        else
        {
                val_12 = 0;
        }
        
        .start = val_12;
        return (ProgressData)new ProgressData();
    }
    public BattleAsset()
    {
        this.BattleLevel = new System.Collections.Generic.List<System.Int32>();
    }

}
