using UnityEngine;

namespace Assets.SimpleLocalization
{
    public class LocalizedText : MonoBehaviour
    {
        // Fields
        public string LocalizationKey;
        
        // Methods
        public void Start()
        {
            this.Localize();
            Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void Assets.SimpleLocalization.LocalizedText::Localize()));
        }
        public void OnDestroy()
        {
            Assets.SimpleLocalization.LocalizationManager.remove_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void Assets.SimpleLocalization.LocalizedText::Localize()));
        }
        private void Localize()
        {
            UnityEngine.UI.Text val_1 = this.GetComponent<UnityEngine.UI.Text>();
            string val_2 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.LocalizationKey);
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
        }
        public LocalizedText()
        {
        
        }
    
    }

}
