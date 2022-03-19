using UnityEngine;
public class MovementExtend
{
    // Methods
    public static JumpData CalculateJumpData(float h, float p, float t)
    {
        float val_2;
        float val_2 = t;
        h = h - p;
        p = h / h;
        if(h >= _TYPE_MAX_)
        {
                val_2 = p;
        }
        
        val_2 = val_2 + 1f;
        val_2 = val_2 / val_2;
        float val_1 = h * (-2f);
        val_2 = val_2 * val_2;
        val_2 = val_1 / val_2;
        val_2 = val_1 * val_2;
        if(val_1 < _TYPE_MAX_)
        {
                return new JumpData() {gravity = val_2, initialVelocity = val_2};
        }
        
        return new JumpData() {gravity = val_2, initialVelocity = val_2};
    }
    public static float CalculateBezier(float t, float[] p)
    {
        float val_5;
        float val_6;
        var val_7;
        int val_6 = p.Length;
        int val_1 = val_6 - 1;
        if()
        {
            goto label_2;
        }
        
        var val_5 = 0;
        float val_2 = 1f - t;
        label_16:
        if(val_5 == 0)
        {
            goto label_3;
        }
        
        if(val_1 != val_5)
        {
            goto label_4;
        }
        
        val_5 = t;
        goto label_12;
        label_3:
        val_5 = val_2;
        val_6 = p[0];
        goto label_12;
        label_4:
        val_5 = ((MovementExtend.nCi(n:  (float)val_6, i:  0f)) * val_2) * t;
        label_12:
        val_5 = val_5 * null;
        val_5 = val_5 + 1;
        val_7 = 0f + val_5;
        val_6 = val_6 - 1;
        if(val_5 < (long)val_6)
        {
            goto label_16;
        }
        
        return (float)val_7;
        label_2:
        val_7 = 0f;
        return (float)val_7;
    }
    public static UnityEngine.Vector3 CalculateQuadraticVelocity(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        float val_3 = UnityEngine.Mathf.Clamp01(value:  t);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, b:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
        float val_9 = 1f;
        val_9 = val_9 - val_3;
        val_9 = val_9 + val_9;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.x, y = val_1, z = p2.y}, b:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  val_3 + val_3, a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
    }
    public static UnityEngine.Vector3 CalculateBezier(float t, UnityEngine.Vector3[] p)
    {
        int val_9;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        var val_17;
        UnityEngine.Vector3 val_18;
        UnityEngine.Vector3 val_19;
        float val_20;
        UnityEngine.Vector3 val_21;
        val_9 = p.Length;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_13 = val_1.x;
        val_14 = val_1.y;
        int val_2 = val_9 - 1;
        val_15 = val_1.z;
        if()
        {
                return new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
        }
        
        var val_9 = 12;
        float val_10 = 1f;
        val_9 = p + (val_2 * val_9);
        val_10 = val_10 - t;
        var val_12 = 0;
        val_16 = (float)val_9;
        label_22:
        if(val_12 == 0)
        {
            goto label_5;
        }
        
        if(val_2 != val_12)
        {
            goto label_6;
        }
        
        val_17 = null;
        val_18 = mem[(((p.Length - 1) * 12) + p + 36)];
        val_18 = val_9 + 36;
        val_19 = mem[(((p.Length - 1) * 12) + p + 40)];
        val_19 = val_9 + 40;
        val_20 = t;
        val_21 = mem[(((p.Length - 1) * 12) + p + 32)];
        val_21 = val_9 + 32;
        goto label_16;
        label_5:
        val_17 = null;
        val_21 = p[0];
        val_18 = p[0];
        val_19 = p[1];
        val_20 = val_10;
        goto label_16;
        label_6:
        float val_11 = MovementExtend.nCi(n:  val_16, i:  0f);
        val_11 = val_11 * val_10;
        val_16 = val_16;
        val_20 = val_11 * t;
        label_16:
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  val_20, a:  new UnityEngine.Vector3() {x = 0.8389788f, y = 0.8389788f, z = 0.8389788f});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_12 = val_12 + 1;
        val_13 = val_8.x;
        val_14 = val_8.y;
        val_15 = val_8.z;
        val_9 = val_9 - 1;
        if(val_12 < (long)val_9)
        {
            goto label_22;
        }
        
        return new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
    }
    private static float nCi(float n, float i)
    {
        float val_2;
        float val_3;
        float val_4;
        val_2 = 1f;
        val_3 = val_2;
        if(n > val_2)
        {
                var val_2 = 2;
            do
        {
            val_3 = 1f * 1f;
            val_2 = val_2 + 1;
        }
        while(2f < 0);
        
        }
        
        val_4 = val_2;
        if(i > val_2)
        {
                var val_3 = 2;
            do
        {
            val_4 = 1f * 1f;
            val_3 = val_3 + 1;
        }
        while(2f < 0);
        
        }
        
        n = n - i;
        if(n > val_2)
        {
                var val_4 = 2;
            do
        {
            val_2 = 1f * 1f;
            val_4 = val_4 + 1;
        }
        while(n > 2f);
        
        }
        
        float val_1 = val_4 * val_2;
        val_1 = val_3 / val_1;
        return (float)val_1;
    }
    private static float factorial(float n)
    {
        float val_1 = 1f;
        if(n <= val_1)
        {
                return (float)val_1;
        }
        
        var val_1 = 2;
        do
        {
            val_1 = 1f * 1f;
            val_1 = val_1 + 1;
        }
        while(2f < 0);
        
        return (float)val_1;
    }
    public static JumpData3D CalculateJumpData(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Vector3 offset, float t)
    {
        float val_1;
        float val_25;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        JumpData3D val_0;
        float val_21 = start.y;
        val_25 = offset.z;
        float val_2 = end.x - start.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_27 = val_3.x;
        float val_4 = val_21 + val_1;
        val_4 = val_4 * (-2f);
        val_28 = val_4 / (val_25 * val_25);
        val_4 = val_28 * val_25;
        val_4 = val_4 * val_25;
        val_29 = val_3.z;
        val_30 = val_4 * (-0.5f);
        val_21 = (end.y - val_21) + val_30;
        if(offset.x == 0f)
        {
                val_31 = val_2 / val_25;
        }
        else
        {
                float val_7 = val_2 - offset.x;
            val_7 = val_7 / offset.x;
            if(val_7 >= _TYPE_MAX_)
        {
                val_32 = System.Math.Abs(val_7);
        }
        
            val_32 = val_32 + 1f;
            float val_9 = UnityEngine.Mathf.Sign(f:  offset.x);
            val_9 = val_9 * (-2f);
            val_9 = System.Math.Abs(offset.x) * val_9;
            val_27 = val_9 / ((val_25 / val_32) * (val_25 / val_32));
            val_30 = offset.x;
            float val_12 = offset.x * (-2f);
            val_12 = val_12 * val_27;
            if(val_12 >= _TYPE_MAX_)
        {
                val_30 = System.Math.Abs(val_12);
            val_33 = val_30;
        }
        
            val_31 = (UnityEngine.Mathf.Sign(f:  val_30)) * val_33;
            val_28 = val_28;
        }
        
        float val_25 = end.z;
        val_34 = offset.y;
        val_35 = val_25 - start.z;
        if(val_34 == 0f)
        {
                float val_14 = val_35 / val_25;
        }
        else
        {
                val_34 = offset.y;
            val_25 = val_35 - val_34;
            val_25 = val_25 / val_34;
            if(val_25 >= _TYPE_MAX_)
        {
                val_36 = System.Math.Abs(val_25);
            val_34 = offset.y;
        }
        
            val_36 = val_36 + 1f;
            val_25 = val_34;
            float val_16 = UnityEngine.Mathf.Sign(f:  val_34);
            val_16 = val_16 * (-2f);
            val_16 = System.Math.Abs(val_25) * val_16;
            val_29 = val_16 / ((val_25 / val_36) * (val_25 / val_36));
            val_35 = -2f;
            float val_19 = val_25 * val_35;
            val_19 = val_19 * val_29;
            float val_28 = System.Math.Abs(val_19);
            if(val_19 >= _TYPE_MAX_)
        {
                val_37 = val_28;
        }
        
            val_28 = (UnityEngine.Mathf.Sign(f:  val_25)) * val_37;
            val_28 = val_28;
        }
        
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_31, y:  val_21 / val_25, z:  val_28);
        val_0.gravity.x = val_27;
        val_0.gravity.y = val_28;
        val_0.gravity.z = val_29;
        val_0.initialVelocity.x = val_20.x;
        val_0.initialVelocity.z = val_20.z;
        return val_0;
    }
    public MovementExtend()
    {
    
    }

}
