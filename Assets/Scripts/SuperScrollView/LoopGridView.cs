using UnityEngine;

namespace SuperScrollView
{
    public class LoopGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SuperScrollView.GridItemPool> mItemPoolDict;
        private System.Collections.Generic.List<SuperScrollView.GridItemPool> mItemPoolList;
        private System.Collections.Generic.List<SuperScrollView.GridViewItemPrefabConfData> mItemPrefabDataList;
        private SuperScrollView.GridItemArrangeType mArrangeType;
        private UnityEngine.RectTransform mContainerTrans;
        private UnityEngine.UI.ScrollRect mScrollRect;
        private UnityEngine.RectTransform mScrollRectTransform;
        private UnityEngine.RectTransform mViewPortRectTransform;
        private int mItemTotalCount;
        private int mFixedRowOrColumnCount;
        private UnityEngine.RectOffset mPadding;
        private UnityEngine.Vector2 mItemPadding;
        private UnityEngine.Vector2 mItemSize;
        private UnityEngine.Vector2 mItemRecycleDistance;
        private UnityEngine.Vector2 mItemSizeWithPadding;
        private UnityEngine.Vector2 mStartPadding;
        private UnityEngine.Vector2 mEndPadding;
        private System.Func<SuperScrollView.LoopGridView, int, int, int, SuperScrollView.LoopGridViewItem> mOnGetItemByRowColumn;
        private System.Collections.Generic.List<SuperScrollView.GridItemGroup> mItemGroupObjPool;
        private System.Collections.Generic.List<SuperScrollView.GridItemGroup> mItemGroupList;
        private bool mIsDraging;
        private int mRowCount;
        private int mColumnCount;
        public System.Action<UnityEngine.EventSystems.PointerEventData> mOnBeginDragAction;
        public System.Action<UnityEngine.EventSystems.PointerEventData> mOnDragingAction;
        public System.Action<UnityEngine.EventSystems.PointerEventData> mOnEndDragAction;
        private float mSmoothDumpVel;
        private float mSmoothDumpRate;
        private float mSnapFinishThreshold;
        private float mSnapVecThreshold;
        private bool mItemSnapEnable;
        private SuperScrollView.GridFixedType mGridFixedType;
        public System.Action<SuperScrollView.LoopGridView, SuperScrollView.LoopGridViewItem> mOnSnapItemFinished;
        public System.Action<SuperScrollView.LoopGridView> mOnSnapNearestChanged;
        private int mLeftSnapUpdateExtraCount;
        private UnityEngine.Vector2 mViewPortSnapPivot;
        private UnityEngine.Vector2 mItemSnapPivot;
        private SuperScrollView.LoopGridView.SnapData mCurSnapData;
        private UnityEngine.Vector3 mLastSnapCheckPos;
        private bool mListViewInited;
        private int mListUpdateCheckFrameCount;
        private SuperScrollView.LoopGridView.ItemRangeData mCurFrameItemRangeData;
        private int mNeedCheckContentPosLeftCount;
        private SuperScrollView.ClickEventListener mScrollBarClickEventListener1;
        private SuperScrollView.ClickEventListener mScrollBarClickEventListener2;
        private SuperScrollView.RowColumnPair mCurSnapNearestItemRowColumn;
        
        // Properties
        public SuperScrollView.GridItemArrangeType ArrangeType { get; set; }
        public System.Collections.Generic.List<SuperScrollView.GridViewItemPrefabConfData> ItemPrefabDataList { get; }
        public int ItemTotalCount { get; }
        public UnityEngine.RectTransform ContainerTrans { get; }
        public float ViewPortWidth { get; }
        public float ViewPortHeight { get; }
        public UnityEngine.UI.ScrollRect ScrollRect { get; }
        public bool IsDraging { get; }
        public bool ItemSnapEnable { get; set; }
        public UnityEngine.Vector2 ItemSize { get; set; }
        public UnityEngine.Vector2 ItemPadding { get; set; }
        public UnityEngine.Vector2 ItemSizeWithPadding { get; }
        public UnityEngine.RectOffset Padding { get; set; }
        public SuperScrollView.RowColumnPair CurSnapNearestItemRowColumn { get; }
        
