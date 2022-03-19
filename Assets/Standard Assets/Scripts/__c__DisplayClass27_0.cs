using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass27_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass27_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOShakeAnchorPos>b__0()
    {
        UnityEngine.Vector2 val_1 = this.target.anchoredPosition;
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
    }
    internal void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z});
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }

}
