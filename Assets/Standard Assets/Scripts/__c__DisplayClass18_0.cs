using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass18_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass18_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOAnchorPos3DY>b__0()
    {
        if(this.target != null)
        {
                return this.target.anchoredPosition3D;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x)
    {
        if(this.target != null)
        {
                this.target.anchoredPosition3D = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
            return;
        }
        
        throw new NullReferenceException();
    }

}
