using UnityEngine;
public class UnbiasedTime : MonoBehaviour
{
    // Fields
    private static UnbiasedTime instance;
    public long timeOffset;
    
    // Properties
    public static UnbiasedTime Instance { get; }
    
    // Methods
    public static UnbiasedTime get_Instance()
    {
        UnbiasedTime val_4 = UnbiasedTime.instance;
        if(val_4 != 0)
        {
                return (UnbiasedTime)UnbiasedTime.instance;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "UnbiasedTimeSingleton");
        UnbiasedTime.instance = val_2.AddComponent<UnbiasedTime>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        return (UnbiasedTime)UnbiasedTime.instance;
    }
    private void Awake()
    {
        this.StartAndroid();
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause != false)
        {
                this.EndAndroid();
            return;
        }
        
        this.StartAndroid();
    }
    private void OnApplicationQuit()
    {
        this.EndAndroid();
    }
    public System.DateTime Now()
    {
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddSeconds(value:  (double)-(float)this.timeOffset);
        return (System.DateTime)val_2.dateData;
    }
    public void UpdateTimeOffset()
    {
        this.UpdateTimeOffsetAndroid();
    }
    public bool IsUsingSystemTime()
    {
        return this.UsingSystemTimeAndroid();
    }
    private void SessionStart()
    {
        this.StartAndroid();
    }
    private void SessionEnd()
    {
        this.EndAndroid();
    }
    private void UpdateTimeOffsetAndroid()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.vasilij.unbiasedtime.UnbiasedTime");
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.AndroidJavaObject val_4 = val_2.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_11 = 0;
        if((val_3 == null) || (val_4 == null))
        {
            goto label_4;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_4;
        val_11 = 0;
        this.timeOffset = val_3.CallStatic<System.Int64>(methodName:  "vtcTimestampOffset", args:  val_5);
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_14;
        }
        
        label_8:
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_3.Dispose();
        label_14:
        if( == 0)
        {
                if(val_9 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
            if(0 != 0)
        {
                throw 0;
        }
        
            return;
        }
        
        val_10 = ;
        val_12 = 0;
        throw val_10;
    }
    private void StartAndroid()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.vasilij.unbiasedtime.UnbiasedTime");
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.AndroidJavaObject val_4 = val_2.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_11 = 0;
        if((val_3 == null) || (val_4 == null))
        {
            goto label_4;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_4;
        val_3.CallStatic(methodName:  "vtcOnSessionStart", args:  val_5);
        val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_11 = 0;
        this.timeOffset = val_3.CallStatic<System.Int64>(methodName:  "vtcTimestampOffset", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        goto label_14;
        label_4:
        if(val_3 == null)
        {
            goto label_21;
        }
        
        label_14:
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_3.Dispose();
        label_21:
        if( == 0)
        {
                if(val_9 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
            if(0 != 0)
        {
                throw 0;
        }
        
            return;
        }
        
        val_10 = ;
        val_13 = 0;
        throw val_10;
    }
    private void EndAndroid()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(UnityEngine.Application.platform != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_8 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.vasilij.unbiasedtime.UnbiasedTime");
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.AndroidJavaObject val_4 = val_2.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        val_10 = 0;
        if((val_3 == null) || (val_4 == null))
        {
            goto label_4;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_4;
        val_3.CallStatic(methodName:  "vtcOnSessionEnd", args:  val_5);
        val_10 = 0;
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_13;
        }
        
        label_8:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_3.Dispose();
        label_13:
        if( == 0)
        {
                if(val_8 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_2.Dispose();
        }
        
            if(0 != 0)
        {
                throw 0;
        }
        
            return;
        }
        
        val_9 = ;
        val_11 = 0;
        throw val_9;
    }
    private bool UsingSystemTimeAndroid()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_20;
        if(UnityEngine.Application.platform != 11)
        {
            goto label_24;
        }
        
        UnityEngine.AndroidJavaClass val_2 = null;
        val_13 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.vasilij.unbiasedtime.UnbiasedTime");
        if((val_3 == null) || ((val_2.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity")) == null))
        {
            goto label_4;
        }
        
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_15 = 0;
        val_16 = 0;
        val_17 = val_3.CallStatic<System.Boolean>(methodName:  "vtcUsingDeviceTime", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        goto label_11;
        label_4:
        val_16 = 0;
        val_15 = 0;
        val_17 = 0;
        if(val_3 == null)
        {
            goto label_12;
        }
        
        label_11:
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_3.Dispose();
        label_12:
        if(val_15 != 0)
        {
                throw var val_7 = (val_17 != 0) ? 1 : 0;
        }
        
        if(val_13 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_2.Dispose();
        }
        
        if(0 != 0)
        {
                throw 0;
        }
        
        if(val_16 != 1)
        {
                val_20 = val_7 | ((90 != 92) ? 1 : 0);
            return (bool)val_20;
        }
        
        label_24:
        val_20 = 1;
        return (bool)val_20;
    }
    public UnbiasedTime()
    {
    
    }

}
