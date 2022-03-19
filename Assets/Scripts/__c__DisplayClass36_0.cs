using UnityEngine;
private sealed class MusicManager.<>c__DisplayClass36_0
{
    // Fields
    public bool pitch;
    public System.Action actionOnDone;
    
    // Methods
    public MusicManager.<>c__DisplayClass36_0()
    {
    
    }
    internal void <Stop>b__0()
    {
        if(this.pitch == false)
        {
                return;
        }
        
        MusicManager.AudioSourceReal.pitch = MusicManager.AudioSourceReal.volume;
    }
    internal void <Stop>b__1()
    {
        MusicManager.AudioSourceReal.pitch = 1f;
        MusicManager.AudioSourceReal.volume = MusicManager.MaxVolume;
        MusicManager.AudioSourceReal.Stop();
        if(this.actionOnDone == null)
        {
                return;
        }
        
        this.actionOnDone.Invoke();
    }

}
