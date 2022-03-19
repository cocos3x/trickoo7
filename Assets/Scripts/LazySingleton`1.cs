using UnityEngine;
public abstract class LazySingleton<T> : MonoBehaviour
{
    // Fields
    private static T instance;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_4;
        var val_5;
        if((UnityEngine.Object.op_Implicit(exists:  __RuntimeMethodHiddenParam + 24 + 192 + 184)) != true)
        {
                UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 302;
            val_5 = __RuntimeMethodHiddenParam + 24;
            if((val_4 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24];
            val_5 = __RuntimeMethodHiddenParam + 24;
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_4 = __RuntimeMethodHiddenParam + 24 + 302;
        }
        
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
        {
                return (DataManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        
        return (DataManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
    }
    protected virtual void Awake()
    {
        UnityEngine.Object val_3;
        var val_4;
        var val_5;
        val_3 = this;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
        {
            goto label_5;
        }
        
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        if(X0 == false)
        {
            goto label_8;
        }
        
        if(X0 == true)
        {
            goto label_9;
        }
        
        label_5:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == val_3)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_3);
        return;
        label_8:
        val_5 = 0;
        label_9:
        mem2[0] = val_5;
    }
    protected virtual void OnDestroy()
    {
        var val_2 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != this)
        {
                return;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192;
        mem2[0] = 0;
    }
    protected LazySingleton<T>()
    {
        if(this != null)
        {
                return;
        }
        
        throw new NullReferenceException();
    }

}
