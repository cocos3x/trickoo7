using UnityEngine;
[Serializable]
public struct JumpData
{
    // Fields
    public float gravity;
    public float initialVelocity;
    
    // Methods
    public JumpData(float g, float u)
    {
        this = g;
        this.initialVelocity = u;
    }

}
