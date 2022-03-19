using UnityEngine;
public class UIToggle : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Toggle toggle;
    private UnityEngine.UI.Text status;
    private string keyOn;
    private string keyOff;
    private bool autoSaveLoad;
    private UnityEngine.GameObject toggleOn;
    private UnityEngine.GameObject toggleOff;
    protected static UIToggle instance;
    
    // Properties
    public bool isOn { get; set; }
    
    // Methods
    public virtual void Awake()
    {
        var val_7;
        UnityEngine.UI.Toggle val_8;
        val_7 = null;
        val_7 = null;
        UIToggle.instance = this;
        if(this.toggle == 0)
        {
                UnityEngine.UI.Toggle val_2 = this.GetComponent<UnityEngine.UI.Toggle>();
            val_8 = val_2;
            this.toggle = val_2;
        }
        else
        {
                val_8 = this.toggle;
        }
        
        if(val_8 == 0)
        {
                return;
        }
        
        if(this.autoSaveLoad == false)
        {
                return;
        }
        
        this.toggle.isOn = ((UnityEngine.PlayerPrefs.GetInt(key:  this.name, defaultValue:  this.toggle.m_IsOn)) == 1) ? 1 : 0;
    }
    public virtual void Start()
    {
        this.toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  typeof(UIToggle).__il2cppRuntimeField_1A8));
        this.UpdateStatus();
        this.toggleOn.SetActive(value:  this.toggle.m_IsOn);
        this.toggleOff.SetActive(value:  (this.toggle.m_IsOn == false) ? 1 : 0);
    }
    public virtual void OnChangedAction(UnityEngine.Events.UnityAction<bool> action)
    {
        if(action == null)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.toggle)) == false)
        {
                return;
        }
        
        this.toggle.onValueChanged.AddListener(call:  action);
    }
    public virtual void OnValueChanged(bool isOn)
    {
        if(this.autoSaveLoad != false)
        {
                this.UpdateStatus();
            UnityEngine.PlayerPrefs.SetInt(key:  this.name, value:  isOn);
            UnityEngine.PlayerPrefs.Save();
        }
        
        SoundManager.Play(fileName:  "Button");
        this.toggleOn.SetActive(value:  isOn);
        this.toggleOff.SetActive(value:  (~isOn) & 1);
        UnityEngine.Debug.Log(message:  this.name + " " + isOn.ToString());
    }
    public bool get_isOn()
    {
        if(this.toggle != null)
        {
                return (bool)this.toggle.m_IsOn;
        }
        
        throw new NullReferenceException();
    }
    public void set_isOn(bool value)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.toggle)) == false)
        {
                return;
        }
        
        this.toggle.isOn = value;
    }
    private void Reset()
    {
        this.UpdateStatus();
    }
    private void UpdateStatus()
    {
        bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.status);
    }
    public UIToggle()
    {
        this.keyOn = "On";
        this.autoSaveLoad = true;
        this.keyOff = "Off";
    }
    private static UIToggle()
    {
    
    }

}
