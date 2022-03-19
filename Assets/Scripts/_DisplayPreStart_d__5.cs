using UnityEngine;
private sealed class LevelCreativeTwo.<DisplayPreStart>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCreativeTwo <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCreativeTwo.<DisplayPreStart>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Spine.Unity.SkeletonAnimation val_2;
        var val_3;
        var val_13;
        var val_14;
        int val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_49;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        if(19188 == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_1 = 19188.GetEnumerator();
        val_13 = 1152921513418366288;
        val_14 = 1152921504617177088;
        label_20:
        if(val_3.MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_5 = val_2 + 224.SetAnimation(trackIndex:  0, animationName:  "idle_0", loop:  false);
        if(0f > (Util.GetSpineAnimDuration(animName:  "idle_0", anim:  val_2)))
        {
            goto label_20;
        }
        
        float val_7 = Util.GetSpineAnimDuration(animName:  "idle_0", anim:  val_2);
        goto label_20;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = 1;
        if(19188 == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_8 = 19188.GetEnumerator();
        val_14 = 1152921504721809408;
        val_13 = 1;
        label_35:
        if(val_3.MoveNext() == false)
        {
            goto label_23;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_10 = val_2 + 224.SetAnimation(trackIndex:  0, animationName:  "idle", loop:  true);
        goto label_35;
        label_23:
        val_3.Dispose();
        label_49:
        val_18 = 0;
        return (bool)val_18;
        label_5:
        val_3.Dispose();
        val_18 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0f);
        this.<>1__state = val_18;
        return (bool)val_18;
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
