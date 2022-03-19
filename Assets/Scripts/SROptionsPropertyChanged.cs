using UnityEngine;
public sealed class SROptionsPropertyChanged : MulticastDelegate
{
    // Methods
    public SROptionsPropertyChanged(object object, IntPtr method)
    {
        mem[1152921513514922176] = object;
        mem[1152921513514922184] = method;
        mem[1152921513514922160] = method;
    }
    public virtual void Invoke(object sender, string propertyName)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        if(X8 != 0)
        {
                val_15 = mem[X8 + 24];
            val_15 = X8 + 24;
            if(val_15 == 0)
        {
                return;
        }
        
            val_16 = X8 + 32;
        }
        else
        {
                val_15 = 1;
        }
        
        var val_26 = 0;
        object val_1 = sender - 16;
        string val_2 = propertyName - 16;
        goto label_49;
        label_39:
        val_17 = mem[X24 + 72];
        val_17 = X24 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        System.DateTime val_3 = X24.FireTime;
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_8;
        label_40:
        object val_4 = 1152921504625750016 + ((X24 + 72) << 4);
        val_19 = mem[(1152921504625750016 + (X24 + 72) << 4) + 312];
        goto label_17;
        label_4:
        object val_5 = 1152921504625750016 + val_17;
        goto label_25;
        label_31:
        if((sender & 1) == 0)
        {
            goto label_11;
        }
        
        System.DateTime val_6 = X24.FireTime;
        var val_22 = val_17;
        if((X24 + 72 + 294) == 0)
        {
            goto label_15;
        }
        
        var val_16 = X24 + 72 + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_14:
        if(((X24 + 72 + 176 + 8) + -8) == val_6.dateData)
        {
            goto label_13;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < (X24 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_15;
        label_32:
        var val_7 = val_17 + ((X24 + 72) << 4);
        val_21 = mem[(X24 + 72 + (X24 + 72) << 4) + 312];
        val_21 = (X24 + 72 + (X24 + 72) << 4) + 312;
        goto label_20;
        label_44:
        val_19 = mem[(((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8];
        val_19 = (((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8;
        goto label_17;
        label_8:
        label_17:
        int val_10 = sender.CompareTo(value:  propertyName);
        goto label_25;
        label_11:
        var val_19 = val_17;
        val_19 = val_19 + (X24 + 72);
        goto label_25;
        label_34:
        var val_20 = X11;
        val_20 = val_20 + propertyName;
        val_19 = val_19 + val_20;
        string val_11 = val_19 + 304;
        goto label_20;
        label_13:
        var val_21 = val_16;
        val_21 = val_21 + (X24 + 72);
        val_22 = val_22 + val_21;
        val_20 = val_22 + 304;
        label_15:
        label_20:
        int val_12 = val_17.CompareTo(value:  sender);
        goto label_25;
        label_49:
        val_17 = mem[1152921513515046496];
        if((mem[1152921513515046504] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921513515046504] + 74) == 2)
        {
            goto label_48;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921513515046504] + 74) != 2)
        {
            goto label_26;
        }
        
        if(val_17 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921513515046504] + 72) == 1) || (((mem[1152921513515046496] + 273) & 1) != 0)) || ((mem[1152921513515046496] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921513515046504] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921513515046504] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921513515046496] + 294) == 0)
        {
            goto label_20;
        }
        
        var val_23 = mem[1152921513515046496] + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_35:
        if(((mem[1152921513515046496] + 176 + 8) + -8) == (mem[1152921513515046504] + 24))
        {
            goto label_34;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (mem[1152921513515046496] + 294))
        {
            goto label_35;
        }
        
        goto label_20;
        label_26:
        if(((mem[1152921513515046504] + 72) == 1) || ((mem[1152921513515046504] + 72) == 0))
        {
            goto label_38;
        }
        
        if((mem[1152921513515046504] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921513515046504] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        goto label_44;
        label_38:
        if(val_17 != 0)
        {
            goto label_48;
        }
        
        System.DateTime val_13 = mem[1152921513515046504].FireTime;
        if((val_13.dateData & 1) == 0)
        {
            goto label_48;
        }
        
        goto label_48;
        label_27:
        System.DateTime val_14 = mem[1152921513515046504].FireTime;
        label_48:
        label_25:
        val_26 = val_26 + 1;
        if(val_26 != val_15)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(object sender, string propertyName, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
