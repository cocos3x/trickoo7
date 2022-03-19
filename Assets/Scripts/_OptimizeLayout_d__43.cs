using UnityEngine;
private sealed class UIToast.<OptimizeLayout>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIToast <>4__this;
    private UnityEngine.WaitForEndOfFrame <wait>5__2;
    private System.Collections.Generic.List.Enumerator<UnityEngine.UI.ContentSizeFitter> <>7__wrap2;
    private UnityEngine.UI.ContentSizeFitter <item>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIToast.<OptimizeLayout>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_3;
        List.Enumerator<UnityEngine.UI.ContentSizeFitter> val_4;
        UnityEngine.WaitForEndOfFrame val_7;
        System.Collections.Generic.List<UnityEngine.UI.ContentSizeFitter> val_8;
        var val_9;
        List.Enumerator<UnityEngine.UI.ContentSizeFitter> val_10;
        UnityEngine.WaitForEndOfFrame val_11;
        int val_12;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_7 = val_1;
        val_9 = 0;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        this.<wait>5__2 = val_7;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_8 = this.<>4__this.grids;
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_2 = val_8.GetEnumerator();
        val_10 = this.<>7__wrap2;
        mem[1152921513510464256] = val_3;
        this.<>7__wrap2 = val_4;
        this.<>1__state = -3;
        goto label_6;
        label_2:
        val_8 = this.<item>5__4;
        this.<>1__state = -3;
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        val_9 = 1;
        val_8.enabled = true;
        val_8 = this.<item>5__4;
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        val_10 = this.<>7__wrap2;
        this.<item>5__4 = 0;
        label_6:
        bool val_5 = val_10.MoveNext();
        if(val_5 == false)
        {
            goto label_9;
        }
        
        this.<item>5__4 = val_5;
        val_5.enabled = false;
        val_11 = this.<wait>5__2;
        val_12 = 1;
        this.<>1__state = val_12;
        goto label_11;
        label_1:
        val_12 = 0;
        this.<>1__state = 0;
        return (bool)val_12;
        label_9:
        this.<>m__Finally1();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_11 = this.<wait>5__2;
        this.<>1__state = 2;
        val_12 = 1;
        label_11:
        this.<>2__current = val_11;
        return (bool)val_12;
        label_3:
        val_12 = 0;
        return (bool)val_12;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap2.Dispose();
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
