using UnityEngine;
private sealed class DOTweenModuleUnityVersion.<>c__DisplayClass8_0
{
    // Fields
    public UnityEngine.Material target;
    public int propertyID;
    
    // Methods
    public DOTweenModuleUnityVersion.<>c__DisplayClass8_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOOffset>b__0()
    {
        if(this.target != null)
        {
                return this.target.GetTextureOffset(nameID:  this.propertyID);
        }
        
        throw new NullReferenceException();
    }
    internal void <DOOffset>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.SetTextureOffset(nameID:  this.propertyID, value:  new UnityEngine.Vector2() {x = x.x, y = x.y});
            return;
        }
        
        throw new NullReferenceException();
    }

}
