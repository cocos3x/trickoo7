using UnityEngine;
private sealed class FileExtend.<DODownloadJson>d__9<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action<T, FileStatus> result;
    private UnityEngine.Networking.UnityWebRequest <request>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FileExtend.<DODownloadJson>d__9<T>(int <>1__state)
    {
        mem[1152921513374117872] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if(W8 != 1)
        {
                if(W8 != 3)
        {
                return;
        }
        
        }
    
    }
    private bool MoveNext()
    {
        UnityEngine.Networking.UnityWebRequest val_16;
        string val_18;
        var val_19;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_2;
        }
        
        mem[1152921513374382960] = 0;
        UnityEngine.Networking.UnityWebRequest val_1 = null;
        val_16 = val_1;
        val_18 = X22;
        val_1 = new UnityEngine.Networking.UnityWebRequest(url:  val_18, method:  "GET");
        mem[1152921513374382992] = val_16;
        mem[1152921513374382960] = -3;
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        mem[1152921513374382968] = val_1.SendWebRequest();
        val_19 = 1;
        mem[1152921513374382960] = val_19;
        return (bool)val_19;
        label_1:
        mem[1152921513374382960] = -3;
        if(19164 == 0)
        {
            goto label_10;
        }
        
        val_18 = 0;
        bool val_3 = 19164.isNetworkError;
        if(val_3 == true)
        {
            goto label_10;
        }
        
        if(val_3 == false)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        bool val_4 = val_3.isHttpError;
        if(val_4 == true)
        {
            goto label_10;
        }
        
        if(val_4 == false)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        bool val_6 = System.String.IsNullOrEmpty(value:  val_4.error);
        if(val_6 == false)
        {
            goto label_10;
        }
        
        if(val_6 == false)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        UnityEngine.Networking.DownloadHandler val_7 = val_6.downloadHandler;
        if(val_7 != null)
        {
            goto label_13;
        }
        
        label_10:
        if(val_7 != null)
        {
                val_18 = 0;
        }
        
        label_13:
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        bool val_8 = val_7.isDone;
        if(val_8 == false)
        {
            goto label_20;
        }
        
        if(val_8 == false)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        UnityEngine.Networking.DownloadHandler val_9 = val_8.downloadHandler;
        if(val_9 == null)
        {
            goto label_20;
        }
        
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        UnityEngine.Networking.DownloadHandler val_10 = val_9.downloadHandler;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        bool val_12 = System.String.IsNullOrEmpty(value:  val_10.text);
        if(val_12 == false)
        {
            goto label_20;
        }
        
        if(val_12 == false)
        {
                throw new NullReferenceException();
        }
        
        val_18 = 0;
        UnityEngine.Networking.DownloadHandler val_13 = val_12.downloadHandler;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_13.text == null)
        {
            goto label_58;
        }
        
        goto label_58;
        label_20:
        label_58:
        val_19 = 0;
        mem[1152921513374382992] = 0;
        return (bool)val_19;
        label_2:
        val_19 = 0;
        return (bool)val_19;
    }
    private void <>m__Finally1()
    {
        var val_2;
        mem[1152921513374535936] = 0;
        if(==0)
        {
                return;
        }
        
        var val_3 = mem[26886144];
        if((mem[26886144] + 294) == 0)
        {
            goto label_5;
        }
        
        var val_1 = mem[26886144] + 176;
        var val_2 = 0;
        val_1 = val_1 + 8;
        label_4:
        if(((mem[26886144] + 176 + 8) + -8) == null)
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        val_1 = val_1 + 16;
        if(val_2 < (mem[26886144] + 294))
        {
            goto label_4;
        }
        
        goto label_5;
        label_3:
        val_3 = val_3 + (((mem[26886144] + 176 + 8)) << 4);
        val_2 = val_3 + 304;
        label_5:
        Dispose();
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
