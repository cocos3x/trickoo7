using UnityEngine;
public sealed class DragEventHelper.OnDragEventHandler : MulticastDelegate
{
    // Methods
    public DragEventHelper.OnDragEventHandler(object object, IntPtr method)
    {
        mem[1152921513521987760] = object;
        mem[1152921513521987768] = method;
        mem[1152921513521987744] = method;
    }
    public virtual void Invoke(UnityEngine.EventSystems.PointerEventData eventData)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        var val_20;
        if(X8 != 0)
        {
                val_14 = mem[X8 + 24];
            val_14 = X8 + 24;
            if(val_14 == 0)
        {
                return;
        }
        
            val_15 = X8 + 32;
        }
        else
        {
                val_14 = 1;
        }
        
        var val_25 = 0;
        UnityEngine.EventSystems.PointerEventData val_1 = eventData - 16;
        goto label_46;
        label_39:
        val_16 = mem[X22 + 72];
        val_16 = X22 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        System.DateTime val_2 = X22.FireTime;
        var val_14 = 0;
        val_14 = val_14 + 1;
        goto label_8;
        label_40:
        UnityEngine.EventSystems.PointerEventData val_3 = 1152921504796037120 + ((X22 + 72) << 4);
        val_18 = mem[(1152921504796037120 + (X22 + 72) << 4) + 312];
        goto label_17;
        label_4:
        UnityEngine.EventSystems.PointerEventData val_4 = 1152921504796037120 + val_16;
        goto label_25;
        label_31:
        if((eventData.Equals(obj:  mem[(1152921504796037120 + X22 + 72) + 304 + 8])) == false)
        {
            goto label_11;
        }
        
        System.DateTime val_6 = X22.FireTime;
        var val_21 = val_16;
        if((X22 + 72 + 294) == 0)
        {
            goto label_15;
        }
        
        var val_15 = X22 + 72 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_14:
        if(((X22 + 72 + 176 + 8) + -8) == val_6.dateData)
        {
            goto label_13;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < (X22 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_15;
        label_32:
        var val_7 = val_16 + ((X22 + 72) << 4);
        val_20 = mem[(X22 + 72 + (X22 + 72) << 4) + 312];
        val_20 = (X22 + 72 + (X22 + 72) << 4) + 312;
        goto label_20;
        label_44:
        val_18 = mem[(((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8];
        val_18 = (((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8;
        goto label_17;
        label_8:
        label_17:
        int val_10 = eventData.CompareTo(value:  public System.Int32 System.UInt64::CompareTo(object value));
        goto label_25;
        label_11:
        var val_18 = val_16;
        val_18 = val_18 + (X22 + 72);
        goto label_25;
        label_34:
        var val_19 = X11;
        val_19 = val_19 + ((X22 + 72 + X22 + 72) + 304 + 8);
        val_18 = val_18 + val_19;
        var val_11 = val_18 + 304;
        label_36:
        val_20 = mem[(((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8];
        val_20 = (((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8;
        goto label_20;
        label_13:
        var val_20 = val_15;
        val_20 = val_20 + (X22 + 72);
        val_21 = val_21 + val_20;
        val_19 = val_21 + 304;
        label_15:
        label_20:
        int val_12 = val_16.CompareTo(value:  eventData);
        goto label_25;
        label_46:
        val_16 = mem[1152921513522107984];
        if((mem[1152921513522107992] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921513522107992] + 74) == 1)
        {
            goto label_45;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921513522107992] + 74) != 1)
        {
            goto label_26;
        }
        
        if(val_16 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921513522107992] + 72) == 1) || (((mem[1152921513522107984] + 273) & 1) != 0)) || ((mem[1152921513522107984] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921513522107992] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921513522107992] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921513522107984] + 294) == 0)
        {
            goto label_36;
        }
        
        var val_22 = mem[1152921513522107984] + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_35:
        if(((mem[1152921513522107984] + 176 + 8) + -8) == (mem[1152921513522107992] + 24))
        {
            goto label_34;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (mem[1152921513522107984] + 294))
        {
            goto label_35;
        }
        
        goto label_36;
        label_26:
        if(((mem[1152921513522107992] + 72) == 1) || ((mem[1152921513522107992] + 72) == 0))
        {
            goto label_45;
        }
        
        if((mem[1152921513522107992] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921513522107992] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        goto label_44;
        label_27:
        System.DateTime val_13 = mem[1152921513522107992].FireTime;
        label_45:
        label_25:
        val_25 = val_25 + 1;
        if(val_25 != val_14)
        {
            goto label_46;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.EventSystems.PointerEventData eventData, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
