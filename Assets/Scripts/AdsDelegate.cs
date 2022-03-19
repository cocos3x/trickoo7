using UnityEngine;
public sealed class AdsManager.AdsDelegate : MulticastDelegate
{
    // Methods
    public AdsManager.AdsDelegate(object object, IntPtr method)
    {
        mem[1152921513319142112] = object;
        mem[1152921513319142120] = method;
        mem[1152921513319142096] = method;
    }
    public virtual void Invoke(AdType currentType, AdEvent currentEvent, string currentPlacement, string currentItemId)
    {
        var val_7;
        var val_8;
        AdType val_9;
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
                val_7 = 1;
        }
        
        var val_14 = 0;
        goto label_29;
        label_21:
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        System.DateTime val_1 = X25.FireTime;
        var val_11 = X24;
        val_9 = currentType;
        if((X24 + 294) == 0)
        {
            goto label_8;
        }
        
        var val_6 = X24 + 176;
        var val_7 = 0;
        val_6 = val_6 + 8;
        label_7:
        if(((X24 + 176 + 8) + -8) == val_1.dateData)
        {
            goto label_6;
        }
        
        val_7 = val_7 + 1;
        val_6 = val_6 + 16;
        if(val_7 < (X24 + 294))
        {
            goto label_7;
        }
        
        goto label_8;
        label_22:
        var val_2 = X24 + ((currentType + 72) << 4);
        val_11 = mem[(X24 + (currentType + 72) << 4) + 312];
        val_11 = (X24 + (currentType + 72) << 4) + 312;
        goto label_11;
        label_4:
        var val_8 = X24;
        val_8 = val_8 + (X25 + 72);
        goto label_27;
        label_24:
        var val_9 = X11;
        val_9 = val_9 + currentEvent;
        val_8 = val_8 + val_9;
        AdEvent val_3 = val_8 + 304;
        goto label_11;
        label_6:
        var val_10 = val_6;
        val_10 = val_10 + (X25 + 72);
        val_11 = val_11 + val_10;
        val_10 = val_11 + 304;
        label_8:
        label_11:
        int val_4 = X24.CompareTo(value:  val_9);
        goto label_27;
        label_29:
        val_9 = mem[1152921513319274616];
        if((val_9 & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921513319274616] + 74) != 4)
        {
            goto label_27;
        }
        
        goto label_27;
        label_14:
        if(mem[1152921513319274608] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921513319274616] + 72) == 1) || (((mem[1152921513319274608] + 273) & 1) != 0)) || (mem[1152921513319274600] == 0))
        {
            goto label_27;
        }
        
        if((val_9 & 1) == 0)
        {
            goto label_21;
        }
        
        if((val_9 & 1) == 0)
        {
            goto label_22;
        }
        
        if((mem[1152921513319274608] + 294) == 0)
        {
            goto label_11;
        }
        
        var val_12 = mem[1152921513319274608] + 176;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_25:
        if(((mem[1152921513319274608] + 176 + 8) + -8) == (mem[1152921513319274616] + 24))
        {
            goto label_24;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (mem[1152921513319274608] + 294))
        {
            goto label_25;
        }
        
        goto label_11;
        label_17:
        System.DateTime val_5 = val_9.FireTime;
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
    public virtual System.IAsyncResult BeginInvoke(AdType currentType, AdEvent currentEvent, string currentPlacement, string currentItemId, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
