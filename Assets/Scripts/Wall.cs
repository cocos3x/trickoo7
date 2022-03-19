using UnityEngine;
public class Wall : MonoBehaviour
{
    // Fields
    private LevelDraw level;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if((System.String.op_Equality(a:  other.tag, b:  "Line")) == false)
        {
                return;
        }
        
        this.level.OnChildTriggerEnter(other:  other);
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D other)
    {
        if((System.String.op_Equality(a:  other.tag, b:  "Line")) == false)
        {
                return;
        }
        
        this.level.OnChildTriggerExit(other:  other);
    }
    public Wall()
    {
    
    }

}
