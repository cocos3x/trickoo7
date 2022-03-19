using UnityEngine;
public class UIAnimation : MonoBehaviour
{
    // Fields
    protected UIAnimation.NavigationType navigation;
    public bool dontPlayWithParent;
    private bool hideAtStart;
    private bool hideAtEnd;
    private bool animationAtStart;
    private UIAnimStatus status;
    public UIAnimation.OnStatusChangedDelegate OnStatusChanged;
    protected UIAnimation.Type animationIn;
    private UIAnimation.MovePosition startPos;
    public float timeAnimationIn;
    public float timeDelayIn;
    private UIAnimation.AnimEvent m_StartEvent;
    private UIAnimation.AnimEvent m_ShowCompletedEvent;
    protected UIAnimation.Type animationOut;
    private UIAnimation.MovePosition endPos;
    public float timeAnimationOut;
    private float timeDelayOut;
    private UIAnimation.AnimEvent m_HideCompletedEvent;
    private DG.Tweening.TweenCallback <onHideCompleted>k__BackingField;
    private UnityEngine.RectTransform <rectTransform>k__BackingField;
    private UnityEngine.CanvasGroup <canvasGroup>k__BackingField;
    
    // Properties
    public UIAnimStatus Status { get; set; }
    public bool IsAnimation { get; }
    public UIAnimation.AnimEvent OnStart { get; set; }
    public UIAnimation.AnimEvent OnShowCompleted { get; set; }
    public UIAnimation.AnimEvent OnHideCompleted { get; set; }
    public DG.Tweening.TweenCallback onHideCompleted { get; set; }
    private UnityEngine.RectTransform rectTransform { get; set; }
    private UnityEngine.CanvasGroup canvasGroup { get; set; }
    public UnityEngine.RectTransform GetRectTransform { get; }
    
