using UnityEngine;

namespace SuperScrollView
{
    public class DeleteItemDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        public UnityEngine.UI.Button mSelectAllButton;
        public UnityEngine.UI.Button mCancelAllButton;
        public UnityEngine.UI.Button mDeleteButton;
        public UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.DeleteItemDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mSelectAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.DeleteItemDemoScript::OnSelectAllBtnClicked()));
            this.mCancelAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.DeleteItemDemoScript::OnCancelAllBtnClicked()));
            this.mDeleteButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.DeleteItemDemoScript::OnDeleteBtnClicked()));
            this.mBackButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.DeleteItemDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_7;
            if((index & 2147483648) != 0)
            {
                    return 0;
            }
            
            val_7 = 1152921504891031552;
            if(SuperScrollView.DataSourceMgr.Get.TotalItemCount <= index)
            {
                    return 0;
            }
            
            SuperScrollView.ItemData val_4 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  index);
            if(val_4 == null)
            {
                    return 0;
            }
            
            SuperScrollView.ListItem3 val_6 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1").GetComponent<SuperScrollView.ListItem3>();
            if(val_5.mIsInitHandlerCalled == false)
            {
                goto label_12;
            }
            
            if(val_6 != null)
            {
                goto label_13;
            }
            
            return 0;
            label_12:
            val_5.mIsInitHandlerCalled = true;
            val_6.Init();
            label_13:
            val_6.SetItemData(itemData:  val_4, itemIndex:  index);
            return 0;
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
            
            this.mLoopListView.SetListItemCount(itemCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        public DeleteItemDemoScript()
        {
        
        }
    
    }

}
