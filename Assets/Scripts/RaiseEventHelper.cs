using UnityEngine;
public class RaiseEventHelper : MonoBehaviour
{
    // Fields
    private EventID eventID;
    
    // Methods
    public void In_Raise()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  this.eventID);
    }
    public RaiseEventHelper()
    {
    
    }

}
