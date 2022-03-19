using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewWithStickyHeadDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mExpandAllButton;
        private UnityEngine.UI.Button mCollapseAllButton;
        private UnityEngine.UI.InputField mScrollToInputItem;
        private UnityEngine.UI.InputField mScrollToInputChild;
        private UnityEngine.UI.Button mBackButton;
        private UnityEngine.UI.Button mAddNewButton;
        private UnityEngine.UI.InputField mAddNewInputItem;
        private UnityEngine.UI.InputField mAddNewInputChild;
        private SuperScrollView.TreeViewItemCountMgr mTreeItemCountMgr;
        public SuperScrollView.ListItem12 mStickeyHeadItem;
        private UnityEngine.RectTransform mStickeyHeadItemRf;
        private float mStickeyHeadItemHeight;
        
        // Methods
        private void Start()
        {
            int val_2 = SuperScrollView.TreeViewDataSourceMgr.Get.TreeViewItemCount;
            if(val_2 >= 1)
            {
                    var val_38 = 0;
                do
            {
                this.mTreeItemCountMgr.AddTreeItem(count:  SuperScrollView.TreeViewDataSourceMgr.Get.GetItemDataByIndex(index:  0).ChildCount, isExpand:  true);
                val_38 = val_38 + 1;
            }
            while(val_38 < val_2);
            
            }
            
            this.mLoopListView.InitListView(itemTotalCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.TreeViewWithStickyHeadDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mExpandAllButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/ExpandAllButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mCollapseAllButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/CollapseAllButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInputItem = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputFieldItem").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInputChild = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputFieldChild").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_20.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnBackBtnClicked()));
            this.mExpandAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnExpandAllBtnClicked()));
            this.mCollapseAllButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnCollapseAllBtnClicked()));
            this.mAddNewButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup4/AddNewButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddNewInputItem = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup4/AddNewInputFieldItem").GetComponent<UnityEngine.UI.InputField>();
            this.mAddNewInputChild = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup4/AddNewInputFieldChild").GetComponent<UnityEngine.UI.InputField>();
            this.mAddNewButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnAddNewBtnClicked()));
            UnityEngine.Rect val_32 = this.mStickeyHeadItem.GetComponent<UnityEngine.RectTransform>().rect;
            this.mStickeyHeadItemHeight = val_32.m_XMin.height;
            this.mStickeyHeadItem.Init();
            this.mStickeyHeadItem.mClickHandler = new System.Action<System.Int32>(object:  this, method:  public System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnExpandClicked(int index));
            this.mStickeyHeadItemRf = this.mStickeyHeadItem.gameObject.GetComponent<UnityEngine.RectTransform>();
            this.mLoopListView.mScrollRect.m_OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnScrollContentPosChanged(UnityEngine.Vector2 pos)));
            this.UpdateStickeyHeadPos();
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            int val_13;
            int val_14;
            var val_15;
            var val_16;
            if((index & 2147483648) != 0)
            {
                goto label_15;
            }
            
            SuperScrollView.TreeViewItemCountData val_1 = this.mTreeItemCountMgr.QueryTreeItemByTotalIndex(totalIndex:  index);
            if(val_1 == null)
            {
                goto label_15;
            }
            
            val_14 = val_1;
            val_13 = val_1.mTreeItemIndex;
            val_15 = SuperScrollView.TreeViewDataSourceMgr.Get.GetItemDataByIndex(index:  val_13);
            if(val_1.mBeginIndex != index)
            {
                goto label_7;
            }
            
            SuperScrollView.LoopListViewItem2 val_4 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_16 = val_4;
            SuperScrollView.ListItem12 val_5 = val_4.GetComponent<SuperScrollView.ListItem12>();
            if(val_4.mIsInitHandlerCalled == false)
            {
                goto label_10;
            }
            
            val_4.mUserIntData1 = val_13;
            val_4.mUserIntData2 = 0;
            if(val_15 != null)
            {
                goto label_12;
            }
            
            label_7:
            val_14 = (~val_1.mBeginIndex) + index;
            SuperScrollView.ItemData val_6 = val_15.GetChild(index:  val_14);
            if(val_6 == null)
            {
                goto label_15;
            }
            
            SuperScrollView.LoopListViewItem2 val_7 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab2");
            val_16 = val_7;
            val_15 = val_7.GetComponent<SuperScrollView.ListItem13>();
            if(val_7.mIsInitHandlerCalled == false)
            {
                goto label_18;
            }
            
            val_7.mUserIntData1 = val_13;
            val_7.mUserIntData2 = val_14;
            if(val_15 != null)
            {
                goto label_19;
            }
            
            label_15:
            val_16 = 0;
            return (SuperScrollView.LoopListViewItem2)val_16;
            label_10:
            val_4.mIsInitHandlerCalled = true;
            val_5.Init();
            val_5.mClickHandler = new System.Action<System.Int32>(object:  this, method:  public System.Void SuperScrollView.TreeViewWithStickyHeadDemoScript::OnExpandClicked(int index));
            val_4.mUserIntData1 = val_13;
            val_4.mUserIntData2 = 0;
            label_12:
            val_5.SetItemData(treeItemIndex:  val_13, expand:  val_1.mIsExpand);
            return (SuperScrollView.LoopListViewItem2)val_16;
            label_18:
            val_7.mIsInitHandlerCalled = true;
            val_15.Init();
            val_7.mUserIntData1 = val_13;
            val_7.mUserIntData2 = val_14;
            label_19:
            val_15.SetItemData(itemData:  val_6, itemIndex:  val_13, childIndex:  val_14);
            val_13 = UnityEngine.Random.Range(min:  200, max:  144);
            val_16.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  1, size:  (float)val_13);
            return (SuperScrollView.LoopListViewItem2)val_16;
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
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  val_9, offset:  this.mStickeyHeadItemHeight);
        }
        private void OnAddNewBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddNewInputItem.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            if((System.Int32.TryParse(s:  this.mAddNewInputChild.m_Text, result: out  val_1)) != false)
            {
                    if((0 & 2147483648) == 0)
            {
                goto label_5;
            }
            
            }
            
            label_5:
            if((this.mTreeItemCountMgr.GetTreeItem(treeIndex:  0)) == null)
            {
                    return;
            }
            
            SuperScrollView.TreeViewDataSourceMgr.Get.AddNewItemChildForTest(itemIndex:  0, AddToBeforeChildIndex:  0);
            this.mTreeItemCountMgr.SetItemChildCount(treeIndex:  0, count:  val_4.mChildCount + 1);
            this.mLoopListView.SetListItemCount(itemCount:  this.mTreeItemCountMgr.GetTotalItemAndChildCount(), resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
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
        private void UpdateStickeyHeadPos()
        {
            var val_34;
            SuperScrollView.LoopListViewItem2 val_35;
            float val_36;
            var val_37;
            float val_39;
            float val_40;
            float val_41;
            val_34 = this;
            bool val_2 = this.mStickeyHeadItem.gameObject.activeSelf;
            int val_3 = this.mLoopListView.ShownItemCount;
            if(val_3 == 0)
            {
                goto label_25;
            }
            
            val_35 = this.mLoopListView.GetShownItemByIndex(index:  0);
            UnityEngine.Vector3 val_5 = this.mLoopListView.GetItemCornerPosInViewPort(item:  val_35, corner:  1);
            val_36 = val_5.y;
            if(val_36 <= 0f)
            {
                goto label_25;
            }
            
            val_36 = val_36 - val_35.ItemSizeWithPadding;
            if(val_36 >= 0)
            {
                goto label_9;
            }
            
            val_37 = 0;
            goto label_17;
            label_9:
            if(val_3 < 2)
            {
                goto label_11;
            }
            
            val_37 = 1;
            do
            {
                SuperScrollView.LoopListViewItem2 val_7 = this.mLoopListView.GetShownItemByIndexWithoutCheck(index:  1);
                val_35 = val_7;
                float val_8 = val_7.ItemSizeWithPadding;
                val_8 = val_36 - val_8;
                if(val_36 >= 0f)
            {
                    if(val_8 <= 0f)
            {
                goto label_15;
            }
            
            }
            
                val_37 = val_37 + 1;
            }
            while(val_37 < val_3);
            
            val_35 = 0;
            val_37 = 0;
            label_15:
            val_36 = val_8;
            goto label_17;
            label_11:
            val_35 = 0;
            val_37 = 0;
            label_17:
            if((val_35 == 0) || ((((this.mTreeItemCountMgr.GetTreeItem(treeIndex:  0)) == null) || (val_10.mIsExpand == false)) || (val_10.mChildCount == 0)))
            {
                goto label_25;
            }
            
            if(val_2 != true)
            {
                    this.mStickeyHeadItem.gameObject.SetActive(value:  true);
            }
            
            if(this.mStickeyHeadItem.mTreeItemIndex != 0)
            {
                    SuperScrollView.TreeViewItemData val_13 = SuperScrollView.TreeViewDataSourceMgr.Get.GetItemDataByIndex(index:  0);
                this.mStickeyHeadItem.SetItemData(treeItemIndex:  0, expand:  val_10.mIsExpand);
            }
            
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            this.mStickeyHeadItem.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            val_39 = this.mStickeyHeadItemHeight;
            val_40 = -val_36;
            val_41 = val_40 - (1.401298E-45f);
            if(val_41 >= val_39)
            {
                    return;
            }
            
            val_35 = val_37 + 1;
            goto label_44;
            label_25:
            if(val_2 == false)
            {
                    return;
            }
            
            this.mStickeyHeadItem.gameObject.SetActive(value:  false);
            return;
            label_52:
            if(val_18.mUserIntData1 != (???))
            {
                goto label_50;
            }
            
            val_39 = mem[??? + 128];
            val_39 = ??? + 128;
            val_40 = (???) + (??? + 24.GetShownItemByIndexWithoutCheck(index:  ???).ItemSizeWithPadding);
            val_41 = val_40 - val_18.mPadding;
            if(val_41 >= val_39)
            {
                    return;
            }
            
            val_35 = (???) + 1;
            label_44:
            if(val_35 < (???))
            {
                goto label_52;
            }
            
            goto label_53;
            label_50:
            val_39 = mem[??? + 128];
            val_39 = ??? + 128;
            val_41 = (???) - (???);
            label_53:
            val_34 = mem[??? + 120];
            val_34 = ??? + 120;
            val_39 = val_39 - val_41;
            UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  0f, y:  val_39, z:  0f);
            val_34.anchoredPosition3D = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        }
        private void OnScrollContentPosChanged(UnityEngine.Vector2 pos)
        {
            this.UpdateStickeyHeadPos();
        }
        public TreeViewWithStickyHeadDemoScript()
        {
            this.mTreeItemCountMgr = new SuperScrollView.TreeViewItemCountMgr();
            this.mStickeyHeadItemHeight = -1f;
        }
    
    }

}
