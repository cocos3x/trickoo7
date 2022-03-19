using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mExpandAllButton;
        private UnityEngine.UI.Button mCollapseAllButton;
        private UnityEngine.UI.InputField mScrollToInputItem;
        private UnityEngine.UI.InputField mScrollToInputChild;
        private UnityEngine.UI.Button mBackButton;
        private SuperScrollView.TreeViewItemCountMgr mTreeItemCountMgr;
        
        // Methods
        private void Start()
        {
            int val_2 = SuperScrollView.TreeViewDataSourceMgr.Get.TreeViewItemCount;
            if(val_2 >= 1)
            {
                    var val_24 = 0;
                do
            {
                this.mTreeItemCountMgr.AddTreeItem(count:  SuperScrollView.TreeViewDataSourceMgr.Get.GetItemDataByIndex(index:  0).ChildCount, isExpand:  true);
                val_24 = val_24 + 1;
            }
            while(val_24 < val_2);
            
            }
            
            this.mLoopListView.InitListView(itemTotalCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.TreeViewDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mExpandAllButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/ExpandAllButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mCollapseAllButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/CollapseAllButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInputItem = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputFieldItem").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInputChild = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputFieldChild").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_20.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewDemoScript::OnBackBtnClicked()));
            this.mExpandAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewDemoScript::OnExpandAllBtnClicked()));
            this.mCollapseAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewDemoScript::OnCollapseAllBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            int val_11;
            int val_12;
            var val_13;
            var val_14;
            if((index & 2147483648) != 0)
            {
                goto label_15;
            }
            
            SuperScrollView.TreeViewItemCountData val_1 = this.mTreeItemCountMgr.QueryTreeItemByTotalIndex(totalIndex:  index);
            if(val_1 == null)
            {
                goto label_15;
            }
            
            val_12 = val_1;
            val_11 = val_1.mTreeItemIndex;
            val_13 = SuperScrollView.TreeViewDataSourceMgr.Get.GetItemDataByIndex(index:  val_11);
            if(val_1.mBeginIndex != index)
            {
                goto label_7;
            }
            
            SuperScrollView.LoopListViewItem2 val_4 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_14 = val_4;
            SuperScrollView.ListItem12 val_5 = val_4.GetComponent<SuperScrollView.ListItem12>();
            if(val_4.mIsInitHandlerCalled == false)
            {
                goto label_10;
            }
            
            if(val_13 != null)
            {
                goto label_12;
            }
            
            label_7:
            val_12 = (~val_1.mBeginIndex) + index;
            SuperScrollView.ItemData val_6 = val_13.GetChild(index:  val_12);
            if(val_6 == null)
            {
                goto label_15;
            }
            
            SuperScrollView.LoopListViewItem2 val_7 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab2");
            val_14 = val_7;
            val_13 = val_7.GetComponent<SuperScrollView.ListItem13>();
            if(val_7.mIsInitHandlerCalled == false)
            {
                goto label_18;
            }
            
            if(val_13 != null)
            {
                goto label_19;
            }
            
            label_15:
            val_14 = 0;
            return (SuperScrollView.LoopListViewItem2)val_14;
            label_10:
            val_4.mIsInitHandlerCalled = true;
            val_5.Init();
            val_5.mClickHandler = new System.Action<System.Int32>(object:  this, method:  public System.Void SuperScrollView.TreeViewDemoScript::OnExpandClicked(int index));
            label_12:
            val_5.SetItemData(treeItemIndex:  val_11, expand:  val_1.mIsExpand);
            return (SuperScrollView.LoopListViewItem2)val_14;
            label_18:
            val_7.mIsInitHandlerCalled = true;
            val_13.Init();
            label_19:
            val_13.SetItemData(itemData:  val_6, itemIndex:  val_11, childIndex:  val_12);
            return (SuperScrollView.LoopListViewItem2)val_14;
        }
        public void OnExpandClicked(int index)
        {
            this.mTreeItemCountMgr.ToggleItemExpand(treeIndex:  index);
            this.mLoopListView.SetListItemCount(itemCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void OnJumpBtnClicked()
        {
            var val_8;
            int val_9;
            int val_3 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInputItem.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            if((System.Int32.TryParse(s:  this.mScrollToInputChild.m_Text, result: out  val_3)) != false)
            {
                    if((val_3 & 2147483648) == 0)
            {
                goto label_4;
            }
            
            }
            
            label_4:
            if((this.mTreeItemCountMgr.GetTreeItem(treeIndex:  0)) == null)
            {
                    return;
            }
            
            if((val_5.mChildCount == 0) || (val_5.mIsExpand == false))
            {
                goto label_9;
            }
            
            val_8 = 0;
            if(val_8 == 0)
            {
                goto label_9;
            }
            
            var val_6 = (0 > val_5.mChildCount) ? val_5.mChildCount : (val_8);
            if(0 <= val_5.mChildCount)
            {
                    if(val_6 > 0)
            {
                goto label_11;
            }
            
            }
            
            val_8 = (val_6 > 0) ? (val_6) : (0 + 1);
            label_11:
            val_9 = val_8 + val_5.mBeginIndex;
            goto label_12;
            label_9:
            val_9 = val_5.mBeginIndex;
            label_12:
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  val_9, offset:  0f);
        }
        private void OnExpandAllBtnClicked()
        {
            int val_1 = this.mTreeItemCountMgr.TreeViewItemCount;
            if(val_1 >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.mTreeItemCountMgr.SetItemExpand(treeIndex:  0, isExpand:  true);
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
            
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void OnCollapseAllBtnClicked()
        {
            int val_1 = this.mTreeItemCountMgr.TreeViewItemCount;
            if(val_1 >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.mTreeItemCountMgr.SetItemExpand(treeIndex:  0, isExpand:  false);
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
            
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        public TreeViewDemoScript()
        {
            this.mTreeItemCountMgr = new SuperScrollView.TreeViewItemCountMgr();
        }
    
    }

}
