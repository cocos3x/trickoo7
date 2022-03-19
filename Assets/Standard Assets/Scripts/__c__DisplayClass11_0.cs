using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass11_0
{
    // Fields
    public UnityEngine.UI.Outline target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass11_0()
    {
    
    }
    internal UnityEngine.Color <DOFade>b__0()
    {
        if(this.target != null)
        {
                return new UnityEngine.Color();
        }
        
        throw new NullReferenceException();
    }
    internal void <DOFade>b__1(UnityEngine.Color x)
    {
        if(this.target != null)
        {
                this.target.effectColor = new UnityEngine.Color() {r = x.r, g = x.g, b = x.b, a = x.a};
            return;
        }
        
        throw new NullReferenceException();
    }

}
