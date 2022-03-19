using UnityEngine;
private sealed class MusicManager.<>c__DisplayClass42_1
{
    // Fields
    public UnityEngine.AudioClip clip;
    public FileStatus status;
    public MusicManager.<>c__DisplayClass42_0 CS$<>8__locals1;
    
    // Methods
    public MusicManager.<>c__DisplayClass42_1()
    {
    
    }
    internal void <Load>b__1(bool onDone)
    {
        FileStatus val_1;
        UnityEngine.AudioClip val_2;
        var val_3;
        if(onDone != false)
        {
                if((this.CS$<>8__locals1.actionOnDone) == null)
        {
                return;
        }
        
            val_1 = this.status;
            val_2 = this.clip;
            val_3 = 1152921513385236944;
        }
        else
        {
                if((this.CS$<>8__locals1.actionOnDone) == null)
        {
                return;
        }
        
            val_1 = this.status;
            val_3 = 1152921513385236944;
            val_2 = 0;
        }
        
        this.CS$<>8__locals1.actionOnDone.Invoke(arg1:  val_2, arg2:  val_1);
    }

}
