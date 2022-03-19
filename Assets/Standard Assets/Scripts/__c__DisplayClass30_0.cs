using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass30_0
{
    // Fields
    public UnityEngine.UI.ScrollRect target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass30_0()
    {
    
    }
    internal UnityEngine.Vector2 <DONormalizedPos>b__0()
    {
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.target.horizontalNormalizedPosition, y:  this.target.verticalNormalizedPosition);
        return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
    }
    internal void <DONormalizedPos>b__1(UnityEngine.Vector2 x)
    {
        this.target.horizontalNormalizedPosition = x.x;
        this.target.verticalNormalizedPosition = x.y;
    }

}
