using UnityEngine;
public class Button2D : MonoBehaviour
{
    // Fields
    public UnityEngine.Events.UnityEvent action;
    
    // Methods
    private void OnMouseDown()
    {
        if(this.action != null)
        {
                this.action.Invoke();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void OnMouseUp()
    {
    
    }
    public Button2D()
    {
    
    }

}
