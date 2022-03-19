using UnityEngine;

namespace SuperScrollView
{
    public class ResponsiveGridViewDemoScript : MonoBehaviour
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
        private int mItemCountPerRow;
        private int mListItemTotalCount;
        public SuperScrollView.DragChangSizeScript mDragChangSizeScript;
        
        // Methods
        private void Start()
        {
            int val_2 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            this.mListItemTotalCount = val_2;
            int val_4 = val_2 / this.mItemCountPerRow;
            this.mLoopListView.InitListView(itemTotalCount:  ((val_2 - (val_4 * this.mItemCountPerRow)) > 0) ? (val_4 + 1) : (val_4), onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.ResponsiveGridViewDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mSetCountButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mAddItemButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemButton").GetComponent<UnityEngine.UI.Button>();
            this.mSetCountInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/SetCountInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mAddItemInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup3/AddItemInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript::OnJumpBtnClicked()));
            this.mAddItemButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript::OnAddItemBtnClicked()));
            this.mSetCountButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript::OnSetItemCountBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_23.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript::OnBackBtnClicked()));
            this.mDragChangSizeScript.mOnDragEndAction = new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript::OnViewPortSizeChanged());
            this.UpdateItemPrefab();
            this.SetListItemTotalCount(count:  this.mListItemTotalCount);
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private void SetListItemTotalCount(int count)
        {
            int val_8;
            int val_1 = count & (~(count >> 31));
            this.mListItemTotalCount = val_1;
            if(val_1 > SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                    this.mListItemTotalCount = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            }
            else
            {
                    val_8 = this.mListItemTotalCount;
            }
            
            int val_8 = this.mItemCountPerRow;
            int val_6 = val_8 / val_8;
            val_8 = val_8 - (val_6 * val_8);
            this.mLoopListView.SetListItemCount(itemCount:  (val_8 > 0) ? (val_6 + 1) : (val_6), resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void UpdateItemPrefab()
        {
            SuperScrollView.ResponsiveGridViewDemoScript val_29;
            var val_33;
            System.Collections.Generic.List<SuperScrollView.ListItem5> val_34;
            var val_35;
            val_29 = this;
            SuperScrollView.ItemPrefabConfData val_1 = this.mLoopListView.GetItemPrefabConfData(prefabName:  "ItemPrefab1");
            UnityEngine.RectTransform val_2 = val_1.mItemPrefab.GetComponent<UnityEngine.RectTransform>();
            SuperScrollView.ListItem6 val_3 = val_1.mItemPrefab.GetComponent<SuperScrollView.ListItem6>();
            float val_4 = this.mLoopListView.ViewPortWidth;
            if(==0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_5 = this.mLoopListView.mItemPoolList.gameObject;
            UnityEngine.Rect val_7 = val_5.GetComponent<UnityEngine.RectTransform>().rect;
            float val_8 = val_7.m_XMin.width;
            val_8 = val_4 / val_8;
            int val_9 = UnityEngine.Mathf.FloorToInt(f:  val_8);
            int val_10 = (val_9 != 0) ? (val_9) : (0 + 1);
            this.mItemCountPerRow = val_10;
            val_2.SetSizeWithCurrentAnchors(axis:  0, size:  val_4);
            var val_11 = val_10 - 26877952;
            if(val_9 <= 0)
            {
                goto label_14;
            }
            
            if(val_11 < 1)
            {
                goto label_28;
            }
            
            do
            {
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
                UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
                UnityEngine.GameObject val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_5, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, parent:  val_2);
                val_29 = val_14;
                UnityEngine.RectTransform val_15 = val_14.GetComponent<UnityEngine.RectTransform>();
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
                val_15.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
                val_15.anchoredPosition3D = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
                UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.identity;
                val_15.rotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
                val_3.mItemList.Add(item:  val_29.GetComponent<SuperScrollView.ListItem5>());
                val_33 = 0 + 1;
            }
            while(val_33 < val_11);
            
            goto label_28;
            label_14:
            if(val_9 < 0)
            {
                    var val_20 = 26877952 - val_10;
                if(val_20 >= 1)
            {
                    val_33 = 1152921504729477120;
                do
            {
                val_34 = val_3.mItemList;
                var val_21 = val_10 - 1;
                if(val_10 != 0)
            {
                    val_35 = val_10 + (val_21 << 3);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_34 = val_3.mItemList;
                val_35 = X9 + (val_21 << 3);
            }
            
                val_35 = val_35 + 32;
                val_34.RemoveAt(index:  val_35 - 1);
                UnityEngine.Object.DestroyImmediate(obj:  val_35.gameObject);
                val_29 = 0 + 1;
            }
            while(val_29 < val_20);
            
            }
            
            }
            
            label_28:
            var val_28 = val_10;
            var val_31 = 0;
            float val_29 = (float)val_28;
            val_28 = val_28 + 1;
            val_29 = val_8 * val_29;
            val_29 = val_4 - val_29;
            val_29 = val_29 / (float)val_28;
            float val_30 = V10.16B;
            label_43:
            if(val_31 >= val_28)
            {
                goto label_38;
            }
            
            if(val_28 <= val_31)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + 0;
            UnityEngine.Vector3 val_26 = new UnityEngine.Vector3(x:  val_30, y:  0f, z:  0f);
            ((val_9 != 0 ? val_9 : (0 + 1) + 1) + 0) + 32.gameObject.GetComponent<UnityEngine.RectTransform>().anchoredPosition3D = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            val_30 = S10 + (val_8 + val_30);
            val_31 = val_31 + 1;
            if(val_3.mItemList != null)
            {
                goto label_43;
            }
            
            label_38:
            this.mLoopListView.OnItemPrefabChanged(prefabName:  "ItemPrefab1");
        }
        private void OnViewPortSizeChanged()
        {
            this.UpdateItemPrefab();
            this.SetListItemTotalCount(count:  this.mListItemTotalCount);
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_8;
            int val_9;
            if((index & 2147483648) != 0)
            {
                goto label_1;
            }
            
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            val_8 = val_1;
            if(val_1.mIsInitHandlerCalled != true)
            {
                    val_1.mIsInitHandlerCalled = true;
                val_1.GetComponent<SuperScrollView.ListItem6>().Init();
            }
            
            int val_9 = this.mItemCountPerRow;
            if(val_9 < 1)
            {
                    return (SuperScrollView.LoopListViewItem2)val_8;
            }
            
            var val_10 = 4;
            label_26:
            val_9 = val_9 * index;
            val_9 = val_10 + val_9;
            val_9 = val_9 - 4;
            if(val_9 >= this.mListItemTotalCount)
            {
                goto label_7;
            }
            
            SuperScrollView.ItemData val_5 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_9);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_5 == null)
            {
                goto label_16;
            }
            
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.gameObject.SetActive(value:  true);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.SetItemData(itemData:  val_5, itemIndex:  val_9);
            goto label_20;
            label_7:
            val_9 = val_2.mItemList;
            if((val_10 - 4) >= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_16:
            (4 + (this.mItemCountPerRow * index)) + 32.gameObject.SetActive(value:  false);
            label_20:
            val_10 = val_10 + 1;
            if((val_10 - 3) < this.mItemCountPerRow)
            {
                goto label_26;
            }
            
            return (SuperScrollView.LoopListViewItem2)val_8;
            label_1:
            val_8 = 0;
            return (SuperScrollView.LoopListViewItem2)val_8;
        }
        private void OnJumpBtnClicked()
        {
            var val_7;
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            val_7 = val_1;
            if((val_7 & 2147483648) != 0)
            {
                    val_7 = 0;
            }
            
            var val_7 = 1;
            int val_3 = val_7 / this.mItemCountPerRow;
            val_7 = val_7 - (val_3 * this.mItemCountPerRow);
            var val_4 = (val_7 > 0) ? (val_3 + 1) : (val_3);
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  val_4 - ((val_4 > 0) ? 1 : 0), offset:  0f);
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
        public ResponsiveGridViewDemoScript()
        {
            this.mItemCountPerRow = 3;
        }
    
    }

}
