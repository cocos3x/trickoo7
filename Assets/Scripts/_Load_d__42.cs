using UnityEngine;
private sealed class MusicManager.<Load>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string fileId;
    public System.Action<UnityEngine.AudioClip, FileStatus> actionOnDone;
    public bool autoPlay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MusicManager.<Load>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_35;
        }
        
        this.<>1__state = 0;
        .fileId = this.fileId;
        .actionOnDone = this.actionOnDone;
        .autoPlay = this.autoPlay;
        val_11 = null;
        if((System.String.IsNullOrEmpty(value:  this.fileId)) == false)
        {
            goto label_4;
        }
        
        val_11 = null;
        MusicManager.Init(actionOnDone:  0, clip:  MusicManager.instance.defaultClip, autoPlay:  true, fadeTime:  null);
        label_35:
        val_12 = 0;
        return (bool)val_12;
        label_1:
        val_12 = 0;
        this.<>1__state = 0;
        return (bool)val_12;
        label_4:
        val_13 = null;
        val_13 = null;
        if(MusicManager.audioClip == 0)
        {
            goto label_25;
        }
        
        val_14 = null;
        val_14 = null;
        if((MusicManager.audioClip.name.Equals(value:  (MusicManager.<>c__DisplayClass42_0)[1152921513385991360].fileId)) == false)
        {
            goto label_25;
        }
        
        if(((MusicManager.<>c__DisplayClass42_0)[1152921513385991360].autoPlay) != false)
        {
                MusicManager.Play(actionOnDone:  0, time:  0f, loop:  true, fadeTime:  0.5f, audioSourceRealDelay:  0f);
        }
        
        if(((MusicManager.<>c__DisplayClass42_0)[1152921513385991360].actionOnDone) == null)
        {
            goto label_35;
        }
        
        val_15 = null;
        val_15 = null;
        (MusicManager.<>c__DisplayClass42_0)[1152921513385991360].actionOnDone.Invoke(arg1:  MusicManager.audioClip, arg2:  1);
        goto label_35;
        label_25:
        string val_7 = FileExtend.FileNameToPath(fileName:  (MusicManager.<>c__DisplayClass42_0)[1152921513385991360].fileId((MusicManager.<>c__DisplayClass42_0)[1152921513385991360].fileId) + ".mp3");
        this.<>2__current = FileExtend.DOLoadRes<UnityEngine.AudioClip>(result:  new System.Action<UnityEngine.AudioClip, FileStatus>(object:  new MusicManager.<>c__DisplayClass42_0(), method:  System.Void MusicManager.<>c__DisplayClass42_0::<Load>b__0(UnityEngine.AudioClip clip, FileStatus status)), fileName:  "tracks/"("tracks/") + (MusicManager.<>c__DisplayClass42_0)[1152921513385991360].fileId((MusicManager.<>c__DisplayClass42_0)[1152921513385991360].fileId));
        val_12 = 1;
        this.<>1__state = val_12;
        return (bool)val_12;
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
