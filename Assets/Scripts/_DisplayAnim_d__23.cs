using UnityEngine;
private sealed class Level.<DisplayAnim>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public Level <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Level.<DisplayAnim>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        var val_8;
        int val_9;
        var val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_25;
        }
        
        this.<>1__state = 0;
        val_9 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.duration);
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.<>4__this.showAnim) == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_2 = this.<>4__this.showAnim.GetEnumerator();
        val_8 = 1152921513418366288;
        val_10 = 1;
        label_18:
        if(val_4.MoveNext() == false)
        {
            goto label_6;
        }
        
        if(val_3 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_3 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_6 = val_3 + 224.SetAnimation(trackIndex:  0, animationName:  "3", loop:  true);
        goto label_18;
        label_6:
        val_4.Dispose();
        label_25:
        val_9 = 0;
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
