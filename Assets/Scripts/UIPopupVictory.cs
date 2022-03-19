using UnityEngine;
public class UIPopupVictory : UICore
{
    // Fields
    private UnityEngine.UI.Button btnNext;
    private UnityEngine.UI.Button btnAddBraindAds;
    private UnityEngine.UI.Text txtVictory;
    private string stringLanguage;
    private int brainPointAds;
    private int brainPointHint;
    private UserData userData;
    
    // Methods
    private void Start()
    {
        this.btnNext.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIPopupVictory::<Start>b__7_0()));
        this.btnAddBraindAds.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIPopupVictory::<Start>b__7_1()));
        Assets.SimpleLocalization.LocalizationManager.add_LocalizationChanged(value:  new System.Action(object:  this, method:  System.Void UIPopupVictory::<Start>b__7_2()));
    }
    public void Show(Level level)
    {
        this.Show(onDone:  0);
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        StageData val_2 = val_1.stagesAsset.StageStatus(index:  level.index);
        string val_3 = "Win_" + level.index;
        this.stringLanguage = val_3;
        string val_4 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  val_3);
        VibrateManager.Haptic();
        EffectManager.SpawnEfxWin();
        SoundManager.PlayBattle(fileName:  "Clap");
        DataManager val_5 = LazySingleton<DataManager>.Instance;
        this.brainPointAds = val_5.gameConfig.brainPointAds;
        DataManager val_6 = LazySingleton<DataManager>.Instance;
        this.brainPointHint = val_6.gameConfig.brainPointHint;
        DataManager val_7 = LazySingleton<DataManager>.Instance;
        this.userData = val_7.<gameData>k__BackingField.user;
        DataManager val_9 = LazySingleton<DataManager>.Instance;
        this.btnAddBraindAds.gameObject.SetActive(value:  val_9.gameConfig.isUseBrainPoint);
    }
    public override void Hide()
    {
        this.Hide();
        SoundManager.StopBattle();
    }
    private void HandleShowAdsAddBrainPoint()
    {
        UIPopupVictory.<>c__DisplayClass10_0 val_1 = new UIPopupVictory.<>c__DisplayClass10_0();
        .<>4__this = this;
        .RewardAdPosition = "add_brain_point";
        if(AdsManager.VideoRewaredIsReady != false)
        {
                StageData val_5 = LazySingleton<DataManager>.Instance.CurrentStage;
            AdsManager.ShowVideoReward(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIPopupVictory.<>c__DisplayClass10_0::<HandleShowAdsAddBrainPoint>b__0(AdEvent status)), placementName:  (UIPopupVictory.<>c__DisplayClass10_0)[1152921513502629712].RewardAdPosition, itemId:  val_5.level.ToString());
            return;
        }
        
        if(AdsManager.InterstitialIsReady == false)
        {
                return;
        }
        
        StageData val_10 = LazySingleton<DataManager>.Instance.CurrentStage;
        AdsManager.ShowInterstitial(onSuccess:  new System.Action<AdEvent>(object:  val_1, method:  System.Void UIPopupVictory.<>c__DisplayClass10_0::<HandleShowAdsAddBrainPoint>b__1(AdEvent status)), placementName:  (UIPopupVictory.<>c__DisplayClass10_0)[1152921513502629712].RewardAdPosition, itemId:  val_10.level.ToString(), userWanted:  true);
    }
    private void AddBrainPoint()
    {
        int val_2 = this.userData._brainPoint;
        val_2 = this.brainPointAds + val_2;
        this.userData._brainPoint = val_2;
        LazySingleton<DataManager>.Instance.Save();
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  70);
    }
    public UIPopupVictory()
    {
    
    }
    private void <Start>b__7_0()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  10);
        goto typeof(UIPopupVictory).__il2cppRuntimeField_190;
    }
    private void <Start>b__7_1()
    {
        SoundManager.Play(fileName:  "Button");
        this.HandleShowAdsAddBrainPoint();
    }
    private void <Start>b__7_2()
    {
        string val_1 = Assets.SimpleLocalization.LocalizationManager.Localize(localizationKey:  this.stringLanguage);
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
    }

}
