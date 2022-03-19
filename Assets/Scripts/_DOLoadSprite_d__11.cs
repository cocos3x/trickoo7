using UnityEngine;
private sealed class FileExtend.<DOLoadSprite>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<UnityEngine.Sprite> result;
    public string url;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FileExtend.<DOLoadSprite>d__11(int <>1__state)
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
            .result = this.result;
            this.<>2__current = FileExtend.DOLoadTexture(result:  new System.Action<UnityEngine.Texture2D, FileStatus>(object:  new FileExtend.<>c__DisplayClass11_0(), method:  System.Void FileExtend.<>c__DisplayClass11_0::<DOLoadSprite>b__0(UnityEngine.Texture2D e, FileStatus s)), url:  this.url);
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
