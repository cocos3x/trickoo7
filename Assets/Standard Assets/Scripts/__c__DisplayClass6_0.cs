using UnityEngine;
private sealed class DOTweenModulePhysics2D.<>c__DisplayClass6_0
{
    // Fields
    public UnityEngine.Transform trans;
    public UnityEngine.Rigidbody2D target;
    
    // Methods
    public DOTweenModulePhysics2D.<>c__DisplayClass6_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOLocalPath>b__0()
    {
        if(this.trans != null)
        {
                return this.trans.localPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOLocalPath>b__1(UnityEngine.Vector3 x)
    {
        float val_6;
        float val_7;
        float val_8;
        val_6 = x.z;
        val_7 = x.y;
        val_8 = x.x;
        if(this.trans.parent != 0)
        {
                UnityEngine.Vector3 val_4 = this.trans.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_6});
            val_8 = val_4.x;
            val_7 = val_4.y;
            val_6 = val_4.z;
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_6});
        this.target.MovePosition(position:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
    }

}
