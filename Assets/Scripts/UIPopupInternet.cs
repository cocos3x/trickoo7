using UnityEngine;
public class UIPopupInternet : UICore
{
    // Methods
    public void CheckInternet()
    {
        SoundManager.Play(fileName:  "Button");
        if(Util.InternetConnection() == false)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  22, param:  true);
    }
    public UIPopupInternet()
    {
    
    }

}
