using UnityEngine;
public class PersistentLazySingleton<T> : MonoBehaviour
{
    // Fields
    private static bool singletonDestroyed;
    private static T instance;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_4;
        var val_5;
        System.Object[] val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            UnityEngine.Debug.LogWarningFormat(format:  "[Singleton] Singleton was already destroyed by quiting game. Returning null", args:  val_6);
            val_7 = 0;
            return (object)val_7;
        }
        
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_8 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8)) != true)
        {
                UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            val_9 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_9 = __RuntimeMethodHiddenParam + 24 + 302;
            val_10 = __RuntimeMethodHiddenParam + 24;
            if((val_9 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24];
            val_10 = __RuntimeMethodHiddenParam + 24;
            val_9 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_9 = __RuntimeMethodHiddenParam + 24 + 302;
        }
        
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
            if((val_11 & 1) == 0)
        {
                val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
            UnityEngine.Object.DontDestroyOnLoad(target:  __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8);
        }
        
        val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_12 & 1) == 0)
        {
                val_12 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_12 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 8;
        return (object)val_7;
    }
    protected virtual void Awake()
    {
        UnityEngine.Object val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_3 = this;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) != 0)
        {
            goto label_9;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
            goto label_16;
        }
        
        label_9:
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((val_7 & 512) != 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 224) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) == this)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
        return;
        label_16:
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_8 & 1) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_9 = __RuntimeMethodHiddenParam + 24 + 192;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_9 = __RuntimeMethodHiddenParam + 24 + 192;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 184];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        if(X0 != false)
        {
                if(X0 == true)
        {
            goto label_37;
        }
        
        }
        
        val_10 = 0;
        label_37:
        mem2[0] = val_10;
    }
    protected virtual void OnDestroy()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = __RuntimeMethodHiddenParam;
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_3 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 8) != this)
        {
                return;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 302;
        }
        
        mem2[0] = 1;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192;
        mem2[0] = 0;
    }
    public PersistentLazySingleton<T>()
    {
        if(this != null)
        {
                return;
        }
        
        throw new NullReferenceException();
    }
    private static PersistentLazySingleton<T>()
    {
    
    }

}
