using UnityEngine;
private sealed class MusicManager.<DoPlay>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<bool> onDone;
    public bool autoPlay;
    public string fileName;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MusicManager.<DoPlay>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
        val_4 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            .onDone = this.onDone;
            .autoPlay = this.autoPlay;
            this.<>2__current = FileExtend.DOLoadRes<UnityEngine.AudioClip>(result:  new System.Action<UnityEngine.AudioClip, FileStatus>(object:  new MusicManager.<>c__DisplayClass28_0(), method:  System.Void MusicManager.<>c__DisplayClass28_0::<DoPlay>b__0(UnityEngine.AudioClip clib, FileStatus status)), fileName:  this.fileName);
            val_5 = 1;
            val_4 = 1;
        }
        else
        {
                val_5 = 0;
        }
        
        this.<>1__state = val_5;
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
