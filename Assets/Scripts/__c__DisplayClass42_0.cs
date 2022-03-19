using UnityEngine;
private sealed class UIIngame.<>c__DisplayClass42_0
{
    // Fields
    public UIIngame <>4__this;
    public System.Collections.Generic.List<UnityEngine.Vector2> listPosition;
    public UnityEngine.Vector2 offset;
    
    // Methods
    public UIIngame.<>c__DisplayClass42_0()
    {
    
    }
    internal void <ShowTutorialHandler>b__0()
    {
        if((this.<>4__this) == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.<>4__this.txtQuestion, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.offset, y = V8.16B});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.<>4__this.hand.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }

}
