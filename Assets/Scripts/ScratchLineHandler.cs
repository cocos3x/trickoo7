using UnityEngine;
public sealed class ScratchCardInput.ScratchLineHandler : MulticastDelegate
{
    // Methods
    public ScratchCardInput.ScratchLineHandler(object object, IntPtr method)
    {
        mem[1152921513680358624] = object;
        mem[1152921513680358632] = method;
        mem[1152921513680358608] = method;
    }
    public virtual void Invoke(UnityEngine.Vector2 start, UnityEngine.Vector2 end)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(X8 != 0)
        {
                val_7 = mem[X8 + 24];
            val_7 = X8 + 24;
            if(val_7 == 0)
        {
                return;
        }
        
            val_8 = X8 + 32;
        }
        else
        {
                val_8;
            val_7 = 1;
        }
        
        var val_14 = 0;
        goto label_29;
        label_21:
        val_9 = mem[X22 + 72];
        val_9 = X22 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        System.DateTime val_1 = X22.FireTime;
        var val_11 = X21;
        if((X21 + 294) == 0)
        {
            goto label_8;
        }
        
        var val_6 = X21 + 176;
        var val_7 = 0;
        val_6 = val_6 + 8;
        label_7:
        if(((X21 + 176 + 8) + -8) == val_1.dateData)
        {
            goto label_6;
        }
        
        val_7 = val_7 + 1;
        val_6 = val_6 + 16;
        if(val_7 < (X21 + 294))
        {
            goto label_7;
        }
        
        goto label_8;
        label_22:
        var val_2 = X21 + ((X22 + 72) << 4);
        val_11 = mem[(X21 + (X22 + 72) << 4) + 312];
        val_11 = (X21 + (X22 + 72) << 4) + 312;
        goto label_11;
        label_4:
        var val_8 = X21;
        val_8 = val_8 + val_9;
        goto label_27;
        label_24:
        var val_9 = X11;
        val_9 = val_9 + W2;
        val_8 = val_8 + val_9;
        var val_3 = val_8 + 304;
        label_26:
        val_11 = mem[(((X21 + X22 + 72) + (X11 + W2)) + 304) + 8];
        val_11 = (((X21 + X22 + 72) + (X11 + W2)) + 304) + 8;
        goto label_11;
        label_6:
        var val_10 = val_6;
        val_10 = val_10 + val_9;
        val_11 = val_11 + val_10;
        val_10 = val_11 + 304;
        label_8:
        label_11:
        int val_4 = X21.CompareTo(value:  public System.Int32 System.UInt64::CompareTo(object value));
        goto label_27;
        label_29:
        if((mem[1152921513680474744] & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921513680474744] + 74) != 2)
        {
            goto label_27;
        }
        
        goto label_27;
        label_14:
        if(mem[1152921513680474736] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921513680474744] + 72) == 1) || (((mem[1152921513680474736] + 273) & 1) != 0)) || ((mem[1152921513680474736] + 273) == 0))
        {
            goto label_27;
        }
        
        if((mem[1152921513680474744] & 1) == 0)
        {
            goto label_21;
        }
        
        if((mem[1152921513680474744] & 1) == 0)
        {
            goto label_22;
        }
        
        if((mem[1152921513680474736] + 294) == 0)
        {
            goto label_26;
        }
        
        var val_12 = mem[1152921513680474736] + 176;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_25:
        if(((mem[1152921513680474736] + 176 + 8) + -8) == (mem[1152921513680474744] + 24))
        {
            goto label_24;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (mem[1152921513680474736] + 294))
        {
            goto label_25;
        }
        
        goto label_26;
        label_17:
        System.DateTime val_5 = mem[1152921513680474744].FireTime;
        if((val_5.dateData & 1) != 0)
        {
            
        }
        
        label_27:
        val_14 = val_14 + 1;
        if(val_14 != val_7)
        {
            goto label_29;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector2 start, UnityEngine.Vector2 end, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
