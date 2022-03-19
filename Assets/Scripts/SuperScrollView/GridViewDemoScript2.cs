using UnityEngine;

namespace SuperScrollView
{
    public class GridViewDemoScript2 : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopGridView mLoopGridView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.Button mAddItemButton;
        private UnityEngine.UI.Button mSetCountButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.InputField mAddItemInput;
        private UnityEngine.UI.InputField mSetCountInput;
        private UnityEngine.UI.Button mBackButton;
        
        // Methods
        private void Start()
        {
            this.mLoopGridView.InitGridView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, onGetItemByRowColumn:  new System.Func<SuperScrollView.LoopGridView, System.Int32, System.Int32, System.Int32, SuperScrollView.LoopGridViewItem>(object:  this, method:  SuperScrollView.LoopGridViewItem SuperScrollView.GridViewDemoScript2::OnGetItemByRowColumn(SuperScrollView.LoopGridView gridView, int itemIndex, int row, int column)), settingParam:  0, initParam:  0);
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript2::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript2::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript2::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_20.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.GridViewDemoScript2::OnBackBtnClicked()));
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
            SuperScrollView.ListItem18 val_4 = val_3.GetComponent<SuperScrollView.ListItem18>();
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
        private void OnJumpBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            this.mLoopGridView.MovePanelToItemByIndex(itemIndex:  0, offsetX:  0f, offsetY:  0f);
        }
        private void OnAddItemBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddItemInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            this.mLoopGridView.SetListItemCount(itemCount:  this.mLoopGridView.mItemTotalCount + val_1, resetPos:  false);
        }
        private void OnSetItemCountBtnClicked()
        {
            int val_7;
            if((System.Int32.TryParse(s:  this.mSetCountInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            if(0 <= SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                goto label_6;
            }
            
            int val_6 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            val_7 = val_6;
            if((val_7 & 2147483648) == 0)
            {
                goto label_12;
            }
            
            goto label_11;
            label_6:
            val_7 = val_6;
            if((val_7 & 2147483648) == 0)
            {
                goto label_12;
            }
            
            label_11:
            val_7 = 0;
            label_12:
            this.mLoopGridView.SetListItemCount(itemCount:  0, resetPos:  true);
        }
        public GridViewDemoScript2()
        {
        
        }
    
    }

}
