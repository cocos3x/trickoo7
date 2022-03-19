using UnityEngine;

namespace Assets.SimpleLocalization
{
    public class Example : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text FormattedText;
        
        // Methods
        public void Awake()
        {
            string val_10;
            var val_11;
            Assets.SimpleLocalization.LocalizationManager.Read(path:  "Localization");
            if((UnityEngine.PlayerPrefs.HasKey(key:  "CurrentLanguage")) == false)
            {
                goto label_3;
            }
            
            Assets.SimpleLocalization.LocalizationManager.Language = UnityEngine.PlayerPrefs.GetString(key:  "CurrentLanguage");
            goto label_6;
            label_3:
            UnityEngine.SystemLanguage val_3 = UnityEngine.Application.systemLanguage;
            if(val_3 <= 14)
            {
                goto label_7;
            }
            
            if((val_3 - 21) > 9)
            {
                goto label_8;
            }
            
            var val_10 = 20143144 + ((val_3 - 21)) << 2;
            val_10 = val_10 + 20143144;
            goto (20143144 + ((val_3 - 21)) << 2 + 20143144);
            label_7:
            if(val_3 == 6)
            {
                goto label_12;
            }
            
            if(val_3 != 14)
            {
                goto label_20;
            }
            
            val_10 = "French";
            goto label_32;
            label_12:
            val_10 = "Chinese";
            goto label_32;
            label_8:
            if(val_3 != 39)
            {
                goto label_20;
            }
            
            val_10 = "Vietnamese";
            goto label_32;
            label_20:
            val_10 = "English";
            label_32:
            Assets.SimpleLocalization.LocalizationManager.Language = ;
            val_11 = null;
            val_11 = null;
            UnityEngine.PlayerPrefs.SetString(key:  "CurrentLanguage", value:  Assets.SimpleLocalization.LocalizationManager._language);
            label_6:
            object[] val_5 = new object[1];
            System.TimeSpan val_6 = System.TimeSpan.FromHours(value:  10.5);
            val_5[0] = val_6._ticks.TotalHours;
            string val_8 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  "Hint_Level_1", args:  val_5);
            Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void Assets.SimpleLocalization.Example::<Awake>b__1_0()));
        }
        public void SetLocalization(string localization)
        {
            Assets.SimpleLocalization.LocalizationManager.Language = localization;
        }
        public void Review()
        {
            UnityEngine.Application.OpenURL(url:  "https://www.assetstore.unity3d.com/#!/content/120113");
        }
        public Example()
        {
        
        }
        private void <Awake>b__1_0()
        {
            object[] val_1 = new object[1];
            System.TimeSpan val_2 = System.TimeSpan.FromHours(value:  10.5);
            val_1[0] = val_2._ticks.TotalHours;
            string val_4 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  "Hint_Level_1", args:  val_1);
        }
    
    }

}
