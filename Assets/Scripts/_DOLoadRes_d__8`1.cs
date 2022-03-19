using UnityEngine;
private sealed class FileExtend.<DOLoadRes>d__8<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string fileName;
    public System.Action<T, FileStatus> result;
    private UnityEngine.ResourceRequest <request>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FileExtend.<DOLoadRes>d__8<T>(int <>1__state)
    {
        mem[1152921513373343472] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Type val_19;
        var val_20;
        var val_21;
        var val_23;
        val_20 = this;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_27;
        }
        
        val_21 = val_20;
        mem[1152921513373615632] = 0;
        mem[1152921513373615600] = 0;
        val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192});
        if((System.Type.op_Equality(left:  val_19, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
        {
            goto label_5;
        }
        
        val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192});
        bool val_6 = System.Type.op_Equality(left:  val_19, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_6 == false)
        {
            goto label_8;
        }
        
        label_5:
        label_35:
        UnityEngine.ResourceRequest val_7 = UnityEngine.Resources.LoadAsync<UnityEngine.TextAsset>(path:  val_6);
        mem[1152921513373615632] = val_7;
        if(val_7 != null)
        {
            goto label_9;
        }
        
        label_1:
        val_21 = 1152921513373615632;
        mem[1152921513373615600] = 0;
        label_37:
        label_9:
        if(1152921504879955968.isDone == false)
        {
            goto label_12;
        }
        
        if(1152921504879955968.isDone == false)
        {
            goto label_27;
        }
        
        val_19 = 1152921504879955968.asset;
        bool val_11 = UnityEngine.Object.op_Inequality(x:  val_19, y:  0);
        if(val_11 == false)
        {
            goto label_27;
        }
        
        UnityEngine.Object val_12 = val_11.asset;
        val_19 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16];
        val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        if(X0 == false)
        {
            goto label_23;
        }
        
        if(X0 == true)
        {
            goto label_24;
        }
        
        label_12:
        val_23 = 1;
        mem[1152921513373615608] = 0;
        mem[1152921513373615600] = val_23;
        return (bool)val_23;
        label_8:
        if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_30;
        }
        
        goto label_35;
        label_30:
        bool val_18 = System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if(val_18 == false)
        {
            goto label_34;
        }
        
        goto label_35;
        label_23:
        label_24:
        label_27:
        val_23 = 0;
        return (bool)val_23;
        label_34:
        if(val_18 == false)
        {
            goto label_37;
        }
        
        goto label_37;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
