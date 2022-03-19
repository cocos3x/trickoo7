using UnityEngine;

namespace ScratchCardAsset.Tools
{
    public static class MeshGenerator
    {
        // Methods
        public static UnityEngine.Mesh GenerateQuad(UnityEngine.Vector3 size, UnityEngine.Vector3 offset)
        {
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  0f, y:  size.y, z:  0f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = offset.x, y = offset.y, z = offset.z});
            val_2[0] = val_4;
            val_2[0] = val_4.y;
            val_2[1] = val_4.z;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  size.x, y:  size.y, z:  0f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = offset.x, y = offset.y, z = offset.z});
            val_2[1] = val_6;
            val_2[2] = val_6.y;
            val_2[2] = val_6.z;
            UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  size.x, y:  0f, z:  0f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = offset.x, y = offset.y, z = offset.z});
            val_2[3] = val_8;
            val_2[3] = val_8.y;
            val_2[4] = val_8.z;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = offset.x, y = offset.y, z = offset.z});
            val_2[4] = val_10;
            val_2[5] = val_10.y;
            val_2[5] = val_10.z;
            val_1.vertices = val_2;
            UnityEngine.Vector2[] val_11 = new UnityEngine.Vector2[4];
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_11[0] = val_12.x;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_11[1] = val_13.x;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  1f, y:  0f);
            val_11[2] = val_14.x;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_11[3] = val_15.x;
            val_1.uv = val_11;
            val_1.triangles = new int[6] {0, 1, 2, 2, 3, 0};
            UnityEngine.Color[] val_17 = new UnityEngine.Color[4];
            UnityEngine.Color val_18 = UnityEngine.Color.white;
            val_17[0] = val_18;
            val_17[0] = val_18.g;
            val_17[1] = val_18.b;
            val_17[1] = val_18.a;
            UnityEngine.Color val_19 = UnityEngine.Color.white;
            val_17[2] = val_19;
            val_17[2] = val_19.g;
            val_17[3] = val_19.b;
            val_17[3] = val_19.a;
            UnityEngine.Color val_20 = UnityEngine.Color.white;
            val_17[4] = val_20;
            val_17[4] = val_20.g;
            val_17[5] = val_20.b;
            val_17[5] = val_20.a;
            UnityEngine.Color val_21 = UnityEngine.Color.white;
            val_17[6] = val_21;
            val_17[6] = val_21.g;
            val_17[7] = val_21.b;
            val_17[7] = val_21.a;
            val_1.colors = val_17;
            return val_1;
        }
    
    }

}
