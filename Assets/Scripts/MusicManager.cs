using UnityEngine;
public class MusicManager : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource audioSourceReal;
    private UnityEngine.AudioClip defaultClip;
    private System.Collections.Generic.List<UnityEngine.AudioClip> otherClips;
    private static MusicManager.ClipChangedDelegate OnClipChanged;
    private UIToggle musicToggle;
    private float maxVolume;
    private static float <latency>k__BackingField;
    private static UnityEngine.AudioClip audioClip;
    private static MusicManager instance;
    private UnityEngine.Coroutine WaitAudioPlayCoroutine;
    private int indexMusic;
    
    // Properties
    public static UnityEngine.AudioSource AudioSourceReal { get; }
    public static float MaxVolume { get; }
    public static float latency { get; set; }
    private static UnityEngine.AudioClip AudioClip { get; set; }
    public static bool IsPlaying { get; }
    public static bool IsOn { get; }
    
    // Methods
    public static UnityEngine.AudioSource get_AudioSourceReal()
    {
        var val_1;
        UnityEngine.AudioSource val_2;
        val_1 = null;
        val_1 = null;
        if(MusicManager.instance != null)
        {
                val_2 = mem[MusicManager.instance + 24];
            val_2 = MusicManager.instance.audioSourceReal;
            return (UnityEngine.AudioSource)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.AudioSource)val_2;
    }
    public static void add_OnClipChanged(MusicManager.ClipChangedDelegate value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((System.Delegate.Combine(a:  MusicManager.OnClipChanged, b:  value)) != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = null;
        val_3 = null;
        return;
        label_4:
    }
    public static void remove_OnClipChanged(MusicManager.ClipChangedDelegate value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((System.Delegate.Remove(source:  MusicManager.OnClipChanged, value:  value)) != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = null;
        val_3 = null;
        return;
        label_4:
    }
    public static float get_MaxVolume()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MusicManager.instance == 0)
        {
                return 1f;
        }
        
        val_3 = null;
        val_3 = null;
        return 1f;
    }
    public static float get_latency()
    {
        null = null;
        return (float)MusicManager.<latency>k__BackingField;
    }
    public static void set_latency(float value)
    {
        null = null;
        MusicManager.<latency>k__BackingField = value;
    }
    private static UnityEngine.AudioClip get_AudioClip()
    {
        null = null;
        return (UnityEngine.AudioClip)MusicManager.audioClip;
    }
    private static void set_AudioClip(UnityEngine.AudioClip value)
    {
        UnityEngine.AudioClip val_7;
        var val_8;
        var val_9;
        var val_11;
        var val_12;
        val_7 = value;
        val_8 = null;
        val_8 = null;
        if(MusicManager.audioClip != 0)
        {
            goto label_5;
        }
        
        label_21:
        val_9 = null;
        val_9 = null;
        MusicManager.audioClip = val_7;
        val_7 = MusicManager.OnClipChanged;
        if(val_7 == null)
        {
                return;
        }
        
        val_7.Invoke(clipName:  MusicManager.audioClip.name);
        return;
        label_5:
        val_11 = null;
        val_11 = null;
        if(MusicManager.audioClip == val_7)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.String.op_Inequality(a:  MusicManager.audioClip.name, b:  val_7.name)) == true)
        {
            goto label_21;
        }
    
    }
    public static bool get_IsPlaying()
    {
        return MusicManager.AudioSourceReal.isPlaying;
    }
    public static bool get_IsOn()
    {
        var val_2;
        UIToggle val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        if(MusicManager.instance != null)
        {
                val_3 = mem[MusicManager.instance + 48];
            val_3 = MusicManager.instance.musicToggle;
        }
        else
        {
                val_3 = 0;
        }
        
        if(val_3 == 0)
        {
                return true;
        }
        
        val_4 = null;
        val_4 = null;
        return isOn;
    }
    private void Awake()
    {
        null = null;
        MusicManager.instance = this;
        if(this.audioSourceReal != 0)
        {
                return;
        }
        
        this.audioSourceReal = this.GetComponent<UnityEngine.AudioSource>();
    }
    private void Start()
    {
        var val_9;
        var val_10;
        UnityEngine.Events.UnityAction<System.Boolean> val_12;
        val_9 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.musicToggle)) == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = MusicManager.<>c.<>9__27_0;
        if(val_12 == null)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_2 = null;
            val_12 = val_2;
            val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  MusicManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MusicManager.<>c::<Start>b__27_0(bool isOn));
            MusicManager.<>c.<>9__27_0 = val_12;
        }
        
        val_9 = ???;
        goto typeof(UIToggle).__il2cppRuntimeField_190;
    }
    public static System.Collections.IEnumerator DoPlay(string fileName, bool autoPlay, System.Action<bool> onDone)
    {
        .<>1__state = 0;
        .fileName = fileName;
        .autoPlay = autoPlay;
        .onDone = onDone;
        return (System.Collections.IEnumerator)new MusicManager.<DoPlay>d__28();
    }
    public static void Init(System.Action<bool> actionOnDone, UnityEngine.AudioClip clip, bool autoPlay = False, float fadeTime = 0.25)
    {
        System.Action<System.Boolean> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        MusicManager.<>c__DisplayClass29_0 val_1 = null;
        val_11 = val_1;
        val_1 = new MusicManager.<>c__DisplayClass29_0();
        .clip = clip;
        .actionOnDone = actionOnDone;
        .autoPlay = autoPlay;
        val_12 = null;
        val_12 = null;
        if(MusicManager.audioClip != 0)
        {
            goto label_9;
        }
        
        MusicManager.AudioClip = (MusicManager.<>c__DisplayClass29_0)[1152921513378625504].clip;
        val_13 = null;
        val_13 = null;
        MusicManager.AudioSourceReal.clip = MusicManager.audioClip;
        val_11 = (MusicManager.<>c__DisplayClass29_0)[1152921513378625504].actionOnDone;
        if(((MusicManager.<>c__DisplayClass29_0)[1152921513378625504].autoPlay) == false)
        {
            goto label_16;
        }
        
        label_37:
        MusicManager.Play(actionOnDone:  val_11, time:  0f, loop:  true, fadeTime:  0.5f, audioSourceRealDelay:  0f);
        return;
        label_9:
        val_14 = null;
        val_14 = null;
        if((System.String.op_Equality(a:  MusicManager.audioClip.name, b:  (MusicManager.<>c__DisplayClass29_0)[1152921513378625504].clip.name)) == false)
        {
            goto label_26;
        }
        
        if(((MusicManager.<>c__DisplayClass29_0)[1152921513378625504].autoPlay) != false)
        {
                if(MusicManager.AudioSourceReal.isPlaying == false)
        {
            goto label_37;
        }
        
        }
        
        if(((MusicManager.<>c__DisplayClass29_0)[1152921513378625504].actionOnDone) == null)
        {
                return;
        }
        
        val_15 = 1152921510399441488;
        val_16 = 1;
        goto label_33;
        label_26:
        MusicManager.Stop(actionOnDone:  new System.Action(object:  val_1, method:  System.Void MusicManager.<>c__DisplayClass29_0::<Init>b__0()), pitch:  false, fadeTime:  0.25f);
        return;
        label_16:
        if(val_11 == null)
        {
                return;
        }
        
        val_15 = 1152921510399441488;
        val_16 = 1;
        label_33:
        val_11.Invoke(obj:  true);
    }
    public static void Play(System.Action<bool> actionOnDone, float time = 0, bool loop = True, float fadeTime = 0.5, float audioSourceRealDelay = 0)
    {
        var val_14;
        var val_15;
        .time = time;
        .actionOnDone = actionOnDone;
        .fadeTime = fadeTime;
        .loop = loop;
        int val_4 = DG.Tweening.ShortcutExtensions.DOKill(target:  MusicManager.AudioSourceReal, complete:  false);
        if(audioSourceRealDelay > 0f)
        {
                DG.Tweening.Tween val_7 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Tween>(t:  DG.Tweening.DOVirtual.DelayedCall(delay:  audioSourceRealDelay, callback:  new DG.Tweening.TweenCallback(object:  new MusicManager.<>c__DisplayClass30_0(), method:  System.Void MusicManager.<>c__DisplayClass30_0::<Play>b__0()), ignoreTimeScale:  true), stringId:  "AudioSourceReal");
            return;
        }
        
        val_14 = null;
        val_14 = null;
        if((UnityEngine.Object.op_Implicit(exists:  MusicManager.instance.musicToggle)) == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(isOn == false)
        {
                return;
        }
        
        MusicManager.AudioSourceReal.loop = (MusicManager.<>c__DisplayClass30_0)[1152921513378832848].loop;
        MusicManager.AudioSourceReal.volume = 0f;
        MusicManager.AudioSourceReal.pitch = 1f;
        MusicManager.AudioSourceReal.Play();
        MusicManager.WaitAudioPlay(actionOnDone:  (MusicManager.<>c__DisplayClass30_0)[1152921513378832848].actionOnDone, time:  (MusicManager.<>c__DisplayClass30_0)[1152921513378832848].time, fadeTime:  (MusicManager.<>c__DisplayClass30_0)[1152921513378832848].fadeTime);
    }
    public static void WaitAudioPlay(System.Action<bool> actionOnDone, float time, float fadeTime)
    {
        var val_3;
        MusicManager val_4;
        val_3 = null;
        val_3 = null;
        val_4 = MusicManager.instance;
        if(null != 0)
        {
                val_4 = MusicManager.instance;
            val_4.StopCoroutine(routine:  MusicManager.instance.WaitAudioPlayCoroutine);
            val_3 = null;
        }
        
        val_3 = null;
        MusicManager.instance.WaitAudioPlayCoroutine = MusicManager.instance.StartCoroutine(routine:  MusicManager.DoWaitAudioPlay(actionOnDone:  actionOnDone, time:  time, fadeTime:  fadeTime));
    }
    private static System.Collections.IEnumerator DoWaitAudioPlay(System.Action<bool> actionOnDone, float time, float fadeTime)
    {
        .<>1__state = 0;
        .actionOnDone = actionOnDone;
        .time = time;
        .fadeTime = fadeTime;
        return (System.Collections.IEnumerator)new MusicManager.<DoWaitAudioPlay>d__33();
    }
    public static void Pause()
    {
        MusicManager.AudioSourceReal.Pause();
    }
    public static void UnPause(float fadeTime = 1)
    {
        if(fadeTime > 0f)
        {
                MusicManager.AudioSourceReal.volume = 0f;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOFade(target:  MusicManager.AudioSourceReal, endValue:  MusicManager.MaxVolume, duration:  fadeTime), stringId:  "AudioSourceReal");
        MusicManager.AudioSourceReal.UnPause();
    }
    public static void Stop(System.Action actionOnDone, bool pitch = True, float fadeTime = 1.5)
    {
        MusicManager.<>c__DisplayClass36_0 val_1 = new MusicManager.<>c__DisplayClass36_0();
        .pitch = pitch;
        .actionOnDone = actionOnDone;
        if(fadeTime != 0f)
        {
                if(MusicManager.AudioSourceReal.volume != 0f)
        {
            goto label_6;
        }
        
        }
        
        MusicManager.AudioSourceReal.Stop();
        label_14:
        if(((MusicManager.<>c__DisplayClass36_0)[1152921513379584336].actionOnDone) == null)
        {
                return;
        }
        
        (MusicManager.<>c__DisplayClass36_0)[1152921513379584336].actionOnDone.Invoke();
        return;
        label_6:
        if(MusicManager.AudioSourceReal.isPlaying == false)
        {
            goto label_14;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOFade(target:  MusicManager.AudioSourceReal, endValue:  0f, duration:  fadeTime), stringId:  "AudioSourceReal"), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MusicManager.<>c__DisplayClass36_0::<Stop>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MusicManager.<>c__DisplayClass36_0::<Stop>b__1()));
    }
    public static void FadeIn(System.Action actionOnDone, float volume = 1, float fadeTime = 0.125)
    {
        var val_11;
        .actionOnDone = actionOnDone;
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  MusicManager.AudioSourceReal, complete:  false);
        if((UnityEngine.Object.op_Implicit(exists:  MusicManager.instance.musicToggle)) == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(isOn == false)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOFade(target:  MusicManager.AudioSourceReal, endValue:  volume, duration:  fadeTime), stringId:  "AudioSourceReal"), action:  new DG.Tweening.TweenCallback(object:  new MusicManager.<>c__DisplayClass37_0(), method:  System.Void MusicManager.<>c__DisplayClass37_0::<FadeIn>b__0()));
    }
    public static void FadeOut(System.Action actionOnDone, float fadeTime = 0.5)
    {
        .actionOnDone = actionOnDone;
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  MusicManager.AudioSourceReal, complete:  false);
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOFade(target:  MusicManager.AudioSourceReal, endValue:  0f, duration:  fadeTime), stringId:  "AudioSourceReal"), action:  new DG.Tweening.TweenCallback(object:  new MusicManager.<>c__DisplayClass38_0(), method:  System.Void MusicManager.<>c__DisplayClass38_0::<FadeOut>b__0()));
    }
    public static void SetPitch(float pitch, float timeAnim, DG.Tweening.TweenCallback actionOnDone, DG.Tweening.TweenCallback<float> onUpdate)
    {
        MusicManager.<>c__DisplayClass39_0 val_1 = new MusicManager.<>c__DisplayClass39_0();
        .onUpdate = onUpdate;
        .actionOnDone = actionOnDone;
        if(timeAnim > 0f)
        {
                int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  MusicManager.AudioSourceReal, complete:  false);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetId<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleAudio.DOPitch(target:  MusicManager.AudioSourceReal, endValue:  pitch, duration:  timeAnim), stringId:  "AudioSourceReal"), updateType:  0, isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MusicManager.<>c__DisplayClass39_0::<SetPitch>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MusicManager.<>c__DisplayClass39_0::<SetPitch>b__1()));
            return;
        }
        
        MusicManager.AudioSourceReal.pitch = pitch;
    }
    public void ChangeBgAuto()
    {
        var val_2;
        this.indexMusic = (this.indexMusic >= this.otherClips) ? 1 : (this.indexMusic + 1);
        val_2 = null;
        val_2 = null;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        MusicManager.Init(actionOnDone:  0, clip:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (this.indexMusic) << 3) + 32, autoPlay:  true, fadeTime:  null);
    }
    public static System.Collections.IEnumerator Load(System.Action<UnityEngine.AudioClip, FileStatus> actionOnDone, string fileId, string fileUrl, bool autoPlay = False, bool downloadToPlay = False)
    {
        .<>1__state = 0;
        .fileId = fileId;
        .actionOnDone = actionOnDone;
        .autoPlay = autoPlay;
        return (System.Collections.IEnumerator)new MusicManager.<Load>d__42();
    }
    public MusicManager()
    {
        this.maxVolume = 0.75f;
    }
    private static MusicManager()
    {
    
    }

}
