using UnityEngine;
private sealed class LevelDrag.<FinishStepByStep>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelDrag <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelDrag.<FinishStepByStep>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        object val_11;
        int val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_19;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_11 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_12 = 1;
        this.<>2__current = val_11;
        this.<>1__state = val_12;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.mainDrag.isPlaying = false;
        List.Enumerator<T> val_2 = this.<>4__this.subDrags.GetEnumerator();
        goto label_7;
        label_9:
        if(val_3 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = 0;
        label_7:
        if(val_4.MoveNext() == true)
        {
            goto label_9;
        }
        
        val_4.Dispose();
        mem2[0] = 1;
        if((public System.Void List.Enumerator<DragDrop>::Dispose()) == 0)
        {
                mem2[0] = 0;
            this.<>4__this.DisplayResult();
            UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.WaitAnimWin());
        }
        
        List.Enumerator<T> val_8 = this.<>4__this.listHint.GetEnumerator();
        val_11 = 1152921513355036272;
        label_14:
        if(0.MoveNext() == false)
        {
            goto label_12;
        }
        
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        0.SetActive(value:  false);
        goto label_14;
        label_12:
        0.Dispose();
        label_19:
        val_12 = 0;
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
