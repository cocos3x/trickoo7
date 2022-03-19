using UnityEngine;

namespace SuperScrollView
{
    public class PullToLoadMoreDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus;
        private float mLoadingTipItemHeight;
        private int mLoadMoreCount;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.PullToLoadMoreDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListView.mOnBeginDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnBeginDrag());
            this.mLoopListView.mOnDragingAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnDraging());
            this.mLoopListView.mOnEndDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnEndDrag());
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_14.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            SuperScrollView.ItemData val_11;
            SuperScrollView.LoopListViewItem2 val_12;
            val_11 = this;
            if((index & 2147483648) == 0)
            {
                    if(SuperScrollView.DataSourceMgr.Get.TotalItemCount == index)
            {
                    val_12 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
                this.UpdateLoadingTip(item:  val_12);
                return (SuperScrollView.LoopListViewItem2)val_12;
            }
            
                SuperScrollView.ItemData val_5 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  index);
                if(val_5 != null)
            {
                    val_11 = val_5;
                SuperScrollView.LoopListViewItem2 val_6 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
                val_12 = val_6;
                SuperScrollView.ListItem2 val_7 = val_6.GetComponent<SuperScrollView.ListItem2>();
                if(val_6.mIsInitHandlerCalled != true)
            {
                    val_6.mIsInitHandlerCalled = true;
                val_7.Init();
            }
            
                if((SuperScrollView.DataSourceMgr.Get.TotalItemCount - 1) == index)
            {
                    val_6.mPadding = 0f;
            }
            
                val_7.SetItemData(itemData:  val_11, itemIndex:  index);
                return (SuperScrollView.LoopListViewItem2)val_12;
            }
            
            }
            
            val_12 = 0;
            return (SuperScrollView.LoopListViewItem2)val_12;
        }
        private void UpdateLoadingTip(SuperScrollView.LoopListViewItem2 item)
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
            
            if(this.mLoadingTipStatus == 3)
            {
                goto label_8;
            }
            
            if(this.mLoadingTipStatus == 2)
            {
                goto label_9;
            }
            
            if(this.mLoadingTipStatus != 0)
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
            item.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  val_6, size:  this.mLoadingTipItemHeight);
        }
        private void OnBeginDrag()
        {
        
        }
        private void OnDraging()
        {
            UnityEngine.Object val_13;
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_13 = this.mLoadingTipStatus;
            val_13 = val_13 | 2;
            if(val_13 != 2)
            {
                    return;
            }
            
            val_13 = 1152921504891031552;
            SuperScrollView.LoopListViewItem2 val_4 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount);
            if(val_4 == 0)
            {
                    return;
            }
            
            val_13 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount - 1);
            if(val_13 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = this.mLoopListView.GetItemCornerPosInViewPort(item:  val_13, corner:  0);
            float val_12 = this.mLoopListView.ViewPortSize;
            val_12 = val_11.y + val_12;
            if(val_12 < this.mLoadingTipItemHeight)
            {
                    if(this.mLoadingTipStatus != 2)
            {
                    return;
            }
            
                this.mLoadingTipStatus = 0;
            }
            else
            {
                    if(this.mLoadingTipStatus != 0)
            {
                    return;
            }
            
                this.mLoadingTipStatus = 2;
            }
            
            this.UpdateLoadingTip(item:  val_4);
        }
        private void OnEndDrag()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_8 = this.mLoadingTipStatus;
            val_8 = val_8 | 2;
            if(val_8 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_4 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount);
            if(val_4 == 0)
            {
                    return;
            }
            
            this.mLoopListView.OnItemSizeChanged(itemIndex:  val_4.mItemIndex);
            if(this.mLoadingTipStatus != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 3;
            this.UpdateLoadingTip(item:  val_4);
            SuperScrollView.DataSourceMgr.Get.RequestLoadMoreDataList(loadCount:  this.mLoadMoreCount, onLoadMoreFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.PullToLoadMoreDemoScript::OnDataSourceLoadMoreFinished()));
        }
        private void OnDataSourceLoadMoreFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 0;
            this.mLoopListView.SetListItemCount(itemCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1, resetPos:  false);
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
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
        }
        public PullToLoadMoreDemoScript()
        {
            this.mLoadingTipItemHeight = 100f;
            this.mLoadMoreCount = 20;
        }
    
    }

}
