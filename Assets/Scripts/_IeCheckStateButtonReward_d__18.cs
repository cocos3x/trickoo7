using UnityEngine;
private sealed class UIDailyReward.<IeCheckStateButtonReward>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIDailyReward <>4__this;
    private bool <flag>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIDailyReward.<IeCheckStateButtonReward>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        bool val_5;
        int val_6;
        val_4 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        this.<flag>5__2 = true;
        goto label_4;
        label_2:
        this.<>1__state = 0;
        if(AdsManager.InterstitialIsReady != true)
        {
                if(AdsManager.VideoRewaredIsReady == false)
        {
            goto label_10;
        }
        
        }
        
        val_5 = this;
        this.<flag>5__2 = false;
        this.<>4__this.receiveRewardBtn.SetActive(value:  true);
        this.<>4__this.receiveRewardByAdsBtn.SetActive(value:  true);
        goto label_14;
        label_1:
        val_6 = 0;
        goto label_15;
        label_10:
        val_5 = this.<flag>5__2;
        label_14:
        if(val_5 == false)
        {
            goto label_17;
        }
        
        label_4:
        val_6 = 1;
        label_17:
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        label_15:
        this.<>1__state = val_6;
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
