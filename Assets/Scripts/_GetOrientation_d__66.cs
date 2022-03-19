using UnityEngine;
private sealed class UIManager.<GetOrientation>d__66 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    private int <infiniteLoopBreak>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIManager.<GetOrientation>d__66(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        Orientation val_3;
        var val_4;
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_17;
        }
        
        this.<>1__state = 0;
        val_2 = null;
        val_2 = null;
        val_3 = UIManager.currentOrientation;
        if(val_3 != 2)
        {
                val_3 = UIManager.currentOrientation;
            UnityEngine.Debug.Log(message:  "DeviceOrientation_" + val_3);
        }
        
        this.<infiniteLoopBreak>5__2 = 0;
        goto label_10;
        label_1:
        int val_2 = this.<infiniteLoopBreak>5__2;
        this.<>1__state = 0;
        val_2 = val_2 + 1;
        this.<infiniteLoopBreak>5__2 = val_2;
        if(val_2 > 1000)
        {
            goto label_17;
        }
        
        label_10:
        val_4 = null;
        val_4 = null;
        if(UIManager.currentOrientation == 2)
        {
                UIManager.CheckDeviceOrientation();
            if(UIManager.currentOrientation == 2)
        {
                val_5 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        }
        
        label_17:
        val_5 = 0;
        return (bool)val_5;
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
