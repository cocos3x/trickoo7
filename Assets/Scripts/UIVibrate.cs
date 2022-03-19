using UnityEngine;
public class UIVibrate : UIToggle
{
    // Methods
    public override void Start()
    {
        this.Start();
        0.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void UIVibrate::ToggleVibrate(bool isOn)));
    }
    private void ToggleVibrate(bool isOn)
    {
        if(isOn == false)
        {
                return;
        }
        
        UnityEngine.Handheld.Vibrate();
    }
    public static void Vibrate()
    {
        null = null;
        UnityEngine.Handheld.Vibrate();
    }
    public UIVibrate()
    {
    
    }

}
