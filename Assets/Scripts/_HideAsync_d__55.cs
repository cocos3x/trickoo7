using UnityEngine;
private sealed class UIAnimation.<HideAsync>d__55 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIAnimation <>4__this;
    public DG.Tweening.TweenCallback onCompleted;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIAnimation.<HideAsync>d__55(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) >= 2)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if(((this.<>4__this.status) - 1) < 2)
        {
            goto label_2;
        }
        
        if((this.<>4__this.status) != 0)
        {
                this.<>4__this.status = 2;
            if((this.<>4__this.OnStatusChanged) != null)
        {
                this.<>4__this.OnStatusChanged.Invoke(status:  2);
        }
        
            this.<>4__this.Play(type:  this.<>4__this.animationOut, playBack:  false, onStart:  0, onShowCompleted:  0, onHideCompleted:  this.onCompleted);
        }
        
        label_3:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        val_2 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
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
