using UnityEngine;
private sealed class DOTweenProShortcuts.<>c__DisplayClass1_0
{
    // Fields
    public UnityEngine.Transform target;
    
    // Methods
    public DOTweenProShortcuts.<>c__DisplayClass1_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOSpiral>b__0()
    {
        if(this.target != null)
        {
                return this.target.localPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOSpiral>b__1(UnityEngine.Vector3 x)
    {
        if(this.target != null)
        {
                this.target.localPosition = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
            return;
        }
        
        throw new NullReferenceException();
    }

}
