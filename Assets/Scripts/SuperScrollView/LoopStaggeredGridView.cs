using UnityEngine;

namespace SuperScrollView
{
    public class LoopStaggeredGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SuperScrollView.StaggeredGridItemPool> mItemPoolDict;
        private System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPool> mItemPoolList;
        private System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPrefabConfData> mItemPrefabDataList;
        private SuperScrollView.ListItemArrangeType mArrangeType;
        private UnityEngine.RectTransform mContainerTrans;
        private UnityEngine.UI.ScrollRect mScrollRect;
        private int mGroupCount;
        private System.Collections.Generic.List<SuperScrollView.StaggeredGridItemGroup> mItemGroupList;
        private System.Collections.Generic.List<SuperScrollView.ItemIndexData> mItemIndexDataList;
        private UnityEngine.RectTransform mScrollRectTransform;
        private UnityEngine.RectTransform mViewPortRectTransform;
        private float mItemDefaultWithPaddingSize;
        private int mItemTotalCount;
        private bool mIsVertList;
        private System.Func<SuperScrollView.LoopStaggeredGridView, int, SuperScrollView.LoopStaggeredGridViewItem> mOnGetItemByItemIndex;
        private UnityEngine.Vector3[] mItemWorldCorners;
        private UnityEngine.Vector3[] mViewPortRectLocalCorners;
        private float mDistanceForRecycle0;
        private float mDistanceForNew0;
        private float mDistanceForRecycle1;
        private float mDistanceForNew1;
        private bool mIsDraging;
        private UnityEngine.EventSystems.PointerEventData mPointerEventData;
        public System.Action mOnBeginDragAction;
        public System.Action mOnDragingAction;
        public System.Action mOnEndDragAction;
        private UnityEngine.Vector3 mLastFrameContainerPos;
        private bool mListViewInited;
        private int mListUpdateCheckFrameCount;
        private SuperScrollView.GridViewLayoutParam mLayoutParam;
        
        // Properties
        public SuperScrollView.ListItemArrangeType ArrangeType { get; set; }
        public System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPrefabConfData> ItemPrefabDataList { get; }
        public int ListUpdateCheckFrameCount { get; }
        public bool IsVertList { get; }
        public int ItemTotalCount { get; }
        public UnityEngine.RectTransform ContainerTrans { get; }
        public UnityEngine.UI.ScrollRect ScrollRect { get; }
        public bool IsDraging { get; }
        public SuperScrollView.GridViewLayoutParam LayoutParam { get; }
        public bool IsInited { get; }
        public float ViewPortSize { get; }
        public float ViewPortWidth { get; }
        public float ViewPortHeight { get; }
        public int CurMaxCreatedItemIndexCount { get; }
        
        // Methods
        public SuperScrollView.ListItemArrangeType get_ArrangeType()
        {
            return (SuperScrollView.ListItemArrangeType)this.mArrangeType;
        }
        public void set_ArrangeType(SuperScrollView.ListItemArrangeType value)
        {
            this.mArrangeType = value;
        }
        public System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPrefabConfData> get_ItemPrefabDataList()
        {
            return (System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPrefabConfData>)this.mItemPrefabDataList;
        }
        public int get_ListUpdateCheckFrameCount()
        {
            return (int)this.mListUpdateCheckFrameCount;
        }
        public bool get_IsVertList()
        {
            return (bool)this.mIsVertList;
        }
        public int get_ItemTotalCount()
        {
            return (int)this.mItemTotalCount;
        }
        public UnityEngine.RectTransform get_ContainerTrans()
        {
            return (UnityEngine.RectTransform)this.mContainerTrans;
        }
        public UnityEngine.UI.ScrollRect get_ScrollRect()
        {
            return (UnityEngine.UI.ScrollRect)this.mScrollRect;
        }
        public bool get_IsDraging()
        {
            return (bool)this.mIsDraging;
        }
        public SuperScrollView.GridViewLayoutParam get_LayoutParam()
        {
            return (SuperScrollView.GridViewLayoutParam)this.mLayoutParam;
        }
        public bool get_IsInited()
        {
            return (bool)this.mListViewInited;
        }
        public SuperScrollView.StaggeredGridItemGroup GetItemGroupByIndex(int index)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            if((index & 2147483648) != 0)
            {
                    return (SuperScrollView.StaggeredGridItemGroup)val_1;
            }
            
