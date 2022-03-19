using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass34_0
{
    // Fields
    public UnityEngine.UI.Text target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass34_0()
    {
    
    }
    internal UnityEngine.Color <DOColor>b__0()
    {
        if(this.target != null)
        {
                return this.target.color;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOColor>b__1(UnityEngine.Color x)
    {
        if(this.target != null)
        {
                this.target.color = new UnityEngine.Color() {r = x.r, g = x.g, b = x.b, a = x.a};
            return;
        }
        
        throw new NullReferenceException();
    }

}
