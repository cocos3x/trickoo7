using UnityEngine;

namespace Assets.SimpleLocalization
{
    public class LocalizedDropdown : MonoBehaviour
    {
        // Fields
        public string[] LocalizationKeys;
        
        // Methods
        public void Start()
        {
            this.Localize();
            Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void Assets.SimpleLocalization.LocalizedDropdown::Localize()));
        }
        public void OnDestroy()
        {
            Assets.SimpleLocalization.LocalizationManager.remove_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void Assets.SimpleLocalization.LocalizedDropdown::Localize()));
        }
        private void Localize()
        {
            var val_13;
            System.String[] val_14;
            var val_15;
            string val_16;
            val_13 = this;
            val_14 = this.LocalizationKeys;
            val_15 = 4;
            label_11:
            var val_2 = val_15 - 4;
            if(val_2 >= this.LocalizationKeys.Length)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<OptionData> val_3 = this.GetComponent<UnityEngine.UI.Dropdown>().options;
            if(val_14 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = this.LocalizationKeys[0];
            mem2[0] = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  val_16);
            val_14 = this.LocalizationKeys;
            val_15 = val_15 + 1;
            if(val_14 != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_3:
            if(val_1.m_Value >= this.LocalizationKeys.Length)
            {
                    return;
            }
            
            string val_5 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  val_14[val_1.m_Value]);
            val_13 = ???;
            val_16 = ???;
            val_15 = ???;
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
        }
        public LocalizedDropdown()
        {
        
        }
    
    }

}
