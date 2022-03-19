using UnityEngine;

namespace SuperScrollView
{
    public class PullToRefreshAndLoadMoreDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus1;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus2;
        private float mDataLoadedTipShowLeftTime;
        private float mLoadingTipItemHeight1;
        private float mLoadingTipItemHeight2;
        private int mLoadMoreCount;
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
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 2, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListView.mOnDragingAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnDraging());
            this.mLoopListView.mOnEndDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnEndDrag());
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_13.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            int val_13;
            SuperScrollView.LoopListViewItem2 val_14;
            val_13 = this;
            if((index & 2147483648) != 0)
            {
                goto label_14;
            }
            
            if(index == 0)
            {
                goto label_2;
            }
            
            if((SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1) != index)
            {
                goto label_6;
            }
            
            val_14 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            this.UpdateLoadingTip2(item:  val_14);
            return (SuperScrollView.LoopListViewItem2)val_14;
            label_2:
            val_14 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
            this.UpdateLoadingTip1(item:  val_14);
            return (SuperScrollView.LoopListViewItem2)val_14;
            label_6:
            val_13 = index - 1;
            SuperScrollView.ItemData val_7 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_13);
            if(val_7 != null)
            {
                    SuperScrollView.LoopListViewItem2 val_8 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab2");
                val_14 = val_8;
                SuperScrollView.ListItem2 val_9 = val_8.GetComponent<SuperScrollView.ListItem2>();
                if(val_8.mIsInitHandlerCalled != true)
            {
                    val_8.mIsInitHandlerCalled = true;
                val_9.Init();
            }
            
                if(SuperScrollView.DataSourceMgr.Get.TotalItemCount == index)
            {
                    val_8.mPadding = 0f;
            }
            
                val_9.SetItemData(itemData:  val_7, itemIndex:  val_13);
                return (SuperScrollView.LoopListViewItem2)val_14;
            }
            
            label_14:
            val_14 = 0;
            return (SuperScrollView.LoopListViewItem2)val_14;
        }
        private void UpdateLoadingTip1(SuperScrollView.LoopListViewItem2 item)
        {
            if(item == 0)
            {
                    return;
            }
            
            if((item.GetComponent<SuperScrollView.ListItem0>()) == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 > 4)
            {
                    return;
            }
            
            var val_6 = 20154564 + (this.mLoadingTipStatus1) << 2;
            val_6 = val_6 + 20154564;
            goto (20154564 + (this.mLoadingTipStatus1) << 2 + 20154564);
        }
        private void OnDraging()
        {
            this.OnDraging1();
            this.OnDraging2();
        }
        private void OnEndDrag()
        {
            this.OnEndDrag1();
            this.OnEndDrag2();
        }
        private void OnDraging1()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_9 = this.mLoadingTipStatus1;
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
                    if(this.mLoadingTipStatus1 != 0)
            {
                    return;
            }
            
                this.mLoadingTipStatus1 = 2;
                this.UpdateLoadingTip1(item:  val_2);
                UnityEngine.RectTransform val_5 = val_2.CachedRectTransform;
                UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  this.mLoadingTipItemHeight1, z:  0f);
            }
            else
            {
                    if(this.mLoadingTipStatus1 != 2)
            {
                    return;
            }
            
                this.mLoadingTipStatus1 = 0;
                this.UpdateLoadingTip1(item:  val_2);
                this = val_2.CachedRectTransform;
                UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            }
            
            this.anchoredPosition3D = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private void OnEndDrag1()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_6 = this.mLoadingTipStatus1;
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
            if(this.mLoadingTipStatus1 != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 3;
            this.UpdateLoadingTip1(item:  val_2);
            SuperScrollView.DataSourceMgr.Get.RequestRefreshDataList(onReflushFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnDataSourceRefreshFinished()));
        }
        private void OnDataSourceRefreshFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 4;
            this.mDataLoadedTipShowLeftTime = 0.7f;
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip1(item:  val_2);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void Update()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 != 4)
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
            
            this.mLoadingTipStatus1 = 0;
            SuperScrollView.LoopListViewItem2 val_3 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_3 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip1(item:  val_3);
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  -this.mLoadingTipItemHeight1, z:  0f);
            val_3.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.mLoopListView.OnItemSizeChanged(itemIndex:  0);
        }
        private void UpdateLoadingTip2(SuperScrollView.LoopListViewItem2 item)
        {
            Axis val_6;
            if(item == 0)
            {
                    return;
            }
            
            if((item.GetComponent<SuperScrollView.ListItem0>()) == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus2 == 3)
            {
                goto label_8;
            }
            
            if(this.mLoadingTipStatus2 == 2)
            {
                goto label_9;
            }
            
            if(this.mLoadingTipStatus2 != 0)
            {
                    return;
            }
            
            val_2.mRoot.SetActive(value:  false);
            UnityEngine.RectTransform val_4 = item.CachedRectTransform;
            val_6 = 1;
            goto label_14;
            label_9:
            val_2.mRoot.SetActive(value:  true);
            val_2.mArrow.SetActive(value:  true);
            val_2.mWaitingIcon.SetActive(value:  false);
            goto label_20;
            label_8:
            val_2.mRoot.SetActive(value:  true);
            val_2.mArrow.SetActive(value:  false);
            val_2.mWaitingIcon.SetActive(value:  true);
            label_20:
            val_6 = 1;
            label_14:
            item.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  val_6, size:  this.mLoadingTipItemHeight2);
        }
        private void OnDraging2()
        {
            UnityEngine.Object val_13;
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_13 = this.mLoadingTipStatus2;
            val_13 = val_13 | 2;
            if(val_13 != 2)
            {
                    return;
            }
            
            val_13 = 1152921504891031552;
            SuperScrollView.LoopListViewItem2 val_5 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1);
            if(val_5 == 0)
            {
                    return;
            }
            
            val_13 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount);
            if(val_13 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = this.mLoopListView.GetItemCornerPosInViewPort(item:  val_13, corner:  0);
            float val_12 = this.mLoopListView.ViewPortSize;
            val_12 = val_11.y + val_12;
            if(val_12 < this.mLoadingTipItemHeight2)
            {
                    if(this.mLoadingTipStatus2 != 2)
            {
                    return;
            }
            
                this.mLoadingTipStatus2 = 0;
            }
            else
            {
                    if(this.mLoadingTipStatus2 != 0)
            {
                    return;
            }
            
                this.mLoadingTipStatus2 = 2;
            }
            
            this.UpdateLoadingTip2(item:  val_5);
        }
        private void OnEndDrag2()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_9 = this.mLoadingTipStatus2;
            val_9 = val_9 | 2;
            if(val_9 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_5 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1);
            if(val_5 == 0)
            {
                    return;
            }
            
            this.mLoopListView.OnItemSizeChanged(itemIndex:  val_5.mItemIndex);
            if(this.mLoadingTipStatus2 != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus2 = 3;
            this.UpdateLoadingTip2(item:  val_5);
            SuperScrollView.DataSourceMgr.Get.RequestLoadMoreDataList(loadCount:  this.mLoadMoreCount, onLoadMoreFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.PullToRefreshAndLoadMoreDemoScript::OnDataSourceLoadMoreFinished()));
        }
        private void OnDataSourceLoadMoreFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus2 != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus2 = 0;
            this.mLoopListView.SetListItemCount(itemCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 2, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
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
        public PullToRefreshAndLoadMoreDemoScript()
        {
            this.mLoadingTipItemHeight1 = ;
            this.mLoadMoreCount = 20;
        }
    
    }

}
