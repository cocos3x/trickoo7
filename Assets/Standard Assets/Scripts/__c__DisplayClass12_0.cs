using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass12_0
{
    // Fields
    public UnityEngine.UI.Outline target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass12_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOScale>b__0()
    {
        if(this.target != null)
        {
                return new UnityEngine.Vector2();
        }
        
        throw new NullReferenceException();
    }
    internal void <DOScale>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.effectDistance = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }

}
