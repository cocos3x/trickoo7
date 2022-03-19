using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass32_0
{
    // Fields
    public UnityEngine.UI.ScrollRect target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass32_0()
    {
    
    }
    internal float <DOVerticalNormalizedPos>b__0()
    {
        if(this.target != null)
        {
                return this.target.verticalNormalizedPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOVerticalNormalizedPos>b__1(float x)
    {
        if(this.target != null)
        {
                this.target.verticalNormalizedPosition = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
