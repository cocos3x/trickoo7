using UnityEngine;
private sealed class PowerBar.<UpdatePowerBar>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PowerBar <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PowerBar.<UpdatePowerBar>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        float val_3;
        float val_4;
        int val_5;
        float val_6;
        if((this.<>1__state) >= 2)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.powerBarOn) == false)
        {
            goto label_3;
        }
        
        val_2 = this.<>4__this.currentPowerBarValue;
        if((this.<>4__this.powerIsIncreasing) == true)
        {
            goto label_4;
        }
        
        val_3 = val_2 - (this.<>4__this.barChangeSpeed);
        this.<>4__this.currentPowerBarValue = val_3;
        if(val_3 <= 0f)
        {
            goto label_5;
        }
        
        val_4 = this.<>4__this.maxPowerBarValue;
        goto label_8;
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_5:
        this.<>4__this.powerIsIncreasing = true;
        label_4:
        val_4 = this.<>4__this.maxPowerBarValue;
        val_6 = val_3 + (this.<>4__this.barChangeSpeed);
        this.<>4__this.currentPowerBarValue = val_6;
        if(val_6 >= val_4)
        {
                this.<>4__this.powerIsIncreasing = false;
        }
        
        label_8:
        val_6 = val_6 / val_4;
        this.<>4__this.SetPowerBarValue(value:  val_6);
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.02f);
        this.<>1__state = val_5;
        return (bool)val_5;
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
