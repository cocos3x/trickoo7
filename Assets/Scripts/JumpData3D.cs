using UnityEngine;
[Serializable]
public struct JumpData3D
{
    // Fields
    public UnityEngine.Vector3 gravity;
    public UnityEngine.Vector3 initialVelocity;
    
    // Methods
    public JumpData3D(UnityEngine.Vector3 g, UnityEngine.Vector3 u)
    {
        this = g.x;
        mem[1152921513361885380] = g.y;
        mem[1152921513361885384] = g.z;
        this.initialVelocity = u;
        mem[1152921513361885392] = u.y;
        mem[1152921513361885396] = u.z;
    }

}
