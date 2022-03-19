using UnityEngine;
public class LocalizationText : MonoBehaviour
{
    // Fields
    private string localizationID;
    private bool isUpper;
    private UnityEngine.UI.Text txtObj;
    private UnityEngine.TextMesh txtMeshObj;
    
    // Methods
    private void Start()
    {
        UnityEngine.UI.Text val_1 = this.GetComponent<UnityEngine.UI.Text>();
        this.txtObj = val_1;
        if(val_1 == 0)
        {
                this.txtMeshObj = this.GetComponent<UnityEngine.TextMesh>();
            Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void LocalizationText::<Start>b__4_0()));
            this.txtMeshObj.text = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.localizationID);
            if(this.isUpper == false)
        {
                return;
        }
        
            this.txtMeshObj.text = this.txtMeshObj.text.ToUpper();
            return;
        }
        
        Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void LocalizationText::<Start>b__4_1()));
        string val_9 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.localizationID);
        if(this.isUpper == false)
        {
                return;
        }
        
        string val_10 = this.txtObj.ToUpper();
        this = ???;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }
    public LocalizationText()
    {
    
    }
    private void <Start>b__4_0()
    {
        this.txtMeshObj.text = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.localizationID);
        if(this.isUpper == false)
        {
                return;
        }
        
        this.txtMeshObj.text = this.txtMeshObj.text.ToUpper();
    }
    private void <Start>b__4_1()
    {
        string val_1 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.localizationID);
        if(this.isUpper == false)
        {
                return;
        }
        
        string val_2 = this.txtObj.ToUpper();
        this = ???;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }

}
