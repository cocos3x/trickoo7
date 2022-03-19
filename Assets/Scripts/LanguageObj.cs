using UnityEngine;
public class LanguageObj : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<LanguageData> listLanguage;
    private UnityEngine.Sprite notSelected;
    private UnityEngine.Sprite selected;
    private UnityEngine.UI.Button btn;
    private UnityEngine.UI.Text txt;
    private UnityEngine.UI.Image flag;
    private int index;
    private string stringLanguage;
    
    // Methods
    private void Start()
    {
        this.btn.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void LanguageObj::<Start>b__8_0()));
        Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void LanguageObj::<Start>b__8_1()));
        this.UpdateStatus();
    }
    public void Init(int _index)
    {
        bool val_2 = true;
        this.index = _index;
        if(val_2 <= _index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (_index << 3);
        var val_3 = (true + (_index) << 3) + 32;
        this.flag.sprite = (true + (_index) << 3) + 32 + 24;
        if(val_3 <= this.index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + ((this.index) << 3);
        this.stringLanguage = ((true + (_index) << 3) + 32 + (this.index) << 3) + 32 + 16;
        string val_1 = ((true + (_index) << 3) + 32 + (this.index) << 3) + 32 + 16.ToUpper();
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }
    public void UpdateStatus()
    {
        var val_7 = null;
        var val_3 = ((System.String.op_Equality(a:  Assets.SimpleLocalization.LocalizationManager._language, b:  this.stringLanguage)) != true) ? 40 : 32;
        this.btn.image.sprite = null;
        if((System.String.IsNullOrEmpty(value:  this.stringLanguage)) != false)
        {
                return;
        }
        
        string val_6 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.stringLanguage).ToUpper();
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }
    public UnityEngine.Sprite getImgByLanguage()
    {
        var val_3;
        System.Func<LanguageData, System.Boolean> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = LanguageObj.<>c.<>9__11_0;
        if(val_5 == null)
        {
                System.Func<LanguageData, System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<LanguageData, System.Boolean>(object:  LanguageObj.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LanguageObj.<>c::<getImgByLanguage>b__11_0(LanguageData x));
            LanguageObj.<>c.<>9__11_0 = val_5;
        }
        
        LanguageData val_2 = System.Linq.Enumerable.FirstOrDefault<LanguageData>(source:  this.listLanguage, predicate:  val_1);
        return (UnityEngine.Sprite)val_2.spr;
    }
    public LanguageObj()
    {
    
    }
    private void <Start>b__8_0()
    {
        var val_1;
        SoundManager.Play(fileName:  "Button");
        Assets.SimpleLocalization.LocalizationManager.Language = this.stringLanguage;
        val_1 = null;
        val_1 = null;
        UnityEngine.PlayerPrefs.SetString(key:  "CurrentLanguage", value:  Assets.SimpleLocalization.LocalizationManager._language);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  25);
    }
    private void <Start>b__8_1()
    {
        this.UpdateStatus();
    }

}
