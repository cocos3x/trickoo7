using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass0_0
{
    // Fields
    public UnityEngine.CanvasGroup target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass0_0()
    {
    
    }
    internal float <DOFade>b__0()
    {
        if(this.target != null)
        {
                return this.target.alpha;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOFade>b__1(float x)
    {
        if(this.target != null)
        {
                this.target.alpha = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
