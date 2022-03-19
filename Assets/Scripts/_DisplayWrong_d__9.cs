using UnityEngine;
private sealed class LevelCreativeTwo.<DisplayWrong>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCreativeTwo <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCreativeTwo.<DisplayWrong>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((X22 + 24) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Util.DisplaySpineAnim(animName:  this.<>4__this.animWrong, anim:  X22 + 16 + 32, isLoop:  true, timeScale:  1f);
        if((X22 + 24) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Util.GetSpineAnimDuration(animName:  this.<>4__this.animWrong, anim:  X22 + 16 + 32));
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>2__current) == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = 1;
        Util.DisplaySpineAnim(animName:  "idle", anim:  this.<>1__state + 32, isLoop:  true, timeScale:  1f);
        val_4 = 0;
        mem2[0] = val_3;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
