using UnityEngine;
public class UIDailyReward : UICore
{
    // Fields
    private UnityEngine.GameObject bg;
    private UnityEngine.CanvasGroup panel;
    private UnityEngine.Sprite[] lstSprBgReward;
    private UnityEngine.UI.Button[] lstButtonDayReward;
    private UnityEngine.GameObject[] lstTickDayReward;
    private UnityEngine.GameObject[] lstAmountReward;
    private UnityEngine.GameObject receiveRewardBtn;
    private UnityEngine.GameObject receiveRewardByAdsBtn;
    private UnityEngine.UI.Text totalBrainTxt;
    private UserData userData;
    
    // Methods
    protected override void Awake()
    {
        var val_3;
        this.Awake();
        val_3 = null;
        val_3 = null;
        System.Delegate val_2 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void UIDailyReward::SetupDataDailyReward()));
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
    public override void Show(DG.Tweening.TweenCallback onDone)
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  60);
    }
    public override void Hide()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  61);
        goto typeof(UIDailyReward).__il2cppRuntimeField_190;
    }
    public void ShowHideDailyReward()
    {
        this.panel.gameObject.SetActive(value:  (~this.panel.gameObject.activeSelf) & 1);
    }
    private void OnEnable()
    {
        if(this.userData == null)
        {
                return;
        }
        
        this.IeCheckShowReward();
        this.SetupStateDailyReward();
    }
    private void SetupDataDailyReward()
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        this.userData = val_1.<gameData>k__BackingField.user;
        this.UpdateIndexReward();
    }
    private void UpdateIndexReward()
    {
        UserData val_6;
        if(this.userData._isLockCheckIndex == true)
        {
                return;
        }
        
        System.DateTime val_2 = UnbiasedTime.Instance.Now();
        System.DateTime val_3 = val_2.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_2.dateData});
        if((this.userData._dayReceiveDailyReward.Equals(value:  val_3.dateData.ToString(format:  "MM/dd/yyyy"))) == true)
        {
                return;
        }
        
        val_6 = this.userData;
        int val_6 = this.userData._currentIndexReward;
        if(val_6 <= 5)
        {
                val_6 = val_6 + 1;
            this.userData._currentIndexReward = val_6;
            val_6 = this.userData;
        }
        
        this.userData._isReceivedDailyReward = false;
        this.userData._isLockCheckIndex = true;
    }
    private void SetupStateDailyReward()
    {
        var val_16;
        UnityEngine.Sprite val_17;
        string val_1 = +this.userData._brainPoint;
        var val_26 = 0;
        label_46:
        if(val_26 > this.userData._currentIndexReward)
        {
            goto label_4;
        }
        
        if(val_26 != this.userData._currentIndexReward)
        {
            goto label_5;
        }
        
        val_16 = 0;
        if(this.userData._isReceivedDailyReward == true)
        {
            goto label_9;
        }
        
        this.lstTickDayReward[val_16].SetActive(value:  false);
        this.lstButtonDayReward[val_16].interactable = true;
        UnityEngine.Color32 val_3 = new UnityEngine.Color32(r:  255, g:  255, b:  255, a:  255);
        UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_3.r, g = val_3.r, b = val_3.r, a = val_3.r});
        this.lstButtonDayReward[val_16].GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        this.lstAmountReward[val_16].SetActive(value:  true);
        UnityEngine.UI.Image val_5 = this.lstButtonDayReward[val_16].GetComponent<UnityEngine.UI.Image>();
        val_17 = this.lstSprBgReward[0];
        goto label_26;
        label_5:
        val_16 = 0;
        label_9:
        this.lstTickDayReward[val_16].SetActive(value:  true);
        this.lstButtonDayReward[val_16].interactable = false;
        UnityEngine.Color32 val_7 = new UnityEngine.Color32(r:  180, g:  180, b:  180, a:  255);
        UnityEngine.Color val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_7.r, g = val_7.r, b = val_7.r, a = val_7.r});
        this.lstButtonDayReward[val_16].GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        this.lstAmountReward[val_16].SetActive(value:  false);
        val_17 = this.lstSprBgReward[1];
        label_26:
        this.lstButtonDayReward[val_16].GetComponent<UnityEngine.UI.Image>().sprite = val_17;
        val_26 = val_26 + 1;
        if(this.userData != null)
        {
            goto label_46;
        }
        
        label_4:
        if(this.userData._isReceivedDailyReward != false)
        {
                this.receiveRewardBtn.SetActive(value:  false);
            this.receiveRewardByAdsBtn.SetActive(value:  false);
        }
        else
        {
                UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.IeCheckStateButtonReward());
        }
        
        var val_29 = 0;
        do
        {
            if(val_29 >= this.lstAmountReward.Length)
        {
                return;
        }
        
            UnityEngine.UI.Text val_12 = this.lstAmountReward[val_29].GetComponent<UnityEngine.UI.Text>();
            DataManager val_13 = LazySingleton<DataManager>.Instance;
            string val_14 = "+"("+") + val_13.dailyRewardData.lstRewardBrainPoint[val_29];
            var val_15 = (val_14 == null) ? "" : (val_14);
            val_29 = val_29 + 1;
        }
        while(this.lstAmountReward != null);
        
        throw new NullReferenceException();
    }
    private System.Collections.IEnumerator IeCheckStateButtonReward()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new UIDailyReward.<IeCheckStateButtonReward>d__18();
    }
    private void IeCheckShowReward()
    {
        if(this.IsAutoShowDailyReward() == false)
        {
                return;
        }
        
        this.bg.SetActive(value:  true);
        this.panel.gameObject.SetActive(value:  true);
    }
    public bool IsAutoShowDailyReward()
    {
        var val_7;
        System.DateTime val_2 = UnbiasedTime.Instance.Now();
        System.DateTime val_3 = val_2.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_2.dateData});
        string val_4 = val_3.dateData.ToString(format:  "MM/dd/yyyy");
        if((this.userData._dayReceiveDailyReward.Equals(value:  val_4)) != true)
        {
                if((this.userData._dayOpenApp.Equals(value:  val_4)) == false)
        {
            goto label_7;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
        label_7:
        val_7 = 1;
        this.userData._dayOpenApp = val_4;
        return (bool)val_7;
    }
    public void ReceiveBrainPoint(int typeReceive)
    {
        object val_7 = this;
        SoundManager.Play(fileName:  "Button");
        if(typeReceive < 2)
        {
                this.AddBrainPoint(isReceiveByAds:  false);
            return;
        }
        
        if(typeReceive != 2)
        {
                return;
        }
        
        if(AdsManager.VideoRewaredIsReady != false)
        {
                val_7 = this.userData._currentIndexReward.ToString();
            AdsManager.ShowVideoReward(onSuccess:  new System.Action<AdEvent>(object:  this, method:  System.Void UIDailyReward::<ReceiveBrainPoint>b__21_0(AdEvent status)), placementName:  "daily_reward", itemId:  val_7);
            return;
        }
        
        if(AdsManager.InterstitialIsReady == false)
        {
                return;
        }
        
        val_7 = this.userData._currentIndexReward.ToString();
        AdsManager.ShowInterstitial(onSuccess:  new System.Action<AdEvent>(object:  this, method:  System.Void UIDailyReward::<ReceiveBrainPoint>b__21_1(AdEvent status)), placementName:  "daily_reward", itemId:  val_7, userWanted:  false);
    }
    private void AddBrainPoint(bool isReceiveByAds = False)
    {
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        int val_9 = val_1.dailyRewardData.lstRewardBrainPoint[this.userData._currentIndexReward];
        val_9 = this.userData._brainPoint + (val_9 * ((isReceiveByAds != true) ? (1 + 1) : 1));
        this.userData._brainPoint = val_9;
        string val_3 = +this.userData._brainPoint;
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  70);
        this.userData._isReceivedDailyReward = true;
        System.DateTime val_5 = UnbiasedTime.Instance.Now();
        System.DateTime val_6 = val_5.dateData.ReadTimestamp(key:  "unbiasedTimer", defaultValue:  new System.DateTime() {dateData = val_5.dateData});
        this.userData._dayReceiveDailyReward = val_6.dateData.ToString(format:  "MM/dd/yyyy");
        this.SetupDataDailyReward();
        this.SetupStateDailyReward();
        this.userData._isLockCheckIndex = false;
        this.receiveRewardBtn.SetActive(value:  false);
        this.receiveRewardByAdsBtn.SetActive(value:  false);
        LazySingleton<DataManager>.Instance.Save();
    }
    private System.DateTime ReadTimestamp(string key, System.DateTime defaultValue)
    {
        long val_2 = System.Convert.ToInt64(value:  UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  "0"));
        if(val_2 == 0)
        {
                return (System.DateTime)defaultValue.dateData;
        }
        
        return System.DateTime.FromBinary(dateData:  val_2);
    }
    private void WriteTimestamp(string key, System.DateTime time)
    {
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  time.dateData.ToBinary().ToString());
    }
    public UIDailyReward()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <ReceiveBrainPoint>b__21_0(AdEvent status)
    {
        FirebaseManager val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if((status - 7) < 2)
        {
            goto label_1;
        }
        
        if(status == 1)
        {
            goto label_2;
        }
        
        if(status != 3)
        {
                return;
        }
        
        this.AddBrainPoint(isReceiveByAds:  true);
        val_4 = null;
        val_4 = null;
        val_3 = FirebaseManager.<Instance>k__BackingField;
        val_3.LogEvent(eventType:  4.24399158193054E-314);
        AppsflyerHelper.Log(id:  0);
        return;
        label_1:
        if(Util.InternetConnection() == true)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  22, param:  null);
        return;
        label_2:
        val_5 = null;
        val_5 = null;
        val_3 = FirebaseManager.<Instance>k__BackingField;
        val_3.LogEvent(eventType:  2.12199579096527E-314);
    }
    private void <ReceiveBrainPoint>b__21_1(AdEvent status)
    {
        FirebaseManager val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if((status - 7) < 2)
        {
            goto label_1;
        }
        
        if(status == 1)
        {
            goto label_2;
        }
        
        if(status != 3)
        {
                return;
        }
        
        this.AddBrainPoint(isReceiveByAds:  true);
        val_4 = null;
        val_4 = null;
        val_3 = FirebaseManager.<Instance>k__BackingField;
        val_3.LogEvent(eventType:  4.24399158193054E-314);
        AppsflyerHelper.Log(id:  1);
        return;
        label_1:
        if(Util.InternetConnection() == true)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  22, param:  null);
        return;
        label_2:
        val_5 = null;
        val_5 = null;
        val_3 = FirebaseManager.<Instance>k__BackingField;
        val_3.LogEvent(eventType:  2.12199579096527E-314);
    }

}
