using UnityEngine;

namespace SuperScrollView
{
    public class GridViewDeleteItemDemoScript2 : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopGridView mLoopGridView;
        public UnityEngine.UI.Button mSelectAllButton;
        public UnityEngine.UI.Button mCancelAllButton;
        public UnityEngine.UI.Button mDeleteButton;
        public UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopGridView.InitGridView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, onGetItemByRowColumn:  new System.Func<SuperScrollView.LoopGridView, System.Int32, System.Int32, System.Int32, SuperScrollView.LoopGridViewItem>(object:  this, method:  SuperScrollView.LoopGridViewItem SuperScrollView.GridViewDeleteItemDemoScript2::OnGetItemByRowColumn(SuperScrollView.LoopGridView gridView, int itemIndex, int row, int column)), settingParam:  0, initParam:  0);
            this.mBackButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript2::OnBackBtnClicked()));
            this.mSelectAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript2::OnSelectAllBtnClicked()));
            this.mCancelAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript2::OnCancelAllBtnClicked()));
            this.mDeleteButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDeleteItemDemoScript2::OnDeleteBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopGridViewItem OnGetItemByRowColumn(SuperScrollView.LoopGridView gridView, int itemIndex, int row, int column)
        {
            var val_5;
            SuperScrollView.ItemData val_2 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  itemIndex);
            if(val_2 == null)
            {
                goto label_4;
            }
            
            SuperScrollView.LoopGridViewItem val_3 = gridView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
            val_5 = val_3;
            SuperScrollView.ListItem19 val_4 = val_3.GetComponent<SuperScrollView.ListItem19>();
            if(val_3.mIsInitHandlerCalled == false)
            {
                goto label_7;
            }
            
            if(val_4 != null)
            {
                goto label_8;
            }
            
            label_4:
            val_5 = 0;
            return (SuperScrollView.LoopGridViewItem)val_5;
            label_7:
            val_3.mIsInitHandlerCalled = true;
            val_4.Init();
            label_8:
            val_4.SetItemData(itemData:  val_2, itemIndex:  itemIndex, row:  row, column:  column);
            return (SuperScrollView.LoopGridViewItem)val_5;
        }
        private void OnSelectAllBtnClicked()
        {
            SuperScrollView.DataSourceMgr.Get.CheckAllItem();
            this.mLoopGridView.RefreshAllShownItem();
        }
        private void OnCancelAllBtnClicked()
        {
            SuperScrollView.DataSourceMgr.Get.UnCheckAllItem();
            this.mLoopGridView.RefreshAllShownItem();
        }
        private void OnDeleteBtnClicked()
        {
            if(SuperScrollView.DataSourceMgr.Get.DeleteAllCheckedItem() == false)
            {
                    return;
            }
            
            this.mLoopGridView.SetListItemCount(itemCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, resetPos:  false);
            this.mLoopGridView.RefreshAllShownItem();
        }
        public GridViewDeleteItemDemoScript2()
        {
        
        }
    
    }

}
