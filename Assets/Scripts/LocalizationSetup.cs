using UnityEngine;
public class LocalizationSetup : MonoBehaviour
{
    // Fields
    private const string CurrentLanguage = "CurrentLanguage";
    
    // Methods
    private void Awake()
    {
        var val_4;
        Assets.SimpleLocalization.LocalizationManager.Read(path:  "Localization");
        if((UnityEngine.PlayerPrefs.HasKey(key:  "CurrentLanguage")) != false)
        {
                Assets.SimpleLocalization.LocalizationManager.Language = UnityEngine.PlayerPrefs.GetString(key:  "CurrentLanguage");
            return;
        }
        
        UnityEngine.SystemLanguage val_3 = UnityEngine.Application.systemLanguage;
        Assets.SimpleLocalization.LocalizationManager.Language = "English";
        val_4 = null;
        val_4 = null;
        UnityEngine.PlayerPrefs.SetString(key:  "CurrentLanguage", value:  Assets.SimpleLocalization.LocalizationManager._language);
    }
    public void SetLocalization(string localization)
    {
        Assets.SimpleLocalization.LocalizationManager.Language = localization;
        UnityEngine.PlayerPrefs.SetString(key:  "CurrentLanguage", value:  localization);
    }
    public LocalizationSetup()
    {
    
    }

}
