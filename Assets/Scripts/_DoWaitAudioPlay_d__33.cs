using UnityEngine;
private sealed class MusicManager.<DoWaitAudioPlay>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<bool> actionOnDone;
    public float time;
    public float fadeTime;
    private int <timeout>5__2;
    private float <start>5__3;
    private bool <failed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MusicManager.<DoWaitAudioPlay>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        var val_16;
        var val_17;
        object val_18;
        System.Action<System.Boolean> val_19;
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
            goto label_33;
        }
        
        this.<>1__state = 0;
        this.<timeout>5__2 = 5;
        this.<start>5__3 = UnityEngine.Time.time;
        this.<failed>5__4 = false;
        goto label_4;
        label_2:
        this.<>1__state = 0;
        label_4:
        if(MusicManager.AudioSourceReal.isPlaying == false)
        {
            goto label_8;
        }
        
        if((this.<failed>5__4) == true)
        {
            goto label_9;
        }
        
        this.<start>5__3 = UnityEngine.Time.time;
        goto label_10;
        label_1:
        this.<>1__state = 0;
        label_10:
        val_15 = null;
        val_15 = null;
        float val_15 = MusicManager.<latency>k__BackingField;
        val_15 = this.time + val_15;
        if(MusicManager.AudioSourceReal.time <= val_15)
        {
            goto label_17;
        }
        
        if((this.<failed>5__4) == true)
        {
            goto label_18;
        }
        
        if(this.actionOnDone != null)
        {
                this.actionOnDone.Invoke(obj:  true);
        }
        
        val_16 = null;
        val_16 = null;
        if((UnityEngine.Object.op_Implicit(exists:  MusicManager.instance.musicToggle)) == false)
        {
            goto label_33;
        }
        
        val_17 = null;
        val_17 = null;
        if(isOn == false)
        {
            goto label_33;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOFade(target:  MusicManager.AudioSourceReal, endValue:  MusicManager.MaxVolume, duration:  this.fadeTime), stringId:  "AudioSourceReal");
        goto label_33;
        label_8:
        float val_13 = UnityEngine.Time.time;
        val_13 = val_13 - (this.<start>5__3);
        if(val_13 <= ((float)this.<timeout>5__2))
        {
            goto label_34;
        }
        
        this.<failed>5__4 = true;
        label_9:
        val_18 = "Play Music failed!";
        goto label_37;
        label_17:
        float val_14 = UnityEngine.Time.time;
        val_14 = val_14 - (this.<start>5__3);
        if(val_14 <= ((float)this.<timeout>5__2))
        {
            goto label_38;
        }
        
        this.<failed>5__4 = true;
        label_18:
        val_18 = "Play Music -> wait latency failed!";
        label_37:
        UnityEngine.Debug.Log(message:  val_18);
        val_19 = this.actionOnDone;
        if(val_19 == null)
        {
                return (bool)val_19;
        }
        
        val_19.Invoke(obj:  false);
        label_33:
        val_19 = 0;
        return (bool)val_19;
        label_34:
        this.<>2__current = 0;
        this.<>1__state = 1;
        return (bool)val_19;
        label_38:
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_19;
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
