using UnityEngine;
public class UIPopupHint : UICore
{
    // Fields
    private UnityEngine.UI.Button btnClose;
    private UnityEngine.UI.Text txtVictory;
    private string stringLanguage;
    
    // Methods
    private void Start()
    {
        this.btnClose.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIPopupHint::<Start>b__3_0()));
        Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void UIPopupHint::<Start>b__3_1()));
    }
    public void Show()
    {
        this.Show(onDone:  0);
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        StageData val_4 = val_3.stagesAsset.StageStatus(index:  26890240);
        string val_5 = "Hint_" + 26890240;
        this.stringLanguage = val_5;
        string val_6 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  val_5);
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }
    public UIPopupHint()
    {
    
    }
    private void <Start>b__3_0()
    {
        SoundManager.Play(fileName:  "Button");
        this.Hide();
    }
    private void <Start>b__3_1()
    {
        if((System.String.IsNullOrEmpty(value:  this.stringLanguage)) != false)
        {
                return;
        }
        
        string val_2 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.stringLanguage);
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }

}
