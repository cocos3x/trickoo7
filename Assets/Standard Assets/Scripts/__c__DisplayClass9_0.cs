using UnityEngine;
private sealed class DOTweenModuleUnityVersion.<>c__DisplayClass9_0
{
    // Fields
    public UnityEngine.Material target;
    public int propertyID;
    
    // Methods
    public DOTweenModuleUnityVersion.<>c__DisplayClass9_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOTiling>b__0()
    {
        if(this.target != null)
        {
                return this.target.GetTextureScale(nameID:  this.propertyID);
        }
        
        throw new NullReferenceException();
    }
    internal void <DOTiling>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.SetTextureScale(nameID:  this.propertyID, value:  new UnityEngine.Vector2() {x = x.x, y = x.y});
            return;
        }
        
        throw new NullReferenceException();
    }

}
