using UnityEngine;

namespace ScratchCardAsset.Core.Data
{
    public class Triangle
    {
        // Fields
        private readonly UnityEngine.Vector3 v0;
        private readonly UnityEngine.Vector3 v1;
        private readonly UnityEngine.Vector3 v2;
        private readonly UnityEngine.Vector2 uv0;
        private readonly UnityEngine.Vector2 uv1;
        private readonly UnityEngine.Vector2 uv2;
        
        // Methods
        public Triangle(UnityEngine.Vector3 vertex0, UnityEngine.Vector3 vertex1, UnityEngine.Vector3 vertex2, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2)
        {
            var val_1;
            this.v0 = vertex0;
            mem[1152921513683248036] = vertex0.y;
            mem[1152921513683248040] = vertex0.z;
            this.v1 = vertex1;
            mem[1152921513683248064] = vertex2.y;
            this.uv0 = vertex2.z;
            this.v2 = vertex2;
            mem[1152921513683248072] = val_1;
            mem[1152921513683248048] = vertex1.y;
            mem[1152921513683248052] = vertex1.z;
            this.uv1 = uv0;
        }
        public UnityEngine.Vector2 GetUV(UnityEngine.Vector3 point)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.v0, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.v1, y = val_1.y, z = point.x}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.v2, y = val_2.y, z = point.x}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.v0, y = val_3.y, z = V6.16B}, b:  new UnityEngine.Vector3() {x = this.v1, y = point.y, z = point.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.v0, y = val_4.y, z = V6.16B}, b:  new UnityEngine.Vector3() {x = this.v2, y = point.y, z = point.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            float val_30 = val_6.x.magnitude;
            float val_28 = val_7.x.magnitude;
            val_28 = (val_28 / val_30) * (UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})));
            float val_29 = val_8.x.magnitude;
            val_29 = (val_29 / val_30) * (UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})));
            val_30 = (val_9.x.magnitude / val_30) * (UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})));
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.uv0, y = val_2.x}, d:  val_28);
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.uv1, y = val_28}, d:  val_29);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = this.uv2, y = val_24.x}, d:  val_30);
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, b:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
            return new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
        }
    
    }

}
