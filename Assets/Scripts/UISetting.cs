using UnityEngine;
public class UISetting : UICore
{
    // Fields
    private UnityEngine.UI.Button btnBack;
    private UnityEngine.UI.Button btnLanguage;
    private UnityEngine.UI.Button btnHome;
    private UnityEngine.UI.Text txtAppVersion;
    private LanguageObj languageObj;
    private UnityEngine.UI.Image currentLanguageImg;
    
    // Methods
    private void Start()
    {
        string val_2 = UnityEngine.Application.version.Replace(oldValue:  ".", newValue:  System.String.alignConst);
        this.btnBack.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UISetting::<Start>b__6_0()));
        this.btnLanguage.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UISetting::<Start>b__6_1()));
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UISetting::<Start>b__6_2());
        this.btnHome.m_OnClick.AddListener(call:  val_5);
        this.ChangeLanguageHandler(obj:  val_5);
    }
    private void OnEnable()
    {
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  25, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UISetting::ChangeLanguageHandler(object obj)), eventType:  1);
    }
    private void OnDisable()
    {
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        val_1.RemoveListener(eventID:  25, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UISetting::ChangeLanguageHandler(object obj)));
    }
    private void ChangeLanguageHandler(object obj)
    {
        this.currentLanguageImg.sprite = this.languageObj.getImgByLanguage();
    }
    public UISetting()
    {
    
    }
    private void <Start>b__6_0()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  17);
    }
    private void <Start>b__6_1()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  23);
    }
    private void <Start>b__6_2()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  17);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  14);
    }

}
