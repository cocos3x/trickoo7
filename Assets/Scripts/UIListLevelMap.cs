using UnityEngine;
public class UIListLevelMap : UICore
{
    // Fields
    private UnityEngine.Transform content;
    private UnityEngine.UI.ScrollRect sr;
    private UnityEngine.UI.Button btnDirection;
    private UnityEngine.UI.Button btnSetting;
    private UnityEngine.UI.Button btnDaily;
    private UnityEngine.GameObject mapPrefab;
    private UnityEngine.Transform direction;
    private UnityEngine.Transform top;
    private UnityEngine.Transform bot;
    private System.Collections.Generic.List<UILevelMap> uILevels;
    private System.Collections.Generic.List<UnityEngine.GameObject> listPath;
    private int numberOfPrefab;
    private bool dataLoaded;
    
    // Methods
    protected override void Awake()
    {
        var val_3;
        this.Awake();
        val_3 = null;
        val_3 = null;
        System.Delegate val_2 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void UIListLevelMap::DataManager_OnLoaded()));
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
    private void Start()
    {
        this.btnDirection.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIListLevelMap::<Start>b__14_0()));
        this.btnSetting.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIListLevelMap::<Start>b__14_1()));
        this.btnDaily.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIListLevelMap::<Start>b__14_2()));
    }
    private void DataManager_OnLoaded()
    {
        var val_12;
        var val_13;
        var val_42;
        var val_43;
        int val_44;
        var val_45;
        this.dataLoaded = true;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        if(val_1.gameConfig.isUseBrainPoint != true)
        {
                this.btnDaily.gameObject.SetActive(value:  false);
        }
        
        this.uILevels = new System.Collections.Generic.List<UILevelMap>();
        this.listPath = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(this.numberOfPrefab >= 1)
        {
                val_42 = 1152921513498047136;
            do
        {
            this.listPath.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.mapPrefab, parent:  this.content));
            val_43 = 0 + 1;
        }
        while(val_43 < this.numberOfPrefab);
        
        }
        
        DataManager val_6 = LazySingleton<DataManager>.Instance;
        int val_41 = this.numberOfPrefab;
        if(val_41 < 1)
        {
            goto label_51;
        }
        
        val_42 = 1152921504729477120;
        val_44 = 0;
        label_50:
        int val_7 = val_41 + 0;
        if(0 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_41 = val_41 + (val_7 << 3);
        List.Enumerator<T> val_11 = TransformExtend.GetChilds(transform:  (this.numberOfPrefab + ((this.numberOfPrefab + 0)) << 3) + 32.transform.GetChild(index:  0)).GetEnumerator();
        goto label_27;
        label_29:
        val_11.current.Add(item:  this.listPath);
        val_44 = 1;
        label_27:
        if(val_13.MoveNext() == false)
        {
            goto label_21;
        }
        
        if(val_12 == 0)
        {
                throw new NullReferenceException();
        }
        
        UILevelMap val_15 = val_12.GetComponent<UILevelMap>();
        var val_17 = (val_44 < (X9 + 24)) ? 1 : 0;
        val_17 = val_17 & (UnityEngine.Object.op_Implicit(exists:  val_15));
        if(val_17 == true)
        {
            goto label_25;
        }
        
        UnityEngine.GameObject val_18 = val_12.gameObject;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18.SetActive(value:  false);
        goto label_27;
        label_25:
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        val_15.index = val_44;
        val_15.UpdateStatus();
        if(this.uILevels != null)
        {
            goto label_29;
        }
        
        throw new NullReferenceException();
        label_21:
        val_13.Dispose();
        val_45 = 1;
        if(1 != 1)
        {
                val_45 = 1;
        }
        
        int val_42 = this.numberOfPrefab;
        val_42 = val_42 - 1;
        if(0 == val_42)
        {
                if(val_42 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_42 = val_42 + (((long)(int)((this.numberOfPrefab + 0))) << 3);
            if(val_42 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_42 = val_42 + (((long)(int)((this.numberOfPrefab + 0))) << 3);
            ((this.numberOfPrefab - 1) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + 32.transform.GetChild(index:  ((((this.numberOfPrefab - 1) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + 32.transform.childCount) - 1).gameObject.SetActive(value:  true);
        }
        
        if(val_42 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_42 = val_42 + (((long)(int)((this.numberOfPrefab + 0))) << 3);
        ((((this.numberOfPrefab - 1) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + ((long)(int)((this.numberOfPrefab + 0))) << 3) + 32.transform.GetChild(index:  1).GetChild(index:  UnityEngine.Random.Range(min:  0, max:  3)).gameObject.SetActive(value:  true);
        val_43 = 0 + 1;
        if(val_43 < this.numberOfPrefab)
        {
            goto label_50;
        }
        
        label_51:
        UnityEngine.RectTransform val_30 = this.mapPrefab.GetComponent<UnityEngine.RectTransform>();
        this.content.GetComponent<UnityEngine.UI.VerticalLayoutGroup>().top = 1449;
        UnityEngine.RectTransform val_32 = this.content.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector2 val_33 = val_32.sizeDelta;
        UnityEngine.Vector2 val_34 = val_30.sizeDelta;
        float val_43 = (float)this.numberOfPrefab;
        val_43 = val_34.y * val_43;
        val_43 = val_43 + (float)val_30.bottom;
        float val_44 = (float)top;
        val_44 = val_43 + val_44;
        val_13 = 0;
        UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  val_33.x, y:  val_44);
        val_32.sizeDelta = new UnityEngine.Vector2() {x = val_37.x, y = val_37.y};
        this.content.GetChild(index:  0).SetAsLastSibling();
        this.sr.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  public System.Void UIListLevelMap::CheckDirection(UnityEngine.Vector2 value)));
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.zero;
        this.CheckDirection(value:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
    }
    private void OnEnable()
    {
        if(this.dataLoaded == false)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.uILevels.GetEnumerator();
        label_5:
        if(0.MoveNext() == false)
        {
            goto label_3;
        }
        
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        0.UpdateStatus();
        goto label_5;
        label_3:
        0.Dispose();
        var val_9 = 1152921513314619296;
        StageData val_4 = LazySingleton<DataManager>.Instance.CurrentStage;
        if(val_9 <= W21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + ((X21) << 3);
        this.direction.SetParent(p:  (1152921513314619296 + (X21) << 3) + 32.transform);
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  330f);
        this.direction.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIListLevelMap::<OnEnable>b__16_0()), ignoreTimeScale:  true);
    }
    private void BackToCurrentLevel()
    {
        var val_9 = 1152921513314619296;
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        if(val_9 <= W21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + ((X21) << 3);
        UnityEngine.Transform val_3 = (1152921513314619296 + (X21) << 3) + 32.transform;
        UnityEngine.Vector3 val_4 = val_3.position;
        int val_6 = UnityEngine.Screen.height;
        var val_7 = (val_6 < 0) ? (val_6 + 1) : (val_6);
        val_7 = val_7 >> 1;
        new UnityEngine.Vector2(x:  0f, y:  (float)val_7).SnapTo(scroller:  this.sr, child:  val_3.GetComponent<UnityEngine.RectTransform>(), Offset:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
    }
    public void SnapTo(UnityEngine.UI.ScrollRect scroller, UnityEngine.RectTransform child, UnityEngine.Vector2 Offset)
    {
        UnityEngine.Canvas.ForceUpdateCanvases();
        UnityEngine.Vector3 val_2 = scroller.m_Content.position;
        UnityEngine.Vector3 val_3 = scroller.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_6 = child.position;
        UnityEngine.Vector3 val_7 = scroller.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = Offset.x, y = Offset.y});
        scroller.m_Content.anchoredPosition = new UnityEngine.Vector2() {x = (scroller.m_Horizontal == false) ? val_4.x : val_10.x, y = (scroller.m_Vertical == false) ? val_4.y : val_10.y};
        goto typeof(UnityEngine.UI.ScrollRect).__il2cppRuntimeField_3C0;
    }
    public void CheckDirection(UnityEngine.Vector2 value)
    {
        var val_7;
        UnityEngine.Vector3 val_1 = this.direction.position;
        UnityEngine.Vector3 val_2 = this.bot.position;
        if(val_1.y < 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_3 = this.direction.position;
        UnityEngine.Vector3 val_4 = this.top.position;
        if(val_3.y <= val_4.y)
        {
            goto label_5;
        }
        
        label_2:
        UnityEngine.GameObject val_5 = this.btnDirection.gameObject;
        val_7 = 1;
        goto label_8;
        label_5:
        val_7 = 0;
        label_8:
        this.btnDirection.gameObject.SetActive(value:  false);
    }
    public UIListLevelMap()
    {
        this.numberOfPrefab = 6;
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Start>b__14_0()
    {
        SoundManager.Play(fileName:  "Button");
        this.BackToCurrentLevel();
    }
    private void <Start>b__14_1()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  16);
    }
    private void <Start>b__14_2()
    {
        SoundManager.Play(fileName:  "Button");
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  90);
    }
    private void <OnEnable>b__16_0()
    {
        this.BackToCurrentLevel();
    }

}
