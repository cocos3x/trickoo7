using UnityEngine;
public class UIPopupLanguage : UICore
{
    // Fields
    private UnityEngine.UI.Button btnBack;
    private LanguageObj prefab;
    private UnityEngine.Transform languageGroup;
    private System.Collections.Generic.List<LanguageObj> languageObjs;
    
    // Methods
    private void Start()
    {
        this.btnBack.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIPopupLanguage::<Start>b__4_0()));
        this.CreateLanguageObj();
    }
    public void CreateLanguageObj()
    {
        this.languageObjs = new System.Collections.Generic.List<LanguageObj>();
        var val_4 = 0;
        do
        {
            LanguageObj val_2 = UnityEngine.Object.Instantiate<LanguageObj>(original:  this.prefab, parent:  this.languageGroup);
            val_2.Init(_index:  val_4 + 1);
            this.languageObjs.Add(item:  val_2);
            val_4 = val_4 + 1;
        }
        while(val_4 < 9);
    
    }
    public UIPopupLanguage()
    {
    
    }
    private void <Start>b__4_0()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  24);
    }

}
