using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass21_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass21_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOAnchorMin>b__0()
    {
        if(this.target != null)
        {
                return this.target.anchorMin;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOAnchorMin>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.anchorMin = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }

}
