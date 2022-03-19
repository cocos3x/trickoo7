using UnityEngine;

namespace SuperScrollView
{
    public class GridViewDeleteItemDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        public UnityEngine.UI.Button mSelectAllButton;
        public UnityEngine.UI.Button mCancelAllButton;
        public UnityEngine.UI.Button mDeleteButton;
        public UnityEngine.UI.Button mBackButton;
        private const int mItemCountPerRow = 3;
        private int mListItemTotalCount;
        
        // Methods
        private void Start()
        {
            int val_2 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            this.mListItemTotalCount = val_2;
            var val_9 = 0;
            val_9 = val_2 - val_9;
            this.mLoopListView.InitListView(itemTotalCount:  (val_9 > 0) ? (0 + 1) : 0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.GridViewDeleteItemDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mBackButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript::OnBackBtnClicked()));
            this.mSelectAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript::OnSelectAllBtnClicked()));
            this.mCancelAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript::OnCancelAllBtnClicked()));
            this.mDeleteButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript::OnDeleteBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_9;
            var val_10;
            int val_10 = index;
            if((val_10 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_10 = val_1;
            val_9 = val_1.GetComponent<SuperScrollView.ListItem10>();
            if(val_1.mIsInitHandlerCalled != true)
            {
                    val_1.mIsInitHandlerCalled = true;
                val_9.Init();
            }
            
            var val_14 = 4;
            label_25:
            val_10 = ((val_10 + (val_10 << 1)) + val_14) - 4;
            if(val_10 >= this.mListItemTotalCount)
            {
                goto label_6;
            }
            
            SuperScrollView.ItemData val_7 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_10);
            if(val_7 == null)
            {
                goto label_15;
            }
            
            val_2.mItemList[0].gameObject.SetActive(value:  true);
            val_2.mItemList[0].SetItemData(itemData:  val_7, itemIndex:  val_10);
            goto label_19;
            label_6:
            label_15:
            val_2.mItemList[0].gameObject.SetActive(value:  false);
            label_19:
            val_14 = val_14 + 1;
            if((val_14 - 4) < 2)
            {
                goto label_25;
            }
            
            return (SuperScrollView.LoopListViewItem2)val_10;
            label_1:
            val_10 = 0;
            return (SuperScrollView.LoopListViewItem2)val_10;
        }
        private void OnSelectAllBtnClicked()
        {
            SuperScrollView.DataSourceMgr.Get.CheckAllItem();
            this.mLoopListView.RefreshAllShownItem();
        }
        private void OnCancelAllBtnClicked()
        {
            SuperScrollView.DataSourceMgr.Get.UnCheckAllItem();
            this.mLoopListView.RefreshAllShownItem();
        }
        private void OnDeleteBtnClicked()
        {
            if(SuperScrollView.DataSourceMgr.Get.DeleteAllCheckedItem() == false)
            {
                    return;
            }
            
            this.SetListItemTotalCount(count:  SuperScrollView.DataSourceMgr.Get.TotalItemCount);
        }
        private void SetListItemTotalCount(int count)
        {
            int val_7;
            int val_1 = count & (~(count >> 31));
            this.mListItemTotalCount = val_1;
            if(val_1 > SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                    this.mListItemTotalCount = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            }
            else
            {
                    val_7 = this.mListItemTotalCount;
            }
            
            var val_7 = 0;
            val_7 = val_7 - val_7;
            this.mLoopListView.SetListItemCount(itemCount:  (val_7 > 0) ? (0 + 1) : 0, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        public GridViewDeleteItemDemoScript()
        {
        
        }
    
    }

}
