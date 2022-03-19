using UnityEngine;
public static class JumpDataExtend
{
    // Methods
    public static UnityEngine.Vector3 GetPositionAtTime(JumpData3D jumpData, float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = jumpData.gravity.x, y = jumpData.gravity.y, z = jumpData.gravity.z}, d:  t);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = jumpData.initialVelocity.x, y = jumpData.initialVelocity.y, z = jumpData.initialVelocity.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = jumpData.initialVelocity.x, y = jumpData.initialVelocity.y, z = jumpData.initialVelocity.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  t);
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.5f);
    }

}
