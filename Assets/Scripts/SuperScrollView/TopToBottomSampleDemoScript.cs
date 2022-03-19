using UnityEngine;

namespace SuperScrollView
{
    public class TopToBottomSampleDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mAppendItemButton;
        private UnityEngine.UI.Button mInsertItemButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private System.Collections.Generic.List<SuperScrollView.CustomData> mDataList;
        private int mTotalInsertedCount;
        
        // Methods
        private void Start()
        {
            this.InitData();
            this.mLoopListView.InitListView(itemTotalCount:  W21, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.TopToBottomSampleDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAppendItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AppendItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mInsertItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/InsertItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TopToBottomSampleDemoScript::OnJumpBtnClicked()));
            this.mAppendItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TopToBottomSampleDemoScript::OnAppendItemBtnClicked()));
            this.mInsertItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TopToBottomSampleDemoScript::OnInsertItemBtnClicked()));
        }
        private void InitData()
        {
            this.mDataList = new System.Collections.Generic.List<SuperScrollView.CustomData>();
            var val_5 = 0;
            do
            {
                .mContent = "Item" + val_5 + 1(val_5 + 1);
                this.mDataList.Add(item:  new SuperScrollView.CustomData());
                val_5 = val_5 + 1;
            }
            while(val_5 < 99);
        
        }
        private void AppendOneData()
        {
            .mContent = "Item" + this.mDataList;
            this.mDataList.Add(item:  new SuperScrollView.CustomData());
        }
        private void InsertOneData()
        {
            int val_3 = this.mTotalInsertedCount;
            val_3 = val_3 + 1;
            this.mTotalInsertedCount = val_3;
            .mContent = "Item(-"("Item(-") + this.mTotalInsertedCount + ")";
            this.mDataList.Insert(index:  0, item:  new SuperScrollView.CustomData());
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            System.Collections.Generic.List<SuperScrollView.CustomData> val_3 = this;
            bool val_3 = true;
            if((index & 2147483648) != 0)
            {
                    return 0;
            }
            
            val_3 = this.mDataList;
            if(val_3 <= index)
            {
                    return 0;
            }
            
            if(val_3 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (index << 3);
            val_3 = mem[(true + (index) << 3) + 32];
            val_3 = (true + (index) << 3) + 32;
            if(val_3 == 0)
            {
                    return 0;
            }
            
            SuperScrollView.ListItem16 val_2 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1").GetComponent<SuperScrollView.ListItem16>();
            if(val_1.mIsInitHandlerCalled != false)
            {
                    if(val_2 != null)
            {
                    return 0;
            }
            
                return 0;
            }
            
            val_1.mIsInitHandlerCalled = true;
            val_2.Init();
            return 0;
        }
        private void OnJumpBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
        }
        private void OnAppendItemBtnClicked()
        {
            this.AppendOneData();
            this.mLoopListView.SetListItemCount(itemCount:  0, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void OnInsertItemBtnClicked()
        {
            this.InsertOneData();
            this.mLoopListView.SetListItemCount(itemCount:  0, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        public TopToBottomSampleDemoScript()
        {
        
        }
    
    }

}
