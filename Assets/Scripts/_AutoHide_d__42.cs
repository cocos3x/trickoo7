using UnityEngine;
private sealed class UIToast.<AutoHide>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIToast <>4__this;
    public bool active;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIToast.<AutoHide>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_7;
        var val_8;
        float val_9;
        int val_10;
        val_7 = this;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_8 = null;
        val_8 = null;
        val_9 = UIToast.elapsedTime;
        if(val_9 > 0f)
        {
            goto label_4;
        }
        
        this.<>4__this.deActive.SetActive(value:  (this.active == false) ? 1 : 0);
        UnityEngine.Vector2 val_2 = this.<>4__this.contentStartPos.anchoredPosition;
        val_7 = DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.<>4__this.contentTransform, endValue:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, duration:  0.125f, snapping:  false);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_7, action:  new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void UIToast::<AutoHide>b__42_0()));
        label_1:
        val_10 = 0;
        return (bool)val_10;
        label_4:
        val_9 = UIToast.elapsedTime;
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_9 - val_6;
        val_10 = 1;
        UIToast.elapsedTime = val_6;
        this.<>2__current = 0;
        this.<>1__state = val_10;
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
