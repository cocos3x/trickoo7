using UnityEngine;
public class ShapeTransform : MonoBehaviour
{
    // Fields
    public int[] steps;
    public System.Collections.Generic.List<UnityEngine.Transform> posList;
    
    // Properties
    public int totalPos { get; }
    
    // Methods
    public int get_totalPos()
    {
        return 15882;
    }
    public ShapeTransform SetChildPos(System.Collections.Generic.List<UnityEngine.Transform> transforms)
    {
        UnityEngine.Transform val_3;
        if(transforms == null)
        {
                return (ShapeTransform)this;
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_4 = this.posList;
        var val_5 = 4;
        do
        {
            var val_1 = val_5 - 4;
            if(val_1 >= val_4)
        {
                return (ShapeTransform)this;
        }
        
            if(val_1 < val_4)
        {
                val_4 = val_4 & 4294967295;
            if(val_1 >= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(26865664 != 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_3 = mem[UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32];
            val_3 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Vector3 val_3 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32.localPosition;
            TransformExtend.SetLocalPosition(transform:  val_3, pos:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        
        }
        
            val_5 = val_5 + 1;
        }
        while(this.posList != null);
        
        throw new NullReferenceException();
    }
    public ShapeTransform()
    {
        this.posList = new System.Collections.Generic.List<UnityEngine.Transform>();
    }

}
