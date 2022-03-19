using UnityEngine;

namespace SuperScrollView
{
    public class TopToBottomFilterSampleDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.Button mFilterButton;
        private UnityEngine.UI.InputField mFilterInput;
        private System.Collections.Generic.List<SuperScrollView.CustomData2> mAllDataList;
        private System.Collections.Generic.List<SuperScrollView.CustomData2> mFilteredDataList;
        private string mFilerStr;
        private int mTotalInsertedCount;
        
        // Methods
        private void Start()
        {
            this.mFilerStr = "";
            this.InitData();
            this.UpdateFilteredDataList();
            this.mLoopListView.InitListView(itemTotalCount:  W21, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.TopToBottomFilterSampleDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TopToBottomFilterSampleDemoScript::OnJumpBtnClicked()));
            this.mFilterButton = UnityEngine.GameObject.Find(name:  this.mScrollToButton.m_OnClick).GetComponent<UnityEngine.UI.Button>();
            this.mFilterInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/FilterInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mFilterButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.TopToBottomFilterSampleDemoScript::OnFilterButtonClicked()));
        }
        private void InitData()
        {
            this.mAllDataList = new System.Collections.Generic.List<SuperScrollView.CustomData2>();
            this.mFilteredDataList = new System.Collections.Generic.List<SuperScrollView.CustomData2>();
            var val_6 = 0;
            do
            {
                .mContent = "Item" + val_6 + 1(val_6 + 1);
                this.mAllDataList.Add(item:  new SuperScrollView.CustomData2());
                val_6 = val_6 + 1;
            }
            while(val_6 < 99);
        
        }
        private void UpdateFilteredDataList()
        {
            string val_5;
            System.Collections.Generic.List<SuperScrollView.CustomData2> val_6;
            this.mFilteredDataList.Clear();
            if((System.String.IsNullOrEmpty(value:  this.mFilerStr)) != false)
            {
                    this.mFilteredDataList.AddRange(collection:  this.mAllDataList);
                return;
            }
            
            List.Enumerator<T> val_2 = this.mAllDataList.GetEnumerator();
            label_11:
            val_5 = public System.Boolean List.Enumerator<SuperScrollView.CustomData2>::MoveNext();
            if(0.MoveNext() == false)
            {
                goto label_6;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = 11993091;
            if(val_6 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = this.mFilerStr;
            if((val_6.Contains(value:  val_5)) == false)
            {
                goto label_11;
            }
            
            val_6 = this.mFilteredDataList;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6.Add(item:  0);
            goto label_11;
            label_6:
            0.Dispose();
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            System.Collections.Generic.List<SuperScrollView.CustomData2> val_3 = this;
            bool val_3 = true;
            if((index & 2147483648) != 0)
            {
                    return 0;
            }
            
            val_3 = this.mFilteredDataList;
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
        private void OnFilterButtonClicked()
        {
            if((System.String.op_Equality(a:  this.mFilterInput.m_Text, b:  this.mFilerStr)) != false)
            {
                    return;
            }
            
            this.mFilerStr = this.mFilterInput.m_Text;
            this.UpdateFilteredDataList();
            this.mLoopListView.SetListItemCount(itemCount:  this.mFilerStr, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        public TopToBottomFilterSampleDemoScript()
        {
            this.mFilerStr = "";
        }
    
    }

}
