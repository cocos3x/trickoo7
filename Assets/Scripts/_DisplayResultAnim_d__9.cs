using UnityEngine;
private sealed class LevelTapToStop.<DisplayResultAnim>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelTapToStop <>4__this;
    public bool isWin;
    private float <duration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelTapToStop.<DisplayResultAnim>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Spine.Unity.SkeletonAnimation val_4;
        var val_5;
        DG.Tweening.TweenCallback val_21;
        float val_22;
        int val_24;
        var val_25;
        int val_26;
        if(((this.<>1__state) - 2) < 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_31;
        }
        
        this.<>1__state = 0;
        bool val_2 = UnityEngine.Object.op_Implicit(exists:  X21);
        if(val_2 != false)
        {
                val_2.SetActive(value:  false);
        }
        
        this.<duration>5__2 = 0f;
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        label_11:
        if(val_5.MoveNext() == false)
        {
            goto label_10;
        }
        
        float val_8 = Util.GetSpineAnimDuration(animName:  (this.isWin == false) ? this.<>4__this.animLose : this.<>4__this.animWin, anim:  val_4);
        this.<duration>5__2 = (val_8 > (this.<duration>5__2)) ? (val_8) : this.<duration>5__2;
        Util.DisplaySpineAnim(animName:  (this.isWin == false) ? this.<>4__this.animLose : this.<>4__this.animWin, anim:  val_4, isLoop:  true, timeScale:  1f);
        goto label_11;
        label_1:
        this.<>1__state = 0;
        if(this.isWin == true)
        {
            goto label_12;
        }
        
        List.Enumerator<T> val_11 = 19193.GetEnumerator();
        val_21 = 1152921513418366288;
        val_22 = 1f;
        label_16:
        if(val_5.MoveNext() == false)
        {
            goto label_15;
        }
        
        Util.DisplaySpineAnim(animName:  this.<>4__this.animIdle, anim:  val_4, isLoop:  true, timeScale:  val_22);
        goto label_16;
        label_2:
        this.<>1__state = 0;
        SoundManager.Play(fileName:  "Victory");
        SetActive(value:  true);
        DG.Tweening.TweenCallback val_13 = null;
        val_21 = val_13;
        val_13 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void LevelTapToStop::<DisplayResultAnim>b__9_0());
        DG.Tweening.Tween val_14 = DG.Tweening.DOVirtual.DelayedCall(delay:  1f, callback:  val_13, ignoreTimeScale:  true);
        val_22 = this.<duration>5__2;
        if(this.isWin == false)
        {
            goto label_21;
        }
        
        UnityEngine.WaitForSeconds val_16 = null;
        float val_15 = val_22 + S9;
        val_15 = val_15 - S10;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        val_24 = 2;
        this.<>2__current = val_16;
        goto label_22;
        label_10:
        val_5.Dispose();
        if(this.isWin == false)
        {
            goto label_23;
        }
        
        EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  2);
        val_21 = 1152921504880275456;
        val_25 = null;
        if(MusicManager.IsOn != false)
        {
                MusicManager.Pause();
        }
        
        val_26 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_26;
        return (bool)val_26;
        label_15:
        val_5.Dispose();
        this.<>4__this.powerBar.EnablePowerBar();
        if(this.isWin == false)
        {
            goto label_31;
        }
        
        label_12:
        EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  1);
        label_31:
        val_26 = 0;
        return (bool)val_26;
        label_23:
        val_22 = this.<duration>5__2;
        label_21:
        this.<>2__current = ;
        val_24 = 3;
        label_22:
        this.<>1__state = val_24;
        val_26 = 1;
        return (bool)val_26;
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
