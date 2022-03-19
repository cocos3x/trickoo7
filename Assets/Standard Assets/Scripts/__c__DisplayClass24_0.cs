using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass24_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass24_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOPivotY>b__0()
    {
        if(this.target != null)
        {
                return this.target.pivot;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOPivotY>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.pivot = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }

}