        // Methods
        public SuperScrollView.GridItemArrangeType get_ArrangeType()
        {
            return (SuperScrollView.GridItemArrangeType)this.mArrangeType;
        }
        public void set_ArrangeType(SuperScrollView.GridItemArrangeType value)
        {
            this.mArrangeType = value;
        }
        public System.Collections.Generic.List<SuperScrollView.GridViewItemPrefabConfData> get_ItemPrefabDataList()
        {
            return (System.Collections.Generic.List<SuperScrollView.GridViewItemPrefabConfData>)this.mItemPrefabDataList;
        }
        public int get_ItemTotalCount()
        {
            return (int)this.mItemTotalCount;
        }
        public UnityEngine.RectTransform get_ContainerTrans()
        {
            return (UnityEngine.RectTransform)this.mContainerTrans;
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
        public UnityEngine.UI.ScrollRect get_ScrollRect()
        {
            return (UnityEngine.UI.ScrollRect)this.mScrollRect;
        }
        public bool get_IsDraging()
        {
            return (bool)this.mIsDraging;
        }
        public bool get_ItemSnapEnable()
        {
            return (bool)this.mItemSnapEnable;
        }
        public void set_ItemSnapEnable(bool value)
        {
            this.mItemSnapEnable = value;
        }
        public UnityEngine.Vector2 get_ItemSize()
        {
            return new UnityEngine.Vector2() {x = this.mItemSize};
        }
        public void set_ItemSize(UnityEngine.Vector2 value)
        {
            this.SetItemSize(newSize:  new UnityEngine.Vector2() {x = value.x, y = value.y});
        }
        public UnityEngine.Vector2 get_ItemPadding()
        {
            return new UnityEngine.Vector2() {x = this.mItemPadding};
        }
        public void set_ItemPadding(UnityEngine.Vector2 value)
        {
            this.SetItemPadding(newPadding:  new UnityEngine.Vector2() {x = value.x, y = value.y});
        }
        public UnityEngine.Vector2 get_ItemSizeWithPadding()
        {
            return new UnityEngine.Vector2() {x = this.mItemSizeWithPadding};
        }
        public UnityEngine.RectOffset get_Padding()
        {
            return (UnityEngine.RectOffset)this.mPadding;
        }
        public void set_Padding(UnityEngine.RectOffset value)
        {
            this.SetPadding(newPadding:  value);
        }
        public SuperScrollView.GridViewItemPrefabConfData GetItemPrefabConfData(string prefabName)
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
            val_10 = public System.Boolean List.Enumerator<SuperScrollView.GridViewItemPrefabConfData>::MoveNext();
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
            return (SuperScrollView.GridViewItemPrefabConfData)val_12;
        }
        public void InitGridView(int itemTotalCount, System.Func<SuperScrollView.LoopGridView, int, int, int, SuperScrollView.LoopGridViewItem> onGetItemByRowColumn, SuperScrollView.LoopGridViewSettingParam settingParam, SuperScrollView.LoopGridViewInitParam initParam)
        {
            SuperScrollView.LoopGridViewSettingParam val_8;
            int val_9;
            object val_10;
            val_8 = settingParam;
            val_9 = itemTotalCount;
            if(this.mListViewInited == false)
            {
                goto label_1;
            }
            
            val_10 = "LoopGridView.InitListView method can be called only once.";
            goto label_4;
            label_1:
            this.mListViewInited = true;
            if((val_9 & 2147483648) != 0)
            {
                    UnityEngine.Debug.LogError(message:  "itemTotalCount is  < 0");
                val_9 = 0;
            }
            
            if(val_8 != null)
            {
                    this.UpdateFromSettingParam(param:  val_8);
            }
            
            if(initParam != null)
            {
                    this.mSmoothDumpRate = initParam.mSmoothDumpRate;
                this.mSnapFinishThreshold = initParam.mSnapFinishThreshold;
                this.mSnapVecThreshold = initParam.mSnapVecThreshold;
            }
            
            UnityEngine.UI.ScrollRect val_2 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            this.mScrollRect = val_2;
            val_8 = 1152921504729477120;
            if(val_2 != 0)
            {
                goto label_13;
            }
            
            val_10 = "ListView Init Failed! ScrollRect component not found!";
            label_4:
            UnityEngine.Debug.LogError(message:  val_10);
            return;
            label_13:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mScrollRectTransform = this.mScrollRect.GetComponent<UnityEngine.RectTransform>();
            this.mContainerTrans = this.mScrollRect.m_Content;
            this.mViewPortRectTransform = this.mScrollRect.m_Viewport;
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
            
            this.SetScrollbarListener();
            this.AdjustViewPortPivot();
            this.AdjustContainerAnchorAndPivot();
            this.InitItemPool();
            this.mOnGetItemByRowColumn = onGetItemByRowColumn;
            this.mNeedCheckContentPosLeftCount = 4;
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mItemTotalCount = val_9;
            this.UpdateAllGridSetting();
        }
        public void SetListItemCount(int itemCount, bool resetPos = True)
        {
            if((itemCount & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.mItemTotalCount == itemCount)
            {
                    return;
            }
            
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mItemTotalCount = itemCount;
            this.UpdateColumnRowCount();
            this.UpdateContentSize();
            if(this.mNeedCheckContentPosLeftCount <= 0)
            {
                    this.mNeedCheckContentPosLeftCount = 1;
            }
            
            if(this.mItemTotalCount != 0)
            {
                    this.VaildAndSetContainerPos();
                this.UpdateGridViewContent();
                this.ClearAllTmpRecycledItem();
                if(resetPos == false)
            {
                    return;
            }
            
                this.MovePanelToItemByRowColumn(row:  0, column:  0, offsetX:  0f, offsetY:  0f);
                return;
            }
            
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
        }
        public SuperScrollView.LoopGridViewItem NewListViewItem(string itemPrefabName)
        {
            var val_8;
            if((this.mItemPoolDict.TryGetValue(key:  itemPrefabName, value: out  0)) != false)
            {
                    SuperScrollView.LoopGridViewItem val_3 = val_1.GetItem();
                val_8 = val_3;
                UnityEngine.RectTransform val_4 = val_3.GetComponent<UnityEngine.RectTransform>();
                val_4.SetParent(p:  this.mContainerTrans);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
                val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                val_4.localEulerAngles = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_3.mParentGridView = this;
                return (SuperScrollView.LoopGridViewItem)val_8;
            }
            
            val_8 = 0;
            return (SuperScrollView.LoopGridViewItem)val_8;
        }
        public void RefreshItemByItemIndex(int itemIndex)
        {
            if((itemIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.mItemTotalCount <= itemIndex)
            {
                    return;
            }
            
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            SuperScrollView.RowColumnPair val_1 = this.GetRowColumnByItemIndex(itemIndex:  itemIndex);
            this.RefreshItemByRowColumn(row:  val_1.mRow, column:  val_1.mRow >> 32);
        }
        public void RefreshItemByRowColumn(int row, int column)
        {
            var val_11;
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            if(this.mGridFixedType != 0)
            {
                    SuperScrollView.GridItemGroup val_1 = this.GetShownGroup(groupIndex:  column);
                if(val_1 == null)
            {
                    return;
            }
            
                val_11 = val_1;
                SuperScrollView.LoopGridViewItem val_2 = val_1.GetItemByRow(row:  row);
            }
            else
            {
                    SuperScrollView.GridItemGroup val_3 = this.GetShownGroup(groupIndex:  row);
                if(val_3 == null)
            {
                    return;
            }
            
                val_11 = val_3;
                SuperScrollView.LoopGridViewItem val_4 = val_3.GetItemByColumn(column:  column);
            }
            
            if(val_4 == 0)
            {
                    return;
            }
            
            SuperScrollView.LoopGridViewItem val_6 = this.GetNewItemByRowColumn(row:  row, column:  column);
            if(val_6 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = val_4.CachedRectTransform.anchoredPosition3D;
            val_11.ReplaceItem(curItem:  val_4, newItem:  val_6);
            this.RecycleItemTmp(item:  val_4);
            val_6.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.ClearAllTmpRecycledItem();
        }
        public void ClearSnapData()
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.mSnapStatus = 0;
                this.mCurSnapData.mIsForceSnapTo = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetSnapTargetItemRowColumn(int row, int column)
        {
            this.mCurSnapData.mSnapTarget = row & (~(row >> 31));
            mem2[0] = column & (~(column >> 31));
            this.mCurSnapData.mSnapStatus = 1;
            this.mCurSnapData.mIsForceSnapTo = 1;
        }
        public SuperScrollView.RowColumnPair get_CurSnapNearestItemRowColumn()
        {
            return new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapNearestItemRowColumn, mColumn = this.mCurSnapNearestItemRowColumn};
        }
        public void ForceSnapUpdateCheck()
        {
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        public void ForceToCheckContentPos()
        {
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void MovePanelToItemByIndex(int itemIndex, float offsetX = 0, float offsetY = 0)
        {
            int val_4 = this.mItemTotalCount;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4 = (val_4 > itemIndex) ? itemIndex : (val_4 - 1);
            itemIndex = val_4 & (~(val_4 >> 31));
            SuperScrollView.RowColumnPair val_2 = this.GetRowColumnByItemIndex(itemIndex:  itemIndex);
            this.MovePanelToItemByRowColumn(row:  val_2.mRow, column:  val_2.mRow >> 32, offsetX:  offsetX, offsetY:  offsetY);
        }
        public void MovePanelToItemByRowColumn(int row, int column, float offsetX = 0, float offsetY = 0)
        {
            float val_18;
            float val_19;
            float val_21;
            float val_22;
            float val_19 = offsetY;
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            if(this.mItemTotalCount == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = this.GetItemPos(row:  row, column:  column);
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            val_18 = val_2.x;
            val_19 = val_2.y;
            if(this.mScrollRect.m_Horizontal != false)
            {
                    UnityEngine.Rect val_3 = this.mContainerTrans.rect;
                val_21 = val_3.m_XMin.width - this.ViewPortWidth;
                val_22 = 0f;
                float val_6 = UnityEngine.Mathf.Max(a:  val_21, b:  val_22);
                if(val_6 > 0f)
            {
                    float val_7 = offsetX - val_1.x;
                val_22 = val_6;
                val_21 = val_7;
                val_18 = (UnityEngine.Mathf.Min(a:  System.Math.Abs(val_7), b:  val_22)) * (UnityEngine.Mathf.Sign(f:  val_21));
            }
            
            }
            
            if(this.mScrollRect.m_Vertical != false)
            {
                    UnityEngine.Rect val_10 = this.mContainerTrans.rect;
                val_21 = val_10.m_XMin.height - this.ViewPortHeight;
                val_22 = 0f;
                float val_13 = UnityEngine.Mathf.Max(a:  val_21, b:  val_22);
                if(val_13 > 0f)
            {
                    val_19 = val_19 - val_1.y;
                val_22 = val_13;
                val_21 = val_19;
                val_19 = (UnityEngine.Mathf.Min(a:  System.Math.Abs(val_19), b:  val_22)) * (UnityEngine.Mathf.Sign(f:  val_21));
            }
            
            }
            
            UnityEngine.Vector3 val_16 = this.mContainerTrans.anchoredPosition3D;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z})) != false)
            {
                    this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_18, y = val_19, z = val_2.z};
            }
            
            this.VaildAndSetContainerPos();
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void RefreshAllShownItem()
        {
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            if(this.mNeedCheckContentPosLeftCount <= 0)
            {
                    this.mNeedCheckContentPosLeftCount = 1;
            }
            
            this.RecycleAllItem();
            this.UpdateGridViewContent();
        }
        public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            this.mIsDraging = true;
            if(this.mOnBeginDragAction == null)
            {
                    return;
            }
            
            this.mOnBeginDragAction.Invoke(obj:  eventData);
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mIsDraging = false;
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mOnEndDragAction == null)
            {
                    return;
            }
            
