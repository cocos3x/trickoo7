using UnityEngine;
public class RaiseEventInListHelper : MonoBehaviour
{
    // Fields
    private EventID[] eventList;
    
    // Methods
    public void In_Raise(int index)
    {
        if((index & 2147483648) != 0)
        {
                return;
        }
        
        if(this.eventList.Length <= index)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  this.eventList[index << 2]);
    }
    public RaiseEventInListHelper()
    {
    
    }

}
