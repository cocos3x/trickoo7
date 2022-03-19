using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass25_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass25_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOSizeDelta>b__0()
    {
        if(this.target != null)
        {
                return this.target.sizeDelta;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOSizeDelta>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.sizeDelta = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }

}
