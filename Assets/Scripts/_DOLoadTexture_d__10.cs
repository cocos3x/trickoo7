using UnityEngine;
private sealed class FileExtend.<DOLoadTexture>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action<UnityEngine.Texture2D, FileStatus> result;
    private UnityEngine.Networking.UnityWebRequest <request>5__2;
    private float <lastProcess>5__3;
    private float <elapsedTime>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FileExtend.<DOLoadTexture>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
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
        var val_12;
        var val_13;
        UnityEngine.Networking.UnityWebRequest val_14;
        int val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_55;
        }
        
        this.<>1__state = 0;
        val_12 = 0;
        UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequestTexture.GetTexture(uri:  this.url);
        val_14 = this;
        this.<request>5__2 = val_1;
        this.<>1__state = -3;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        UnityEngine.Networking.UnityWebRequestAsyncOperation val_2 = val_1.SendWebRequest();
        this.<lastProcess>5__3 = 0f;
        this.<elapsedTime>5__4 = 0f;
        goto label_4;
        label_1:
        val_14 = this.<request>5__2;
        this.<>1__state = -3;
        label_4:
        val_13 = mem[this.<request>5__2];
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        val_13 = mem[this.<request>5__2];
        if(val_13.isDone == false)
        {
            goto label_6;
        }
        
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        if(val_13.isNetworkError == true)
        {
            goto label_8;
        }
        
        val_13 = mem[this.<request>5__2];
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        if(val_13.isHttpError == false)
        {
            goto label_10;
        }
        
        label_8:
        val_13 = mem[this.<request>5__2];
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Debug.LogError(message:  val_13.error);
        if(this.result == null)
        {
            goto label_29;
        }
        
        this.result.Invoke(arg1:  0, arg2:  0);
        goto label_29;
        label_6:
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        float val_7 = val_13.downloadProgress;
        if((this.<lastProcess>5__3) != val_7)
        {
            goto label_17;
        }
        
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = (this.<elapsedTime>5__4) + val_8;
        this.<elapsedTime>5__4 = val_8;
        if(val_8 < 5f)
        {
            goto label_18;
        }
        
        val_12 = 0;
        UnityEngine.Debug.LogError(message:  "[FileHelper] DOLoadTexture: "("[FileHelper] DOLoadTexture: ") + this.url + " TimeOut");
        val_13 = mem[this.<request>5__2];
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_13.Abort();
        mem[this.<request>5__2].Dispose();
        if(this.result != null)
        {
                this.result.Invoke(arg1:  0, arg2:  2);
        }
        
        this.<>m__Finally1();
        label_55:
        val_16 = 0;
        return (bool)val_16;
        label_17:
        this.<elapsedTime>5__4 = 0f;
        this.<lastProcess>5__3 = val_7;
        label_18:
        if(FileExtend.OnProcessChanged != null)
        {
                FileExtend.OnProcessChanged.Invoke(process:  this.<lastProcess>5__3);
        }
        
        val_16 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_10:
        UnityEngine.Debug.Log(message:  "[FileHelper] DOLoadTexture:  "("[FileHelper] DOLoadTexture:  ") + this.url);
        if(this.result != null)
        {
                this.result.Invoke(arg1:  UnityEngine.Networking.DownloadHandlerTexture.GetContent(www:  mem[this.<request>5__2]), arg2:  1);
        }
        
        label_29:
        this.<>m__Finally1();
        val_16 = 0;
        mem2[0] = 0;
        return (bool)val_16;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<request>5__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<request>5__2.Dispose();
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
