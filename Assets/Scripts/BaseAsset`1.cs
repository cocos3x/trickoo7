using UnityEngine;
[Serializable]
public class BaseAsset<T> : ScriptableObject
{
    // Fields
    public int unlockCoinBase;
    public float unlockCoinScale;
    public int unlockCoinMax;
    public int unlockAdsBase;
    public float unlockAdsScale;
    public int unlockAdsMax;
    public int unlockLevelBase;
    public float unlockLevelScale;
    public int unlockStarBase;
    public float unlockStarScale;
    public bool useRandom;
    private T current;
    public System.Collections.Generic.List<T> list;
    private static BaseAsset.DataChangedDelegate<T> OnChanged;
    private T lastCheck;
    
    // Properties
    public T Current { get; set; }
    public System.Collections.Generic.List<T> unlockedList { get; }
    public System.Collections.Generic.List<SaveData> itemSaveList { get; }
    
    // Methods
    public T get_Current()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        if(X8 == 0)
        {
            goto label_0;
        }
        
        bool val_1 = System.String.IsNullOrEmpty(value:  X8 + 16);
        if(val_1 == false)
        {
            goto label_1;
        }
        
        label_0:
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_3 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 8];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 8;
        if(val_4 == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem2[0] = val_4;
        }
        
        val_7 = X21;
        mem[1152921513411157880] = val_7;
        if(val_7 != 0)
        {
            goto label_17;
        }
        
        goto label_19;
        label_1:
        if(val_1 == false)
        {
            goto label_19;
        }
        
        label_17:
        bool val_2 = System.String.IsNullOrEmpty(value:  val_1 + 16);
        if(val_2 == false)
        {
                return (StageData)val_2;
        }
        
        label_19:
        mem[1152921513411157880] = val_2;
        if(val_2 == false)
        {
                return (StageData)val_2;
        }
        
        mem2[0] = 1;
        mem2[0] = 1;
        return (StageData)val_2;
    }
    public void set_Current(T value)
    {
        var val_7;
        var val_8;
        if(X8 == value)
        {
                return;
        }
        
        val_7 = __RuntimeMethodHiddenParam;
        if(X8 != 0)
        {
                mem2[0] = 0;
        }
        
        mem[1152921513411273976] = value;
        mem2[0] = 1;
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 56 + 184;
        if(val_8 == 0)
        {
                return;
        }
        
        val_7 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 72;
    }
    public static void add_OnChanged(BaseAsset.DataChangedDelegate<T> value)
    {
        var val_2;
        label_9:
        if((System.Delegate.Combine(a:  __RuntimeMethodHiddenParam + 24 + 192 + 56 + 184, b:  value)) == null)
        {
            goto label_4;
        }
        
        val_2 = X0;
        if(X0 == true)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        val_2 = 0;
        label_5:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184) != (__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184))
        {
            goto label_9;
        }
        
        return;
        label_6:
    }
    public static void remove_OnChanged(BaseAsset.DataChangedDelegate<T> value)
    {
        var val_2;
        label_9:
        if((System.Delegate.Remove(source:  __RuntimeMethodHiddenParam + 24 + 192 + 56 + 184, value:  value)) == null)
        {
            goto label_4;
        }
        
        val_2 = X0;
        if(X0 == true)
        {
            goto label_5;
        }
        
        goto label_6;
        label_4:
        val_2 = 0;
        label_5:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184) != (__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184))
        {
            goto label_9;
        }
        
        return;
        label_6:
    }
    public void SetChanged(T data)
    {
        var val_7;
        var val_8;
        val_7 = data;
        val_8 = this;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 184) == 0)
        {
                return;
        }
        
        val_7 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 72;
    }
    public System.Collections.Generic.List<T> get_unlockedList()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(X20 == 0)
        {
                return 0;
        }
        
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_8 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 16];
        val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 16;
        if(val_9 == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_10 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
            val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem2[0] = val_9;
        }
    
    }
    public System.Collections.Generic.List<SaveData> get_itemSaveList()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 24];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 24;
        if(val_2 == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_3 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem2[0] = val_2;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 32];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 32;
        if(val_6 != 0)
        {
                return System.Linq.Enumerable.ToList<SaveData>(source:  this);
        }
        
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
        mem2[0] = val_6;
        return System.Linq.Enumerable.ToList<SaveData>(source:  this);
    }
    public void ConvertToData(System.Collections.Generic.List<SaveData> saveData)
    {
        var val_2;
        var val_3;
        var val_6;
        var val_7;
        val_6 = saveData;
        List.Enumerator<T> val_1 = val_6.GetEnumerator();
        goto label_12;
        label_13:
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 160;
        if(val_6 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = val_2;
        if(!=0)
        {
                if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 160 + 16];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 16;
            if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 16 + 64) != 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 160 + 16];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 16;
            if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
        }
        
        }
        
        label_12:
        if(val_3.MoveNext() == true)
        {
            goto label_13;
        }
        
        val_2 = val_3;
        val_3 = null;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_3.Dispose();
        if(0 != 0)
        {
                throw __RuntimeMethodHiddenParam;
        }
    
    }
    public void ConvertToData(System.Collections.Generic.List<StageData> saveData)
    {
        var val_2;
        var val_3;
        System.Exception val_7;
        var val_8;
        List.Enumerator<T> val_1 = saveData.GetEnumerator();
        label_42:
        if(val_3.MoveNext() == false)
        {
            goto label_2;
        }
        
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 192;
        if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = val_2;
        if(X0 == false)
        {
            goto label_6;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 40;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 80;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 84;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 76;
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16;
        if(val_8 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 64) != 0)
        {
                mem2[0] = 1;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 192 + 16;
            if(val_8 == 0)
        {
                throw new NullReferenceException();
        }
        
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 192 + 16 + 65) == 0)
        {
            goto label_42;
        }
        
        mem2[0] = 1;
        goto label_42;
        label_6:
        if(==0)
        {
                throw new NullReferenceException();
        }
        
        if((X0 == false) || (X0 == true))
        {
            goto label_42;
        }
        
        goto label_42;
        label_2:
        val_7 = 0;
        val_2 = val_3;
        val_3 = null;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_3.Dispose();
        if(val_7 != 0)
        {
                throw val_7;
        }
    
    }
    public T GetCanUnlock(UnlockType unlockType, int value, bool random)
    {
        var val_4;
        BaseAsset<T> val_5;
        int val_6;
        UnlockType val_7;
        UnlockType val_8;
        val_4 = random;
        val_5 = this;
        mem2[0] = val_5;
        mem2[0] = value;
        mem2[0] = unlockType;
        if(val_4 == false)
        {
            goto label_3;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 240) == 0)
        {
            goto label_4;
        }
        
        if(unlockType == 0)
        {
            goto label_19;
        }
        
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        val_6 = unlockType;
        if((unlockType == 0) || ((val_6 & 1) == 0))
        {
            goto label_19;
        }
        
        int val_1 = UnityEngine.Random.Range(min:  0, max:  val_6);
        val_7 = val_6;
        goto label_18;
        label_3:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 240) == 0)
        {
            goto label_10;
        }
        
        if(unlockType == 0)
        {
            goto label_19;
        }
        
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        val_7 = unlockType;
        goto label_18;
        label_4:
        if(unlockType == 0)
        {
            goto label_19;
        }
        
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        val_6 = unlockType;
        if((unlockType == 0) || ((val_6 & 1) == 0))
        {
            goto label_19;
        }
        
        int val_2 = UnityEngine.Random.Range(min:  0, max:  val_6);
        val_7 = val_6;
        goto label_18;
        label_10:
        if(unlockType == 0)
        {
            goto label_19;
        }
        
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
        val_7 = unlockType;
        label_18:
        val_8 = val_7;
        if(val_7 == 0)
        {
                return (object)val_8;
        }
        
        mem[1152921513412244920] = val_8;
        return (object)val_8;
        label_19:
        val_8 = 0;
        return (object)val_8;
    }
    public T GetNext(int index)
    {
        var val_7;
        var val_8;
        val_7 = __RuntimeMethodHiddenParam;
        mem2[0] = index;
        if(index == 0)
        {
                return 0;
        }
        
        val_7 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 184;
    }
    public void UpdateIdByName()
    {
        var val_1;
        object val_2;
        var val_10;
        int val_11;
        var val_12;
        val_10 = this;
        label_27:
        if(val_2.MoveNext() == false)
        {
            goto label_2;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 336) == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = val_1;
        if(val_1 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_1 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        string val_4 = val_1 + 16.Replace(oldValue:  "\'", newValue:  "");
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = val_4.Replace(oldValue:  " ", newValue:  "_");
        if(val_1 < 2)
        {
            goto label_27;
        }
        
        object[] val_6 = new object[4];
        if((__RuntimeMethodHiddenParam + 24 + 192 + 336 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 336 + 16 + 40;
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_2 != 0)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        val_11 = val_6.Length;
        val_6[0] = val_2;
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_11 = val_6.Length;
        if(val_11 <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_6[1] = " ";
        if((__RuntimeMethodHiddenParam + 24 + 192 + 336 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 336 + 16 + 24) != 0)
        {
                val_11 = val_6.Length;
        }
        
        if(val_11 <= 2)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_6[2] = __RuntimeMethodHiddenParam + 24 + 192 + 336 + 16 + 24;
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_11 = val_6.Length;
        if(val_11 <= 3)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_6[3] = " is Duplicated";
        UnityEngine.Debug.LogError(message:  +val_6);
        goto label_27;
        label_2:
        val_10 = 0;
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 384;
        val_1 = val_2;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 294) == 0)
        {
            goto label_32;
        }
        
        var val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 384 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_31:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 176 + 8) + -8) == null)
        {
            goto label_30;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (__RuntimeMethodHiddenParam + 24 + 192 + 384 + 294))
        {
            goto label_31;
        }
        
        goto label_32;
        label_30:
        val_12 = ((__RuntimeMethodHiddenParam + 24 + 192 + 384) + (((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 176 + 8)) << 4)) + 304;
        label_32:
        val_2.Dispose();
        if(val_10 != 0)
        {
                throw val_10;
        }
        
        UnityEngine.Debug.Log(message:  "Update Id By Name");
    }
    public void UpdateIndex()
    {
        object val_4;
        int val_5;
        int val_6;
        mem2[0] = this;
        mem2[0] = 0;
        do
        {
            if(0 >= (__RuntimeMethodHiddenParam + 24 + 192 + 392))
        {
                return;
        }
        
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 392 + 16;
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            if(0 >= 2)
        {
                object[] val_1 = new object[4];
            val_5 = val_1.Length;
            val_1[0] = __RuntimeMethodHiddenParam + 24 + 192 + 368 + 40;
            val_5 = val_1.Length;
            val_1[1] = " ";
            val_4 = mem[X0 + 24];
            val_4 = X0 + 24;
            val_6 = val_1.Length;
            val_1[2] = val_4;
            val_6 = val_1.Length;
            val_1[3] = " is Duplicated";
            string val_2 = +val_1;
            UnityEngine.Debug.LogError(message:  val_2);
        }
        
            mem2[0] = (__RuntimeMethodHiddenParam + 24 + 192 + 392 + 16) + 1;
        }
        while(val_2 != null);
        
        throw new NullReferenceException();
    }
    public void OderByIndex()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        object val_8;
        int val_9;
        int val_10;
        mem2[0] = this;
        mem2[0] = 0;
        do
        {
            if(0 >= (__RuntimeMethodHiddenParam + 24 + 192 + 424))
        {
                return;
        }
        
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 40];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 40;
            if(val_5 == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_6 & 1) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 448;
            mem2[0] = val_5;
        }
        
            mem[1152921513412779520] = 0;
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            if(0 >= 2)
        {
                object[] val_1 = new object[4];
            val_9 = val_1.Length;
            val_1[0] = "{0:X4}:{1:X4}:{2:X4}:{3:X4}:{4:X4}:{5:X4}:{6:X4}:{7:X4}";
            val_9 = val_1.Length;
            val_1[1] = " ";
            val_8 = mem[X0 + 24];
            val_8 = X0 + 24;
            val_10 = val_1.Length;
            val_1[2] = val_8;
            val_10 = val_1.Length;
            val_1[3] = " is Duplicated";
            string val_2 = +val_1;
            UnityEngine.Debug.LogError(message:  val_2);
        }
        
            mem2[0] = (__RuntimeMethodHiddenParam + 24 + 192 + 424 + 16) + 1;
        }
        while(val_2 != null);
        
        throw new NullReferenceException();
    }
    public void UpdateCost()
    {
        var val_15;
        object val_16;
        var val_17;
        System.Object[] val_18;
        int val_19;
        int val_20;
        object val_21;
        int val_22;
        int val_24;
        int val_25;
        int val_26;
        string val_2 = "UPDATE COST " + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 480})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 480}));
        UnityEngine.Debug.Log(message:  val_2);
        val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_15 = __RuntimeMethodHiddenParam + 24 + 192;
        if(val_2 >= 1)
        {
                var val_15 = 0;
            val_16 = 4;
            do
        {
            mem2[0] = (val_15 == 0) ? 1 : 0;
            mem2[0] = 0;
            mem2[0] = val_16;
            val_15 = val_15 + 1;
            val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_15 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        while(val_15 < val_2);
        
        }
        
        if(val_2 < 1)
        {
                return;
        }
        
        val_17 = 0;
        var val_20 = 0;
        var val_22 = 0;
        label_73:
        val_16 = val_2;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 272) == 3)
        {
            goto label_14;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 272) != 1)
        {
            goto label_15;
        }
        
        float val_16 = (float)W24 * val_17;
        float val_17 = (float)W24;
        val_16 = S8 * val_16;
        val_17 = val_16 + val_17;
        mem2[0] = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_17), min:  0, max:  __RuntimeMethodHiddenParam + 24 + 192 + 272);
        val_18 = new object[7];
        val_19 = val_7.Length;
        val_18[0] = 1152921504899144384;
        val_19 = val_7.Length;
        val_18[1] = " ";
        val_20 = val_7.Length;
        val_18[2] = " ";
        val_20 = val_7.Length;
        val_18[3] = " ";
        val_21 = " ";
        val_22 = val_7.Length;
        val_18[4] = val_21;
        val_22 = val_7.Length;
        val_18[5] = " ";
        if(val_16 != null)
        {
                val_22 = val_7.Length;
        }
        
        val_17 = val_17 + 1;
        goto label_40;
        label_14:
        float val_18 = (float)W24 * val_20;
        float val_19 = (float)W24;
        val_18 = S8 * val_18;
        val_19 = val_18 + val_19;
        mem2[0] = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_19), min:  0, max:  __RuntimeMethodHiddenParam + 24 + 192 + 272);
        object[] val_11 = new object[7];
        val_18 = val_11;
        val_24 = val_11.Length;
        val_18[0] = 1152921504899144384;
        val_24 = val_11.Length;
        val_18[1] = " ";
        val_25 = val_11.Length;
        val_18[2] = " ";
        val_25 = val_11.Length;
        val_18[3] = " ";
        val_21 = " ";
        val_26 = val_11.Length;
        val_18[4] = val_21;
        val_26 = val_11.Length;
        val_18[5] = " ";
        if(val_16 != null)
        {
                val_26 = val_11.Length;
        }
        
        val_20 = val_20 + 1;
        label_40:
        val_18[6] = val_16;
        val_16 = +val_11;
        UnityEngine.Debug.Log(message:  val_16);
        goto label_67;
        label_15:
        if((val_22 == 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 272) == 4))
        {
                mem2[0] = 1;
        }
        
        float val_21 = (float)W24;
        val_21 = S8 + val_21;
        mem2[0] = (UnityEngine.Mathf.RoundToInt(f:  val_21)) * val_22;
        label_67:
        val_22 = val_22 + 1;
        if(val_22 < val_2)
        {
            goto label_73;
        }
    
    }
    public void UnlockAll()
    {
        var val_2;
        var val_3;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 48];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 184 + 48;
        if(val_8 == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((val_9 & 1) == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302];
            val_9 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
        }
        
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192;
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem2[0] = val_8;
        }
        
        var val_1 = (26890240 < (__RuntimeMethodHiddenParam + 24 + 192)) ? 1 : 0;
        goto label_17;
        label_19:
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = val_1;
        label_17:
        if(val_3.MoveNext() == true)
        {
            goto label_19;
        }
        
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 384;
        val_2 = val_3;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 294) == 0)
        {
            goto label_24;
        }
        
        var val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 384 + 176;
        var val_7 = 0;
        val_6 = val_6 + 8;
        label_23:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 176 + 8) + -8) == null)
        {
            goto label_22;
        }
        
        val_7 = val_7 + 1;
        val_6 = val_6 + 16;
        if(val_7 < (__RuntimeMethodHiddenParam + 24 + 192 + 384 + 294))
        {
            goto label_23;
        }
        
        goto label_24;
        label_22:
        val_11 = ((__RuntimeMethodHiddenParam + 24 + 192 + 384) + (((__RuntimeMethodHiddenParam + 24 + 192 + 384 + 176 + 8)) << 4)) + 304;
        label_24:
        val_3.Dispose();
        if(0 != 0)
        {
                throw val_1;
        }
    
    }
    public virtual void ResetData()
    {
        var val_2 = 0;
        label_12:
        if(val_2 >= this)
        {
            goto label_1;
        }
        
        mem[1152921513413218324] = 0;
        mem[1152921513413218328] = 0;
        mem[1152921513413218321] = 0;
        mem[1152921513413218320] = (val_2 == 0) ? 1 : 0;
        mem[1152921513413218332] = 0;
        val_2 = val_2 + 1;
        if(this != null)
        {
            goto label_12;
        }
        
        throw new NullReferenceException();
        label_1:
        mem[1152921513413218328] = 0;
    }
    public void ClearLog()
    {
    
    }
    public BaseAsset<T>()
    {
        mem[1152921513413442280] = 100;
        mem[1152921513413442288] = 6.36598752111551E-314;
        mem[1152921513413442296] = 1065353216;
        mem[1152921513413442308] = 1077936128;
        mem[1152921513413442300] = 6.36598737536615E-314;
        mem[1152921513413442316] = 1056964608;
        mem[1152921513413442336] = __RuntimeMethodHiddenParam + 24 + 192 + 496;
    }

}
