using UnityEngine;
private sealed class UIIngame.<>c__DisplayClass43_0
{
    // Fields
    public UIIngame <>4__this;
    public UnityEngine.Vector2 btnHintPos;
    public UnityEngine.Vector2 diff;
    
    // Methods
    public UIIngame.<>c__DisplayClass43_0()
    {
    
    }
    internal void <SuggestTouchHintHandler>b__0()
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.btnHintPos, y = V9.16B}, b:  new UnityEngine.Vector2() {x = this.diff, y = V8.16B});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.<>4__this.hand.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    internal void <SuggestTouchHintHandler>b__1()
    {
        if((this.<>4__this.finishMove) != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.<>4__this.finishMove, complete:  false);
            this.<>4__this = this.<>4__this;
        }
        
        this.<>4__this.hand.SetActive(value:  false);
    }

}
