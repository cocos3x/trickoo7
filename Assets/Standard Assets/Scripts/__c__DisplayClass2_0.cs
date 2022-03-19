using UnityEngine;
private sealed class DOTweenProShortcuts.<>c__DisplayClass2_0
{
    // Fields
    public UnityEngine.Rigidbody target;
    
    // Methods
    public DOTweenProShortcuts.<>c__DisplayClass2_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOSpiral>b__0()
    {
        if(this.target != null)
        {
                return this.target.position;
        }
        
        throw new NullReferenceException();
    }

}
