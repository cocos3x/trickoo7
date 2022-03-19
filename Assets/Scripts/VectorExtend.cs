using UnityEngine;
public static class VectorExtend
{
    // Methods
    public static UnityEngine.Vector3 Multi(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
    {
        a.x = a.x * b.x;
        a.y = a.y * b.y;
        a.z = a.z * b.z;
        return new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z};
    }
    public static UnityEngine.Vector3 Multi(UnityEngine.Vector3 a, float x, float y, float z)
    {
        a.x = a.x * x;
        a.y = a.y * y;
        a.z = a.z * z;
        return new UnityEngine.Vector3() {x = a.x, y = a.y, z = a.z};
    }
    public static UnityEngine.Vector2 Multi(UnityEngine.Vector2 a, UnityEngine.Vector2 b)
    {
        a.x = a.x * b.x;
        a.y = a.y * b.y;
        return new UnityEngine.Vector2() {x = a.x, y = a.y};
    }

}
