using UnityEngine;
public class UIIngame : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text txtCurrentLevel;
    private UnityEngine.UI.Text txtQuestion;
    private UnityEngine.UI.Button btnNext;
    private UnityEngine.UI.Button btnHintNotBrain;
    private UnityEngine.UI.Button btnSetting;
    private UnityEngine.UI.Button btnNoAds;
    private UnityEngine.UI.Button btnHint;
    private UnityEngine.UI.Button btnAddBrain;
    private UnityEngine.UI.Text txtBrainPoint;
    private UnityEngine.GameObject braintGroup;
    private UnityEngine.GameObject hand;
    private DG.Tweening.Sequence finishMove;
    private string interAdPosition;
    private string currentText;
    private bool isFinish;
    private bool isHintRemain;
    private int brainPointAds;
    private int brainPointHint;
    private UserData userData;
    private float interval;
    private float currentTime;
    private DG.Tweening.Tween nextShow;
    
    // Methods
    private void Start()
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        this.interAdPosition = "level_" + val_2.level;
        this.btnNext.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_0()));
        this.btnHint.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_1()));
        this.btnAddBrain.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_2()));
        this.btnHintNotBrain.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_3()));
        this.btnSetting.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_4()));
        this.btnNoAds.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIIngame::<Start>b__19_5()));
        this.Reset();
        Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void UIIngame::<Start>b__19_6()));
    }
    private void Awake()
    {
        null = null;
        System.Delegate val_2 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void UIIngame::DataManager_OnLoaded()));
        if(val_2 != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        DataManager.OnDataLoaded = val_2;
        return;
        label_4:
    }
    private void DataManager_OnLoaded()
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        this.brainPointAds = val_1.gameConfig.brainPointAds;
        DataManager val_2 = LazySingleton<DataManager>.Instance;
        this.brainPointHint = val_2.gameConfig.brainPointHint;
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        this.userData = val_3.<gameData>k__BackingField.user;
        string val_4 = val_3.<gameData>k__BackingField.user._brainPoint.ToString();
        this.HandleBtnHintInteractable();
        DataManager val_5 = LazySingleton<DataManager>.Instance;
        if(val_5.gameConfig.isUseBrainPoint != false)
        {
                if(this.btnHintNotBrain.gameObject != null)
        {
            goto label_13;
        }
        
        }
        
        this.btnHint.gameObject.SetActive(value:  false);
        this.btnAddBrain.gameObject.SetActive(value:  false);
        label_13:
        this.braintGroup.SetActive(value:  false);
    }
    private void Reset()
    {
        this.isFinish = true;
        this.isHintRemain = true;
        this.hand.SetActive(value:  false);
        if(this.finishMove != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.finishMove, complete:  false);
        }
        
        this.btnNext.gameObject.SetActive(value:  false);
        if(this.userData == null)
        {
                return;
        }
        
        this.HandleBtnHintInteractable();
    }
    private void OnEnable()
    {
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  10, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::InitLevelHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  12, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::FinishLevelHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  19, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::LevelContentHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  70, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::AddBrainPointHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  2, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::OnWaitWinHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  18, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::ShowTutorialHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  120, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::SuggestTouchHintHandler(object obj)), eventType:  1);
    }
    private void OnDisable()
    {
        System.Action<System.Object> val_15;
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                System.Action<System.Object> val_2 = null;
            val_15 = val_2;
            val_2 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::InitLevelHandler(object obj));
            val_1.RemoveListener(eventID:  10, callback:  val_2);
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 != null)
        {
                System.Action<System.Object> val_4 = null;
            val_15 = val_4;
            val_4 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::FinishLevelHandler(object obj));
            val_3.RemoveListener(eventID:  12, callback:  val_4);
        }
        
        EventDispatcher val_5 = LazySingleton<EventDispatcher>.Instance;
        if(val_5 != null)
        {
                System.Action<System.Object> val_6 = null;
            val_15 = val_6;
            val_6 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::LevelContentHandler(object obj));
            val_5.RemoveListener(eventID:  19, callback:  val_6);
        }
        
        EventDispatcher val_7 = LazySingleton<EventDispatcher>.Instance;
        if(val_7 != null)
        {
                System.Action<System.Object> val_8 = null;
            val_15 = val_8;
            val_8 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::AddBrainPointHandler(object obj));
            val_7.RemoveListener(eventID:  70, callback:  val_8);
        }
        
        EventDispatcher val_9 = LazySingleton<EventDispatcher>.Instance;
        if(val_9 != null)
        {
                System.Action<System.Object> val_10 = null;
            val_15 = val_10;
            val_10 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::OnWaitWinHandler(object obj));
            val_9.RemoveListener(eventID:  2, callback:  val_10);
        }
        
        EventDispatcher val_11 = LazySingleton<EventDispatcher>.Instance;
        if(val_11 != null)
        {
                System.Action<System.Object> val_12 = null;
            val_15 = val_12;
            val_12 = new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::ShowTutorialHandler(object obj));
            val_11.RemoveListener(eventID:  18, callback:  val_12);
        }
        
        EventDispatcher val_13 = LazySingleton<EventDispatcher>.Instance;
        if(val_13 == null)
        {
                return;
        }
        
        val_13.RemoveListener(eventID:  120, callback:  new System.Action<System.Object>(object:  this, method:  System.Void UIIngame::SuggestTouchHintHandler(object obj)));
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.currentTime + val_1;
        this.currentTime = val_1;
        if(val_1 < this.interval)
        {
                return;
        }
        
        val_1 = val_1 - this.interval;
        this.currentTime = val_1;
        this.HandleBtnAdsInteractable();
    }
    private void InitLevelHandler(object obj)
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        this.interAdPosition = "level_" + val_2.level;
        this.Reset();
        StageData val_5 = LazySingleton<DataManager>.Instance.CurrentStage;
        string val_6 = "LEVEL " + val_5.level;
        if(this.userData != null)
        {
                string val_7 = this.userData._brainPoint.ToString();
        }
        
        if(this.nextShow == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.nextShow, complete:  false);
    }
    private void FinishLevelHandler(object obj)
    {
        this.isFinish = true;
        this.HandleBtnHintInteractable();
        this.ShowInterFinish();
        NotificationManager.SetupLocalPush();
    }
    private void LevelContentHandler(object obj)
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        string val_3 = "Text_" + 0;
        this.currentText = val_3;
        string val_4 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  val_3);
        this.txtQuestion.gameObject.SetActive(value:  true);
    }
    private void HandleHint()
    {
        UnityEngine.MonoBehaviour val_5;
        var val_6;
        val_5 = this;
        int val_5 = this.userData._brainPoint;
        val_5 = val_5 - this.brainPointHint;
        if()
        {
                return;
        }
        
        this.userData._brainPoint = val_5;
        LazySingleton<DataManager>.Instance.Save();
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  70);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  13);
        this.isHintRemain = false;
        this.HandleBtnHintInteractable();
        StageData val_3 = LazySingleton<DataManager>.Instance.CurrentStage;
        val_6 = null;
        val_6 = null;
        val_5 = FirebaseManager.<Instance>k__BackingField;
        string val_4 = val_3.level.ToString();
        val_5.LogEvent(eventType:  0);
    }
    private void ShowHintWithAds()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  13);
        this.hand.SetActive(value:  false);
        if(this.finishMove == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.finishMove, complete:  false);
    }
    private void HandleHintWithAds()
    {
        UIIngame.<>c__DisplayClass34_0 val_1 = new UIIngame.<>c__DisplayClass34_0();
        .<>4__this = this;
        StageData val_3 = LazySingleton<DataManager>.Instance.CurrentStage;
        .RewardAdPosition = "hint_" + val_3.level;
        if(this.isFinish != false)
        {
                return;
        }
        
        if(this.isHintRemain == false)
        {
            goto label_5;
        }
        
        if(AdsManager.VideoRewaredIsReady == false)
        {
            goto label_8;
        }
        
        StageData val_8 = LazySingleton<DataManager>.Instance.CurrentStage;
        AdsManager.ShowVideoReward(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass34_0::<HandleHintWithAds>b__0(AdEvent status)), placementName:  (UIIngame.<>c__DisplayClass34_0)[1152921513490281408].RewardAdPosition, itemId:  val_8.level.ToString());
        return;
        label_5:
        this.ShowHintWithAds();
        return;
        label_8:
        if(AdsManager.InterstitialIsReady == false)
        {
                return;
        }
        
        StageData val_13 = LazySingleton<DataManager>.Instance.CurrentStage;
        AdsManager.ShowInterstitial(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass34_0::<HandleHintWithAds>b__1(AdEvent status)), placementName:  (UIIngame.<>c__DisplayClass34_0)[1152921513490281408].RewardAdPosition, itemId:  val_13.level.ToString(), userWanted:  true);
    }
    private void HandleBtnHintInteractable()
    {
        if(this.isFinish == false)
        {
            goto label_0;
        }
        
        label_4:
        label_6:
        this.btnHint.interactable = false;
        return;
        label_0:
        if((this.isHintRemain == false) || (this.userData._brainPoint < this.brainPointHint))
        {
            goto label_4;
        }
        
        goto label_6;
    }
    private void ShowInterFinish()
    {
        StageData val_3 = LazySingleton<DataManager>.Instance.CurrentStage;
        AdsManager.ShowInterstitial(onSuccess:  new System.Action<AdEvent>(object:  this, method:  System.Void UIIngame::<ShowInterFinish>b__36_0(AdEvent status)), placementName:  this.interAdPosition, itemId:  val_3.level.ToString(), userWanted:  false);
    }
    private void HandleBtnAdsInteractable()
    {
        var val_3;
        if(this.isFinish != false)
        {
                label_9:
            val_3 = 0;
        }
        else
        {
                if(AdsManager.VideoRewaredIsReady != true)
        {
                if(AdsManager.InterstitialIsReady == false)
        {
            goto label_9;
        }
        
        }
        
            val_3 = 1;
        }
        
        this.btnAddBrain.interactable = true;
    }
    private void HandleShowAdsAddBrainPoint()
    {
        UIIngame.<>c__DisplayClass38_0 val_1 = new UIIngame.<>c__DisplayClass38_0();
        .<>4__this = this;
        .RewardAdPosition = "add_brain_point";
        if(AdsManager.VideoRewaredIsReady != false)
        {
                StageData val_5 = LazySingleton<DataManager>.Instance.CurrentStage;
            AdsManager.ShowVideoReward(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass38_0::<HandleShowAdsAddBrainPoint>b__0(AdEvent status)), placementName:  (UIIngame.<>c__DisplayClass38_0)[1152921513490921008].RewardAdPosition, itemId:  val_5.level.ToString());
            return;
        }
        
        if(AdsManager.InterstitialIsReady == false)
        {
                return;
        }
        
        StageData val_10 = LazySingleton<DataManager>.Instance.CurrentStage;
        AdsManager.ShowInterstitial(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass38_0::<HandleShowAdsAddBrainPoint>b__1(AdEvent status)), placementName:  (UIIngame.<>c__DisplayClass38_0)[1152921513490921008].RewardAdPosition, itemId:  val_10.level.ToString(), userWanted:  true);
    }
    private void AddBrainPoint()
    {
        int val_2 = this.userData._brainPoint;
        val_2 = this.brainPointAds + val_2;
        this.userData._brainPoint = val_2;
        LazySingleton<DataManager>.Instance.Save();
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  70);
    }
    private void AddBrainPointHandler(object obj)
    {
        string val_1 = this.userData._brainPoint.ToString();
        this.HandleBtnHintInteractable();
    }
    private void OnWaitWinHandler(object obj)
    {
        this.hand.SetActive(value:  false);
        if(this.finishMove != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.finishMove, complete:  false);
        }
        
        this.isFinish = true;
    }
    private void ShowTutorialHandler(object obj)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_39;
        UnityEngine.Vector2 val_40;
        float val_41;
        float val_46;
        float val_47;
        float val_48;
        System.Collections.Generic.List<UnityEngine.Vector2> val_49;
        var val_50;
        val_39 = obj;
        .<>4__this = this;
        if(this.isFinish == true)
        {
                return;
        }
        
        .listPosition = val_39;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.3f, y:  -0.35f);
        .offset = val_2.x;
        if(val_2.x == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_40 = (UIIngame.<>c__DisplayClass42_0)[1152921513491665968].offset;
        val_41 = mem[val_2.x + 32 + 4];
        val_41 = val_2.x + 32 + 4;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x + 32, y = val_41}, b:  new UnityEngine.Vector2() {x = val_40, y = V8.16B});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.hand.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        val_39 = this.hand.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_8 = DG.Tweening.DOTweenModuleUI.DOColor(target:  val_39, endValue:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a}, duration:  0f);
        this.hand.gameObject.SetActive(value:  true);
        if(this.finishMove != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.finishMove, complete:  false);
        }
        
        val_46 = 1f;
        this.finishMove = DG.Tweening.DOTween.Sequence();
        UnityEngine.Color val_11;
        val_47 = 0f;
        val_48 = val_46;
        val_11 = new UnityEngine.Color(r:  val_46, g:  val_48, b:  val_46, a:  val_47);
        val_49 = (UIIngame.<>c__DisplayClass42_0)[1152921513491665968].listPosition;
        val_50 = 1;
        label_41:
        if(val_50 >= 20086784)
        {
            goto label_24;
        }
        
        if(val_50 != 20086783)
        {
            goto label_20;
        }
        
        if(val_50 >= 20086784)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_41 = 2.302333E-42f;
        val_40 = 2.225262E-42f;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
        val_47 = val_12.y;
        val_46 = val_41;
        val_48 = val_40;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = val_41, y = val_40}, rhs:  new UnityEngine.Vector2() {x = val_12.x, y = val_47})) == true)
        {
            goto label_24;
        }
        
        val_49 = (UIIngame.<>c__DisplayClass42_0)[1152921513491665968].listPosition;
        label_20:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32, y = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32 + 4}, rhs:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y})) != false)
        {
                DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_39, endValue:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, duration:  0f));
            val_50 = val_50 + 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_19 = val_50 << 32;
            val_41 = (UIIngame.<>c__DisplayClass42_0)[1152921513491665968].offset;
            val_48 = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + ((ulong)((val_50 + 1) << 32)) >> 29) + 32 + 4;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + ((ulong)((val_50 + 1) << 32)) >> 29) + 32, y = val_48}, b:  new UnityEngine.Vector2() {x = val_41, y = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32 + 4});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            val_47 = 0f;
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.hand.transform, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  val_47, snapping:  false));
        }
        else
        {
                UnityEngine.Color val_24 = UnityEngine.Color.white;
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_39, endValue:  new UnityEngine.Color() {r = val_24.r, g = val_24.g, b = val_24.b, a = val_24.a}, duration:  0f));
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_41 = (UIIngame.<>c__DisplayClass42_0)[1152921513491665968].offset;
            val_48 = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32 + 4;
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32, y = val_48}, b:  new UnityEngine.Vector2() {x = val_41, y = (UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 8) + 32 + 4});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
            val_47 = 0.8f;
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.hand.transform, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.8f, snapping:  false));
            val_50 = val_50 + 1;
        }
        
        if(((UIIngame.<>c__DisplayClass42_0)[1152921513491665968].listPosition) != null)
        {
            goto label_41;
        }
        
        throw new NullReferenceException();
        label_24:
        DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_39, endValue:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a}, duration:  0.8f), action:  new DG.Tweening.TweenCallback(object:  new UIIngame.<>c__DisplayClass42_0(), method:  System.Void UIIngame.<>c__DisplayClass42_0::<ShowTutorialHandler>b__0())));
        UnityEngine.Color val_36 = UnityEngine.Color.white;
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_39, endValue:  new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.a}, duration:  0.2f));
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.finishMove, loops:  0);
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  13, param:  null);
        this.isHintRemain = false;
    }
    private void SuggestTouchHintHandler(object obj)
    {
        UIIngame val_36 = this;
        UIIngame.<>c__DisplayClass43_0 val_1 = new UIIngame.<>c__DisplayClass43_0();
        .<>4__this = val_36;
        if(this.isHintRemain == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.3f, y:  -0.3f);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.06f, y:  -0.06f);
        .diff = val_3.x;
        UnityEngine.Vector3 val_5 = this.btnHintNotBrain.transform.position;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        .btnHintPos = val_7;
        mem[1152921513492091340] = val_7.y;
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].btnHintPos, y = val_7.y}, b:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].diff, y = val_2.y});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        this.hand.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        UnityEngine.UI.Image val_11 = this.hand.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_13 = DG.Tweening.DOTweenModuleUI.DOColor(target:  val_11, endValue:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a}, duration:  0f);
        this.hand.SetActive(value:  true);
        if(this.finishMove != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.finishMove, complete:  false);
        }
        
        this.finishMove = DG.Tweening.DOTween.Sequence();
        UnityEngine.Color val_15 = new UnityEngine.Color(r:  1f, g:  1f, b:  1f, a:  0f);
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].btnHintPos, y = val_5.y}, b:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].diff, y = val_5.x});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.hand.transform, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  1f, snapping:  false));
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].btnHintPos, y = val_18.y}, b:  new UnityEngine.Vector2() {x = (UIIngame.<>c__DisplayClass43_0)[1152921513492091312].diff, y = 1f});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.hand.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  1f, snapping:  false));
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_11, endValue:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a}, duration:  0.8f), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass43_0::<SuggestTouchHintHandler>b__0())));
        UnityEngine.Color val_30 = UnityEngine.Color.white;
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.finishMove, t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  val_11, endValue:  new UnityEngine.Color() {r = val_30.r, g = val_30.g, b = val_30.b, a = val_30.a}, duration:  0.2f));
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.finishMove, loops:  0);
        DG.Tweening.TweenCallback val_34 = null;
        val_36 = val_34;
        val_34 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UIIngame.<>c__DisplayClass43_0::<SuggestTouchHintHandler>b__1());
        DG.Tweening.Tween val_35 = DG.Tweening.DOVirtual.DelayedCall(delay:  5f, callback:  val_34, ignoreTimeScale:  true);
    }
    public UIIngame()
    {
        this.interval = 1f;
        this.interAdPosition = "";
        this.currentText = "";
    }
    private void <Start>b__19_0()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  10);
        this.Reset();
    }
    private void <Start>b__19_1()
    {
        SoundManager.Play(fileName:  "Button");
        this.HandleHint();
    }
    private void <Start>b__19_2()
    {
        SoundManager.Play(fileName:  "Button");
        this.HandleShowAdsAddBrainPoint();
    }
    private void <Start>b__19_3()
    {
        SoundManager.Play(fileName:  "Button");
        this.HandleHintWithAds();
    }
    private void <Start>b__19_4()
    {
        SoundManager.Play(fileName:  "Button");
        if(this.isFinish != false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  "Pencil");
        if(val_1 != null)
        {
                val_1.SetActive(value:  false);
        }
        
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  16);
    }
    private void <Start>b__19_5()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = UIIngame.<>c.<>9__19_8;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  UIIngame.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UIIngame.<>c::<Start>b__19_8());
            UIIngame.<>c.<>9__19_8 = val_5;
        }
        
        PurchaseManager.<Instance>k__BackingField.BuyNonConsumable(callBackSuccess:  new System.Action(object:  this, method:  System.Void UIIngame::<Start>b__19_7()), callBackFail:  val_2);
    }
    private void <Start>b__19_7()
    {
        AdsManager.UpdateBannerArea();
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        val_1.<gameData>k__BackingField.user.isRemovedAds = true;
        LazySingleton<DataManager>.Instance.Save();
        this.btnNoAds.gameObject.SetActive(value:  false);
    }
    private void <Start>b__19_6()
    {
        string val_1 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.currentText);
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }
    private void <ShowInterFinish>b__36_0(AdEvent status)
    {
        FirebaseManager val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = this;
        val_2 = null;
        val_2 = null;
        AdsManager.isAdShowing = false;
        if(status != 1)
        {
                if(status != 3)
        {
                return;
        }
        
            val_3 = null;
            val_3 = null;
            val_1 = FirebaseManager.<Instance>k__BackingField;
            val_1.LogEvent(eventType:  4.24399158193054E-314);
            AppsflyerHelper.Log(id:  1);
            return;
        }
        
        val_4 = null;
        val_4 = null;
        val_1 = FirebaseManager.<Instance>k__BackingField;
        val_1.LogEvent(eventType:  2.12199579096527E-314);
    }

}
