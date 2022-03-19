using UnityEngine;
private sealed class IronHelper.<WaitToShowRewarded>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float waitAvaibale;
    public System.Action onAvaiable;
    private float <elapsedTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IronHelper.<WaitToShowRewarded>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<elapsedTime>5__2 = this.waitAvaibale;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        label_3:
        if(((public static System.Boolean AdsBase<IronHelper>::get_RewardIsReady()) & 1) != 0)
        {
            goto label_6;
        }
        
        float val_2 = this.<elapsedTime>5__2;
        if(val_2 > 0f)
        {
            goto label_7;
        }
        
        label_6:
        val_2 = this.onAvaiable;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        val_2.Invoke();
        label_2:
        val_2 = 0;
        return (bool)val_2;
        label_7:
        val_2 = val_2 + (-0.25f);
        this.<elapsedTime>5__2 = val_2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        this.<>1__state = 1;
        return (bool)val_2;
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
