using UnityEngine;

namespace SuperScrollView
{
    public class PullToRefreshDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus;
        private float mDataLoadedTipShowLeftTime;
        private float mLoadingTipItemHeight;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mAddItemButton;
        private UnityEngine.UI.Button mSetCountButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.InputField mAddItemInput;
        private UnityEngine.UI.InputField mSetCountInput;
        private UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.PullToRefreshDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListView.mOnBeginDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnBeginDrag());
            this.mLoopListView.mOnDragingAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnDraging());
            this.mLoopListView.mOnEndDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnEndDrag());
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_24.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_8;
            SuperScrollView.ItemData val_9;
            SuperScrollView.LoopListViewItem2 val_10;
            int val_8 = index;
            val_8 = listView;
            val_9 = this;
            if((val_8 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_10 = 0;
            if(SuperScrollView.DataSourceMgr.Get.TotalItemCount < val_8)
            {
                    return (SuperScrollView.LoopListViewItem2)val_10;
            }
            
            if(val_8 == 0)
            {
                goto label_6;
            }
            
            val_8 = val_8 - 1;
            SuperScrollView.ItemData val_4 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_8);
            if(val_4 == null)
            {
                goto label_10;
            }
            
            val_9 = val_4;
            SuperScrollView.LoopListViewItem2 val_5 = val_8.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_10 = val_5;
            val_8 = val_5.GetComponent<SuperScrollView.ListItem2>();
            if(val_5.mIsInitHandlerCalled == false)
            {
                goto label_13;
            }
            
            if(val_8 != null)
            {
                goto label_14;
            }
            
            label_10:
            val_10 = 0;
            return (SuperScrollView.LoopListViewItem2)val_10;
            label_6:
            val_10 = val_8.NewListViewItem(itemPrefabName:  "ItemPrefab0");
            this.UpdateLoadingTip(item:  val_10);
            return (SuperScrollView.LoopListViewItem2)val_10;
            label_13:
            val_5.mIsInitHandlerCalled = true;
            val_8.Init();
            label_14:
            val_8.SetItemData(itemData:  val_9, itemIndex:  val_8);
            return (SuperScrollView.LoopListViewItem2)val_10;
        }
        private void UpdateLoadingTip(SuperScrollView.LoopListViewItem2 item)
        {
            if(item == 0)
            {
                    return;
            }
            
            if((item.GetComponent<SuperScrollView.ListItem0>()) == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus > 4)
            {
                    return;
            }
            
            var val_6 = 20154584 + (this.mLoadingTipStatus) << 2;
            val_6 = val_6 + 20154584;
            goto (20154584 + (this.mLoadingTipStatus) << 2 + 20154584);
        }
        private void OnBeginDrag()
        {
        
        }
        private void OnDraging()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_9 = this.mLoadingTipStatus;
            val_9 = val_9 | 2;
            if(val_9 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this.mLoopListView.mScrollRect.m_Content.anchoredPosition3D;
            if(val_4.y < 0)
            {
                    if(this.mLoadingTipStatus != 0)
            {
                    return;
            }
            
                this.mLoadingTipStatus = 2;
                this.UpdateLoadingTip(item:  val_2);
                UnityEngine.RectTransform val_5 = val_2.CachedRectTransform;
                UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  this.mLoadingTipItemHeight, z:  0f);
            }
            else
            {
                    if(this.mLoadingTipStatus != 2)
            {
                    return;
            }
            
                this.mLoadingTipStatus = 0;
                this.UpdateLoadingTip(item:  val_2);
                this = val_2.CachedRectTransform;
                UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            }
            
            this.anchoredPosition3D = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private void OnEndDrag()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_6 = this.mLoadingTipStatus;
            val_6 = val_6 | 2;
            if(val_6 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            this.mLoopListView.OnItemSizeChanged(itemIndex:  val_2.mItemIndex);
            if(this.mLoadingTipStatus != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 3;
            this.UpdateLoadingTip(item:  val_2);
            SuperScrollView.DataSourceMgr.Get.RequestRefreshDataList(onReflushFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshDemoScript::OnDataSourceRefreshFinished()));
        }
        private void OnDataSourceRefreshFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 4;
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip(item:  val_2);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void Update()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus != 4)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.mDataLoadedTipShowLeftTime - val_2;
            this.mDataLoadedTipShowLeftTime = val_2;
            if(val_2 > 0f)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 0;
            SuperScrollView.LoopListViewItem2 val_3 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_3 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip(item:  val_3);
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  -this.mLoadingTipItemHeight, z:  0f);
            val_3.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.mLoopListView.OnItemSizeChanged(itemIndex:  0);
        }
        private void OnJumpBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  1, offset:  0f);
        }
        private void OnAddItemBtnClicked()
        {
            if((this.mLoopListView.mItemTotalCount & 2147483648) != 0)
            {
                    return;
            }
            
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddItemInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            int val_3 = val_1 + this.mLoopListView.mItemTotalCount;
            if(<0)
            {
                    return;
            }
            
            if(val_3 > (SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1))
            {
                    return;
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  val_3, resetPos:  false);
        }
        private void OnSetItemCountBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mSetCountInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            if(0 > SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                    return;
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  1, resetPos:  false);
        }
        public PullToRefreshDemoScript()
        {
            this.mLoadingTipItemHeight = 100f;
        }
    
    }

}
