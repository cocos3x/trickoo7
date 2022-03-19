using UnityEngine;
private sealed class LevelCreativeTwo.<DisplayRight>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCreativeTwo <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCreativeTwo.<DisplayRight>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        float val_8;
        var val_9;
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
        EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  2);
        if((X21 + 24) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = 1;
        Util.DisplaySpineAnim(animName:  this.<>4__this.animRight, anim:  X21 + 16 + 32, isLoop:  true, timeScale:  1f);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  V8.16B);
        this.<>1__state = val_7;
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        val_9 = null;
        if(MusicManager.IsOn != false)
        {
                MusicManager.Pause();
        }
        
        SoundManager.Play(fileName:  "Victory");
        SetActive(value:  true);
        DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  1f, callback:  new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void LevelCreativeTwo::<DisplayRight>b__8_0()), ignoreTimeScale:  true);
        if((X22 + 24) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_5 = Util.GetSpineAnimDuration(animName:  this.<>4__this.animRight, anim:  X22 + 16 + 32);
        val_8 = val_5;
        UnityEngine.WaitForSeconds val_6 = null;
        val_5 = val_8 - S10;
        val_5 = val_5 + S9;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_5);
        this.<>2__current = val_6;
        this.<>1__state = 2;
        val_7 = 1;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  1);
        label_3:
        val_7 = 0;
        return (bool)val_7;
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
