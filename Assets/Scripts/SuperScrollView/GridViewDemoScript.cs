using UnityEngine;

namespace SuperScrollView
{
    public class GridViewDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mAddItemButton;
        private UnityEngine.UI.Button mSetCountButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.InputField mAddItemInput;
        private UnityEngine.UI.InputField mSetCountInput;
        private UnityEngine.UI.Button mBackButton;
        private const int mItemCountPerRow = 3;
        private int mListItemTotalCount;
        
        // Methods
        private void Start()
        {
            int val_2 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            this.mListItemTotalCount = val_2;
            var val_23 = 0;
            val_23 = val_2 - val_23;
            this.mLoopListView.InitListView(itemTotalCount:  (val_23 > 0) ? (0 + 1) : 0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.GridViewDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_21.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
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
            val_9 = val_1.GetComponent<SuperScrollView.ListItem6>();
            if(val_1.mIsInitHandlerCalled != true)
            {
                    val_1.mIsInitHandlerCalled = true;
                val_9.Init();
            }
            
            var val_11 = 4;
            label_25:
            val_10 = ((val_10 + (val_10 << 1)) + val_11) - 4;
            var val_5 = val_11 - 4;
            if(val_10 >= this.mListItemTotalCount)
            {
                goto label_6;
            }
            
            SuperScrollView.ItemData val_7 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_10);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_7 == null)
            {
                goto label_15;
            }
            
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.gameObject.SetActive(value:  true);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.SetItemData(itemData:  val_7, itemIndex:  val_10);
            goto label_19;
            label_6:
            if(val_5 >= this.mListItemTotalCount)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_15:
            this.mListItemTotalCount + 32.gameObject.SetActive(value:  false);
            label_19:
            val_11 = val_11 + 1;
            if(val_5 < 2)
            {
                goto label_25;
            }
            
            return (SuperScrollView.LoopListViewItem2)val_10;
            label_1:
            val_10 = 0;
            return (SuperScrollView.LoopListViewItem2)val_10;
        }
        private void OnJumpBtnClicked()
        {
            var val_6;
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            val_6 = val_1;
            if((val_6 & 2147483648) != 0)
            {
                    val_6 = 0;
            }
            
            val_6 = val_6 + 1;
            val_6 = val_6 - 0;
            var val_3 = (val_6 > 0) ? (0 + 1) : 0;
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  val_3 - ((val_3 > 0) ? 1 : 0), offset:  0f);
        }
        private void OnAddItemBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddItemInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            this.SetListItemTotalCount(count:  val_1 + this.mListItemTotalCount);
        }
        private void OnSetItemCountBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mSetCountInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            this.SetListItemTotalCount(count:  0);
        }
        public GridViewDemoScript()
        {
        
        }
    
    }

}
