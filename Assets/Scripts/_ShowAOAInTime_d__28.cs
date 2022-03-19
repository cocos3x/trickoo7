using UnityEngine;
private sealed class GameUIManager.<ShowAOAInTime>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float timeStart;
    public GameUIManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameUIManager.<ShowAOAInTime>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        var val_11;
        System.Func<System.Boolean> val_13;
        object val_14;
        val_9 = this;
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
            goto label_14;
        }
        
        this.<>1__state = 0;
        val_10 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.timeStart);
        this.<>1__state = val_10;
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        val_11 = null;
        val_11 = null;
        val_13 = GameUIManager.<>c.<>9__28_0;
        if(val_13 == null)
        {
                System.Func<System.Boolean> val_2 = null;
            val_13 = val_2;
            val_2 = new System.Func<System.Boolean>(object:  GameUIManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameUIManager.<>c::<ShowAOAInTime>b__28_0());
            GameUIManager.<>c.<>9__28_0 = val_13;
        }
        
        UnityEngine.WaitUntil val_3 = null;
        val_14 = val_3;
        val_3 = new UnityEngine.WaitUntil(predicate:  val_2);
        this.<>2__current = val_14;
        this.<>1__state = 2;
        val_10 = 1;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.UISplash.gameObject.activeSelf) != false)
        {
                this.<>4__this.aoaIsShowing = true;
            AppOpenAdManager val_6 = AppOpenAdManager.Instance;
            val_6.adsPosition = "open_app";
            val_9 = AppOpenAdManager.Instance;
            System.Action val_8 = null;
            val_14 = val_8;
            val_8 = new System.Action(object:  this.<>4__this, method:  System.Void GameUIManager::<ShowAOAInTime>b__28_1());
            val_9.ShowAdIfAvailable(callback:  val_8);
        }
        
        label_14:
        val_10 = 0;
        return (bool)val_10;
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
