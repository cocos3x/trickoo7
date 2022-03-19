using UnityEngine;

namespace SuperScrollView
{
    public class HorizontalGalleryDemoScript : MonoBehaviour
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
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.DataSourceMgr.Get.TotalItemCount, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.HorizontalGalleryDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.HorizontalGalleryDemoScript::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.HorizontalGalleryDemoScript::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.HorizontalGalleryDemoScript::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_20.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.HorizontalGalleryDemoScript::OnBackBtnClicked()));
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
            
            SuperScrollView.ListItem5 val_6 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1").GetComponent<SuperScrollView.ListItem5>();
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
        private void LateUpdate()
        {
            this.mLoopListView.UpdateAllShownItemSnapData();
            int val_1 = this.mLoopListView.ShownItemCount;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                SuperScrollView.ListItem5 val_3 = this.mLoopListView.GetShownItemByIndex(index:  0).GetComponent<SuperScrollView.ListItem5>();
                float val_8 = System.Math.Abs(val_2.mDistanceWithViewPortSnapCenter);
                val_8 = val_8 / (-700f);
                val_8 = val_8 + 1f;
                float val_4 = UnityEngine.Mathf.Clamp(value:  val_8, min:  0.4f, max:  1f);
                val_3.mContentRootObj.GetComponent<UnityEngine.CanvasGroup>().alpha = val_4;
                UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_4, y:  val_4, z:  1f);
                val_3.mContentRootObj.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_9 = val_9 + 1;
            }
            while(val_9 < val_1);
        
        }
        private void OnJumpBtnClicked()
        {
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  0)) == false)
            {
                    return;
            }
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
            this.mLoopListView.FinishSnapImmediately();
        }
        private void OnAddItemBtnClicked()
        {
            if((this.mLoopListView.mItemTotalCount & 2147483648) != 0)
            {
                    return;
            }
            
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mAddItemInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            int val_3 = val_1 + this.mLoopListView.mItemTotalCount;
            if(<0)
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
        public HorizontalGalleryDemoScript()
        {
        
        }
    
    }

}
