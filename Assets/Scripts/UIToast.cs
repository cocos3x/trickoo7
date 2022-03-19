using UnityEngine;
public class UIToast : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform mainTransform;
    private UnityEngine.RectTransform contentTransform;
    private UnityEngine.RectTransform contentStartPos;
    private UnityEngine.CanvasGroup contents;
    private UnityEngine.UI.HorizontalLayoutGroup horizontalLayoutGroup;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text message;
    private int maxLengthToSplit;
    private UnityEngine.GameObject deActive;
    private UnityEngine.UI.Image iconImage;
    private UnityEngine.Sprite iconLoading;
    private UnityEngine.Sprite iconNotification;
    private string soundNotification;
    private UnityEngine.Sprite iconError;
    private string soundError;
    private UnityEngine.Sprite iconUnlock;
    private string soundUnlock;
    private UnityEngine.Sprite iconTip;
    private System.Collections.Generic.List<UnityEngine.UI.ContentSizeFitter> grids;
    private static float elapsedTime;
    public static ToastType toastType;
    public static UIAnimStatus Status;
    private static UIToast instance;
    private int indexTest;
    
    // Properties
    public static UnityEngine.Sprite IconNotification { get; }
    public static UnityEngine.Sprite IconError { get; }
    public static UnityEngine.Sprite IconUnlock { get; }
    public static UnityEngine.Sprite IconTip { get; }
    
    // Methods
    public static UnityEngine.Sprite get_IconNotification()
    {
        var val_1;
        UnityEngine.Sprite val_2;
        val_1 = null;
        val_1 = null;
        if(UIToast.instance != null)
        {
                val_2 = mem[UIToast.instance + 112];
            val_2 = UIToast.instance.iconNotification;
            return (UnityEngine.Sprite)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.Sprite)val_2;
    }
    public static UnityEngine.Sprite get_IconError()
    {
        var val_1;
        UnityEngine.Sprite val_2;
        val_1 = null;
        val_1 = null;
        if(UIToast.instance != null)
        {
                val_2 = mem[UIToast.instance + 128];
            val_2 = UIToast.instance.iconError;
            return (UnityEngine.Sprite)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.Sprite)val_2;
    }
    public static UnityEngine.Sprite get_IconUnlock()
    {
        var val_1;
        UnityEngine.Sprite val_2;
        val_1 = null;
        val_1 = null;
        if(UIToast.instance != null)
        {
                val_2 = mem[UIToast.instance + 144];
            val_2 = UIToast.instance.iconUnlock;
            return (UnityEngine.Sprite)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.Sprite)val_2;
    }
    public static UnityEngine.Sprite get_IconTip()
    {
        var val_1;
        UnityEngine.Sprite val_2;
        val_1 = null;
        val_1 = null;
        if(UIToast.instance != null)
        {
                val_2 = mem[UIToast.instance + 160];
            val_2 = UIToast.instance.iconTip;
            return (UnityEngine.Sprite)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.Sprite)val_2;
    }
    private void Awake()
    {
        null = null;
        UIToast.instance = this;
    }
    private void Start()
    {
        var val_3;
        UnityEngine.Events.UnityAction val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_5 = UIToast.<>c.<>9__32_0;
        if(val_5 == null)
        {
                UnityEngine.Events.UnityAction val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.Events.UnityAction(object:  UIToast.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UIToast.<>c::<Start>b__32_0());
            UIToast.<>c.<>9__32_0 = val_5;
        }
        
        this.closeButton.m_OnClick.AddListener(call:  val_1);
        this.deActive.SetActive(value:  false);
        this.contentTransform.gameObject.SetActive(value:  false);
        val_6 = null;
        val_6 = null;
        this.mainTransform.anchoredPosition = new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34};
    }
    public static void ShowNotice(string mes)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIToast.instance)) != false)
        {
                val_3 = null;
            val_3 = null;
            UIToast.instance.Show(mes:  mes, type:  1, timeAutoHide:  3f, icon:  0, soundEffect:  "");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[UIToast]  instance NULL");
    }
    public static void ShowError(string mes)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIToast.instance)) != false)
        {
                val_3 = null;
            val_3 = null;
            UIToast.instance.Show(mes:  mes, type:  2, timeAutoHide:  5f, icon:  0, soundEffect:  "");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[UIToast]  instance NULL");
    }
    public static void ShowUnlock(string mes, UnityEngine.Sprite sprite)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIToast.instance)) != false)
        {
                val_3 = null;
            val_3 = null;
            UIToast.instance.Show(mes:  mes, type:  3, timeAutoHide:  5f, icon:  sprite, soundEffect:  "");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[UIToast]  instance NULL");
    }
    public static void ShowLoading(string mes, float timeAutoHide = 3, UnityEngine.Sprite icon)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIToast.instance)) != false)
        {
                val_3 = null;
            val_3 = null;
            UIToast.instance.Show(mes:  mes, type:  0, timeAutoHide:  timeAutoHide, icon:  icon, soundEffect:  "");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[UIToast]  instance NULL");
    }
    public static void Show(string mes, UnityEngine.Sprite icon, ToastType type, float timeAutoHide)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  UIToast.instance)) != false)
        {
                val_3 = null;
            val_3 = null;
            UIToast.instance.Show(mes:  mes, type:  type, timeAutoHide:  timeAutoHide, icon:  icon, soundEffect:  "");
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[UIToast]  instance NULL");
    }
    public void Show(string mes)
    {
        this.Show(mes:  mes, type:  1, timeAutoHide:  3f, icon:  0, soundEffect:  "");
    }
    private void Show(string mes = "", ToastType type = 0, float timeAutoHide = 3, UnityEngine.Sprite icon, string soundEffect = "")
    {
        var val_38;
        string val_39;
        string val_40;
        string val_41;
        var val_42;
        UnityEngine.UI.Image val_43;
        var val_44;
        UnityEngine.Sprite val_45;
        var val_46;
        var val_47;
        var val_48;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_49;
        DG.Tweening.TweenCallback val_50;
        var val_51;
        var val_52;
        UIToast.<>c__DisplayClass39_0 val_1 = new UIToast.<>c__DisplayClass39_0();
        .<>4__this = this;
        .mes = mes;
        val_38 = null;
        val_38 = null;
        UIToast.toastType = type;
        if(((System.String.IsNullOrEmpty(value:  (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes)) == true) || (((UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes.m_stringLength) <= this.maxLengthToSplit))
        {
            goto label_84;
        }
        
        val_39 = (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes;
        if(((UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes.Contains(value:  "...! ")) == false)
        {
            goto label_8;
        }
        
        val_40 = "...! ";
        val_41 = "...!\n";
        goto label_15;
        label_8:
        val_39 = (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes;
        if((val_39.Contains(value:  "... ")) == false)
        {
            goto label_11;
        }
        
        val_40 = "... ";
        val_41 = "...\n";
        goto label_15;
        label_11:
        val_39 = (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes;
        if((val_39.Contains(value:  ". ")) == false)
        {
            goto label_14;
        }
        
        val_40 = ". ";
        val_41 = ".\n";
        goto label_15;
        label_14:
        val_39 = (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes;
        if((val_39.Contains(value:  "!? ")) == false)
        {
            goto label_17;
        }
        
        val_40 = "!? ";
        val_41 = "!?\n";
        label_15:
        label_86:
        .mes = val_39.Replace(oldValue:  val_40, newValue:  val_41);
        label_84:
        val_42 = null;
        val_42 = null;
        UIToast.elapsedTime = timeAutoHide;
        val_43 = this.iconImage;
        if(((UnityEngine.Object.op_Implicit(exists:  val_43)) == false) || (icon != 0))
        {
            goto label_25;
        }
        
        val_44 = null;
        val_44 = null;
        if(UIToast.toastType > 3)
        {
            goto label_83;
        }
        
        var val_38 = 20220376 + (type) << 2;
        val_38 = val_38 + 20220376;
        goto (20220376 + (type) << 2 + 20220376);
        label_25:
        val_45 = icon;
        this.iconImage.sprite = val_45;
        label_83:
        if((System.String.IsNullOrEmpty(value:  soundEffect)) != true)
        {
                SoundManager.Play(fileName:  soundEffect);
        }
        
        val_46 = null;
        val_46 = null;
        if(UIToast.Status == 3)
        {
                if((System.String.op_Equality(a:  this.message, b:  (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes.Trim())) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Sample mes... return");
            return;
        }
        
        }
        
        this.StopAllCoroutines();
        val_47 = null;
        val_47 = null;
        if(UIToast.Status != 0)
        {
                int val_14 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.contents, complete:  true);
            val_49 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this.contents, endValue:  0f, duration:  0.15f);
            DG.Tweening.TweenCallback val_16 = null;
            val_50 = val_16;
            val_16 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIToast.<>c__DisplayClass39_0::<Show>b__2());
            val_51 = 1152921513343583120;
        }
        else
        {
                val_48 = 1152921504889917448;
            UIToast.Status = 1;
            this.contentTransform.gameObject.SetActive(value:  true);
            int val_18 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.contentTransform, complete:  true);
            string val_19 = (UIToast.<>c__DisplayClass39_0)[1152921513506819552].mes.Trim();
            this.message.gameObject.SetActive(value:  false);
            this.horizontalLayoutGroup.enabled = false;
            UnityEngine.Vector2 val_21 = this.contentStartPos.anchoredPosition;
            this.contentTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_21.x, y = val_21.y};
            val_52 = null;
            val_52 = null;
            val_43 = 1152921504774684672;
            val_49 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.contentTransform, endValue:  new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34}, duration:  0.125f, snapping:  false), delay:  0.05f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIToast.<>c__DisplayClass39_0::<Show>b__0()));
            DG.Tweening.TweenCallback val_26 = null;
            val_50 = val_26;
            val_26 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIToast.<>c__DisplayClass39_0::<Show>b__1());
            val_51 = 1152921513342874384;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_49, action:  val_26);
        UnityEngine.Coroutine val_29 = this.StartCoroutine(routine:  this.AutoHide(active:  true));
        this.deActive.SetActive(value:  (UIToast.toastType == 0) ? 1 : 0);
        return;
        label_17:
        if((val_39.Contains(value:  "! ")) == false)
        {
            goto label_84;
        }
        
        goto label_86;
    }
    public void Close()
    {
        null = null;
        if(UIToast.toastType == 0)
        {
                return;
        }
        
        UIToast.Hide(active:  true);
    }
    public static void Hide(bool active = True)
    {
        null = null;
        UIToast.elapsedTime = 0f;
        UIToast.instance.StopCoroutine(routine:  UIToast.instance.AutoHide(active:  active));
    }
    private System.Collections.IEnumerator AutoHide(bool active = True)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .active = active;
        return (System.Collections.IEnumerator)new UIToast.<AutoHide>d__42();
    }
    private System.Collections.IEnumerator OptimizeLayout()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new UIToast.<OptimizeLayout>d__43();
    }
    public void Test()
    {
        int val_4;
        string[] val_1 = new string[7];
        val_4 = val_1.Length;
        val_1[0] = "With music we are the one!";
        val_4 = val_1.Length;
        val_1[1] = "Let\'s the music!";
        val_4 = val_1.Length;
        val_1[2] = "Let\'s the music!";
        val_4 = val_1.Length;
        val_1[3] = "";
        val_4 = val_1.Length;
        val_1[4] = "Got music!?";
        val_4 = val_1.Length;
        val_1[5] = "Touching heaven on frequency!";
        val_4 = val_1.Length;
        val_1[6] = "Oops... Don\'t do that! Touching...!";
        UIToast.ShowNotice(mes:  val_1[this.indexTest]);
        int val_2 = this.indexTest + 1;
        this.indexTest = val_2;
        this.indexTest = (val_2 >= val_1.Length) ? 0 : (this.indexTest + 1);
    }
    public UIToast()
    {
        this.maxLengthToSplit = 36;
    }
    private static UIToast()
    {
    
    }
    private void <AutoHide>b__42_0()
    {
        null = null;
        UIToast.Status = 0;
        this.contentTransform.gameObject.SetActive(value:  false);
    }

}
