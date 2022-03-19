using UnityEngine;
public class UIListLevel : UICore
{
    // Fields
    private UnityEngine.Transform content;
    private UnityEngine.UI.ScrollRect sr;
    private UnityEngine.UI.Button btnBack;
    private UnityEngine.UI.Button btnSetting;
    private SuperScrollView.LoopGridView mLoopGridView;
    private System.Collections.Generic.List<UILevel> uILevels;
    private bool loopgridInit;
    
    // Methods
    private void Start()
    {
        this.uILevels = new System.Collections.Generic.List<UILevel>();
        this.btnBack.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIListLevel::<Start>b__7_0()));
        this.btnSetting.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UIListLevel::<Start>b__7_1()));
    }
    public void Show()
    {
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIListLevel::<Show>b__8_0());
        goto static_value_019A0000 + 368;
    }
    private void createButton()
    {
        int val_5;
        var val_6;
        if(this.loopgridInit != true)
        {
                DataManager val_1 = LazySingleton<DataManager>.Instance;
            this.mLoopGridView.InitGridView(itemTotalCount:  W21, onGetItemByRowColumn:  new System.Func<SuperScrollView.LoopGridView, System.Int32, System.Int32, System.Int32, SuperScrollView.LoopGridViewItem>(object:  this, method:  SuperScrollView.LoopGridViewItem UIListLevel::OnGetItemByRowColumn(SuperScrollView.LoopGridView gridView, int itemIndex, int row, int column)), settingParam:  0, initParam:  0);
            this.loopgridInit = true;
        }
        
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        List.Enumerator<T> val_4 = val_3.needUpdateLevel.GetEnumerator();
        label_10:
        if(val_6.MoveNext() == false)
        {
            goto label_8;
        }
        
        if(this.mLoopGridView == null)
        {
                throw new NullReferenceException();
        }
        
        this.mLoopGridView.RefreshItemByItemIndex(itemIndex:  val_5);
        goto label_10;
        label_8:
        val_6.Dispose();
        DataManager val_8 = LazySingleton<DataManager>.Instance;
        val_8.needUpdateLevel.Clear();
        StageData val_10 = LazySingleton<DataManager>.Instance.CurrentStage;
        this.mLoopGridView.MovePanelToItemByIndex(itemIndex:  0, offsetX:  0f, offsetY:  0f);
    }
    private SuperScrollView.LoopGridViewItem OnGetItemByRowColumn(SuperScrollView.LoopGridView gridView, int itemIndex, int row, int column)
    {
        SuperScrollView.LoopGridViewItem val_1 = gridView.NewListViewItem(itemPrefabName:  "UILevel");
        if(val_1.mIsInitHandlerCalled != true)
        {
                val_1.mIsInitHandlerCalled = true;
        }
        
        val_1.GetComponent<UILevel>().FillData(_index:  itemIndex);
        return val_1;
    }
    public UIListLevel()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Start>b__7_0()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  15);
    }
    private void <Start>b__7_1()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  16);
    }
    private void <Show>b__8_0()
    {
        this.createButton();
    }

}
