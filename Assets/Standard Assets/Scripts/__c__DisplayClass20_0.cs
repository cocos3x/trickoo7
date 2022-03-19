using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass20_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass20_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOAnchorMax>b__0()
    {
        if(this.target != null)
        {
                return this.target.anchorMax;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOAnchorMax>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.anchorMax = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }

}
