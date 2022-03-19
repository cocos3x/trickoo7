using UnityEngine;
public sealed class MusicManager.ClipChangedDelegate : MulticastDelegate
{
    // Methods
    public MusicManager.ClipChangedDelegate(object object, IntPtr method)
    {
        mem[1152921513380784240] = object;
        mem[1152921513380784248] = method;
        mem[1152921513380784224] = method;
    }
    public virtual void Invoke(string clipName)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_17;
        var val_18;
        var val_19;
        if(X8 != 0)
        {
                val_13 = mem[X8 + 24];
            val_13 = X8 + 24;
            if(val_13 == 0)
        {
                return;
        }
        
            val_14 = X8 + 32;
        }
        else
        {
                val_13 = 1;
        }
        
        var val_24 = 0;
        string val_1 = clipName - 16;
        goto label_46;
        label_39:
        val_15 = mem[X22 + 72];
        val_15 = X22 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        System.DateTime val_2 = X22.FireTime;
        var val_13 = 0;
        val_13 = val_13 + 1;
        goto label_8;
        label_40:
        string val_3 = 1152921504621490176 + ((X22 + 72) << 4);
        val_17 = mem[(1152921504621490176 + (X22 + 72) << 4) + 312];
        goto label_17;
        label_4:
        string val_4 = 1152921504621490176 + val_15;
        goto label_25;
        label_31:
        if((clipName & 1) == 0)
        {
            goto label_11;
        }
        
        System.DateTime val_5 = X22.FireTime;
        var val_20 = val_15;
        if((X22 + 72 + 294) == 0)
        {
            goto label_15;
        }
        
        var val_14 = X22 + 72 + 176;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_14:
        if(((X22 + 72 + 176 + 8) + -8) == val_5.dateData)
        {
            goto label_13;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X22 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_15;
        label_32:
        var val_6 = val_15 + ((X22 + 72) << 4);
        val_19 = mem[(X22 + 72 + (X22 + 72) << 4) + 312];
        val_19 = (X22 + 72 + (X22 + 72) << 4) + 312;
        goto label_20;
        label_44:
        val_17 = mem[(((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8];
        val_17 = (((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8;
        goto label_17;
        label_8:
        label_17:
        int val_9 = clipName.CompareTo(value:  public System.Int32 System.UInt64::CompareTo(object value));
        goto label_25;
        label_11:
        var val_17 = val_15;
        val_17 = val_17 + (X22 + 72);
        goto label_25;
        label_34:
        var val_18 = X11;
        val_18 = val_18 + ((X22 + 72 + X22 + 72) + 304 + 8);
        val_17 = val_17 + val_18;
        var val_10 = val_17 + 304;
        label_36:
        val_19 = mem[(((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8];
        val_19 = (((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8;
        goto label_20;
        label_13:
        var val_19 = val_14;
        val_19 = val_19 + (X22 + 72);
        val_20 = val_20 + val_19;
        val_18 = val_20 + 304;
        label_15:
        label_20:
        int val_11 = val_15.CompareTo(value:  clipName);
        goto label_25;
        label_46:
        val_15 = mem[1152921513380904464];
        if((mem[1152921513380904472] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921513380904472] + 74) == 1)
        {
            goto label_45;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921513380904472] + 74) != 1)
        {
            goto label_26;
        }
        
        if(val_15 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921513380904472] + 72) == 1) || (((mem[1152921513380904464] + 273) & 1) != 0)) || ((mem[1152921513380904464] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921513380904472] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921513380904472] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921513380904464] + 294) == 0)
        {
            goto label_36;
        }
        
        var val_21 = mem[1152921513380904464] + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_35:
        if(((mem[1152921513380904464] + 176 + 8) + -8) == (mem[1152921513380904472] + 24))
        {
            goto label_34;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (mem[1152921513380904464] + 294))
        {
            goto label_35;
        }
        
        goto label_36;
        label_26:
        if(((mem[1152921513380904472] + 72) == 1) || ((mem[1152921513380904472] + 72) == 0))
        {
            goto label_45;
        }
        
        if((mem[1152921513380904472] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921513380904472] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        goto label_44;
        label_27:
        System.DateTime val_12 = mem[1152921513380904472].FireTime;
        label_45:
        label_25:
        val_24 = val_24 + 1;
        if(val_24 != val_13)
        {
            goto label_46;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(string clipName, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
