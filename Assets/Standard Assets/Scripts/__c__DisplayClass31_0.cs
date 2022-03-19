using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass31_0
{
    // Fields
    public UnityEngine.UI.ScrollRect target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass31_0()
    {
    
    }
    internal float <DOHorizontalNormalizedPos>b__0()
    {
        if(this.target != null)
        {
                return this.target.horizontalNormalizedPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOHorizontalNormalizedPos>b__1(float x)
    {
        if(this.target != null)
        {
                this.target.horizontalNormalizedPosition = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
