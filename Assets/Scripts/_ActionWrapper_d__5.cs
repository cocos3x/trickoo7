using UnityEngine;
private sealed class UnityMainThreadDispatcher.<ActionWrapper>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action a;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UnityMainThreadDispatcher.<ActionWrapper>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        int val_2;
        val_1 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_1;
        }
        
            this.<>1__state = 0;
            this.a.Invoke();
            val_2 = 1;
            val_1 = 1;
            this.<>2__current = 0;
        }
        else
        {
                val_2 = 0;
        }
        
        this.<>1__state = val_2;
        return (bool)val_1;
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
