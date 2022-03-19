using UnityEngine;

namespace SuperScrollView
{
    public class StaggeredGridView_TopToBottomDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopStaggeredGridView mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mAddItemButton;
        private UnityEngine.UI.Button mSetCountButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.InputField mAddItemInput;
        private UnityEngine.UI.InputField mSetCountInput;
        private UnityEngine.UI.Button mBackButton;
        private int[] mItemHeightArrayForDemo;
        
        // Methods
        private void Start()
        {
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  16745).GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.StaggeredGridView_TopToBottomDemoScript::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.StaggeredGridView_TopToBottomDemoScript::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.StaggeredGridView_TopToBottomDemoScript::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_17.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.StaggeredGridView_TopToBottomDemoScript::OnBackBtnClicked()));
            this.InitItemHeightArrayForDemo();
            .mPadding2 = 10f;
            .mColumnOrRowCount = 3;
            .mItemWidthOrHeight = 217f;
            .mPadding1 = 10f;
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, layoutParam:  new SuperScrollView.GridViewLayoutParam(), onGetItemByItemIndex:  new System.Func<SuperScrollView.LoopStaggeredGridView, System.Int32, SuperScrollView.LoopStaggeredGridViewItem>(object:  this, method:  SuperScrollView.LoopStaggeredGridViewItem SuperScrollView.StaggeredGridView_TopToBottomDemoScript::OnGetItemByIndex(SuperScrollView.LoopStaggeredGridView listView, int index)), initParam:  0);
        }
        private SuperScrollView.LoopStaggeredGridViewItem OnGetItemByIndex(SuperScrollView.LoopStaggeredGridView listView, int index)
        {
            int val_7;
            var val_8;
            val_7 = index;
            if((val_7 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            SuperScrollView.ItemData val_2 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_7);
            if(val_2 == null)
            {
                goto label_5;
            }
            
            SuperScrollView.LoopStaggeredGridViewItem val_3 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
            val_8 = val_3;
            SuperScrollView.ListItem5 val_4 = val_3.GetComponent<SuperScrollView.ListItem5>();
            if(val_3.mIsInitHandlerCalled == false)
            {
                goto label_8;
            }
            
            if(val_4 != null)
            {
                goto label_9;
            }
            
            label_5:
            val_8 = 0;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_8;
            label_8:
            val_3.mIsInitHandlerCalled = true;
            val_4.Init();
            label_9:
            val_4.SetItemData(itemData:  val_2, itemIndex:  val_7);
            int val_5 = val_7 / this.mItemHeightArrayForDemo.Length;
            val_5 = val_7 - (val_5 * this.mItemHeightArrayForDemo.Length);
            val_7 = this.mItemHeightArrayForDemo[val_5];
            float val_8 = 300f;
            float val_7 = (float)val_7;
            val_7 = val_7 * 10f;
            val_8 = val_7 + val_8;
            val_8.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  1, size:  val_8);
            return (SuperScrollView.LoopStaggeredGridViewItem)val_8;
        }
        private void InitItemHeightArrayForDemo()
        {
            int[] val_1 = new int[100];
            this.mItemHeightArrayForDemo = val_1;
            var val_3 = 0;
            do
            {
                if(val_3 >= val_1.Length)
            {
                    return;
            }
            
                val_1[0] = UnityEngine.Random.Range(min:  0, max:  20);
                val_3 = val_3 + 1;
            }
            while(this.mItemHeightArrayForDemo != null);
            
            throw new NullReferenceException();
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private void OnJumpBtnClicked()
        {
            var val_3;
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            val_3 = val_1;
            if((val_3 & 2147483648) != 0)
            {
                    val_3 = 0;
            }
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
        }
        private void OnAddItemBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddItemInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            int val_6 = this.mLoopListView.mItemTotalCount;
            int val_3 = val_1 + val_6;
            val_6 = val_3 >> 31;
            if(val_6 != 0)
            {
                    return;
            }
            
            if(val_3 > SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                    return;
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  val_3, resetPos:  false);
        }
        private void OnSetItemCountBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mSetCountInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            if(0 > SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                    return;
            }
            
            this.mLoopListView.SetListItemCount(itemCount:  0, resetPos:  false);
        }
        public StaggeredGridView_TopToBottomDemoScript()
        {
        
        }
    
    }

}
