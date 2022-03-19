using UnityEngine;
private sealed class LevelCreativeOne.<DisplayResultAnim>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCreativeOne <>4__this;
    public float duration;
    public bool isWin;
    private System.Collections.Generic.List<WinLoseAnim> <resultAnim>5__2;
    private float <durationWait>5__3;
    private System.Collections.Generic.List.Enumerator<WinLoseAnim> <>7__wrap3;
    private WinLoseAnim <animData>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCreativeOne.<DisplayResultAnim>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 2)
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
        var val_2;
        List.Enumerator<WinLoseAnim> val_3;
        UnityEngine.Object val_37;
        var val_41;
        Spine.Unity.SkeletonAnimation val_42;
        string val_43;
        float val_46;
        var val_47;
        int val_49;
        var val_51;
        var val_52;
        var val_53;
        if((this.<>1__state) > 5)
        {
            goto label_198;
        }
        
        var val_35 = 20143348 + (this.<>1__state) << 2;
        val_35 = val_35 + 20143348;
        goto (20143348 + (this.<>1__state) << 2 + 20143348);
        label_67:
        if(val_3.MoveNext() == false)
        {
            goto label_4;
        }
        
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.<>4__this.type) != 1)
        {
            goto label_6;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_5 = val_2 + 16.gameObject;
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        val_5.SetActive(value:  ((val_2 + 32) == 0) ? 1 : 0);
        if((val_2 + 32) == 0)
        {
                val_37 = mem[val_2 + 16];
            val_37 = val_2 + 16;
            if(val_37 != (this.<>4__this.optionAnimOther))
        {
                if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
            if((val_2 + 16 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
            Spine.TrackEntry val_8 = val_2 + 16 + 224.SetAnimation(trackIndex:  0, animationName:  "idle", loop:  true);
            if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
            val_8.timeScale = this.<>4__this.timeScale;
        }
        
        }
        
        if((val_2 + 40) == 0)
        {
            goto label_67;
        }
        
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_9 = val_2 + 16.gameObject;
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        val_9.SetActive(value:  true);
        val_37 = mem[val_2 + 16];
        val_37 = val_2 + 16;
        if(val_37 == (this.<>4__this.optionAnimOther))
        {
            goto label_67;
        }
        
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 16 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 16 + 224.SetAnimation(trackIndex:  0, animationName:  "idle", loop:  true)) != null)
        {
            goto label_25;
        }
        
        throw new NullReferenceException();
        label_6:
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 36) <= 0f)
        {
            goto label_28;
        }
        
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_12 = val_2 + 16.gameObject;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12.SetActive(value:  false);
        goto label_67;
        label_28:
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_13 = val_2 + 16.gameObject;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        val_13.SetActive(value:  true);
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 16 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 16 + 224.SetAnimation(trackIndex:  0, animationName:  "idle", loop:  true)) == null)
        {
                throw new NullReferenceException();
        }
        
        label_25:
        val_14.timeScale = this.<>4__this.timeScale;
        goto label_67;
        label_4:
        val_51 = 0;
        val_3.Dispose();
        if(val_51 != 0)
        {
            goto label_97;
        }
        
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        this.<>4__this.isDisplay = false;
        if(this.isWin != false)
        {
                EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  1);
        }
        
        label_198:
        val_49 = 0;
        return (bool);
        label_97:
        val_43 = ;
        val_42 = 0;
        throw val_43;
        label_175:
        val_52 = mem[??? + 80];
        val_52 = ??? + 80;
        val_41 = (???) + 88;
        mem2[0] = val_52;
        if((??? + 168) != 1)
        {
            goto label_167;
        }
        
        if(val_52 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((??? + 80 + 32) != 0)
        {
            goto label_169;
        }
        
        val_43 = mem[??? + 80 + 16];
        val_43 = ??? + 80 + 16;
        if(val_43 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_42 = 0;
        if(val_41 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_42 = mem[(??? + 88) + 32];
        val_42 = (??? + 88) + 32;
        val_43.gameObject.SetActive(value:  val_42);
        val_52 = mem[(??? + 88)];
        val_52 = val_41;
        label_167:
        if(val_52 == 0)
        {
                throw new NullReferenceException();
        }
        
        label_169:
        if(((??? + 88) + 32) != 0)
        {
            goto label_174;
        }
        
        mem2[0] = 0;
        if((???.MoveNext()) == true)
        {
            goto label_175;
        }
        
        ???.<>m__Finally1();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        if((??? + 44) == 0)
        {
            goto label_176;
        }
        
        val_53 = null;
        if(MusicManager.IsOn != false)
        {
                MusicManager.Pause();
        }
        
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  ??? + 28);
        val_47 = 3;
        goto label_183;
        label_174:
        val_47 = 2;
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  (??? + 88) + 36);
        goto label_183;
        label_176:
        val_46 = mem[??? + 56];
        val_46 = ??? + 56;
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  val_46);
        val_47 = 5;
        label_183:
        mem2[0] = 5;
        return (bool);
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap3.Dispose();
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
