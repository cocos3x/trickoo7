using UnityEngine;
private sealed class Downloader.<Coroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action<UnityEngine.WWW> callback;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Downloader.<Coroutine>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WWW val_7;
        int val_8;
        var val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WWW val_1 = null;
        val_7 = val_1;
        val_1 = new UnityEngine.WWW(url:  this.url);
        val_8 = 1;
        this.<www>5__2 = val_7;
        this.<>2__current = val_7;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        object[] val_2 = new object[3];
        val_2[0] = this.url;
        val_2[1] = Assets.SimpleLocalization.Downloader.CleaunupText(text:  this.<www>5__2.text);
        val_7 = this.<www>5__2.error;
        val_2[2] = val_7;
        UnityEngine.Debug.LogFormat(format:  "downloaded {0}, www.text = {1}, www.error = {2}", args:  val_2);
        if((this.<www>5__2.error) == null)
        {
                val_9 = null;
            val_9 = null;
            Assets.SimpleLocalization.Downloader.OnNetworkReady.Invoke();
        }
        
        this.callback.Invoke(obj:  this.<www>5__2);
        label_2:
        val_8 = 0;
        return (bool)val_8;
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
