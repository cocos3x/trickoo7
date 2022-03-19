using UnityEngine;
private sealed class UIAnimation.<ShowAsync>d__52 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIAnimation <>4__this;
    public bool playback;
    public DG.Tweening.TweenCallback onStart;
    public DG.Tweening.TweenCallback onCompleted;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIAnimation.<ShowAsync>d__52(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        System.Collections.Generic.List<UIAnimation> val_7;
        var val_8;
        int val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_18;
        }
        
        this.<>1__state = 0;
        val_6 = null;
        val_6 = null;
        val_7 = UIManager.<listScreen>k__BackingField;
        if((System.Linq.Enumerable.Any<UIAnimation>(source:  val_7, predicate:  new System.Func<UIAnimation, System.Boolean>(object:  this.<>4__this, method:  System.Boolean UIAnimation::<ShowAsync>b__52_0(UIAnimation x)))) == true)
        {
            goto label_18;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = UIManager.<listPopup>k__BackingField;
        if((System.Linq.Enumerable.Any<UIAnimation>(source:  val_7, predicate:  new System.Func<UIAnimation, System.Boolean>(object:  this.<>4__this, method:  System.Boolean UIAnimation::<ShowAsync>b__52_1(UIAnimation x)))) == false)
        {
            goto label_14;
        }
        
        goto label_18;
        label_1:
        this.<>1__state = 0;
        label_14:
        if(((this.<>4__this.status) - 1) < 2)
        {
            goto label_17;
        }
        
        if((this.<>4__this.status) != 3)
        {
                this.<>4__this.status = 1;
            if((this.<>4__this.OnStatusChanged) != null)
        {
                this.<>4__this.OnStatusChanged.Invoke(status:  1);
        }
        
            this.<>4__this.Play(type:  this.<>4__this.animationIn, playBack:  this.playback, onStart:  this.onStart, onShowCompleted:  this.onCompleted, onHideCompleted:  0);
        }
        
        label_18:
        val_9 = 0;
        return (bool)val_9;
        label_17:
        val_9 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_9;
        return (bool)val_9;
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