            if(val_1 <= index)
            {
                    return (SuperScrollView.StaggeredGridItemGroup)val_1;
            }
            
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            val_1 = mem[(true + (index) << 3) + 32];
            val_1 = (true + (index) << 3) + 32;
            return (SuperScrollView.StaggeredGridItemGroup)val_1;
        }
        public SuperScrollView.StaggeredGridItemPrefabConfData GetItemPrefabConfData(string prefabName)
        {
            var val_2;
            var val_3;
            UnityEngine.Object val_8;
            string val_9;
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            val_9 = prefabName;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_11:
            val_10 = public System.Boolean List.Enumerator<SuperScrollView.StaggeredGridItemPrefabConfData>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_12 = val_2;
            if(val_12 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = mem[val_2 + 16];
            val_8 = val_2 + 16;
            val_10 = 0;
            if(val_8 != val_10)
            {
                goto label_6;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab is null ");
            goto label_11;
            label_6:
            val_11 = mem[val_2 + 16];
            val_11 = val_2 + 16;
            if(val_11 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.String.op_Equality(a:  val_9, b:  val_11.name)) == false)
            {
                goto label_11;
            }
            
            goto label_12;
            label_2:
            val_12 = 0;
            label_12:
            val_3.Dispose();
            return (SuperScrollView.StaggeredGridItemPrefabConfData)val_12;
        }
        public void InitListView(int itemTotalCount, SuperScrollView.GridViewLayoutParam layoutParam, System.Func<SuperScrollView.LoopStaggeredGridView, int, SuperScrollView.LoopStaggeredGridViewItem> onGetItemByItemIndex, SuperScrollView.StaggeredGridViewInitParam initParam)
        {
            SuperScrollView.GridViewLayoutParam val_14;
            var val_15;
            object val_16;
            UnityEngine.RectTransform val_17;
            System.Func<System.Int32, System.Int32, SuperScrollView.LoopStaggeredGridViewItem> val_18;
            val_14 = layoutParam;
            this.mLayoutParam = val_14;
            if(val_14 == null)
            {
                goto label_1;
            }
            
            if(val_14.CheckParam() == false)
            {
                    return;
            }
            
            if(initParam != null)
            {
                    this.mDistanceForRecycle0 = initParam.mDistanceForRecycle0;
                this.mDistanceForNew0 = initParam.mDistanceForNew0;
                this.mDistanceForRecycle1 = initParam.mDistanceForRecycle1;
                this.mDistanceForNew1 = initParam.mDistanceForNew1;
                this.mItemDefaultWithPaddingSize = initParam.mItemDefaultWithPaddingSize;
            }
            
            UnityEngine.UI.ScrollRect val_3 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            this.mScrollRect = val_3;
            val_15 = 1152921504729477120;
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            val_16 = "LoopStaggeredGridView Init Failed! ScrollRect component not found!";
            goto label_10;
            label_1:
            val_16 = "layoutParam can not be null!";
            label_10:
            UnityEngine.Debug.LogError(message:  val_16);
            return;
            label_7:
            if(this.mDistanceForRecycle0 <= this.mDistanceForNew0)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle0 should be bigger than mDistanceForNew0");
            }
            
            if(this.mDistanceForRecycle1 <= this.mDistanceForNew1)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle1 should be bigger than mDistanceForNew1");
            }
            
            this.mScrollRectTransform = this.mScrollRect.GetComponent<UnityEngine.RectTransform>();
            this.mContainerTrans = this.mScrollRect.m_Content;
            this.mViewPortRectTransform = this.mScrollRect.m_Viewport;
            this.mGroupCount = this.mLayoutParam.mColumnOrRowCount;
            if(this.mScrollRect.m_Viewport == 0)
            {
                    this.mViewPortRectTransform = this.mScrollRectTransform;
            }
            
            if(this.mScrollRect.m_HorizontalScrollbarVisibility == 2)
            {
                    if(this.mScrollRect.m_HorizontalScrollbar != 0)
            {
                    UnityEngine.Debug.LogError(message:  "ScrollRect.horizontalScrollbarVisibility cannot be set to AutoHideAndExpandViewport");
            }
            
            }
            
            if(this.mScrollRect.m_VerticalScrollbarVisibility == 2)
            {
                    if(this.mScrollRect.m_VerticalScrollbar != 0)
            {
                    UnityEngine.Debug.LogError(message:  "ScrollRect.verticalScrollbarVisibility cannot be set to AutoHideAndExpandViewport");
            }
            
            }
            
            this.mIsVertList = (this.mArrangeType < 2) ? 1 : 0;
            this.mScrollRect.m_Horizontal = (this.mArrangeType > 1) ? 1 : 0;
            this.mScrollRect.m_Vertical = this.mIsVertList;
            this.AdjustPivot(rtf:  this.mViewPortRectTransform);
            this.AdjustAnchor(rtf:  this.mContainerTrans);
            this.AdjustContainerPivot(rtf:  this.mContainerTrans);
            this.InitItemPool();
            this.mOnGetItemByItemIndex = onGetItemByItemIndex;
            if(this.mListViewInited != false)
            {
                    UnityEngine.Debug.LogError(message:  "LoopStaggeredGridView.InitListView method can be called only once.");
            }
            
            this.mListViewInited = true;
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            val_17 = this.mContainerTrans;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_17.anchoredPosition3D = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            this.mItemTotalCount = itemTotalCount;
            this.UpdateLayoutParamAutoValue();
            this.mItemGroupList.Clear();
            if(this.mGroupCount >= 1)
            {
                    var val_14 = 0;
                do
            {
                SuperScrollView.StaggeredGridItemGroup val_12 = null;
                val_17 = val_12;
                val_12 = new SuperScrollView.StaggeredGridItemGroup();
                System.Func<System.Int32, System.Int32, SuperScrollView.LoopStaggeredGridViewItem> val_13 = null;
                val_18 = val_13;
                val_13 = new System.Func<System.Int32, System.Int32, SuperScrollView.LoopStaggeredGridViewItem>(object:  this, method:  public SuperScrollView.LoopStaggeredGridViewItem SuperScrollView.LoopStaggeredGridView::GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup));
                val_12.Init(parent:  this, itemTotalCount:  this.mItemTotalCount, groupIndex:  0, onGetItemByIndex:  val_13);
                this.mItemGroupList.Add(item:  val_12);
                val_14 = val_14 + 1;
            }
            while(val_14 < this.mGroupCount);
            
            }
            
            this.UpdateContentSize();
        }
        public void ResetGridViewLayoutParam(int itemTotalCount, SuperScrollView.GridViewLayoutParam layoutParam)
        {
            UnityEngine.RectTransform val_5;
            object val_6;
            if(this.mListViewInited == false)
            {
                goto label_1;
            }
            
            this.SetListItemCount(itemCount:  0, resetPos:  true);
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
            this.mLayoutParam = layoutParam;
            if(layoutParam == null)
            {
                goto label_3;
            }
            
            if(layoutParam.CheckParam() == false)
            {
                    return;
            }
            
            this.mGroupCount = this.mLayoutParam.mColumnOrRowCount;
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            val_5 = this.mContainerTrans;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_5.anchoredPosition3D = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.mItemTotalCount = itemTotalCount;
            this.UpdateLayoutParamAutoValue();
            this.mItemGroupList.Clear();
            if(this.mGroupCount >= 1)
            {
                    var val_5 = 0;
                do
            {
                SuperScrollView.StaggeredGridItemGroup val_3 = null;
                val_5 = val_3;
                val_3 = new SuperScrollView.StaggeredGridItemGroup();
                val_3.Init(parent:  this, itemTotalCount:  this.mItemTotalCount, groupIndex:  0, onGetItemByIndex:  new System.Func<System.Int32, System.Int32, SuperScrollView.LoopStaggeredGridViewItem>(object:  this, method:  public SuperScrollView.LoopStaggeredGridViewItem SuperScrollView.LoopStaggeredGridView::GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup)));
                this.mItemGroupList.Add(item:  val_3);
                val_5 = val_5 + 1;
            }
            while(val_5 < this.mGroupCount);
            
            }
            
            this.UpdateContentSize();
            return;
            label_1:
            val_6 = "ResetLayoutParam can not use before LoopStaggeredGridView.InitListView are called!";
            goto label_17;
            label_3:
            val_6 = "layoutParam can not be null!";
            label_17:
            UnityEngine.Debug.LogError(message:  val_6);
        }
        private void UpdateLayoutParamAutoValue()
        {
            float val_5;
            if(this.mLayoutParam.mCustomColumnOrRowOffsetArray != null)
            {
                    return;
            }
            
            this.mLayoutParam.mCustomColumnOrRowOffsetArray = new float[0];
            if(this.mIsVertList != false)
            {
                    float val_2 = this.ViewPortWidth;
            }
            else
            {
                    float val_3 = this.ViewPortHeight;
            }
            
            float val_7 = this.mLayoutParam.mPadding1;
            val_3 = val_3 - val_7;
            if()
            {
                    return;
            }
            
            float val_5 = (float)this.mGroupCount;
            val_5 = this.mLayoutParam.mItemWidthOrHeight * val_5;
            var val_6 = 0;
            val_3 = val_3 - this.mLayoutParam.mPadding2;
            val_3 = val_3 - val_5;
            val_3 = val_3 / ((float)this.mGroupCount - 1);
            label_14:
            if(this.mIsVertList == false)
            {
                goto label_9;
            }
            
            val_5 = val_7;
            if(val_6 < this.mLayoutParam.mCustomColumnOrRowOffsetArray.Length)
            {
                goto label_10;
            }
            
            label_9:
            val_5 = -val_7;
            label_10:
            this.mLayoutParam.mCustomColumnOrRowOffsetArray[val_6] = val_5;
            val_6 = val_6 + 1;
            val_7 = val_7 + this.mLayoutParam.mItemWidthOrHeight;
            val_7 = val_3 + val_7;
            if(val_6 < this.mGroupCount)
            {
                goto label_14;
            }
        
        }
        public SuperScrollView.LoopStaggeredGridViewItem NewListViewItem(string itemPrefabName)
        {
            var val_8;
            if((this.mItemPoolDict.TryGetValue(key:  itemPrefabName, value: out  0)) != false)
            {
                    SuperScrollView.LoopStaggeredGridViewItem val_3 = val_1.GetItem();
                val_8 = val_3;
                UnityEngine.RectTransform val_4 = val_3.GetComponent<UnityEngine.RectTransform>();
                val_4.SetParent(p:  this.mContainerTrans);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
                val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                val_4.localEulerAngles = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_3.mParentListView = this;
                return (SuperScrollView.LoopStaggeredGridViewItem)val_8;
            }
            
            val_8 = 0;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_8;
        }
        public void SetListItemCount(int itemCount, bool resetPos = True)
        {
            int val_3;
            int val_4;
            val_3 = itemCount;
            int val_2 = this.mItemTotalCount;
            if(val_2 == val_3)
            {
                    return;
            }
            
            this.mItemTotalCount = val_3;
            if(26877952 >= 1)
            {
                    label_7:
                if(val_2 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                (this.mItemTotalCount + 0) + 32.SetListItemCount(itemCount:  this.mItemTotalCount);
                val_3 = 0 + 1;
                if(val_3 < 26877952)
            {
                    if(this.mItemGroupList != null)
            {
                goto label_7;
            }
            
            }
            
            }
            
            this.UpdateContentSize();
            if(this.mItemTotalCount == 0)
            {
                goto label_10;
            }
            
            if(26877952 > 1)
            {
                    this.mItemIndexDataList.RemoveRange(index:  this.mItemTotalCount, count:  val_3 - this.mItemTotalCount);
            }
            
            if(resetPos == false)
            {
                goto label_12;
            }
            
            val_4 = 0;
            goto label_13;
            label_10:
            this.mItemIndexDataList.Clear();
            this.ClearAllTmpRecycledItem();
            return;
            label_12:
            if(val_3 <= this.mItemTotalCount)
            {
                    return;
            }
            
            val_4 = this.mItemTotalCount - 1;
            label_13:
            this.MovePanelToItemIndex(itemIndex:  val_4, offset:  0f);
        }
        public void MovePanelToItemIndex(int itemIndex, float offset)
        {
            UnityEngine.RectTransform val_19;
            UnityEngine.RectTransform val_21;
            UnityEngine.RectTransform val_22;
            if((itemIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.mItemTotalCount == 0)
            {
                    return;
            }
            
            this.CheckAllGroupIfNeedUpdateItemPos();
            this.UpdateContentSize();
            float val_1 = this.ViewPortSize;
            float val_2 = this.GetContentSize();
            if(val_2 <= val_1)
            {
                goto label_3;
            }
            
            float val_5 = this.GetItemAbsPosByItemIndex(itemIndex:  (this.mItemTotalCount > itemIndex) ? itemIndex : (this.mItemTotalCount - 1));
            if(val_5 < 0)
            {
                    return;
            }
            
            if(this.mIsVertList == false)
            {
                goto label_5;
            }
            
            val_5 = val_5 + offset;
            val_19 = this.mContainerTrans;
            float val_7 = (this.mArrangeType == 0) ? 1f : -1f;
            if((val_2 - S11) >= val_1)
            {
                goto label_7;
            }
            
            float val_8 = val_2 - val_1;
            val_8 = val_8 * val_7;
            this.SetAnchoredPositionY(rtf:  val_19, y:  val_8);
            float val_18 = 100f;
            val_18 = val_1 + val_18;
            this.UpdateListView(distanceForRecycle0:  val_18, distanceForRecycle1:  val_18, distanceForNew0:  val_1, distanceForNew1:  val_1);
            this.ClearAllTmpRecycledItem();
            this.UpdateContentSize();
            float val_9 = this.GetContentSize();
            val_19 = this.mContainerTrans;
            if((val_9 - S11) >= val_1)
            {
                goto label_7;
            }
            
            val_9 = val_9 - val_1;
            val_9 = val_7 * val_9;
            goto label_9;
            label_3:
            val_21 = this.mContainerTrans;
            if(this.mIsVertList == true)
            {
                goto label_9;
            }
            
            goto label_13;
            label_7:
            label_9:
            this.SetAnchoredPositionY(rtf:  val_19, y:  S11 * val_7);
            return;
            label_5:
            val_5 = val_5 + offset;
            val_22 = this.mContainerTrans;
            float val_13 = (this.mArrangeType == 3) ? 1f : -1f;
            if((val_2 - S11) >= val_1)
            {
                goto label_12;
            }
            
            float val_14 = val_2 - val_1;
            val_14 = val_14 * val_13;
            this.SetAnchoredPositionX(rtf:  val_22, x:  val_14);
            float val_19 = 100f;
            val_19 = val_1 + val_19;
            this.UpdateListView(distanceForRecycle0:  val_19, distanceForRecycle1:  val_19, distanceForNew0:  val_1, distanceForNew1:  val_1);
            this.ClearAllTmpRecycledItem();
            this.UpdateContentSize();
            float val_15 = this.GetContentSize();
            val_22 = this.mContainerTrans;
            if((val_15 - S11) >= val_1)
            {
                goto label_12;
            }
            
            val_15 = val_15 - val_1;
            val_15 = val_13 * val_15;
            goto label_13;
            label_12:
            label_13:
            this.SetAnchoredPositionX(rtf:  val_22, x:  S11 * val_13);
        }
        public SuperScrollView.LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
        {
            SuperScrollView.ItemIndexData val_1 = this.GetItemIndexData(itemIndex:  itemIndex);
            if(val_1 == null)
            {
                    return (SuperScrollView.LoopStaggeredGridViewItem)val_1;
            }
            
            return this.GetItemGroupByIndex(index:  val_1.mGroupIndex).GetShownItemByIndexInGroup(indexInGroup:  val_1.mIndexInGroup);
        }
        public void RefreshAllShownItem()
        {
            bool val_1 = true;
            if(26877952 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.RefreshAllShownItem();
                val_2 = val_2 + 1;
                if(val_2 >= 26877952)
            {
                    return;
            }
            
            }
            while(this.mItemGroupList != null);
            
            throw new NullReferenceException();
        }
        public void OnItemSizeChanged(int itemIndex)
        {
            if((this.GetItemIndexData(itemIndex:  itemIndex)) == null)
            {
                    return;
            }
            
            this.GetItemGroupByIndex(index:  val_1.mGroupIndex).OnItemSizeChanged(indexInGroup:  val_1.mIndexInGroup);
        }
        public void RefreshItemByItemIndex(int itemIndex)
        {
            if((this.GetItemIndexData(itemIndex:  itemIndex)) == null)
            {
                    return;
            }
            
            this.GetItemGroupByIndex(index:  val_1.mGroupIndex).RefreshItemByIndexInGroup(indexInGroup:  val_1.mIndexInGroup);
        }
        public void ResetListView(bool resetPos = True)
        {
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            if(resetPos == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public float get_ViewPortSize()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            if(this.mIsVertList == false)
            {
                    return (float)val_1.m_XMin.width;
            }
            
            float val_2 = val_1.m_XMin.height;
            return (float)val_1.m_XMin.width;
        }
        public float get_ViewPortWidth()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            return (float)val_1.m_XMin.width;
        }
        public float get_ViewPortHeight()
        {
            UnityEngine.Rect val_1 = this.mViewPortRectTransform.rect;
            return (float)val_1.m_XMin.height;
        }
        public void RecycleAllItem()
        {
            bool val_1 = true;
            if(26877952 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.RecycleAllItem();
                val_2 = val_2 + 1;
                if(val_2 >= 26877952)
            {
                    return;
            }
            
            }
            while(this.mItemGroupList != null);
            
            throw new NullReferenceException();
        }
        public void RecycleItemTmp(SuperScrollView.LoopStaggeredGridViewItem item)
        {
            if(item == 0)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  item.mItemPrefabName)) == true)
            {
                    return;
            }
            
            if((this.mItemPoolDict.TryGetValue(key:  item.mItemPrefabName, value: out  0)) == false)
            {
                    return;
            }
            
            val_3.RecycleItem(item:  item);
        }
        public void ClearAllTmpRecycledItem()
        {
            bool val_1 = true;
            if(26877952 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.ClearTmpRecycledItem();
                val_2 = val_2 + 1;
                if(val_2 >= 26877952)
            {
                    return;
            }
            
            }
            while(this.mItemPoolList != null);
            
            throw new NullReferenceException();
        }
        private void AdjustContainerPivot(UnityEngine.RectTransform rtf)
        {
            UnityEngine.Vector2 val_1 = rtf.pivot;
            if(this.mArrangeType <= 3)
            {
                    var val_2 = 20154480 + (this.mArrangeType) << 2;
                val_2 = val_2 + 20154480;
            }
            else
            {
                    rtf.pivot = new UnityEngine.Vector2() {x = 1f, y = val_1.y};
            }
        
        }
        private void AdjustPivot(UnityEngine.RectTransform rtf)
        {
            UnityEngine.Vector2 val_1 = rtf.pivot;
            if(this.mArrangeType <= 3)
            {
                    var val_2 = 20154448 + (this.mArrangeType) << 2;
                val_2 = val_2 + 20154448;
            }
            else
            {
                    rtf.pivot = new UnityEngine.Vector2() {x = 1f, y = val_1.y};
            }
        
        }
        private void AdjustContainerAnchor(UnityEngine.RectTransform rtf)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector2 val_1 = rtf.anchorMin;
            val_3 = val_1.x;
            UnityEngine.Vector2 val_2 = rtf.anchorMax;
            val_4 = val_2.x;
            if(this.mArrangeType <= 3)
            {
                    var val_3 = 20154500 + (this.mArrangeType) << 2;
                val_3 = val_3 + 20154500;
            }
            else
            {
                    val_5 = val_2.y;
                rtf.anchorMin = new UnityEngine.Vector2() {x = val_3, y = val_1.y};
                rtf.anchorMax = new UnityEngine.Vector2() {x = val_4, y = val_5};
            }
        
        }
        private void AdjustAnchor(UnityEngine.RectTransform rtf)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Vector2 val_1 = rtf.anchorMin;
            val_3 = val_1.x;
            UnityEngine.Vector2 val_2 = rtf.anchorMax;
            val_4 = val_2.x;
            if(this.mArrangeType <= 3)
            {
                    var val_3 = 20154464 + (this.mArrangeType) << 2;
                val_3 = val_3 + 20154464;
            }
            else
            {
                    val_5 = val_2.y;
                rtf.anchorMin = new UnityEngine.Vector2() {x = val_3, y = val_1.y};
                rtf.anchorMax = new UnityEngine.Vector2() {x = val_4, y = val_5};
            }
        
        }
        private void InitItemPool()
        {
            var val_2;
            var val_3;
            UnityEngine.Object val_16;
            System.Collections.Generic.Dictionary<System.String, SuperScrollView.StaggeredGridItemPool> val_17;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_31:
            val_16 = public System.Boolean List.Enumerator<SuperScrollView.StaggeredGridItemPrefabConfData>::MoveNext();
            if(val_3.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            if((val_2 + 16) != val_16)
            {
                goto label_6;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab is null ");
            goto label_31;
            label_6:
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            string val_6 = val_17.name;
            val_17 = this.mItemPoolDict;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = val_6;
            if((val_17.ContainsKey(key:  val_16)) == false)
            {
                goto label_12;
            }
            
            UnityEngine.Debug.LogError(message:  "A item prefab with name " + val_6 + " has existed!"(" has existed!"));
            goto label_31;
            label_12:
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.RectTransform val_9 = val_17.GetComponent<UnityEngine.RectTransform>();
            if(val_9 != 0)
            {
                goto label_19;
            }
            
            UnityEngine.Debug.LogError(message:  "RectTransform component is not found in the prefab " + val_6);
            goto label_31;
            label_19:
            this.AdjustAnchor(rtf:  val_9);
            val_16 = val_9;
            this.AdjustPivot(rtf:  val_16);
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            if((val_17.GetComponent<SuperScrollView.LoopStaggeredGridViewItem>()) == val_16)
            {
                    val_17 = mem[val_2 + 16];
                val_17 = val_2 + 16;
                if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_16 = public SuperScrollView.LoopStaggeredGridViewItem UnityEngine.GameObject::AddComponent<SuperScrollView.LoopStaggeredGridViewItem>();
                SuperScrollView.LoopStaggeredGridViewItem val_14 = val_17.AddComponent<SuperScrollView.LoopStaggeredGridViewItem>();
            }
            
            SuperScrollView.StaggeredGridItemPool val_15 = new SuperScrollView.StaggeredGridItemPool();
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = mem[val_2 + 16];
            val_16 = val_2 + 16;
            val_15.Init(prefabObj:  val_16, padding:  val_2 + 24, createCount:  val_2 + 28, parent:  this.mContainerTrans);
            val_17 = this.mItemPoolDict;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = val_6;
            val_17.Add(key:  val_16, value:  val_15);
            val_17 = this.mItemPoolList;
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17.Add(item:  val_15);
            goto label_31;
            label_2:
            val_3.Dispose();
        }
        public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mIsDraging = true;
            this.CacheDragPointerEventData(eventData:  eventData);
            if(this.mOnBeginDragAction == null)
            {
                    return;
            }
            
            this.mOnBeginDragAction.Invoke();
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(eventData != null)
            {
                    if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
                this.mIsDraging = false;
                this.mPointerEventData = 0;
                if(this.mOnEndDragAction == null)
            {
                    return;
            }
            
                this.mOnEndDragAction.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.CacheDragPointerEventData(eventData:  eventData);
            if(this.mOnDragingAction == null)
            {
                    return;
            }
            
            this.mOnDragingAction.Invoke();
        }
        private void CacheDragPointerEventData(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.EventSystems.PointerEventData val_3 = this.mPointerEventData;
            if(val_3 == null)
            {
                    UnityEngine.EventSystems.PointerEventData val_2 = null;
                val_3 = val_2;
                val_2 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.EventSystems.EventSystem.current);
                this.mPointerEventData = val_3;
            }
            
            .<button>k__BackingField = eventData.<button>k__BackingField;
            this.mPointerEventData.<position>k__BackingField = eventData.<position>k__BackingField;
        }
        public int get_CurMaxCreatedItemIndexCount()
        {
            return 11214;
        }
        private void SetAnchoredPositionX(UnityEngine.RectTransform rtf, float x)
        {
            UnityEngine.Vector3 val_1 = rtf.anchoredPosition3D;
            rtf.anchoredPosition3D = new UnityEngine.Vector3() {x = x, y = val_1.y, z = val_1.z};
        }
        private void SetAnchoredPositionY(UnityEngine.RectTransform rtf, float y)
        {
            UnityEngine.Vector3 val_1 = rtf.anchoredPosition3D;
            rtf.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = y, z = val_1.z};
        }
        public SuperScrollView.ItemIndexData GetItemIndexData(int itemIndex)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            if((itemIndex & 2147483648) != 0)
            {
                    return (SuperScrollView.ItemIndexData)val_1;
            }
            
            if(val_1 <= itemIndex)
            {
                    return (SuperScrollView.ItemIndexData)val_1;
            }
            
            if(val_1 <= itemIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (itemIndex << 3);
            val_1 = mem[(true + (itemIndex) << 3) + 32];
            val_1 = (true + (itemIndex) << 3) + 32;
            return (SuperScrollView.ItemIndexData)val_1;
        }
        public void UpdateAllGroupShownItemsPos()
        {
            bool val_1 = true;
            if(26877952 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.UpdateAllShownItemsPos();
                val_2 = val_2 + 1;
                if(val_2 >= 26877952)
            {
                    return;
            }
            
            }
            while(this.mItemGroupList != null);
            
            throw new NullReferenceException();
        }
        private void CheckAllGroupIfNeedUpdateItemPos()
        {
            bool val_1 = true;
            if(26877952 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                (true + 0) + 32.CheckIfNeedUpdateItemPos();
                val_2 = val_2 + 1;
                if(val_2 >= 26877952)
            {
                    return;
            }
            
            }
            while(this.mItemGroupList != null);
            
            throw new NullReferenceException();
        }
        public float GetItemAbsPosByItemIndex(int itemIndex)
        {
            bool val_1 = true;
            if((itemIndex & 2147483648) != 0)
            {
                    return -1f;
            }
            
            if(val_1 <= itemIndex)
            {
                    return -1f;
            }
            
            if(val_1 <= itemIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (itemIndex << 3);
            if(val_1 <= ((true + (itemIndex) << 3) + 32 + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (((true + (itemIndex) << 3) + 32 + 16) << 3);
            return ((true + (itemIndex) << 3) + ((true + (itemIndex) << 3) + 32 + 16) << 3) + 32 + 152.GetItemPos(itemIndex:  (true + (itemIndex) << 3) + 32 + 20);
        }
        public SuperScrollView.LoopStaggeredGridViewItem GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup)
        {
            UnityEngine.Object val_6;
            var val_7;
            if((indexInGroup & 2147483648) != 0)
            {
                goto label_20;
            }
            
            int val_6 = this.mItemTotalCount;
            if(val_6 == 0)
            {
                goto label_20;
            }
            
            if(val_6 <= groupIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (groupIndex << 3);
            if(((this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 24) <= indexInGroup)
            {
                goto label_7;
            }
            
            if(((this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 24) <= indexInGroup)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = (this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 16;
            val_7 = val_7 + (indexInGroup << 2);
            val_6 = this.mOnGetItemByItemIndex.Invoke(arg1:  this, arg2:  ((this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 16 + (indexInGroup) << 2) + 32);
            val_7 = 0;
            if(val_6 == 0)
            {
                    return (SuperScrollView.LoopStaggeredGridViewItem)val_7;
            }
            
            label_30:
            val_1.mItemIndex = ((this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 16 + (indexInGroup) << 2) + 32;
            val_1.mItemIndexInGroup = indexInGroup;
            val_7 = val_6;
            val_1.mStartPosOffset = this.mLayoutParam.mCustomColumnOrRowOffsetArray[(long)groupIndex];
            val_1.mItemCreatedCheckFrameCount = this.mListUpdateCheckFrameCount;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_7;
            label_7:
            if((((this.mItemTotalCount + (groupIndex) << 3) + 32 + 72 + 24) != indexInGroup) || (this.mItemGroupList >= this.mItemTotalCount))
            {
                goto label_20;
            }
            
            val_6 = this.mOnGetItemByItemIndex.Invoke(arg1:  this, arg2:  this.mItemGroupList);
            val_7 = 0;
            if(val_6 == 0)
            {
                    return (SuperScrollView.LoopStaggeredGridViewItem)val_7;
            }
            
            (this.mItemTotalCount + (groupIndex) << 3) + 32 + 72.Add(item:  this.mItemGroupList);
            .mGroupIndex = groupIndex;
            .mIndexInGroup = indexInGroup;
            this.mItemIndexDataList.Add(item:  new SuperScrollView.ItemIndexData());
            if(val_6 != null)
            {
                goto label_30;
            }
            
            throw new NullReferenceException();
            label_20:
            val_7 = 0;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_7;
        }
        private int GetCurShouldAddNewItemGroupIndex()
        {
            System.Collections.Generic.List<SuperScrollView.StaggeredGridItemGroup> val_4;
            var val_5;
            val_4 = this.mItemGroupList;
            if(W21 >= 1)
            {
                    var val_6 = 1;
                do
            {
                var val_1 = val_6 - 1;
                if(20140032 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = 20140032 + (val_1 << 3);
                float val_3 = (20140032 + ((1 - 1)) << 3) + 32.GetShownItemPosMaxValue();
                var val_4 = (val_3 < 0) ? (val_1) : 0;
                if(val_6 >= W21)
            {
                    return (int)val_5;
            }
            
                val_4 = this.mItemGroupList;
                var val_5 = (val_3 < 0) ? (val_3) : 3.402823E+38f;
                val_6 = val_6 + 1;
            }
            while(val_4 != null);
            
                throw new NullReferenceException();
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public void UpdateListViewWithDefault()
        {
            this.UpdateListView(distanceForRecycle0:  this.mDistanceForRecycle0, distanceForRecycle1:  this.mDistanceForRecycle1, distanceForNew0:  this.mDistanceForNew0, distanceForNew1:  this.mDistanceForNew1);
            this.UpdateContentSize();
        }
        private void Update()
        {
            if(this.mListViewInited == false)
            {
                    return;
            }
            
            this.UpdateListViewWithDefault();
            this.ClearAllTmpRecycledItem();
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            this.mLastFrameContainerPos = val_1;
            mem[1152921513643806548] = val_1.y;
            mem[1152921513643806552] = val_1.z;
        }
        public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            object val_4;
            object val_5;
            val_4 = this;
            int val_4 = this.mListUpdateCheckFrameCount;
            val_4 = val_4 + 1;
            this.mListUpdateCheckFrameCount = val_4;
            if(26877952 < 1)
            {
                goto label_5;
            }
            
            var val_5 = 0;
            label_6:
            if(val_4 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            ((this.mListUpdateCheckFrameCount + 1) + 0) + 32.UpdateListViewPart1(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1);
            val_5 = val_5 + 1;
            if(val_5 < 26877952)
            {
                    if(this.mItemGroupList != null)
            {
                goto label_6;
            }
            
            }
            
            label_5:
            val_5 = 1;
            label_12:
            if(val_5 >= 9999)
            {
                goto label_8;
            }
            
            int val_1 = this.GetCurShouldAddNewItemGroupIndex();
            if(val_4 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_1 << 3);
            val_5 = val_5 + 1;
            if((((this.mListUpdateCheckFrameCount + 1) + (val_1) << 3) + 32.UpdateListViewPart2(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_12;
            }
            
            return;
            label_8:
            val_4 = "UpdateListView while loop " + val_5 + " times! something is wrong!"(" times! something is wrong!");
            UnityEngine.Debug.LogError(message:  val_4);
        }
        public float GetContentSize()
        {
            UnityEngine.Rect val_1 = this.mContainerTrans.rect;
            if(this.mIsVertList == false)
            {
                    return (float)val_1.m_XMin.width;
            }
            
            float val_2 = val_1.m_XMin.height;
            return (float)val_1.m_XMin.width;
        }
        public void UpdateContentSize()
        {
            var val_5;
            float val_6;
            Axis val_8;
            bool val_5 = true;
            if(26877952 < 1)
            {
                goto label_2;
            }
            
            var val_6 = 0;
            label_8:
            if(val_5 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_5 = 0f;
            if(((true + 0) + 32 + 152 + 28) > 0f)
            {
                    val_5 = ((true + 0) + 32 + 152 + 28) - ((true + 0) + 32 + 168);
            }
            
            val_6 = val_6 + 1;
            var val_1 = (((true + 0) + 32 + 152 + 28) > 0f) ? ((true + 0) + 32 + 152 + 28) : 0f;
            if(val_6 >= 26877952)
            {
                goto label_7;
            }
            
            if(this.mItemGroupList != null)
            {
                goto label_8;
            }
            
            label_2:
            val_6 = 0f;
            label_7:
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(this.mIsVertList != false)
            {
                    if(val_2.m_XMin.height == val_6)
            {
                    return;
            }
            
                val_8 = 1;
            }
            else
            {
                    if(val_2.m_XMin.width == val_6)
            {
                    return;
            }
            
                val_8 = 0;
            }
            
            this.mContainerTrans.SetSizeWithCurrentAnchors(axis:  val_8, size:  val_6);
        }
        public LoopStaggeredGridView()
        {
            this.mItemPoolDict = new System.Collections.Generic.Dictionary<System.String, SuperScrollView.StaggeredGridItemPool>();
            this.mItemPoolList = new System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPool>();
            this.mItemPrefabDataList = new System.Collections.Generic.List<SuperScrollView.StaggeredGridItemPrefabConfData>();
            this.mItemGroupList = new System.Collections.Generic.List<SuperScrollView.StaggeredGridItemGroup>();
            this.mItemIndexDataList = new System.Collections.Generic.List<SuperScrollView.ItemIndexData>();
            this.mItemDefaultWithPaddingSize = 20f;
            this.mItemWorldCorners = new UnityEngine.Vector3[4];
            this.mViewPortRectLocalCorners = new UnityEngine.Vector3[4];
            this.mDistanceForRecycle0 = ;
            this.mDistanceForNew0 = ;
            this.mDistanceForRecycle1 = 300f;
            this.mDistanceForNew1 = 200f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.mLastFrameContainerPos = val_8;
            mem[1152921513644382740] = val_8.y;
            mem[1152921513644382744] = val_8.z;
        }
    
    }

}