    // Methods
    public UIAnimStatus get_Status()
    {
        return (UIAnimStatus)this.status;
    }
    public void set_Status(UIAnimStatus value)
    {
        if(this.status == value)
        {
                return;
        }
        
        this.status = value;
        if(this.OnStatusChanged == null)
        {
                return;
        }
        
        this.OnStatusChanged.Invoke(status:  value);
    }
    public bool get_IsAnimation()
    {
        UIAnimStatus val_2 = this.status;
        val_2 = val_2 - 1;
        return (bool)(val_2 < 2) ? 1 : 0;
    }
    public UIAnimation.AnimEvent get_OnStart()
    {
        return (AnimEvent)this.m_StartEvent;
    }
    public void set_OnStart(UIAnimation.AnimEvent value)
    {
        this.m_StartEvent = value;
    }
    public UIAnimation.AnimEvent get_OnShowCompleted()
    {
        return (AnimEvent)this.m_ShowCompletedEvent;
    }
    public void set_OnShowCompleted(UIAnimation.AnimEvent value)
    {
        this.m_ShowCompletedEvent = value;
    }
    public UIAnimation.AnimEvent get_OnHideCompleted()
    {
        return (AnimEvent)this.m_HideCompletedEvent;
    }
    public void set_OnHideCompleted(UIAnimation.AnimEvent value)
    {
        this.m_HideCompletedEvent = value;
    }
    public DG.Tweening.TweenCallback get_onHideCompleted()
    {
        return (DG.Tweening.TweenCallback)this.<onHideCompleted>k__BackingField;
    }
    public void set_onHideCompleted(DG.Tweening.TweenCallback value)
    {
        this.<onHideCompleted>k__BackingField = value;
    }
    private UnityEngine.RectTransform get_rectTransform()
    {
        return (UnityEngine.RectTransform)this.<rectTransform>k__BackingField;
    }
    private void set_rectTransform(UnityEngine.RectTransform value)
    {
        this.<rectTransform>k__BackingField = value;
    }
    private UnityEngine.CanvasGroup get_canvasGroup()
    {
        return (UnityEngine.CanvasGroup)this.<canvasGroup>k__BackingField;
    }
    private void set_canvasGroup(UnityEngine.CanvasGroup value)
    {
        this.<canvasGroup>k__BackingField = value;
    }
    private void Awake()
    {
        this.<rectTransform>k__BackingField = this.gameObject.GetComponent<UnityEngine.RectTransform>();
    }
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.SetActive(value:  (this.hideAtStart == false) ? 1 : 0);
        if(this.animationAtStart == false)
        {
                return;
        }
    
    }
    public void Show()
    {
        goto typeof(UIAnimation).__il2cppRuntimeField_170;
    }
    public void Show(bool playback)
    {
        bool val_1 = playback;
        goto typeof(UIAnimation).__il2cppRuntimeField_170;
    }
    public virtual void Show(DG.Tweening.TweenCallback onStart, DG.Tweening.TweenCallback onCompleted, bool playback = True)
    {
        bool val_1 = playback;
        goto typeof(UIAnimation).__il2cppRuntimeField_180;
    }
    public virtual void Show(DG.Tweening.TweenCallback onStart, DG.Tweening.TweenCallback onCompleted, DG.Tweening.TweenCallback onHide, bool playback = True)
    {
        this.<onHideCompleted>k__BackingField = onHide;
        UIManager.DoStartCoroutine(ienumerator:  this.ShowAsync(playback:  playback, onStart:  onStart, onCompleted:  onCompleted));
    }
    private System.Collections.IEnumerator ShowAsync(bool playback, DG.Tweening.TweenCallback onStart, DG.Tweening.TweenCallback onCompleted)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .playback = playback;
        .onStart = onStart;
        .onCompleted = onCompleted;
        return (System.Collections.IEnumerator)new UIAnimation.<ShowAsync>d__52();
    }
    public void Hide()
    {
        goto typeof(UIAnimation).__il2cppRuntimeField_190;
    }
    public virtual void Hide(DG.Tweening.TweenCallback onCompleted)
    {
        UIManager.DoStartCoroutine(ienumerator:  this.HideAsync(onCompleted:  onCompleted));
    }
    private System.Collections.IEnumerator HideAsync(DG.Tweening.TweenCallback onCompleted)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .onCompleted = onCompleted;
        return (System.Collections.IEnumerator)new UIAnimation.<HideAsync>d__55();
    }
    public void Play(UIAnimation.Type type, bool playBack = False, DG.Tweening.TweenCallback onStart, DG.Tweening.TweenCallback onShowCompleted, DG.Tweening.TweenCallback onHideCompleted)
    {
        var val_20;
        var val_21;
        System.Collections.Generic.List<UIAnimation> val_22;
        UIAnimation val_23;
        var val_24;
        var val_25;
        var val_26;
        if(this.navigation == 3)
        {
            goto label_1;
        }
        
        if(this.navigation != 1)
        {
            goto label_18;
        }
        
        val_20 = 1152921504878145536;
        val_21 = null;
        val_21 = null;
        val_22 = UIManager.<listScreen>k__BackingField;
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = this;
        if((val_22.Contains(item:  this)) != true)
        {
                val_24 = null;
            val_24 = null;
            val_22 = UIManager.<listScreen>k__BackingField;
            if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
            val_22.Add(item:  this);
        }
        
        UIManager.CurScreen = this;
        goto label_18;
        label_1:
        val_20 = 1152921504878145536;
        val_25 = null;
        val_25 = null;
        val_22 = UIManager.<listPopup>k__BackingField;
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = this;
        if((val_22.Contains(item:  this)) != true)
        {
                val_26 = null;
            val_26 = null;
            val_22 = UIManager.<listPopup>k__BackingField;
            if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
            val_22.Add(item:  this);
        }
        
        UIManager.CurPopup = this;
        label_18:
        if((type - 1) <= 3)
        {
                var val_20 = 20145224 + ((type - 1)) << 2;
            val_20 = val_20 + 20145224;
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "[UIAnimaion] " + this.startPos + " not implemented!"(" not implemented!"));
        }
    
    }
    private void SlideIn(UnityEngine.RectTransform rectTransform, UnityEngine.Vector2 fromPosition, float timeAnimation, float timeDelay, DG.Tweening.TweenCallback actionOnStart, DG.Tweening.TweenCallback actionOnComplete, DG.Tweening.Ease ease = 9)
    {
        UnityEngine.CanvasGroup val_15;
        var val_16;
        UIAnimation.<>c__DisplayClass57_0 val_1 = new UIAnimation.<>c__DisplayClass57_0();
        .actionOnStart = actionOnStart;
        .<>4__this = this;
        .actionOnComplete = actionOnComplete;
        if((this.<canvasGroup>k__BackingField) == 0)
        {
                UnityEngine.CanvasGroup val_3 = rectTransform.GetComponent<UnityEngine.CanvasGroup>();
            val_15 = val_3;
            this.<canvasGroup>k__BackingField = val_3;
        }
        else
        {
                val_15 = this.<canvasGroup>k__BackingField;
        }
        
        if(val_15 != 0)
        {
                this.<canvasGroup>k__BackingField.alpha = 1f;
        }
        
        this.gameObject.SetActive(value:  true);
        int val_6 = DG.Tweening.ShortcutExtensions.DOComplete(target:  rectTransform, withCallbacks:  false);
        rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = fromPosition.x, y = fromPosition.y};
        val_16 = null;
        val_16 = null;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  rectTransform, endValue:  new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34}, duration:  timeAnimation, snapping:  false), delay:  timeDelay), ease:  ease), updateType:  0, isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIAnimation.<>c__DisplayClass57_0::<SlideIn>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIAnimation.<>c__DisplayClass57_0::<SlideIn>b__1()));
    }
    private void SlideOut(UnityEngine.RectTransform rectTransform, UnityEngine.Vector2 toPosition, float timeAnimation, float timeDelay, DG.Tweening.TweenCallback actionOnComplete, DG.Tweening.Ease ease = 8)
    {
        .<>4__this = this;
        .actionOnComplete = actionOnComplete;
        int val_2 = DG.Tweening.ShortcutExtensions.DOKill(target:  rectTransform, complete:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  rectTransform, endValue:  new UnityEngine.Vector2() {x = toPosition.x, y = toPosition.y}, duration:  timeAnimation, snapping:  false), delay:  timeDelay), ease:  ease), updateType:  0, isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass58_0(), method:  System.Void UIAnimation.<>c__DisplayClass58_0::<SlideOut>b__0()));
        this.HideElements(actionOnCompleted:  0);
    }
    private void FaceIn(UnityEngine.RectTransform rectTransform, float timeAnimation, float timeDelay, float end = 1, DG.Tweening.TweenCallback actionOnStart, DG.Tweening.TweenCallback actionOnComplete, DG.Tweening.Ease ease = 9)
    {
        UnityEngine.CanvasGroup val_14;
        var val_15;
        .<>4__this = this;
        .end = end;
        .timeAnimation = timeAnimation;
        .timeDelay = timeDelay;
        .ease = ease;
        .actionOnStart = actionOnStart;
        .actionOnComplete = actionOnComplete;
        if((this.<canvasGroup>k__BackingField) == 0)
        {
                UnityEngine.CanvasGroup val_3 = rectTransform.GetComponent<UnityEngine.CanvasGroup>();
            val_14 = val_3;
            this.<canvasGroup>k__BackingField = val_3;
        }
        else
        {
                val_14 = this.<canvasGroup>k__BackingField;
        }
        
        if(val_14 != 0)
        {
            goto label_9;
        }
        
        UnityEngine.CanvasGroup val_6 = rectTransform.gameObject.AddComponent<UnityEngine.CanvasGroup>();
        this.<canvasGroup>k__BackingField = val_6;
        if(val_6 != null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        this.<canvasGroup>k__BackingField.alpha = 0f;
        this.gameObject.SetActive(value:  true);
        int val_8 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.<canvasGroup>k__BackingField, complete:  true);
        int val_9 = DG.Tweening.ShortcutExtensions.DOKill(target:  rectTransform, complete:  true);
        val_15 = null;
        val_15 = null;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  rectTransform, endValue:  new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34}, duration:  0f, snapping:  false), action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass59_0(), method:  System.Void UIAnimation.<>c__DisplayClass59_0::<FaceIn>b__0())), updateType:  0, isIndependentUpdate:  true);
    }
    private void FaceOut(UnityEngine.RectTransform rectTransform, float timeAnimation, float timeDelay, float end = 0, DG.Tweening.TweenCallback actionOnComplete, DG.Tweening.Ease ease = 8)
    {
        UnityEngine.CanvasGroup val_14;
        UnityEngine.CanvasGroup val_15;
        .<>4__this = this;
        .actionOnComplete = actionOnComplete;
        if((this.<canvasGroup>k__BackingField) == 0)
        {
                UnityEngine.CanvasGroup val_3 = rectTransform.GetComponent<UnityEngine.CanvasGroup>();
            val_14 = val_3;
            this.<canvasGroup>k__BackingField = val_3;
        }
        else
        {
                val_14 = this.<canvasGroup>k__BackingField;
        }
        
        if(val_14 == 0)
        {
                this.<canvasGroup>k__BackingField = rectTransform.gameObject.AddComponent<UnityEngine.CanvasGroup>();
        }
        else
        {
                val_15 = this.<canvasGroup>k__BackingField;
        }
        
        int val_7 = DG.Tweening.ShortcutExtensions.DOKill(target:  val_15, complete:  true);
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.<canvasGroup>k__BackingField, endValue:  end, duration:  timeAnimation), delay:  timeDelay), ease:  ease), updateType:  0, isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass60_0(), method:  System.Void UIAnimation.<>c__DisplayClass60_0::<FaceOut>b__0()));
        this.HideElements(actionOnCompleted:  0);
    }
    public void ShowElements(DG.Tweening.TweenCallback actionOnCompleted)
    {
        var val_13;
        var val_15;
        var val_16;
        var val_17;
        DG.Tweening.TweenCallback val_18;
        DG.Tweening.TweenCallback val_19;
        val_13 = this;
        System.Collections.Generic.List<UIAnimation> val_1 = new System.Collections.Generic.List<UIAnimation>();
        var val_13 = 0;
        label_12:
        if(val_13 >= this.transform.childCount)
        {
            goto label_2;
        }
        
        UIAnimation val_7 = this.transform.GetChild(index:  0).gameObject.GetComponent<UIAnimation>();
        if((val_7 != 0) && (val_7.dontPlayWithParent != true))
        {
                val_1.Add(item:  val_7);
        }
        
        val_13 = val_13 + 1;
        if(this.transform != null)
        {
            goto label_12;
        }
        
        label_2:
        if((System.Linq.Enumerable.Any<UIAnimation>(source:  val_1)) != false)
        {
                if(W23 < 1)
        {
                return;
        }
        
            var val_14 = 0;
            do
        {
            val_15 = W23;
            if(W23 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = X9 + 0;
            val_13 = mem[(X9 + 0) + 32];
            val_13 = (X9 + 0) + 32;
            val_16 = val_13;
            if(val_15 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_16 = val_16 + 0;
            val_16 = mem[((X9 + 0) + 32 + 0) + 32];
            val_16 = ((X9 + 0) + 32 + 0) + 32;
        }
        
            if(val_14 == (W23 - 1))
        {
                val_17 = 0;
            val_18 = 0;
            val_19 = actionOnCompleted;
        }
        else
        {
                val_17 = 0;
            val_18 = 0;
            val_19 = 0;
        }
        
            val_13.Play(type:  ((X9 + 0) + 32 + 0) + 32 + 48, playBack:  false, onStart:  val_18, onShowCompleted:  val_19, onHideCompleted:  0);
            val_14 = val_14 + 1;
        }
        while(val_14 < W23);
        
            return;
        }
        
        if(actionOnCompleted == null)
        {
                return;
        }
        
        actionOnCompleted.Invoke();
    }
    public void HideElements(DG.Tweening.TweenCallback actionOnCompleted)
    {
        var val_13;
        var val_15;
        var val_16;
        var val_17;
        DG.Tweening.TweenCallback val_18;
        DG.Tweening.TweenCallback val_19;
        DG.Tweening.TweenCallback val_20;
        val_13 = this;
        System.Collections.Generic.List<UIAnimation> val_1 = new System.Collections.Generic.List<UIAnimation>();
        var val_13 = 0;
        label_12:
        if(val_13 >= this.transform.childCount)
        {
            goto label_2;
        }
        
        UIAnimation val_7 = this.transform.GetChild(index:  0).gameObject.GetComponent<UIAnimation>();
        if((val_7 != 0) && (val_7.dontPlayWithParent != true))
        {
                val_1.Add(item:  val_7);
        }
        
        val_13 = val_13 + 1;
        if(this.transform != null)
        {
            goto label_12;
        }
        
        label_2:
        if((System.Linq.Enumerable.Any<UIAnimation>(source:  val_1)) != false)
        {
                if(W23 < 1)
        {
                return;
        }
        
            var val_14 = 0;
            do
        {
            val_15 = W23;
            if(W23 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = X9 + 0;
            val_13 = mem[(X9 + 0) + 32];
            val_13 = (X9 + 0) + 32;
            val_16 = val_13;
            if(val_15 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_16 = val_16 + 0;
            val_16 = mem[((X9 + 0) + 32 + 0) + 32];
            val_16 = ((X9 + 0) + 32 + 0) + 32;
        }
        
            if(val_14 == (W23 - 1))
        {
                val_17 = 0;
            val_18 = 0;
            val_19 = 0;
            val_20 = actionOnCompleted;
        }
        else
        {
                val_17 = 0;
            val_18 = 0;
            val_19 = 0;
            val_20 = 0;
        }
        
            val_13.Play(type:  ((X9 + 0) + 32 + 0) + 32 + 80, playBack:  false, onStart:  val_18, onShowCompleted:  val_19, onHideCompleted:  val_20);
            val_14 = val_14 + 1;
        }
        while(val_14 < W23);
        
            return;
        }
        
        if(actionOnCompleted == null)
        {
                return;
        }
        
        actionOnCompleted.Invoke();
    }
    public UnityEngine.Vector2 GetPosition(UIAnimation.MovePosition movePosition)
    {
        UnityEngine.RectTransform val_53;
        UnityEngine.Object val_54;
        UnityEngine.Object val_55;
        var val_56;
        float val_65;
        float val_66;
        float val_76;
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        val_54 = 0;
        UnityEngine.Transform val_1 = val_53.parent;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_55 = val_1.GetComponent<UnityEngine.RectTransform>();
        val_54 = 0;
        if(val_55 == val_54)
        {
                UnityEngine.RectTransform val_4 = UIManager.UIContainer;
            if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
            val_54 = public UnityEngine.RectTransform UnityEngine.Component::GetComponent<UnityEngine.RectTransform>();
            val_55 = val_4.GetComponent<UnityEngine.RectTransform>();
        }
        
        val_56 = null;
        val_56 = null;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UIManager.startAnchoredPosition2D, y = UIManager.instance.__il2cppRuntimeField_34});
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Canvas val_7 = val_53.GetComponent<UnityEngine.Canvas>();
        val_54 = 0;
        if(val_7 == val_54)
        {
                val_53 = this.<rectTransform>k__BackingField;
            if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
            val_54 = 0;
            UnityEngine.Transform val_9 = val_53.root;
            if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Canvas val_10 = val_9.GetComponentInChildren<UnityEngine.Canvas>();
        }
        else
        {
                if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
            val_54 = 0;
            UnityEngine.Canvas val_11 = val_7.rootCanvas;
        }
        
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_54 = public UnityEngine.RectTransform UnityEngine.Component::GetComponent<UnityEngine.RectTransform>();
        UnityEngine.RectTransform val_12 = val_11.GetComponent<UnityEngine.RectTransform>();
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Rect val_13 = val_12.rect;
        val_54 = 0;
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        float val_53 = val_13.m_XMin.width;
        UnityEngine.Rect val_15 = val_53.rect;
        val_54 = 0;
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector2 val_17 = val_53.pivot;
        val_54 = 0;
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        float val_56 = val_13.m_XMin.height;
        UnityEngine.Rect val_19 = val_53.rect;
        val_54 = 0;
        val_53 = this.<rectTransform>k__BackingField;
        if(val_53 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector2 val_21 = val_53.pivot;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
        if(movePosition <= 5)
        {
                var val_55 = 20145240 + (movePosition) << 2;
            float val_54 = 0.5f;
            val_53 = (val_53 * val_54) + (val_15.m_XMin.width * val_17.x);
            val_54 = val_56 * val_54;
            val_55 = val_55 + 20145240;
            val_56 = val_54 + (val_19.m_XMin.height * val_21.y);
        }
        else
        {
                val_76 = val_6.y;
            val_65 = val_6.x;
            val_66 = val_6.z;
            UnityEngine.Debug.LogWarning(message:  "[UIAnimaion] This should not happen! DoMoveIn in UIAnimator went to the default setting!");
            UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {});
            return new UnityEngine.Vector2() {x = val_47.x, y = val_47.y};
        }
    
    }
    public UnityEngine.RectTransform get_GetRectTransform()
    {
        UnityEngine.RectTransform val_3;
        if((this.<rectTransform>k__BackingField) == 0)
        {
                this.<rectTransform>k__BackingField = this.GetComponent<UnityEngine.RectTransform>();
            return val_3;
        }
        
        val_3 = this.<rectTransform>k__BackingField;
        return val_3;
    }
    public static void DoShakeScreen(UnityEngine.Transform tran, float timeAnimation, float strength, float timeDelay = 0.01, DG.Tweening.TweenCallback onDone)
    {
        if(onDone != null)
        {
                return;
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOShakePosition(target:  tran, duration:  timeAnimation, strength:  strength, vibrato:  10, randomness:  90f, snapping:  false, fadeOut:  true), delay:  timeDelay), action:  0);
    }
    public static void DoScale(UnityEngine.Transform tran, float scaleTo = 1.05, float timeAnimation = 0.25, float delayTime = 0.01, bool autoRevese = True)
    {
        .tran = tran;
        .timeAnimation = timeAnimation;
        if(tran == 0)
        {
                UnityEngine.Debug.LogError(message:  "[UIAnimation] DoScale: "("[UIAnimation] DoScale: ") + (UIAnimation.<>c__DisplayClass67_0)[1152921513344818688].tran.name((UIAnimation.<>c__DisplayClass67_0)[1152921513344818688].tran.name) + " NULL");
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  (UIAnimation.<>c__DisplayClass67_0)[1152921513344818688].tran, complete:  false);
        float val_12 = 0.35f;
        val_12 = ((UIAnimation.<>c__DisplayClass67_0)[1152921513344818688].timeAnimation) * val_12;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  (UIAnimation.<>c__DisplayClass67_0)[1152921513344818688].tran, endValue:  scaleTo, duration:  val_12);
        if(autoRevese != false)
        {
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_6, action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass67_0(), method:  System.Void UIAnimation.<>c__DisplayClass67_0::<DoScale>b__0())), ease:  8), delay:  delayTime);
            return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_6, ease:  8);
    }
    public static void DoMoveZ(UnityEngine.Transform tran, float from = 0, float to = -100, float timeAnimation = 0.25, float delayTime = 0.01, bool autoRevese = False, DG.Tweening.TweenCallback onDone)
    {
        float val_19;
        UnityEngine.Transform val_20;
        object val_21;
        val_19 = timeAnimation;
        val_20 = tran;
        UIAnimation.<>c__DisplayClass68_0 val_1 = null;
        val_21 = val_1;
        val_1 = new UIAnimation.<>c__DisplayClass68_0();
        .onDone = onDone;
        .tran = val_20;
        .from = from;
        .timeAnimation = val_19;
        if(val_20 == 0)
        {
                val_21 = "[UIAnimation] DoScale: "("[UIAnimation] DoScale: ") + (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.name((UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.name) + " NULL";
            UnityEngine.Debug.LogError(message:  val_21);
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran, complete:  false);
        UnityEngine.Vector3 val_6 = (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.localPosition;
        UnityEngine.Vector3 val_7 = (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.localPosition;
        val_19 = val_7.x;
        if(autoRevese != false)
        {
                UnityEngine.Vector3 val_8 = (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.localPosition;
            val_6.x.Set(newX:  val_19, newY:  val_8.y, newZ:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].from);
            float val_19 = 0.7f;
            val_19 = ((UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].timeAnimation) * val_19;
            DG.Tweening.TweenCallback val_10 = null;
            val_20 = val_10;
            val_10 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIAnimation.<>c__DisplayClass68_0::<DoMoveZ>b__0());
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveZ(target:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran, endValue:  to, duration:  val_19, snapping:  false), action:  val_10), ease:  8), delay:  delayTime);
            return;
        }
        
        UnityEngine.Vector3 val_14 = (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran.localPosition;
        val_6.x.Set(newX:  val_19, newY:  val_14.y, newZ:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].from);
        if(((UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].onDone) == null)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveZ(target:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].tran, endValue:  to, duration:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].timeAnimation, snapping:  false), ease:  9), delay:  delayTime), action:  (UIAnimation.<>c__DisplayClass68_0)[1152921513345075072].onDone);
    }
    public static void DoRotateZ(UnityEngine.Transform tran, float to = 90, float timeAnimation = 0.25, float delayTime = 0.01, DG.Tweening.TweenCallback onDone)
    {
        .onDone = onDone;
        if(tran == 0)
        {
                UnityEngine.Debug.LogError(message:  "[UIAnimation] DoRotateZ: "("[UIAnimation] DoRotateZ: ") + tran.name + " NULL");
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  tran, complete:  false);
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  to);
        float val_12 = 0.7f;
        val_12 = timeAnimation * val_12;
        DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  tran, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_12, mode:  0), action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass69_0(), method:  System.Void UIAnimation.<>c__DisplayClass69_0::<DoRotateZ>b__0())), ease:  10), delay:  delayTime);
    }
    public static void DoAlpha(UnityEngine.UI.Image img, float from = 1, float to = 0, float timeAnimation = 0.25, float delayTime = 0.01, bool autoRevese = False, DG.Tweening.TweenCallback onDone)
    {
        .onDone = onDone;
        .img = img;
        .from = from;
        .timeAnimation = timeAnimation;
        if(img == 0)
        {
                UnityEngine.Debug.LogError(message:  "[UIAnimation] DoScale: "("[UIAnimation] DoScale: ") + (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img.name((UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img.name) + " NULL");
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img, complete:  false);
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_6 = DG.Tweening.DOTweenModuleUI.DOFade(target:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img, endValue:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].from, duration:  0f);
        if(autoRevese != false)
        {
                float val_15 = 0.7f;
            val_15 = ((UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].timeAnimation) * val_15;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img, endValue:  to, duration:  val_15), action:  new DG.Tweening.TweenCallback(object:  new UIAnimation.<>c__DisplayClass70_0(), method:  System.Void UIAnimation.<>c__DisplayClass70_0::<DoAlpha>b__0())), ease:  8), delay:  delayTime);
            return;
        }
        
        if(((UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].onDone) == null)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].img, endValue:  to, duration:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].timeAnimation), ease:  9), action:  (UIAnimation.<>c__DisplayClass70_0)[1152921513345560320].onDone);
    }
    public static void DoNumber(UnityEngine.UI.Text text, int startValue, int endValue, string fomat, DG.Tweening.TweenCallback onDone)
    {
        UIAnimation.DoNumber(text:  text, startValue:  startValue, endValue:  endValue, fomat:  fomat, timeAnimationScale:  0.01f, soundCount:  onDone, soundCompleted:  null, onDone:  onDone);
    }
    public static void DoNumber(UnityEngine.UI.Text text, int startValue, int endValue, string fomat, float timeAnimationScale = 0.01, string soundCount = "", string soundCompleted = "", DG.Tweening.TweenCallback onDone)
    {
        UIAnimation.<>c__DisplayClass72_0 val_1 = new UIAnimation.<>c__DisplayClass72_0();
        .nextValue = startValue;
        mem[1152921513345951256] = text;
        mem[1152921513345951264] = fomat;
        mem[1152921513345951272] = endValue;
        mem[1152921513345951280] = onDone;
        mem[1152921513345951248] = startValue;
        string val_2 = .nextValue.ToString();
        timeAnimationScale = ((float)(UIAnimation.<>c__DisplayClass72_0)[1152921513345951232].endValue) * timeAnimationScale;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.DOVirtual.Float(from:  (float)startValue, to:  (float)(UIAnimation.<>c__DisplayClass72_0)[1152921513345951232].endValue, duration:  UnityEngine.Mathf.Clamp(value:  timeAnimationScale, min:  0.25f, max:  1.5f), onVirtualUpdate:  new DG.Tweening.TweenCallback<System.Single>(object:  val_1, method:  System.Void UIAnimation.<>c__DisplayClass72_0::<DoNumber>b__0(float e))), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIAnimation.<>c__DisplayClass72_0::<DoNumber>b__1()));
    }
    public UIAnimation()
    {
        this.hideAtStart = true;
        this.hideAtEnd = true;
        this.animationIn = 3;
        this.timeAnimationIn = 0.25f;
        this.m_StartEvent = new UIAnimation.AnimEvent();
        this.m_ShowCompletedEvent = new UIAnimation.AnimEvent();
        this.animationOut = 4;
        this.timeAnimationOut = 0.175f;
        this.m_HideCompletedEvent = new UIAnimation.AnimEvent();
    }
    private bool <ShowAsync>b__52_0(UIAnimation x)
    {
        if(x != null)
        {
                if(x.navigation != this.navigation)
        {
                return false;
        }
        
            return (bool)(x.status == 1) ? 1 : 0;
        }
        
        throw new NullReferenceException();
    }
    private bool <ShowAsync>b__52_1(UIAnimation x)
    {
        if(x != null)
        {
                if(x.navigation != this.navigation)
        {
                return false;
        }
        
            return (bool)(x.status == 1) ? 1 : 0;
        }
        
        throw new NullReferenceException();
    }

}
