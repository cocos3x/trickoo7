using UnityEngine;
private sealed class UIManager.<GetScreenSize>d__63 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIManager <>4__this;
    private int <infiniteLoopBreak>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIManager.<GetScreenSize>d__63(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        var val_10;
        int val_11;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_15;
        }
        
        this.<infiniteLoopBreak>5__2 = 0;
        this.<>1__state = 0;
        val_9 = null;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        UIManager.UpdateUIScreenRect();
        val_9 = null;
        if(UIManager.firstPass != false)
        {
                val_9 = null;
            val_10 = 1152921504878149688;
            UIManager.firstPass = false;
        }
        
        int val_8 = this.<infiniteLoopBreak>5__2;
        val_8 = val_8 + 1;
        this.<infiniteLoopBreak>5__2 = val_8;
        if(val_8 > 1000)
        {
            goto label_12;
        }
        
        label_3:
        val_9 = null;
        if(UIManager.firstPass != false)
        {
                val_11 = 1;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        label_12:
        val_8 = UnityEngine.Screen.height;
        float val_10 = 1.777778f;
        float val_9 = (float)val_8;
        val_9 = val_9 / (float)UnityEngine.Screen.width;
        float val_5 = val_9 / val_10;
        val_10 = val_5 * 5f;
        UnityEngine.Camera.main.orthographicSize = val_10;
        if(val_5 < 0)
        {
                UnityEngine.Camera.main.orthographicSize = 5f / val_5;
            val_11 = 0;
            this.<>4__this.canvasScaler.m_MatchWidthOrHeight = 1f;
            return (bool)val_11;
        }
        
        label_15:
        val_11 = 0;
        return (bool)val_11;
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