            this.mOnEndDragAction.Invoke(obj:  eventData);
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            if(this.mOnDragingAction == null)
            {
                    return;
            }
            
            this.mOnDragingAction.Invoke(obj:  eventData);
        }
        public int GetItemIndexByRowColumn(int row, int column)
        {
            int val_3 = this.mFixedRowOrColumnCount;
            val_3 = row + (val_3 * column);
            return (int)(this.mGridFixedType == 0) ? (column + (val_3 * row)) : (val_3);
        }
        public SuperScrollView.RowColumnPair GetRowColumnByItemIndex(int itemIndex)
        {
            int val_5;
            int val_6;
            int val_1 = itemIndex & (~(itemIndex >> 31));
            if(this.mGridFixedType != 0)
            {
                    val_5 = val_1 / this.mFixedRowOrColumnCount;
                val_6 = val_1 - (val_5 * this.mFixedRowOrColumnCount);
            }
            else
            {
                    val_6 = val_1 / this.mFixedRowOrColumnCount;
                val_5 = val_1 - (val_6 * this.mFixedRowOrColumnCount);
            }
            
            SuperScrollView.RowColumnPair val_2 = new SuperScrollView.RowColumnPair(row1:  val_6, column1:  val_5);
            return new SuperScrollView.RowColumnPair() {mRow = val_2.mRow, mColumn = val_2.mRow};
        }
        public UnityEngine.Vector2 GetItemAbsPos(int row, int column)
        {
            UnityEngine.Vector2 val_4 = this.mItemSizeWithPadding;
            UnityEngine.Vector2 val_5 = this.mStartPadding;
            val_4 = val_4 * (float)column;
            val_5 = val_5 + val_4;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_5, y:  S1 + (S3 * (float)row));
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public UnityEngine.Vector2 GetItemPos(int row, int column)
        {
            UnityEngine.Vector2 val_1 = this.GetItemAbsPos(row:  row, column:  column);
            if(this.mArrangeType <= 3)
            {
                    var val_4 = 20151976 + (this.mArrangeType) << 2;
                val_4 = val_4 + 20151976;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            }
        
        }
        public SuperScrollView.LoopGridViewItem GetShownItemByItemIndex(int itemIndex)
        {
            if((itemIndex & 2147483648) != 0)
            {
                    return 0;
            }
            
            if(this.mItemTotalCount <= itemIndex)
            {
                    return 0;
            }
            
            if(this.mItemGroupList == null)
            {
                    return 0;
            }
            
            SuperScrollView.RowColumnPair val_1 = this.GetRowColumnByItemIndex(itemIndex:  itemIndex);
            return this.GetShownItemByRowColumn(row:  val_1.mRow, column:  val_1.mRow >> 32);
        }
        public SuperScrollView.LoopGridViewItem GetShownItemByRowColumn(int row, int column)
        {
            if(this.mItemGroupList == null)
            {
                    return 0;
            }
            
            if(this.mGridFixedType != 0)
            {
                    SuperScrollView.GridItemGroup val_1 = this.GetShownGroup(groupIndex:  column);
                if(val_1 == null)
            {
                    return 0;
            }
            
                return val_1.GetItemByRow(row:  row);
            }
            
            SuperScrollView.GridItemGroup val_2 = this.GetShownGroup(groupIndex:  row);
            if(val_2 == null)
            {
                    return 0;
            }
            
            return val_2.GetItemByColumn(column:  column);
        }
        public void UpdateAllGridSetting()
        {
            this.UpdateStartEndPadding();
            this.UpdateItemSize();
            this.UpdateColumnRowCount();
            this.UpdateContentSize();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void SetGridFixedGroupCount(SuperScrollView.GridFixedType fixedType, int count)
        {
            if(this.mGridFixedType == fixedType)
            {
                    if(this.mFixedRowOrColumnCount == count)
            {
                    return;
            }
            
            }
            
            this.mGridFixedType = fixedType;
            this.mFixedRowOrColumnCount = count;
            this.UpdateColumnRowCount();
            this.UpdateContentSize();
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            this.RecycleAllItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void SetItemSize(UnityEngine.Vector2 newSize)
        {
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = newSize.x, y = newSize.y}, rhs:  new UnityEngine.Vector2() {x = this.mItemSize, y = V10.16B})) == true)
            {
                    return;
            }
            
            this.mItemSize = newSize;
            mem[1152921513599611284] = newSize.y;
            this.UpdateItemSize();
            this.UpdateContentSize();
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            this.RecycleAllItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void SetItemPadding(UnityEngine.Vector2 newPadding)
        {
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = newPadding.x, y = newPadding.y}, rhs:  new UnityEngine.Vector2() {x = this.mItemPadding, y = V10.16B})) == true)
            {
                    return;
            }
            
            this.mItemPadding = newPadding;
            mem[1152921513599731468] = newPadding.y;
            this.UpdateItemSize();
            this.UpdateContentSize();
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            this.RecycleAllItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void SetPadding(UnityEngine.RectOffset newPadding)
        {
            if(this.mPadding == newPadding)
            {
                    return;
            }
            
            this.mPadding = newPadding;
            this.UpdateStartEndPadding();
            this.UpdateContentSize();
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            this.RecycleAllItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            if(this.mNeedCheckContentPosLeftCount > 0)
            {
                    return;
            }
            
            this.mNeedCheckContentPosLeftCount = 1;
        }
        public void UpdateContentSize()
        {
            float val_7 = (float)this.mRowCount;
            val_7 = S2 * val_7;
            val_7 = S1 + val_7;
            val_7 = val_7 - S3;
            float val_1 = S4 + val_7;
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(val_2.m_XMin.height != val_1)
            {
                    this.mContainerTrans.SetSizeWithCurrentAnchors(axis:  1, size:  val_1);
            }
            
            float val_8 = (float)this.mColumnCount;
            val_8 = this.mItemSizeWithPadding * val_8;
            val_8 = this.mStartPadding + val_8;
            val_8 = val_8 - this.mItemPadding;
            float val_4 = this.mEndPadding + val_8;
            UnityEngine.Rect val_5 = this.mContainerTrans.rect;
            if(val_5.m_XMin.width == val_4)
            {
                    return;
            }
            
            this.mContainerTrans.SetSizeWithCurrentAnchors(axis:  0, size:  val_4);
        }
        public void VaildAndSetContainerPos()
        {
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_2 = this.GetContainerVaildPos(curX:  val_1.x, curY:  val_1.y);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void ClearAllTmpRecycledItem()
        {
            bool val_1 = true;
            if(26873856 < 1)
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
                if(val_2 >= 26873856)
            {
                    return;
            }
            
            }
            while(this.mItemPoolList != null);
            
            throw new NullReferenceException();
        }
        public void RecycleAllItem()
        {
            List.Enumerator<T> val_1 = this.mItemGroupList.GetEnumerator();
            label_3:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            this.RecycleItemGroupTmp(group:  0);
            goto label_3;
            label_2:
            0.Dispose();
            this.mItemGroupList.Clear();
        }
        public void UpdateGridViewContent()
        {
            System.Collections.Generic.List<SuperScrollView.GridItemGroup> val_20;
            System.Collections.Generic.List<SuperScrollView.GridItemGroup> val_22;
            System.Collections.Generic.List<SuperScrollView.GridItemGroup> val_23;
            int val_19 = this.mListUpdateCheckFrameCount;
            val_19 = val_19 + 1;
            this.mListUpdateCheckFrameCount = val_19;
            if(this.mItemTotalCount == 0)
            {
                goto label_1;
            }
            
            this.UpdateCurFrameItemRangeData();
            if(this.mGridFixedType == 0)
            {
                goto label_4;
            }
            
            int val_1 = val_19 - 1;
            if(<0)
            {
                goto label_5;
            }
            
            label_12:
            if(val_19 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_1 << 3);
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) >= this.mCurFrameItemRangeData.mMinColumn)
            {
                    if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) <= this.mCurFrameItemRangeData.mMaxColumn)
            {
                goto label_9;
            }
            
            }
            
            this.RecycleItemGroupTmp(group:  ((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32);
            this.mItemGroupList.RemoveAt(index:  val_1);
            label_9:
            val_20 = this.mItemGroupList;
            val_1 = val_1 - 1;
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) >= 0)
            {
                goto label_12;
            }
            
            label_5:
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) == 0)
            {
                    val_2.mGroupIndex = this.mCurFrameItemRangeData.mMinColumn;
                this.mItemGroupList.Add(item:  this.GetOneItemGroupObj());
                val_20 = this.mItemGroupList;
            }
            
            do
            {
                if((public System.Void System.Collections.Generic.List<SuperScrollView.GridItemGroup>::Add(SuperScrollView.GridItemGroup item)) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_3.mGroupIndex = ("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + 32 + 20 - 1);
                this.mItemGroupList.Insert(index:  0, item:  this.GetOneItemGroupObj());
            }
            while(this.mItemGroupList != null);
            
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = this.mItemGroupList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_8.mGroupIndex = ((("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 - 1)) << 3) + 32 + 20 + ((("The;
                this.mItemGroupList.Add(item:  this.GetOneItemGroupObj());
            }
            while(this.mItemGroupList != null);
            
            if(1152921513600515552 < 1)
            {
                    return;
            }
            
            var val_20 = 0;
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                this.UpdateColumnItemGroupForRecycleAndNew(group:  (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 - 1)) << 3) + 32 + 20 + 0) + 32);
                val_20 = val_20 + 1;
                if(val_20 >= 1152921513600515552)
            {
                    return;
            }
            
            }
            while(this.mItemGroupList != null);
            
            label_1:
            if(this.mItemGroupList < 1)
            {
                    return;
            }
            
            this.RecycleAllItem();
            return;
            label_4:
            int val_10 = val_19 - 1;
            if(<0)
            {
                goto label_46;
            }
            
            label_53:
            if(val_19 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_10 << 3);
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) >= this.mCurFrameItemRangeData.mMinRow)
            {
                    if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) <= this.mCurFrameItemRangeData.mMaxRow)
            {
                goto label_50;
            }
            
            }
            
            this.RecycleItemGroupTmp(group:  ((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32);
            this.mItemGroupList.RemoveAt(index:  val_10);
            label_50:
            val_23 = this.mItemGroupList;
            val_10 = val_10 - 1;
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) >= 0)
            {
                goto label_53;
            }
            
            label_46:
            if((((this.mListUpdateCheckFrameCount + 1) + (((this.mListUpdateCheckFrameCount + 1) - 1)) << 3) + 32 + 20) == 0)
            {
                    val_11.mGroupIndex = this.mCurFrameItemRangeData.mMinRow;
                this.mItemGroupList.Add(item:  this.GetOneItemGroupObj());
                val_23 = this.mItemGroupList;
            }
            
            do
            {
                if((public System.Void System.Collections.Generic.List<SuperScrollView.GridItemGroup>::Add(SuperScrollView.GridItemGroup item)) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12.mGroupIndex = ("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + 32 + 20 - 1);
                this.mItemGroupList.Insert(index:  0, item:  this.GetOneItemGroupObj());
            }
            while(this.mItemGroupList != null);
            
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = this.mItemGroupList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17.mGroupIndex = ((("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 - 1)) << 3) + 32 + 20 + ((("The;
                this.mItemGroupList.Add(item:  this.GetOneItemGroupObj());
            }
            while(this.mItemGroupList != null);
            
            if(1152921513600515552 < 1)
            {
                    return;
            }
            
            var val_21 = 0;
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                this.UpdateRowItemGroupForRecycleAndNew(group:  (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 + (("The operation is not allowed on non-connected sockets.".__il2cppRuntimeField_14 - 1)) << 3) + 32 + 20 + 0) + 32);
                val_21 = val_21 + 1;
                if(val_21 >= 1152921513600515552)
            {
                    return;
            }
            
                val_22 = this.mItemGroupList;
            }
            while(val_22 != null);
            
            throw new NullReferenceException();
        }
        public void UpdateStartEndPadding()
        {
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_15 = 20151992 + (this.mArrangeType) << 2;
            val_15 = val_15 + 20151992;
            goto (20151992 + (this.mArrangeType) << 2 + 20151992);
        }
        public void UpdateItemSize()
        {
            UnityEngine.Vector2 val_8 = this.mItemSize;
            if((val_8 > 0f) && (S9 > 0f))
            {
                    UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8, y = V9.16B}, b:  new UnityEngine.Vector2() {x = this.mItemPadding, y = V10.16B});
                this.mItemSizeWithPadding = val_1;
                mem[1152921513600974932] = val_1.y;
                return;
            }
            
            if((W9 != 0) && (26873856 != 0))
            {
                    UnityEngine.RectTransform val_3 = GetComponent<UnityEngine.RectTransform>();
                if(val_3 != 0)
            {
                    UnityEngine.Rect val_5 = val_3.rect;
                UnityEngine.Vector2 val_6 = val_5.m_XMin.size;
                this.mItemSize = val_6;
                mem[1152921513600974916] = val_6.y;
                val_8 = val_6.y;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_8}, b:  new UnityEngine.Vector2() {x = this.mItemPadding, y = V10.16B});
                this.mItemSizeWithPadding = val_7;
                mem[1152921513600974932] = val_7.y;
            }
            
            }
            
            if(this.mItemSize > 0f)
            {
                    if(this.mItemSize > 0f)
            {
                    return;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "Error, ItemSize is invaild.");
        }
        public void UpdateColumnRowCount()
        {
            if(this.mGridFixedType != 0)
            {
                    int val_1 = this.mItemTotalCount / this.mFixedRowOrColumnCount;
                this.mRowCount = this.mFixedRowOrColumnCount;
                this.mColumnCount = ((this.mItemTotalCount - (val_1 * this.mFixedRowOrColumnCount)) > 0) ? (val_1 + 1) : (val_1);
                if(this.mItemTotalCount > this.mFixedRowOrColumnCount)
            {
                    return;
            }
            
                this.mRowCount = this.mItemTotalCount;
                return;
            }
            
            int val_4 = this.mItemTotalCount / this.mFixedRowOrColumnCount;
            this.mRowCount = ((this.mItemTotalCount - (val_4 * this.mFixedRowOrColumnCount)) > 0) ? (val_4 + 1) : (val_4);
            this.mColumnCount = this.mFixedRowOrColumnCount;
            if(this.mItemTotalCount > this.mFixedRowOrColumnCount)
            {
                    return;
            }
            
            this.mColumnCount = this.mItemTotalCount;
        }
        private bool IsContainerTransCanMove()
        {
            UnityEngine.UI.ScrollRect val_7;
            var val_8;
            if(this.mItemTotalCount == 0)
            {
                goto label_6;
            }
            
            val_7 = this.mScrollRect;
            if(this.mScrollRect.m_Horizontal == false)
            {
                goto label_2;
            }
            
            UnityEngine.Rect val_1 = this.mContainerTrans.rect;
            if(val_1.m_XMin.width > this.ViewPortWidth)
            {
                goto label_8;
            }
            
            val_7 = this.mScrollRect;
            label_2:
            if(this.mScrollRect.m_Vertical == false)
            {
                goto label_6;
            }
            
            UnityEngine.Rect val_4 = this.mContainerTrans.rect;
            if(val_4.m_XMin.height > this.ViewPortHeight)
            {
                goto label_8;
            }
            
            label_6:
            val_8 = 0;
            return (bool)val_8;
            label_8:
            val_8 = 1;
            return (bool)val_8;
        }
        private void RecycleItemGroupTmp(SuperScrollView.GridItemGroup group)
        {
            if(group == null)
            {
                    return;
            }
            
            goto label_2;
            label_5:
            this.RecycleItemTmp(item:  group.RemoveFirst());
            label_2:
            if(group.mFirst != 0)
            {
                goto label_5;
            }
            
            group.Clear();
            this.RecycleOneItemGroupObj(obj:  group);
        }
        private void RecycleItemTmp(SuperScrollView.LoopGridViewItem item)
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
        private void AdjustViewPortPivot()
        {
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_2 = 20151944 + (this.mArrangeType) << 2;
            val_2 = val_2 + 20151944;
            goto (20151944 + (this.mArrangeType) << 2 + 20151944);
        }
        private void AdjustContainerAnchorAndPivot()
        {
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_10 = 20151960 + (this.mArrangeType) << 2;
            val_10 = val_10 + 20151960;
            goto (20151960 + (this.mArrangeType) << 2 + 20151960);
        }
        private void AdjustItemAnchorAndPivot(UnityEngine.RectTransform rtf)
        {
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_10 = 20152024 + (this.mArrangeType) << 2;
            val_10 = val_10 + 20152024;
            goto (20152024 + (this.mArrangeType) << 2 + 20152024);
        }
        private void InitItemPool()
        {
            var val_2;
            var val_3;
            UnityEngine.Object val_16;
            System.Collections.Generic.Dictionary<System.String, SuperScrollView.GridItemPool> val_17;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_31:
            val_16 = public System.Boolean List.Enumerator<SuperScrollView.GridViewItemPrefabConfData>::MoveNext();
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
            val_16 = val_9;
            this.AdjustItemAnchorAndPivot(rtf:  val_16);
            val_17 = mem[val_2 + 16];
            val_17 = val_2 + 16;
            if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = 0;
            if((val_17.GetComponent<SuperScrollView.LoopGridViewItem>()) == val_16)
            {
                    val_17 = mem[val_2 + 16];
                val_17 = val_2 + 16;
                if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
                SuperScrollView.LoopGridViewItem val_14 = val_17.AddComponent<SuperScrollView.LoopGridViewItem>();
            }
            
            SuperScrollView.GridItemPool val_15 = null;
            val_16 = 0;
            val_15 = new SuperScrollView.GridItemPool();
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = mem[val_2 + 16];
            val_16 = val_2 + 16;
            val_15.Init(prefabObj:  val_16, createCount:  val_2 + 24, parent:  this.mContainerTrans);
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
        private SuperScrollView.LoopGridViewItem GetNewItemByRowColumn(int row, int column)
        {
            var val_5;
            int val_5 = this.mFixedRowOrColumnCount;
            val_5 = row + (val_5 * column);
            int val_2 = (this.mGridFixedType == 0) ? (column + (val_5 * row)) : (val_5);
            if(((val_2 & 2147483648) == 0) && (val_2 < this.mItemTotalCount))
            {
                    SuperScrollView.LoopGridViewItem val_3 = this.mOnGetItemByRowColumn.Invoke(arg1:  this, arg2:  val_2, arg3:  row, arg4:  column);
                val_5 = 0;
                if(val_3 == 0)
            {
                    return (SuperScrollView.LoopGridViewItem)val_5;
            }
            
                val_3.mPrevItem = 0;
                val_3.mNextItem = 0;
                val_3.mItemIndex = val_2;
                val_3.mRow = row;
                val_3.mColumn = column;
                val_5 = val_3;
                val_3.mItemCreatedCheckFrameCount = this.mListUpdateCheckFrameCount;
                return (SuperScrollView.LoopGridViewItem)val_5;
            }
            
            val_5 = 0;
            return (SuperScrollView.LoopGridViewItem)val_5;
        }
        private SuperScrollView.RowColumnPair GetCeilItemRowColumnAtGivenAbsPos(float ax, float ay)
        {
            ax = System.Math.Abs(ay) - ax;
            ax = ax / ay;
            UnityEngine.Vector2 val_13 = this.mStartPadding;
            int val_2 = (UnityEngine.Mathf.CeilToInt(f:  ax)) - 1;
            val_13 = System.Math.Abs(ax) - val_13;
            val_13 = val_13 / this.mItemSizeWithPadding;
            int val_4 = (UnityEngine.Mathf.CeilToInt(f:  val_13)) - 1;
            int val_5 = val_2 & (~(val_2 >> 31));
            val_4 = val_4 & (~(val_4 >> 31));
            SuperScrollView.RowColumnPair val_10 = new SuperScrollView.RowColumnPair(row1:  (val_5 < this.mRowCount) ? (val_5) : (this.mRowCount - 1), column1:  (val_4 < this.mColumnCount) ? (val_4) : (this.mColumnCount - 1));
            return new SuperScrollView.RowColumnPair() {mRow = val_10.mRow, mColumn = val_10.mRow};
        }
        private void Update()
        {
            if(this.mListViewInited == false)
            {
                    return;
            }
            
            this.UpdateSnapMove(immediate:  false, forceSendEvent:  false);
            this.UpdateGridViewContent();
            this.ClearAllTmpRecycledItem();
        }
        private SuperScrollView.GridItemGroup CreateItemGroup(int groupIndex)
        {
            val_1.mGroupIndex = groupIndex;
            return (SuperScrollView.GridItemGroup)this.GetOneItemGroupObj();
        }
        private UnityEngine.Vector2 GetContainerMovedDistance()
        {
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_3 = this.GetContainerVaildPos(curX:  val_1.x, curY:  val_2.y);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  System.Math.Abs(val_3.x), y:  System.Math.Abs(val_3.y));
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        private UnityEngine.Vector2 GetContainerVaildPos(float curX, float curY)
        {
            float val_13;
            float val_14;
            val_13 = curY;
            val_14 = curX;
            UnityEngine.Rect val_1 = this.mContainerTrans.rect;
            float val_3 = this.ViewPortWidth;
            val_3 = val_1.m_XMin.width - val_3;
            float val_4 = UnityEngine.Mathf.Max(a:  val_3, b:  0f);
            UnityEngine.Rect val_5 = this.mContainerTrans.rect;
            float val_7 = this.ViewPortHeight;
            val_7 = val_5.m_XMin.height - val_7;
            if(this.mArrangeType <= 3)
            {
                    var val_13 = 20152008 + (this.mArrangeType) << 2;
                val_13 = val_13 + 20152008;
            }
            else
            {
                    UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  null, y:  null);
                return new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            }
        
        }
        private void UpdateCurFrameItemRangeData()
        {
            UnityEngine.Vector2 val_1 = this.GetContainerMovedDistance();
            int val_11 = this.mNeedCheckContentPosLeftCount;
            if(val_11 <= 0)
            {
                goto label_1;
            }
            
            label_11:
            val_11 = val_11 - 1;
            this.mNeedCheckContentPosLeftCount = val_11;
            label_12:
            UnityEngine.Vector2 val_12 = this.mItemRecycleDistance;
            val_12 = val_1.x - val_12;
            val_1.y = val_1.y - val_1.y;
            SuperScrollView.RowColumnPair val_2 = this.GetCeilItemRowColumnAtGivenAbsPos(ax:  val_12, ay:  val_1.y);
            this.mCurFrameItemRangeData.mMinColumn = val_2.mRow >> 32;
            this.mCurFrameItemRangeData.mMinRow = val_2.mRow;
            UnityEngine.Vector2 val_13 = this.mItemRecycleDistance;
            val_13 = (val_1.x + val_13) + this.ViewPortWidth;
            float val_7 = val_1.y + S11;
            val_7 = val_7 + this.ViewPortHeight;
            SuperScrollView.RowColumnPair val_8 = this.GetCeilItemRowColumnAtGivenAbsPos(ax:  val_13, ay:  val_7);
            this.mCurFrameItemRangeData.mMaxColumn = val_8.mRow >> 32;
            this.mCurFrameItemRangeData.mMaxRow = val_8.mRow;
            this.mCurFrameItemRangeData.mCheckedPosition = val_1;
            mem2[0] = val_1.y;
            return;
            label_1:
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.mCurFrameItemRangeData.mCheckedPosition, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) == true)
            {
                    return;
            }
            
            if(this.mNeedCheckContentPosLeftCount >= 1)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        private void UpdateRowItemGroupForRecycleAndNew(SuperScrollView.GridItemGroup group)
        {
            SuperScrollView.LoopGridViewItem val_23;
            float val_24;
            goto label_3;
            label_8:
            this.RecycleItemTmp(item:  group.RemoveFirst());
            label_3:
            if(group.mFirst == 0)
            {
                goto label_9;
            }
            
            if(group.mFirst.mColumn < this.mCurFrameItemRangeData.mMinColumn)
            {
                goto label_8;
            }
            
            goto label_9;
            label_15:
            if(group.mLast.mColumn <= this.mCurFrameItemRangeData.mMaxColumn)
            {
                    if(group.mLast.mItemIndex < this.mItemTotalCount)
            {
                goto label_12;
            }
            
            }
            
            this.RecycleItemTmp(item:  group.RemoveLast());
            label_9:
            if(group.mLast != 0)
            {
                goto label_15;
            }
            
            label_12:
            val_23 = group.mFirst;
            if(val_23 == 0)
            {
                    val_23 = this.GetNewItemByRowColumn(row:  group.mGroupIndex, column:  this.mCurFrameItemRangeData.mMinColumn);
                if(val_23 == 0)
            {
                    return;
            }
            
                UnityEngine.Vector2 val_9 = this.GetItemPos(row:  val_6.mRow, column:  val_6.mColumn);
                val_24 = val_9.x;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_9.y});
                val_23.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                group.AddFirst(newItem:  val_23);
            }
            
            label_35:
            if(group.mFirst.mColumn <= this.mCurFrameItemRangeData.mMinColumn)
            {
                goto label_30;
            }
            
            val_23 = this.GetNewItemByRowColumn(row:  group.mGroupIndex, column:  group.mFirst.mColumn - 1);
            if(val_23 == 0)
            {
                goto label_30;
            }
            
            UnityEngine.Vector2 val_15 = this.GetItemPos(row:  val_12.mRow, column:  val_12.mColumn);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_23.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            group.AddFirst(newItem:  val_23);
            if(group.mFirst != null)
            {
                goto label_35;
            }
            
            label_45:
            SuperScrollView.LoopGridViewItem val_18 = this.GetNewItemByRowColumn(row:  group.mGroupIndex, column:  group.mFirst + 1);
            if(val_18 == 0)
            {
                    return;
            }
            
            val_23 = val_18.CachedRectTransform;
            UnityEngine.Vector2 val_21 = this.GetItemPos(row:  val_18.mRow, column:  val_18.mColumn);
            val_24 = val_21.x;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_21.y});
            val_23.anchoredPosition3D = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            group.AddLast(newItem:  val_18);
            label_30:
            if(group.mLast.mColumn < this.mCurFrameItemRangeData.mMaxColumn)
            {
                goto label_45;
            }
        
        }
        private void UpdateColumnItemGroupForRecycleAndNew(SuperScrollView.GridItemGroup group)
        {
            SuperScrollView.LoopGridViewItem val_23;
            float val_24;
            goto label_3;
            label_8:
            this.RecycleItemTmp(item:  group.RemoveFirst());
            label_3:
            if(group.mFirst == 0)
            {
                goto label_9;
            }
            
            if(group.mFirst.mRow < this.mCurFrameItemRangeData.mMinRow)
            {
                goto label_8;
            }
            
            goto label_9;
            label_15:
            if(group.mLast.mRow <= this.mCurFrameItemRangeData.mMaxRow)
            {
                    if(group.mLast.mItemIndex < this.mItemTotalCount)
            {
                goto label_12;
            }
            
            }
            
            this.RecycleItemTmp(item:  group.RemoveLast());
            label_9:
            if(group.mLast != 0)
            {
                goto label_15;
            }
            
            label_12:
            val_23 = group.mFirst;
            if(val_23 == 0)
            {
                    val_23 = this.GetNewItemByRowColumn(row:  this.mCurFrameItemRangeData.mMinRow, column:  group.mGroupIndex);
                if(val_23 == 0)
            {
                    return;
            }
            
                UnityEngine.Vector2 val_9 = this.GetItemPos(row:  val_6.mRow, column:  val_6.mColumn);
                val_24 = val_9.x;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_9.y});
                val_23.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                group.AddFirst(newItem:  val_23);
            }
            
            label_35:
            if(group.mFirst.mRow <= this.mCurFrameItemRangeData.mMinRow)
            {
                goto label_30;
            }
            
            val_23 = this.GetNewItemByRowColumn(row:  group.mFirst.mRow - 1, column:  group.mGroupIndex);
            if(val_23 == 0)
            {
                goto label_30;
            }
            
            UnityEngine.Vector2 val_15 = this.GetItemPos(row:  val_12.mRow, column:  val_12.mColumn);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_23.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            group.AddFirst(newItem:  val_23);
            if(group.mFirst != null)
            {
                goto label_35;
            }
            
            label_45:
            SuperScrollView.LoopGridViewItem val_18 = this.GetNewItemByRowColumn(row:  group.mFirst + 1, column:  group.mGroupIndex);
            if(val_18 == 0)
            {
                    return;
            }
            
            val_23 = val_18.CachedRectTransform;
            UnityEngine.Vector2 val_21 = this.GetItemPos(row:  val_18.mRow, column:  val_18.mColumn);
            val_24 = val_21.x;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24, y = val_21.y});
            val_23.anchoredPosition3D = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            group.AddLast(newItem:  val_18);
            label_30:
            if(group.mLast.mRow < this.mCurFrameItemRangeData.mMaxRow)
            {
                goto label_45;
            }
        
        }
        private void SetScrollbarListener()
        {
            UnityEngine.UI.ScrollRect val_13;
            UnityEngine.UI.Scrollbar val_14;
            UnityEngine.UI.Scrollbar val_15;
            var val_16;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            val_13 = this.mScrollRect;
            this.mScrollBarClickEventListener1 = 0;
            this.mScrollBarClickEventListener2 = 0;
            if(this.mScrollRect.m_Vertical == false)
            {
                goto label_3;
            }
            
            val_13 = this.mScrollRect;
            if(this.mScrollRect.m_VerticalScrollbar == 0)
            {
                goto label_6;
            }
            
            val_14 = this.mScrollRect.m_VerticalScrollbar;
            goto label_8;
            label_6:
            label_3:
            val_14 = 0;
            label_8:
            if((this.mScrollRect.m_Horizontal != false) && (this.mScrollRect.m_HorizontalScrollbar != 0))
            {
                    val_15 = this.mScrollRect.m_HorizontalScrollbar;
            }
            else
            {
                    val_15 = 0;
            }
            
            val_16 = 1152921504729477120;
            if(val_14 != 0)
            {
                    SuperScrollView.ClickEventListener val_5 = SuperScrollView.ClickEventListener.Get(obj:  val_14.gameObject);
                this.mScrollBarClickEventListener1 = val_5;
                val_14 = val_5;
                val_5.mOnPointerUpHandler = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopGridView::OnPointerUpInScrollBar(UnityEngine.GameObject obj));
                val_5.mOnPointerDownHandler = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopGridView::OnPointerDownInScrollBar(UnityEngine.GameObject obj));
            }
            
            if(val_15 == 0)
            {
                    return;
            }
            
            this.mScrollBarClickEventListener2 = SuperScrollView.ClickEventListener.Get(obj:  val_15.gameObject);
            System.Action<UnityEngine.GameObject> val_11 = null;
            val_16 = 1152921513524501872;
            val_11 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopGridView::OnPointerUpInScrollBar(UnityEngine.GameObject obj));
            val_10.mOnPointerUpHandler = val_11;
            System.Action<UnityEngine.GameObject> val_12 = null;
            val_14 = val_12;
            val_12 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopGridView::OnPointerDownInScrollBar(UnityEngine.GameObject obj));
            val_10.mOnPointerDownHandler = val_14;
        }
        private void OnPointerDownInScrollBar(UnityEngine.GameObject obj)
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.mSnapStatus = 0;
                this.mCurSnapData.mIsForceSnapTo = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnPointerUpInScrollBar(UnityEngine.GameObject obj)
        {
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        private SuperScrollView.RowColumnPair FindNearestItemWithLocalPos(float x, float y)
        {
            float val_13;
            var val_14;
            val_13 = y;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  x, y:  val_13);
            SuperScrollView.RowColumnPair val_2 = this.GetCeilItemRowColumnAtGivenAbsPos(ax:  val_1.x, ay:  val_1.y);
            val_14 = val_2.mRow;
            SuperScrollView.RowColumnPair val_3 = new SuperScrollView.RowColumnPair(row1:  0, column1:  0);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            int val_5 = val_14 - 1;
            int val_6 = val_14 + 1;
            if(val_5 > val_6)
            {
                    return new SuperScrollView.RowColumnPair() {mRow = val_5, mColumn = val_5};
            }
            
            int val_7 = val_14 >> 32;
            int val_8 = val_7 - 1;
            int val_9 = val_7 + 1;
            do
            {
                if(val_8 <= val_9)
            {
                    do
            {
                if(((((val_5 & 2147483648) == 0) && ((val_8 & 2147483648) == 0)) && (val_5 < this.mRowCount)) && (val_8 < this.mColumnCount))
            {
                    UnityEngine.Vector2 val_10 = this.GetItemSnapPivotLocalPos(row:  val_5, column:  val_8);
                val_13 = val_10.x;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_13, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
                float val_12 = val_11.x.sqrMagnitude;
            }
            
                val_14 = val_8 + 1;
            }
            while(val_14 <= val_9);
            
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 <= val_6);
            
            return new SuperScrollView.RowColumnPair() {mRow = val_5, mColumn = val_5};
        }
        private UnityEngine.Vector2 GetItemSnapPivotLocalPos(int row, int column)
        {
            UnityEngine.Vector2 val_1 = this.GetItemAbsPos(row:  row, column:  column);
            if(this.mArrangeType <= 3)
            {
                    var val_8 = 20152040 + (this.mArrangeType) << 2;
                val_8 = val_8 + 20152040;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            }
        
        }
        private UnityEngine.Vector2 GetViewPortSnapPivotLocalPos(UnityEngine.Vector2 pos)
        {
            float val_10;
            float val_14;
            if(this.mArrangeType <= 3)
            {
                    var val_9 = 20152056 + (this.mArrangeType) << 2;
                val_9 = val_9 + 20152056;
            }
            else
            {
                    val_14 = 0f;
                val_10 = 0f;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  null, y:  null);
                return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            }
        
        }
        private void UpdateNearestSnapItem(bool forceSendEvent)
        {
            var val_11;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(this.mItemGroupList == null)
            {
                    return;
            }
            
            if(this.IsContainerTransCanMove() == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector3 val_3 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_4 = this.GetContainerVaildPos(curX:  val_2.x, curY:  val_3.y);
            if(val_4.y == val_3.z)
            {
                    var val_5 = (val_4.x != this.mLastSnapCheckPos) ? 1 : 0;
            }
            else
            {
                    val_11 = 1;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.mLastSnapCheckPos = val_6;
            mem[1152921513604523652] = val_6.y;
            mem[1152921513604523656] = val_6.z;
            if(val_11 == 0)
            {
                    int val_11 = this.mLeftSnapUpdateExtraCount;
                val_11 = val_11 - 1;
                if(val_4.y < val_3.z)
            {
                    return;
            }
            
                this.mLeftSnapUpdateExtraCount = val_11;
            }
            
            SuperScrollView.RowColumnPair val_7 = new SuperScrollView.RowColumnPair(row1:  0, column1:  0);
            UnityEngine.Vector2 val_8 = this.GetViewPortSnapPivotLocalPos(pos:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            SuperScrollView.RowColumnPair val_9 = this.FindNearestItemWithLocalPos(x:  val_8.x, y:  val_8.y);
            if((val_9.mRow & 2147483648) == 0)
            {
                    this.mCurSnapNearestItemRowColumn = val_9;
                if(forceSendEvent != true)
            {
                    if((SuperScrollView.RowColumnPair.op_Inequality(a:  new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapNearestItemRowColumn, mColumn = this.mCurSnapNearestItemRowColumn}, b:  new SuperScrollView.RowColumnPair() {mRow = val_9.mRow, mColumn = val_9.mColumn})) == false)
            {
                    return;
            }
            
            }
            
                if(this.mOnSnapNearestChanged == null)
            {
                    return;
            }
            
                this.mOnSnapNearestChanged.Invoke(obj:  this);
                return;
            }
            
            this.mCurSnapNearestItemRowColumn = -1;
        }
        private void UpdateFromSettingParam(SuperScrollView.LoopGridViewSettingParam param)
        {
            if(param == null)
            {
                    return;
            }
            
            if(param.mItemSize != null)
            {
                    this.mItemSize = new UnityEngine.Vector2();
            }
            
            if(param.mItemPadding != null)
            {
                    this.mItemPadding = new UnityEngine.Vector2();
            }
            
            if(param.mPadding != null)
            {
                    this.mPadding = param.mPadding;
            }
            
            if(param.mGridFixedType != null)
            {
                    this.mGridFixedType = null;
            }
            
            if(param.mFixedRowOrColumnCount == null)
            {
                    return;
            }
            
            this.mFixedRowOrColumnCount = null;
        }
        public void FinishSnapImmediately()
        {
            this.UpdateSnapMove(immediate:  true, forceSendEvent:  false);
        }
        private void UpdateSnapMove(bool immediate = False, bool forceSendEvent = False)
        {
            UnityEngine.UI.ScrollRect val_16;
            float val_17;
            SnapData val_18;
            UnityEngine.Vector2 val_19;
            float val_22;
            float val_23;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            this.UpdateNearestSnapItem(forceSendEvent:  false);
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(this.CanSnap() == false)
            {
                goto label_5;
            }
            
            this.UpdateCurSnapData();
            if(this.mCurSnapData.mSnapStatus != 2)
            {
                    return;
            }
            
            val_16 = this.mScrollRect;
            val_16 = this.mScrollRect;
            float val_17 = System.Math.Abs(val_2.x);
            val_17 = System.Math.Abs(this.mScrollRect.m_Velocity) + val_17;
            val_17 = this.mCurSnapData.mCurSnapVal;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.SmoothDamp(current:  val_17, target:  this.mCurSnapData.mTargetSnapVal, currentVelocity: ref  this.mSmoothDumpVel, smoothTime:  this.mSmoothDumpRate);
            val_18 = this.mCurSnapData;
            if(immediate == true)
            {
                goto label_17;
            }
            
            val_18 = this.mCurSnapData;
            if((this.mCurSnapData.mTargetSnapVal ?? this.mCurSnapData.mCurSnapVal) >= 0)
            {
                goto label_20;
            }
            
            label_17:
            val_19 = this.mCurSnapData.mSnapNeedMoveDir;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(d:  this.mCurSnapData.mTargetSnapVal - val_17, a:  new UnityEngine.Vector2() {x = val_19, y = this.mCurSnapData.mTargetSnapVal});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            this.mCurSnapData.mSnapStatus = 3;
            val_22 = val_9.x;
            val_23 = val_9.y;
            if(this.mOnSnapItemFinished == null)
            {
                goto label_30;
            }
            
            SuperScrollView.LoopGridViewItem val_10 = this.GetShownItemByRowColumn(row:  this.mCurSnapNearestItemRowColumn, column:  forceSendEvent);
            if(val_10 == 0)
            {
                goto label_30;
            }
            
            this.mOnSnapItemFinished.Invoke(arg1:  this, arg2:  val_10);
            goto label_30;
            label_5:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            return;
            label_20:
            val_19 = this.mCurSnapData.mSnapNeedMoveDir;
            val_17 = this.mCurSnapData.mCurSnapVal - val_17;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(d:  val_17, a:  new UnityEngine.Vector2() {x = val_19, y = this.mCurSnapData.mTargetSnapVal});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            val_22 = val_13.x;
            val_23 = val_13.y;
            label_30:
            UnityEngine.Vector2 val_14 = this.GetContainerVaildPos(curX:  val_22, curY:  val_23);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        }
        private SuperScrollView.GridItemGroup GetShownGroup(int groupIndex)
        {
            if((groupIndex & 2147483648) != 0)
            {
                    return 0;
            }
            
            return 0;
        }
        private void FillCurSnapData(int row, int column)
        {
            UnityEngine.Vector2 val_1 = this.GetItemSnapPivotLocalPos(row:  row, column:  column);
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector3 val_3 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_4 = this.GetContainerVaildPos(curX:  val_2.x, curY:  val_3.y);
            UnityEngine.Vector2 val_5 = this.GetViewPortSnapPivotLocalPos(pos:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.mCurSnapData.mTargetSnapVal = 0.magnitude;
            this.mCurSnapData.mCurSnapVal = 0f;
            UnityEngine.Vector2 val_8 = 0.normalized;
            this.mCurSnapData.mSnapNeedMoveDir = val_8;
            mem2[0] = val_8.y;
        }
        private void UpdateCurSnapData()
        {
            SnapData val_7;
            var val_8;
            SnapData val_9;
            SnapData val_10;
            val_7 = this.mCurSnapData;
            if(this.mItemGroupList == null)
            {
                goto label_3;
            }
            
            if(this.mCurSnapData.mSnapStatus == 3)
            {
                    val_8 = 0;
                if((SuperScrollView.RowColumnPair.op_Equality(a:  new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapData.mSnapTarget, mColumn = this.mCurSnapData.mSnapTarget}, b:  new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapNearestItemRowColumn, mColumn = this.mCurSnapNearestItemRowColumn})) == true)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapStatus = 0;
                val_9 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus == 2)
            {
                    val_8 = 0;
                if((SuperScrollView.RowColumnPair.op_Equality(a:  new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapData.mSnapTarget, mColumn = this.mCurSnapData.mSnapTarget}, b:  new SuperScrollView.RowColumnPair() {mRow = this.mCurSnapNearestItemRowColumn, mColumn = this.mCurSnapNearestItemRowColumn})) == true)
            {
                    return;
            }
            
                if(this.mCurSnapData.mIsForceSnapTo == true)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapStatus = 0;
                val_9 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus == 0)
            {
                    val_8 = 0;
                if((this.GetShownItemByRowColumn(row:  this.mCurSnapNearestItemRowColumn, column:  0)) == 0)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapTarget = this.mCurSnapNearestItemRowColumn;
                this.mCurSnapData.mSnapStatus = 1;
                this.mCurSnapData.mIsForceSnapTo = false;
                val_9 = this.mCurSnapData;
            }
            
            if(this.mCurSnapData.mSnapStatus != 1)
            {
                    return;
            }
            
            if((this.GetShownItemByRowColumn(row:  this.mCurSnapData.mSnapTarget, column:  0)) != 0)
            {
                goto label_24;
            }
            
            val_10 = this.mCurSnapData;
            label_3:
            this.mCurSnapData.mSnapStatus = 0;
            this.mCurSnapData.mIsForceSnapTo = false;
            return;
            label_24:
            this.FillCurSnapData(row:  val_5.mRow, column:  val_5.mColumn);
            this.mCurSnapData.mSnapStatus = 2;
        }
        private bool CanSnap()
        {
            float val_8;
            if(this.mIsDraging != false)
            {
                    return false;
            }
            
            if(this.mScrollBarClickEventListener1 != 0)
            {
                    if(this.mScrollBarClickEventListener1.mIsPressed == true)
            {
                    return false;
            }
            
            }
            
            if(this.mScrollBarClickEventListener2 != 0)
            {
                    if(this.mScrollBarClickEventListener2.mIsPressed == true)
            {
                    return false;
            }
            
            }
            
            if(this.IsContainerTransCanMove() == false)
            {
                    return false;
            }
            
            val_8 = this.mSnapVecThreshold;
            if(System.Math.Abs(this.mScrollRect.m_Velocity) > val_8)
            {
                    return false;
            }
            
            val_8 = this.mSnapVecThreshold;
            if(System.Math.Abs(this.mScrollRect.m_Velocity) > val_8)
            {
                    return false;
            }
            
            UnityEngine.Vector3 val_4 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector2 val_5 = this.GetContainerVaildPos(curX:  val_4.x, curY:  val_4.y);
            val_5.x = val_4.x ?? val_5.x;
            if(val_5.x > 3f)
            {
                    return false;
            }
            
            var val_7 = ((val_4.y ?? val_5.y) <= 3f) ? 1 : 0;
            return false;
        }
        private SuperScrollView.GridItemGroup GetOneItemGroupObj()
        {
            var val_3;
            if(true != 0)
            {
                    var val_1 = X9 + 0;
                val_3 = mem[(X9 + 0) + 32];
                val_3 = (X9 + 0) + 32;
                this.mItemGroupObjPool.RemoveAt(index:  0);
                return (SuperScrollView.GridItemGroup)val_3;
            }
            
            SuperScrollView.GridItemGroup val_2 = null;
            val_3 = val_2;
            val_2 = new SuperScrollView.GridItemGroup();
            return (SuperScrollView.GridItemGroup)val_3;
        }
        private void RecycleOneItemGroupObj(SuperScrollView.GridItemGroup obj)
        {
            this.mItemGroupObjPool.Add(item:  obj);
        }
        public LoopGridView()
        {
            this.mItemPoolDict = new System.Collections.Generic.Dictionary<System.String, SuperScrollView.GridItemPool>();
            this.mItemPoolList = new System.Collections.Generic.List<SuperScrollView.GridItemPool>();
            this.mItemPrefabDataList = new System.Collections.Generic.List<SuperScrollView.GridViewItemPrefabConfData>();
            this.mPadding = new UnityEngine.RectOffset();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            this.mItemPadding = val_5;
            mem[1152921513606172876] = val_5.y;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            this.mItemSize = val_6;
            mem[1152921513606172884] = val_6.y;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  50f, y:  50f);
            this.mItemRecycleDistance = val_7.x;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            this.mItemSizeWithPadding = val_8;
            mem[1152921513606172900] = val_8.y;
            this.mItemGroupObjPool = new System.Collections.Generic.List<SuperScrollView.GridItemGroup>();
            this.mItemGroupList = new System.Collections.Generic.List<SuperScrollView.GridItemGroup>();
            this.mSnapVecThreshold = 145f;
            this.mSmoothDumpRate = 0.3f;
            this.mSnapFinishThreshold = 0.1f;
            this.mLeftSnapUpdateExtraCount = 1;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            this.mViewPortSnapPivot = val_11;
            mem[1152921513606173032] = val_11.y;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            this.mItemSnapPivot = val_12;
            mem[1152921513606173040] = val_12.y;
            this.mCurSnapData = new LoopGridView.SnapData();
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            this.mLastSnapCheckPos = val_14;
            mem[1152921513606173060] = val_14.y;
            mem[1152921513606173064] = val_14.z;
            this.mCurFrameItemRangeData = new LoopGridView.ItemRangeData();
            this.mNeedCheckContentPosLeftCount = 1;
        }
    
    }

}
