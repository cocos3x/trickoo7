using UnityEngine;
public class VibrateManager : MonoBehaviour
{
    // Fields
    private UIToggle vibrateToggle;
    private static VibrateManager <instance>k__BackingField;
    
    // Properties
    private static VibrateManager instance { get; set; }
    
    // Methods
    private static VibrateManager get_instance()
    {
        return (VibrateManager)VibrateManager.<instance>k__BackingField;
    }
    private static void set_instance(VibrateManager value)
    {
        VibrateManager.<instance>k__BackingField = value;
    }
    public void Awake()
    {
        VibrateManager.<instance>k__BackingField = this;
    }
    public static void Haptic()
    {
        UIToggle val_3 = mem[VibrateManager.<instance>k__BackingField + 24];
        val_3 = VibrateManager.<instance>k__BackingField.vibrateToggle;
        if(val_3 != 0)
        {
                val_3 = mem[VibrateManager.<instance>k__BackingField + 24];
            val_3 = VibrateManager.<instance>k__BackingField.vibrateToggle;
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        }
        
        MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  1, defaultToRegularVibrate:  false, alsoRumble:  false, coroutineSupport:  0, controllerID:  0);
    }
    public VibrateManager()
    {
    
    }

}
