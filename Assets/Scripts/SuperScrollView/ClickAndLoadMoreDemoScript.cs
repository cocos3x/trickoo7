using UnityEngine;

namespace SuperScrollView
{
    public class ClickAndLoadMoreDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus;
        private int mLoadMoreCount;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount + 1, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.ClickAndLoadMoreDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ClickAndLoadMoreDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_11.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ClickAndLoadMoreDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            ButtonClickedEvent val_10;
            SuperScrollView.LoopListViewItem2 val_11;
            val_10 = index;
            if((val_10 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            if(SuperScrollView.DataSourceMgr.Get.TotalItemCount == val_10)
            {
                    val_11 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
                if(val_3.mIsInitHandlerCalled != true)
            {
                    val_3.mIsInitHandlerCalled = true;
                SuperScrollView.ListItem11 val_4 = val_11.GetComponent<SuperScrollView.ListItem11>();
                val_10 = val_4.mRootButton.m_OnClick;
                val_10.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ClickAndLoadMoreDemoScript::OnLoadMoreBtnClicked()));
            }
            
                this.UpdateLoadingTip(item:  val_11);
                return (SuperScrollView.LoopListViewItem2)val_11;
            }
            
            SuperScrollView.ItemData val_7 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_10);
            if(val_7 == null)
            {
                goto label_16;
            }
            
            SuperScrollView.LoopListViewItem2 val_8 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_11 = val_8;
            SuperScrollView.ListItem2 val_9 = val_8.GetComponent<SuperScrollView.ListItem2>();
            if(val_8.mIsInitHandlerCalled == false)
            {
                goto label_19;
            }
            
            if(val_9 != null)
            {
                goto label_20;
            }
            
            label_16:
            val_11 = 0;
            return (SuperScrollView.LoopListViewItem2)val_11;
            label_19:
            val_8.mIsInitHandlerCalled = true;
            val_9.Init();
            label_20:
            val_9.SetItemData(itemData:  val_7, itemIndex:  val_10);
            return (SuperScrollView.LoopListViewItem2)val_11;
        }
        private void UpdateLoadingTip(SuperScrollView.LoopListViewItem2 item)
        {
            if(item == 0)
            {
                    return;
            }
            
            if((item.GetComponent<SuperScrollView.ListItem11>()) == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus != 3)
            {
                    if(this.mLoadingTipStatus != 0)
            {
                    return;
            }
            
                val_2.mWaitingIcon.SetActive(value:  false);
                return;
            }
            
            val_2.mWaitingIcon.SetActive(value:  true);
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5E0;
        }
        private void OnLoadMoreBtnClicked()
        {
            System.Action val_8;
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus != 0)
            {
                    return;
            }
            
            val_8 = 1152921504891031552;
            SuperScrollView.LoopListViewItem2 val_4 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  SuperScrollView.DataSourceMgr.Get.TotalItemCount);
            if(val_4 == 0)
            {
                    return;
            }
            
            this.mLoadingTipStatus = 3;
            this.UpdateLoadingTip(item:  val_4);
            SuperScrollView.DataSourceMgr val_6 = SuperScrollView.DataSourceMgr.Get;
            System.Action val_7 = null;
            val_8 = val_7;
            val_7 = new System.Action(object:  this, method:  System.Void SuperScrollView.ClickAndLoadMoreDemoScript::OnDataSourceLoadMoreFinished());
            val_6.mOnLoadMoreFinished = val_8;
            val_6.mLoadMoreCount = this.mLoadMoreCount;
            val_6.mDataLoadLeftTime = 1f;
            val_6.mIsWaitLoadingMoreData = true;
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
        public ClickAndLoadMoreDemoScript()
        {
            this.mLoadMoreCount = 20;
        }
    
    }

}
