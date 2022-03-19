using UnityEngine;

namespace SuperScrollView
{
    public class ResponsiveGridViewDemoScript2 : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus1;
        private SuperScrollView.LoadingTipStatus mLoadingTipStatus2;
        private float mDataLoadedTipShowLeftTime;
        private float mLoadingTipItemHeight1;
        private float mLoadingTipItemHeight2;
        private int mLoadMoreCount;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.Button mBackButton;
        private int mItemCountPerRow;
        public SuperScrollView.DragChangSizeScript mDragChangSizeScript;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  this.GetMaxRowCount() + 2, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.ResponsiveGridViewDemoScript2::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int row)), initParam:  0);
            this.mDragChangSizeScript.mOnDragEndAction = new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnViewPortSizeChanged());
            this.mLoopListView.mOnDragingAction = new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnDraging());
            this.mLoopListView.mOnEndDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnEndDrag());
            this.OnViewPortSizeChanged();
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_13.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private void UpdateItemPrefab()
        {
            SuperScrollView.ResponsiveGridViewDemoScript2 val_29;
            var val_33;
            System.Collections.Generic.List<SuperScrollView.ListItem5> val_34;
            var val_35;
            val_29 = this;
            SuperScrollView.ItemPrefabConfData val_1 = this.mLoopListView.GetItemPrefabConfData(prefabName:  "ItemPrefab2");
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
            this.mLoopListView.OnItemPrefabChanged(prefabName:  "ItemPrefab2");
        }
        private void OnViewPortSizeChanged()
        {
            this.UpdateItemPrefab();
            this.mLoopListView.SetListItemCount(itemCount:  this.GetMaxRowCount() + 2, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
        }
        private int GetMaxRowCount()
        {
            var val_7 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            val_7 = val_7 / this.mItemCountPerRow;
            int val_4 = SuperScrollView.DataSourceMgr.Get.TotalItemCount;
            int val_8 = this.mItemCountPerRow;
            val_8 = val_4 - ((val_4 / val_8) * val_8);
            return (int)(val_8 > 0) ? (val_7 + 1) : (val_7);
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int row)
        {
            var val_15;
            SuperScrollView.LoopListViewItem2 val_16;
            int val_17;
            int val_17 = row;
            if((val_17 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(val_17 == 0)
            {
                goto label_2;
            }
            
            if((this.GetMaxRowCount() + 1) != val_17)
            {
                goto label_3;
            }
            
            val_16 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            this.UpdateLoadingTip2(item:  val_16);
            return (SuperScrollView.LoopListViewItem2)val_16;
            label_1:
            val_16 = 0;
            return (SuperScrollView.LoopListViewItem2)val_16;
            label_2:
            val_16 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab0");
            this.UpdateLoadingTip1(item:  val_16);
            return (SuperScrollView.LoopListViewItem2)val_16;
            label_3:
            SuperScrollView.LoopListViewItem2 val_5 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab2");
            val_16 = val_5;
            val_15 = val_5.GetComponent<SuperScrollView.ListItem6>();
            if(val_5.mIsInitHandlerCalled != true)
            {
                    val_5.mIsInitHandlerCalled = true;
                val_15.Init();
            }
            
            val_17 = this.mItemCountPerRow;
            if(val_17 < 1)
            {
                    return (SuperScrollView.LoopListViewItem2)val_16;
            }
            
            var val_18 = 4;
            label_36:
            int val_9 = val_17 * (val_17 - 1);
            val_9 = val_18 + val_9;
            val_17 = val_9 - 4;
            if(val_17 >= SuperScrollView.DataSourceMgr.Get.TotalItemCount)
            {
                goto label_17;
            }
            
            SuperScrollView.ItemData val_13 = SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  val_17);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_13 == null)
            {
                goto label_26;
            }
            
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.gameObject.SetActive(value:  true);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 32.SetItemData(itemData:  val_13, itemIndex:  val_17);
            goto label_30;
            label_17:
            if((val_18 - 4) >= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_26:
            (4 + (this.mItemCountPerRow * (row - 1))) + 32.gameObject.SetActive(value:  false);
            label_30:
            val_17 = this.mItemCountPerRow;
            val_18 = val_18 + 1;
            if((val_18 - 3) < val_17)
            {
                goto label_36;
            }
            
            return (SuperScrollView.LoopListViewItem2)val_16;
        }
        private void UpdateLoadingTip1(SuperScrollView.LoopListViewItem2 item)
        {
            UnityEngine.Object val_8;
            if(item == 0)
            {
                    return;
            }
            
            item.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  this.mLoopListView.ViewPortWidth);
            val_8 = item.GetComponent<SuperScrollView.ListItem17>();
            if(val_8 == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 > 4)
            {
                    return;
            }
            
            var val_8 = 20154604 + (this.mLoadingTipStatus1) << 2;
            val_8 = val_8 + 20154604;
            goto (20154604 + (this.mLoadingTipStatus1) << 2 + 20154604);
        }
        private void OnDraging()
        {
            this.OnDraging1();
            this.OnDraging2();
        }
        private void OnEndDrag()
        {
            this.OnEndDrag1();
            this.OnEndDrag2();
        }
        private void OnDraging1()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 > 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this.mLoopListView.mScrollRect.m_Content.anchoredPosition3D;
            if(val_4.y >= 0f)
            {
                goto label_11;
            }
            
            if((val_4.y >= 0) || (val_4.y <= (-this.mLoadingTipItemHeight1)))
            {
                goto label_13;
            }
            
            SuperScrollView.LoadingTipStatus val_9 = this.mLoadingTipStatus1;
            val_9 = val_9 | 2;
            if(val_9 != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 1;
            goto label_15;
            label_11:
            if(this.mLoadingTipStatus1 != 1)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 0;
            label_15:
            this.UpdateLoadingTip1(item:  val_2);
            this = val_2.CachedRectTransform;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            label_24:
            this.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            return;
            label_13:
            if(val_4.y > (-this.mLoadingTipItemHeight1))
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 != 1)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 2;
            this.UpdateLoadingTip1(item:  val_2);
            UnityEngine.RectTransform val_7 = val_2.CachedRectTransform;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  0f, y:  this.mLoadingTipItemHeight1, z:  0f);
            goto label_24;
        }
        private void OnEndDrag1()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            this.mLoopListView.OnItemSizeChanged(itemIndex:  val_2.mItemIndex);
            if(this.mLoadingTipStatus1 != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 3;
            this.UpdateLoadingTip1(item:  val_2);
            SuperScrollView.DataSourceMgr.Get.RequestRefreshDataList(onReflushFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnDataSourceRefreshFinished()));
        }
        private void OnDataSourceRefreshFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 4;
            this.mDataLoadedTipShowLeftTime = 0.7f;
            SuperScrollView.LoopListViewItem2 val_2 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_2 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip1(item:  val_2);
            this.mLoopListView.RefreshAllShownItem();
        }
        private void Update()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus1 != 4)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.mDataLoadedTipShowLeftTime - val_2;
            this.mDataLoadedTipShowLeftTime = val_2;
            if(val_2 > 0f)
            {
                    return;
            }
            
            this.mLoadingTipStatus1 = 0;
            SuperScrollView.LoopListViewItem2 val_3 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  0);
            if(val_3 == 0)
            {
                    return;
            }
            
            this.UpdateLoadingTip1(item:  val_3);
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  -this.mLoadingTipItemHeight1, z:  0f);
            val_3.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.mLoopListView.OnItemSizeChanged(itemIndex:  0);
        }
        private void UpdateLoadingTip2(SuperScrollView.LoopListViewItem2 item)
        {
            UnityEngine.Object val_8;
            Axis val_9;
            if(item == 0)
            {
                    return;
            }
            
            item.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  this.mLoopListView.ViewPortWidth);
            val_8 = item.GetComponent<SuperScrollView.ListItem0>();
            if(val_8 == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus2 == 3)
            {
                goto label_10;
            }
            
            if(this.mLoadingTipStatus2 == 2)
            {
                goto label_11;
            }
            
            if(this.mLoadingTipStatus2 != 0)
            {
                    return;
            }
            
            val_4.mRoot.SetActive(value:  false);
            UnityEngine.RectTransform val_6 = item.CachedRectTransform;
            val_9 = 1;
            goto label_16;
            label_11:
            val_4.mRoot.SetActive(value:  true);
            val_4.mArrow.SetActive(value:  true);
            val_4.mWaitingIcon.SetActive(value:  false);
            goto label_22;
            label_10:
            val_4.mRoot.SetActive(value:  true);
            val_4.mArrow.SetActive(value:  false);
            val_4.mWaitingIcon.SetActive(value:  true);
            label_22:
            val_9 = 1;
            label_16:
            item.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  val_9, size:  this.mLoadingTipItemHeight2);
        }
        private void OnDraging2()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_11 = this.mLoadingTipStatus2;
            val_11 = val_11 | 2;
            if(val_11 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_4 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  this.GetMaxRowCount() + 1);
            if(val_4 == 0)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_7 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  this.GetMaxRowCount());
            if(val_7 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = this.mLoopListView.GetItemCornerPosInViewPort(item:  val_7, corner:  0);
            float val_10 = this.mLoopListView.ViewPortSize;
            val_10 = val_9.y + val_10;
            if(val_10 < this.mLoadingTipItemHeight2)
            {
                    if(this.mLoadingTipStatus2 != 2)
            {
                    return;
            }
            
                this.mLoadingTipStatus2 = 0;
            }
            else
            {
                    if(this.mLoadingTipStatus2 != 0)
            {
                    return;
            }
            
                this.mLoadingTipStatus2 = 2;
            }
            
            this.UpdateLoadingTip2(item:  val_4);
        }
        private void OnEndDrag2()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            SuperScrollView.LoadingTipStatus val_8 = this.mLoadingTipStatus2;
            val_8 = val_8 | 2;
            if(val_8 != 2)
            {
                    return;
            }
            
            SuperScrollView.LoopListViewItem2 val_4 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  this.GetMaxRowCount() + 1);
            if(val_4 == 0)
            {
                    return;
            }
            
            this.mLoopListView.OnItemSizeChanged(itemIndex:  val_4.mItemIndex);
            if(this.mLoadingTipStatus2 != 2)
            {
                    return;
            }
            
            this.mLoadingTipStatus2 = 3;
            this.UpdateLoadingTip2(item:  val_4);
            SuperScrollView.DataSourceMgr.Get.RequestLoadMoreDataList(loadCount:  this.mLoadMoreCount, onLoadMoreFinished:  new System.Action(object:  this, method:  System.Void SuperScrollView.ResponsiveGridViewDemoScript2::OnDataSourceLoadMoreFinished()));
        }
        private void OnDataSourceLoadMoreFinished()
        {
            if(this.mLoopListView.ShownItemCount == 0)
            {
                    return;
            }
            
            if(this.mLoadingTipStatus2 != 3)
            {
                    return;
            }
            
            this.mLoadingTipStatus2 = 0;
            this.mLoopListView.SetListItemCount(itemCount:  this.GetMaxRowCount() + 2, resetPos:  false);
            this.mLoopListView.RefreshAllShownItem();
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
            val_4 = val_4 - ((val_4 > 0) ? 1 : 0);
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  val_4 + 1, offset:  0f);
        }
        public ResponsiveGridViewDemoScript2()
        {
            this.mLoadMoreCount = 20;
            this.mLoadingTipItemHeight1 = ;
            this.mItemCountPerRow = 3;
        }
    
    }

}
