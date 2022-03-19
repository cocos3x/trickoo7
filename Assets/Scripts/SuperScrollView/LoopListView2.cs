using UnityEngine;

namespace SuperScrollView
{
    public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SuperScrollView.ItemPool> mItemPoolDict;
        private System.Collections.Generic.List<SuperScrollView.ItemPool> mItemPoolList;
        private System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData> mItemPrefabDataList;
        private SuperScrollView.ListItemArrangeType mArrangeType;
        private System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> mItemList;
        private UnityEngine.RectTransform mContainerTrans;
        private UnityEngine.UI.ScrollRect mScrollRect;
        private UnityEngine.RectTransform mScrollRectTransform;
        private UnityEngine.RectTransform mViewPortRectTransform;
        private float mItemDefaultWithPaddingSize;
        private int mItemTotalCount;
        private bool mIsVertList;
        private System.Func<SuperScrollView.LoopListView2, int, SuperScrollView.LoopListViewItem2> mOnGetItemByIndex;
        private UnityEngine.Vector3[] mItemWorldCorners;
        private UnityEngine.Vector3[] mViewPortRectLocalCorners;
        private int mCurReadyMinItemIndex;
        private int mCurReadyMaxItemIndex;
        private bool mNeedCheckNextMinItem;
        private bool mNeedCheckNextMaxItem;
        private SuperScrollView.ItemPosMgr mItemPosMgr;
        private float mDistanceForRecycle0;
        private float mDistanceForNew0;
        private float mDistanceForRecycle1;
        private float mDistanceForNew1;
        private bool mSupportScrollBar;
        private bool mIsDraging;
        private UnityEngine.EventSystems.PointerEventData mPointerEventData;
        public System.Action mOnBeginDragAction;
        public System.Action mOnDragingAction;
        public System.Action mOnEndDragAction;
        private int mLastItemIndex;
        private float mLastItemPadding;
        private float mSmoothDumpVel;
        private float mSmoothDumpRate;
        private float mSnapFinishThreshold;
        private float mSnapVecThreshold;
        private float mSnapMoveDefaultMaxAbsVec;
        private bool mItemSnapEnable;
        private UnityEngine.Vector3 mLastFrameContainerPos;
        public System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2> mOnSnapItemFinished;
        public System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2> mOnSnapNearestChanged;
        private int mCurSnapNearestItemIndex;
        private UnityEngine.Vector2 mAdjustedVec;
        private bool mNeedAdjustVec;
        private int mLeftSnapUpdateExtraCount;
        private UnityEngine.Vector2 mViewPortSnapPivot;
        private UnityEngine.Vector2 mItemSnapPivot;
        private SuperScrollView.ClickEventListener mScrollBarClickEventListener;
        private SuperScrollView.LoopListView2.SnapData mCurSnapData;
        private UnityEngine.Vector3 mLastSnapCheckPos;
        private bool mListViewInited;
        private int mListUpdateCheckFrameCount;
        public System.Action<SuperScrollView.LoopListView2> OnListViewStart;
        
        // Properties
        public SuperScrollView.ListItemArrangeType ArrangeType { get; set; }
        public System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData> ItemPrefabDataList { get; }
        public System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> ItemList { get; }
        public bool IsVertList { get; }
        public int ItemTotalCount { get; }
        public UnityEngine.RectTransform ContainerTrans { get; }
        public UnityEngine.UI.ScrollRect ScrollRect { get; }
        public bool IsDraging { get; }
        public bool ItemSnapEnable { get; set; }
        public bool SupportScrollBar { get; set; }
        public float SnapMoveDefaultMaxAbsVec { get; set; }
        public int ShownItemCount { get; }
        public float ViewPortSize { get; }
        public float ViewPortWidth { get; }
        public float ViewPortHeight { get; }
        public int CurSnapNearestItemIndex { get; }
        
        // Methods
        public SuperScrollView.ListItemArrangeType get_ArrangeType()
        {
            return (SuperScrollView.ListItemArrangeType)this.mArrangeType;
        }
        public void set_ArrangeType(SuperScrollView.ListItemArrangeType value)
        {
            this.mArrangeType = value;
        }
        public System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData> get_ItemPrefabDataList()
        {
            return (System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData>)this.mItemPrefabDataList;
        }
        public System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> get_ItemList()
        {
            return (System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>)this.mItemList;
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
        public bool get_ItemSnapEnable()
        {
            return (bool)this.mItemSnapEnable;
        }
        public void set_ItemSnapEnable(bool value)
        {
            this.mItemSnapEnable = value;
        }
        public bool get_SupportScrollBar()
        {
            return (bool)this.mSupportScrollBar;
        }
        public void set_SupportScrollBar(bool value)
        {
            this.mSupportScrollBar = value;
        }
        public float get_SnapMoveDefaultMaxAbsVec()
        {
            return (float)this.mSnapMoveDefaultMaxAbsVec;
        }
        public void set_SnapMoveDefaultMaxAbsVec(float value)
        {
            this.mSnapMoveDefaultMaxAbsVec = value;
        }
        public SuperScrollView.ItemPrefabConfData GetItemPrefabConfData(string prefabName)
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
            val_10 = public System.Boolean List.Enumerator<SuperScrollView.ItemPrefabConfData>::MoveNext();
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
            return (SuperScrollView.ItemPrefabConfData)val_12;
        }
        public void OnItemPrefabChanged(string prefabName)
        {
            var val_10;
            float val_11;
            float val_12;
            float val_13;
            if((this.GetItemPrefabConfData(prefabName:  prefabName)) == null)
            {
                    return;
            }
            
            if((this.mItemPoolDict.TryGetValue(key:  prefabName, value: out  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            if(W9 >= 1)
            {
                    val_10 = 6178512;
                UnityEngine.Vector3 val_6 = 0.CachedRectTransform.anchoredPosition3D;
                val_11 = val_6.x;
                val_12 = val_6.y;
                val_13 = val_6.z;
            }
            else
            {
                    val_11 = val_4.x;
                val_12 = val_4.y;
                val_13 = val_4.z;
                val_10 = 0;
            }
            
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
            val_2.DestroyAllItem();
            val_2.Init(prefabObj:  val_1.mItemPrefab, padding:  val_1.mPadding, startPosOffset:  val_1.mStartPosOffset, createCount:  val_1.mInitCreateCount, parent:  this.mContainerTrans);
            if(0 != 0)
            {
                    return;
            }
            
            this.RefreshAllShownItemWithFirstIndexAndPos(firstItemIndex:  0, pos:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13});
        }
        public void InitListView(int itemTotalCount, System.Func<SuperScrollView.LoopListView2, int, SuperScrollView.LoopListViewItem2> onGetItemByIndex, SuperScrollView.LoopListViewInitParam initParam)
        {
            SuperScrollView.ItemPosMgr val_11;
            var val_12;
            if(initParam != null)
            {
                    this.mDistanceForRecycle0 = initParam.mDistanceForRecycle0;
                this.mDistanceForNew0 = initParam.mDistanceForNew0;
                this.mDistanceForRecycle1 = initParam.mDistanceForRecycle1;
                this.mDistanceForNew1 = initParam.mDistanceForNew1;
                this.mSmoothDumpRate = initParam.mSmoothDumpRate;
                this.mSnapFinishThreshold = initParam.mSnapFinishThreshold;
                this.mSnapVecThreshold = initParam.mSnapVecThreshold;
                this.mItemDefaultWithPaddingSize = initParam.mItemDefaultWithPaddingSize;
            }
            
            UnityEngine.UI.ScrollRect val_2 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            this.mScrollRect = val_2;
            if(val_2 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "ListView Init Failed! ScrollRect component not found!");
                return;
            }
            
            if(this.mDistanceForRecycle0 <= this.mDistanceForNew0)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle0 should be bigger than mDistanceForNew0");
            }
            
            if(this.mDistanceForRecycle1 <= this.mDistanceForNew1)
            {
                    UnityEngine.Debug.LogError(message:  "mDistanceForRecycle1 should be bigger than mDistanceForNew1");
            }
            
            this.mCurSnapData.Clear();
            this.mItemPosMgr = new SuperScrollView.ItemPosMgr(itemDefaultSize:  this.mItemDefaultWithPaddingSize);
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
            
            this.mIsVertList = (this.mArrangeType < 2) ? 1 : 0;
            this.mScrollRect.m_Horizontal = (this.mArrangeType > 1) ? 1 : 0;
            this.mScrollRect.m_Vertical = this.mIsVertList;
            this.SetScrollbarListener();
            this.AdjustPivot(rtf:  this.mViewPortRectTransform);
            this.AdjustAnchor(rtf:  this.mContainerTrans);
            this.AdjustContainerPivot(rtf:  this.mContainerTrans);
            this.InitItemPool();
            this.mOnGetItemByIndex = onGetItemByIndex;
            if(this.mListViewInited != false)
            {
                    UnityEngine.Debug.LogError(message:  "LoopListView2.InitListView method can be called only once.");
            }
            
            this.mListViewInited = true;
            this.ResetListView(resetPos:  true);
            this.mCurSnapData.Clear();
            this.mItemTotalCount = itemTotalCount;
            if((itemTotalCount & 2147483648) != 0)
            {
                goto label_40;
            }
            
            val_11 = this.mItemPosMgr;
            if(this.mSupportScrollBar == false)
            {
                goto label_41;
            }
            
            val_12 = itemTotalCount;
            goto label_43;
            label_40:
            val_11 = this.mItemPosMgr;
            this.mSupportScrollBar = false;
            label_41:
            val_12 = 0;
            label_43:
            val_11.SetItemMaxCount(maxCount:  0);
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.mLeftSnapUpdateExtraCount = 1;
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            this.UpdateContentSize();
        }
        private void Start()
        {
            if(this.OnListViewStart == null)
            {
                    return;
            }
            
            this.OnListViewStart.Invoke(obj:  this);
        }
        private void SetScrollbarListener()
        {
            UnityEngine.UI.Scrollbar val_8;
            UnityEngine.Object val_9;
            UnityEngine.UI.Scrollbar val_10;
            this.mScrollBarClickEventListener = 0;
            if(this.mIsVertList == false)
            {
                goto label_1;
            }
            
            if(this.mScrollRect.m_VerticalScrollbar == 0)
            {
                goto label_5;
            }
            
            val_8 = this.mScrollRect.m_VerticalScrollbar;
            goto label_7;
            label_1:
            val_8 = 0;
            val_9 = 0;
            goto label_8;
            label_5:
            val_8 = 0;
            label_7:
            val_9 = val_8;
            if(this.mIsVertList == true)
            {
                goto label_13;
            }
            
            label_8:
            val_10 = this.mScrollRect.m_HorizontalScrollbar;
            if(val_10 != 0)
            {
                    val_8 = this.mScrollRect.m_HorizontalScrollbar;
                val_9 = val_8;
            }
            
            label_13:
            if(val_9 == 0)
            {
                    return;
            }
            
            this.mScrollBarClickEventListener = SuperScrollView.ClickEventListener.Get(obj:  val_9.gameObject);
            val_5.mOnPointerUpHandler = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopListView2::OnPointerUpInScrollBar(UnityEngine.GameObject obj));
            System.Action<UnityEngine.GameObject> val_7 = null;
            val_10 = val_7;
            val_7 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.LoopListView2::OnPointerDownInScrollBar(UnityEngine.GameObject obj));
            val_5.mOnPointerDownHandler = val_10;
        }
        private void OnPointerDownInScrollBar(UnityEngine.GameObject obj)
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.Clear();
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
        public void ResetListView(bool resetPos = True)
        {
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            if(resetPos != false)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        public void SetListItemCount(int itemCount, bool resetPos = True)
        {
            SuperScrollView.ItemPosMgr val_3;
            var val_4;
            var val_5;
            if(this.mItemTotalCount == itemCount)
            {
                    return;
            }
            
            this.mCurSnapData.Clear();
            this.mItemTotalCount = itemCount;
            if((itemCount & 2147483648) != 0)
            {
                goto label_3;
            }
            
            val_3 = this.mItemPosMgr;
            if(this.mSupportScrollBar == false)
            {
                goto label_4;
            }
            
            val_4 = itemCount;
            goto label_6;
            label_3:
            val_3 = this.mItemPosMgr;
            this.mSupportScrollBar = false;
            label_4:
            val_4 = 0;
            label_6:
            val_3.SetItemMaxCount(maxCount:  0);
            if(this.mItemTotalCount == 0)
            {
                goto label_8;
            }
            
            if(this.mCurReadyMaxItemIndex >= this.mItemTotalCount)
            {
                    this.mCurReadyMaxItemIndex = this.mItemTotalCount - 1;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            if(resetPos == true)
            {
                goto label_12;
            }
            
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_2 = this.mItemList;
            if(257 == 0)
            {
                goto label_12;
            }
            
            val_2 = val_2 + 2048;
            val_5 = this.mItemTotalCount - 1;
            if(val_2 <= val_5)
            {
                goto label_14;
            }
            
            goto label_15;
            label_12:
            val_5 = 0;
            label_15:
            this.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
            return;
            label_8:
            this.mNeedCheckNextMinItem = false;
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.RecycleAllItem();
            this.ClearAllTmpRecycledItem();
            this.UpdateContentSize();
            return;
            label_14:
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemByItemIndex(int itemIndex)
        {
            return 0;
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemNearestItemIndex(int itemIndex)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = itemIndex;
            if(true != 0)
            {
                    if((-704643072) > val_1)
            {
                    return (SuperScrollView.LoopListViewItem2)val_2;
            }
            
                val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_3 = 0 + 0;
            }
            else
            {
                    val_2 = 0;
                return (SuperScrollView.LoopListViewItem2)val_2;
            }
            
            val_2 = mem[(0 + ((itemIndex - 0)) << 3) + 32];
            val_2 = (0 + ((itemIndex - 0)) << 3) + 32;
            return (SuperScrollView.LoopListViewItem2)val_2;
        }
        public int get_ShownItemCount()
        {
            return 11187;
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
        public SuperScrollView.LoopListViewItem2 GetShownItemByIndex(int index)
        {
            var val_1;
            bool val_1 = true;
            val_1 = 0;
            if((index & 2147483648) != 0)
            {
                    return (SuperScrollView.LoopListViewItem2)val_1;
            }
            
            if(val_1 <= index)
            {
                    return (SuperScrollView.LoopListViewItem2)val_1;
            }
            
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            val_1 = mem[(true + (index) << 3) + 32];
            val_1 = (true + (index) << 3) + 32;
            return (SuperScrollView.LoopListViewItem2)val_1;
        }
        public SuperScrollView.LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index)
        {
            bool val_1 = true;
            if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 3);
            return (SuperScrollView.LoopListViewItem2)(true + (index) << 3) + 32;
        }
        public int GetIndexInShownItemList(SuperScrollView.LoopListViewItem2 item)
        {
            var val_3;
            if((item == 0) || (W24 < 1))
            {
                goto label_10;
            }
            
            val_3 = 0;
            label_11:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 0) + 32) == item)
            {
                    return (int)val_3;
            }
            
            val_3 = val_3 + 1;
            if(val_3 >= X24)
            {
                goto label_10;
            }
            
            if(this.mItemList != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_10:
            val_3 = 0;
            return (int)val_3;
        }
        public void DoActionForEachShownItem(System.Action<SuperScrollView.LoopListViewItem2, object> action, object param)
        {
            bool val_1 = true;
            if(action == null)
            {
                    return;
            }
            
            if(26873856 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                action.Invoke(arg1:  (true + 0) + 32, arg2:  param);
                val_2 = val_2 + 1;
                if(val_2 >= 26873856)
            {
                    return;
            }
            
            }
            while(this.mItemList != null);
            
            throw new NullReferenceException();
        }
        public SuperScrollView.LoopListViewItem2 NewListViewItem(string itemPrefabName)
        {
            var val_8;
            if((this.mItemPoolDict.TryGetValue(key:  itemPrefabName, value: out  0)) != false)
            {
                    SuperScrollView.LoopListViewItem2 val_3 = val_1.GetItem();
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
                return (SuperScrollView.LoopListViewItem2)val_8;
            }
            
            val_8 = 0;
            return (SuperScrollView.LoopListViewItem2)val_8;
        }
        public void OnItemSizeChanged(int itemIndex)
        {
            SuperScrollView.LoopListViewItem2 val_1 = this.GetShownItemByItemIndex(itemIndex:  itemIndex);
            if(val_1 == 0)
            {
                    return;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_4 = val_1.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_5 = val_4.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  itemIndex, itemSize:  val_4.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
        }
        public void RefreshItemByItemIndex(int itemIndex)
        {
            if(true == 0)
            {
                    return;
            }
            
            if((X10 + 24) > itemIndex)
            {
                    return;
            }
        
        }
        public void FinishSnapImmediately()
        {
            this.UpdateSnapMove(immediate:  true, forceSendEvent:  false);
        }
        public void MovePanelToItemIndex(int itemIndex, float offset)
        {
            UnityEngine.Object val_22;
            float val_23;
            var val_26;
            var val_27;
            val_23 = offset;
            this.mCurSnapData.Clear();
            if(this.mItemTotalCount == 0)
            {
                    return;
            }
            
            if((itemIndex & 2147483648) != 0)
            {
                goto label_4;
            }
            
            var val_2 = (this.mItemTotalCount < itemIndex) ? itemIndex : (this.mItemTotalCount - 1);
            label_11:
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_26 = val_3.x;
            val_27 = val_3.y;
            float val_4 = this.ViewPortSize;
            val_23 = val_4;
            float val_5 = (S12 > val_4) ? (val_4) : (S12);
            if(this.mArrangeType > 3)
            {
                goto label_15;
            }
            
            var val_18 = 20151928 + (this.mArrangeType) << 2;
            val_18 = val_18 + 20151928;
            goto (20151928 + (this.mArrangeType) << 2 + 20151928);
            label_4:
            if(this.mItemTotalCount >= 1)
            {
                    return;
            }
            
            goto label_11;
            label_15:
            this.RecycleAllItem();
            val_22 = this.GetNewItemByIndex(index:  itemIndex);
            if(val_22 == 0)
            {
                    this.ClearAllTmpRecycledItem();
                return;
            }
            
             = (this.mIsVertList == true) ? val_10.mStartPosOffset : ();
            val_22.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {y = (this.mIsVertList == true) ? () : val_10.mStartPosOffset, z = V9.16B};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_15 = val_22.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_16 = val_15.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  itemIndex, itemSize:  val_15.m_XMin.width, padding:  val_10.mPadding);
            }
            
            this.mItemList.Add(item:  val_22);
            this.UpdateContentSize();
            float val_20 = 100f;
            val_20 = val_23 + val_20;
            this.UpdateListView(distanceForRecycle0:  val_20, distanceForRecycle1:  val_20, distanceForNew0:  val_23, distanceForNew1:  val_23);
            this.AdjustPanelPos();
            this.ClearAllTmpRecycledItem();
            if(this.mLeftSnapUpdateExtraCount <= 0)
            {
                    this.mLeftSnapUpdateExtraCount = 1;
            }
            
            this.UpdateSnapMove(immediate:  false, forceSendEvent:  true);
        }
        public void RefreshAllShownItem()
        {
            if(W9 == 0)
            {
                    return;
            }
            
            this.RefreshAllShownItemWithFirstIndex(firstItemIndex:  0);
        }
        public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
        {
            UnityEngine.Object val_13;
            var val_14;
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = 11171.CachedRectTransform.anchoredPosition3D;
            val_14 = val_2.x;
            this.RecycleAllItem();
            if(W23 < 1)
            {
                goto label_8;
            }
            
            var val_13 = 0;
            label_16:
            int val_3 = firstItemIndex + val_13;
            val_13 = this.GetNewItemByIndex(index:  val_3);
            if(val_13 == 0)
            {
                goto label_8;
            }
            
            val_13.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = (this.mIsVertList == true) ? val_4.mStartPosOffset : (val_14), y = (this.mIsVertList == true) ? val_2.y : val_4.mStartPosOffset, z = val_2.z};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_10 = val_13.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_11 = val_10.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  val_3, itemSize:  val_10.m_XMin.width, padding:  val_4.mPadding);
            }
            
            this.mItemList.Add(item:  val_13);
            val_13 = val_13 + 1;
            if(val_13 < W23)
            {
                goto label_16;
            }
            
            label_8:
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
            this.ClearAllTmpRecycledItem();
        }
        public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, UnityEngine.Vector3 pos)
        {
            this.RecycleAllItem();
            SuperScrollView.LoopListViewItem2 val_1 = this.GetNewItemByIndex(index:  firstItemIndex);
            if(val_1 == 0)
            {
                    return;
            }
            
            pos.x = (this.mIsVertList == true) ? val_1.mStartPosOffset : pos.x;
            pos.y = (this.mIsVertList == true) ? pos.y : val_1.mStartPosOffset;
            val_1.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_5 = val_1.CachedRectTransform.rect;
                if(this.mIsVertList != false)
            {
                    float val_6 = val_5.m_XMin.height;
            }
            
                this.SetItemSize(itemIndex:  firstItemIndex, itemSize:  val_5.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.mItemList.Add(item:  val_1);
            this.UpdateContentSize();
            this.UpdateAllShownItemsPos();
            this.UpdateListView(distanceForRecycle0:  this.mDistanceForRecycle0, distanceForRecycle1:  this.mDistanceForRecycle1, distanceForNew0:  this.mDistanceForNew0, distanceForNew1:  this.mDistanceForNew1);
            this.ClearAllTmpRecycledItem();
        }
        private void RecycleItemTmp(SuperScrollView.LoopListViewItem2 item)
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
        private void ClearAllTmpRecycledItem()
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
        private void RecycleAllItem()
        {
            List.Enumerator<T> val_1 = this.mItemList.GetEnumerator();
            label_3:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            this.RecycleItemTmp(item:  0);
            goto label_3;
            label_2:
            0.Dispose();
            this.mItemList.Clear();
        }
        private void AdjustContainerPivot(UnityEngine.RectTransform rtf)
        {
            UnityEngine.Vector2 val_1 = rtf.pivot;
            if(this.mArrangeType <= 3)
            {
                    var val_2 = 20152128 + (this.mArrangeType) << 2;
                val_2 = val_2 + 20152128;
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
                    var val_2 = 20152096 + (this.mArrangeType) << 2;
                val_2 = val_2 + 20152096;
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
                    var val_3 = 20152176 + (this.mArrangeType) << 2;
                val_3 = val_3 + 20152176;
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
                    var val_3 = 20152112 + (this.mArrangeType) << 2;
                val_3 = val_3 + 20152112;
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
            System.Collections.Generic.Dictionary<System.String, SuperScrollView.ItemPool> val_17;
            List.Enumerator<T> val_1 = this.mItemPrefabDataList.GetEnumerator();
            label_31:
            val_16 = public System.Boolean List.Enumerator<SuperScrollView.ItemPrefabConfData>::MoveNext();
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
            if((val_17.GetComponent<SuperScrollView.LoopListViewItem2>()) == val_16)
            {
                    val_17 = mem[val_2 + 16];
                val_17 = val_2 + 16;
                if(val_17 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_16 = public SuperScrollView.LoopListViewItem2 UnityEngine.GameObject::AddComponent<SuperScrollView.LoopListViewItem2>();
                SuperScrollView.LoopListViewItem2 val_14 = val_17.AddComponent<SuperScrollView.LoopListViewItem2>();
            }
            
            SuperScrollView.ItemPool val_15 = new SuperScrollView.ItemPool();
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = mem[val_2 + 16];
            val_16 = val_2 + 16;
            val_15.Init(prefabObj:  val_16, padding:  val_2 + 24, startPosOffset:  val_2 + 32, createCount:  val_2 + 28, parent:  this.mContainerTrans);
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
            this.mCurSnapData.Clear();
            if(this.mOnBeginDragAction == null)
            {
                    return;
            }
            
            this.mOnBeginDragAction.Invoke();
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            this.mIsDraging = false;
            this.mPointerEventData = 0;
            if(this.mOnEndDragAction != null)
            {
                    this.mOnEndDragAction.Invoke();
            }
            
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
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
        private SuperScrollView.LoopListViewItem2 GetNewItemByIndex(int index)
        {
            if((index & 2147483648) != 0)
            {
                    if(this.mSupportScrollBar == true)
            {
                    return 0;
            }
            
            }
            
            if((this.mItemTotalCount >= 1) && (this.mItemTotalCount <= index))
            {
                    return 0;
            }
            
            if((this.mOnGetItemByIndex.Invoke(arg1:  this, arg2:  index)) == 0)
            {
                    return 0;
            }
            
            val_1.mItemIndex = index;
            val_1.mItemCreatedCheckFrameCount = this.mListUpdateCheckFrameCount;
            return 0;
        }
        private void SetItemSize(int itemIndex, float itemSize, float padding)
        {
            itemSize = itemSize + padding;
            this.mItemPosMgr.SetItemSize(itemIndex:  itemIndex, size:  itemSize);
            if(this.mLastItemIndex > itemIndex)
            {
                    return;
            }
            
            this.mLastItemIndex = itemIndex;
            this.mLastItemPadding = padding;
        }
        private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
        {
            if(this.mItemPosMgr != null)
            {
                    return this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  pos, index: ref  int val_1 = index, itemPos: ref  float val_2 = 9.415415E-24f);
            }
            
            throw new NullReferenceException();
        }
        private float GetItemPos(int itemIndex)
        {
            if(this.mItemPosMgr != null)
            {
                    return this.mItemPosMgr.GetItemPos(itemIndex:  itemIndex);
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetItemCornerPosInViewPort(SuperScrollView.LoopListViewItem2 item, SuperScrollView.ItemCornerEnum corner = 0)
        {
            item.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3[] val_2 = this.mItemWorldCorners;
            val_2 = val_2 + ((long)corner * 12);
            return this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32, y = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32 + 4, z = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 40});
        }
        private void AdjustPanelPos()
        {
            if(this.mItemList == null)
            {
                    return;
            }
            
            this.UpdateAllShownItemsPos();
            float val_1 = this.ViewPortSize;
            float val_2 = this.GetContentPanelSize();
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_42 = 20152160 + (this.mArrangeType) << 2;
            val_42 = val_42 + 20152160;
            goto (20152160 + (this.mArrangeType) << 2 + 20152160);
        }
        private void Update()
        {
            if(this.mListViewInited == false)
            {
                    return;
            }
            
            if(this.mNeedAdjustVec == false)
            {
                goto label_6;
            }
            
            this.mNeedAdjustVec = false;
            if(this.mIsVertList == false)
            {
                goto label_3;
            }
            
            if((S1 * S0) <= 0f)
            {
                goto label_6;
            }
            
            mem2[0] = ???;
            this.mScrollRect.m_Velocity = this.mAdjustedVec;
            goto label_6;
            label_3:
            UnityEngine.Vector2 val_3 = this.mScrollRect.m_Velocity;
            val_3 = val_3 * this.mAdjustedVec;
            if(val_3 > 0f)
            {
                    this.mScrollRect.m_Velocity = this.mAdjustedVec;
                mem2[0] = this.mIsVertList;
            }
            
            label_6:
            if(this.mSupportScrollBar != false)
            {
                    this.mItemPosMgr.Update(updateAll:  false);
            }
            
            this.UpdateSnapMove(immediate:  false, forceSendEvent:  false);
            this.UpdateListView(distanceForRecycle0:  this.mDistanceForRecycle0, distanceForRecycle1:  this.mDistanceForRecycle1, distanceForNew0:  this.mDistanceForNew0, distanceForNew1:  this.mDistanceForNew1);
            this.ClearAllTmpRecycledItem();
            UnityEngine.Vector3 val_2 = this.mContainerTrans.anchoredPosition3D;
            this.mLastFrameContainerPos = val_2;
            mem[1152921513622415516] = val_2.y;
            mem[1152921513622415520] = val_2.z;
        }
        private void UpdateSnapMove(bool immediate = False, bool forceSendEvent = False)
        {
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(this.mIsVertList != false)
            {
                    this.UpdateSnapVertical(immediate:  immediate, forceSendEvent:  forceSendEvent);
                return;
            }
            
            this.UpdateSnapHorizontal(immediate:  immediate, forceSendEvent:  forceSendEvent);
        }
        public void UpdateAllShownItemSnapData()
        {
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W21 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            if(this.mItemList == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.mItemList.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_44 = 20152192 + (this.mArrangeType) << 2;
            val_44 = val_44 + 20152192;
            goto (20152192 + (this.mArrangeType) << 2 + 20152192);
        }
        private void UpdateSnapVertical(bool immediate = False, bool forceSendEvent = False)
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_44;
            SnapData val_45;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            var val_53;
            float val_54;
            var val_55;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            float val_60;
            SnapData val_61;
            float val_62;
            float val_66;
            val_44 = forceSendEvent;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            val_49 = val_1.y;
            this.mLastSnapCheckPos = val_1;
            mem[1152921513623690612] = val_1.y;
            mem[1152921513623690616] = val_1.z;
            if(val_1.y != val_1.x)
            {
                goto label_5;
            }
            
            int val_36 = this.mLeftSnapUpdateExtraCount;
            val_36 = val_36 - 1;
            if(val_1.y < val_1.x)
            {
                goto label_58;
            }
            
            this.mLeftSnapUpdateExtraCount = val_36;
            label_5:
            if(val_36 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (this.mLeftSnapUpdateExtraCount - 1) + 32.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType == 1)
            {
                goto label_11;
            }
            
            if(this.mArrangeType != 0)
            {
                goto label_46;
            }
            
            UnityEngine.Rect val_3 = this.mViewPortRectTransform.rect;
            UnityEngine.Vector3 val_5 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_50 = val_5.y;
            float val_40 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSizeWithPadding;
            float val_7 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_51 = 1f;
            val_52 = 3.402823E+38f;
            val_5.y = val_51 - val_5.y;
            val_7 = val_7 * val_5.y;
            val_53 = 0;
            val_40 = val_50 - val_40;
            val_54 = val_50 - val_7;
            goto label_18;
            label_28:
            val_55 = 1;
            if(val_55 >= X23)
            {
                goto label_36;
            }
            
            if(val_55 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_55 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_11 = val_40 - 1847620457.ItemSizeWithPadding;
            float val_12 = 1847620457.ItemSize;
            val_53 = val_55;
            val_5.y = val_51 - val_5.y;
            val_12 = val_12 * val_5.y;
            val_54 = val_40 - val_12;
            val_52 = val_50;
            label_18:
            val_50 = (-((val_51 - S15) * val_3.m_XMin.height)) ?? val_54;
            if(val_50 < 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_11:
            UnityEngine.Rect val_13 = this.mViewPortRectTransform.rect;
            UnityEngine.Vector3 val_15 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            val_50 = val_15.y;
            float val_44 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSizeWithPadding;
            float val_17 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_52 = 3.402823E+38f;
            val_17 = val_17 * val_15.y;
            val_53 = 0;
            val_51 = S14 * val_13.m_XMin.height;
            val_44 = val_50 + val_44;
            val_56 = val_50 + val_17;
            goto label_35;
            label_45:
            val_55 = 1;
            if(val_55 >= X23)
            {
                goto label_36;
            }
            
            if(val_55 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_55 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_19 = val_44 + 1847620457.ItemSizeWithPadding;
            float val_20 = 1847620457.ItemSize;
            val_53 = val_55;
            val_20 = val_20 * val_15.y;
            val_56 = val_44 + val_20;
            val_52 = val_50;
            label_35:
            val_50 = val_51 ?? val_56;
            if(val_50 < 0)
            {
                goto label_45;
            }
            
            label_29:
            val_53 = val_53 - 1;
            label_36:
            if((val_53 & 2147483648) != 0)
            {
                goto label_46;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_45 = (long)val_53;
            this.mCurSnapNearestItemIndex = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_53 - 1)) << 3) + 32 + 24;
            if(val_44 != true)
            {
                    val_44 = this.mItemList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_44 = this.mOnSnapNearestChanged;
            if(val_44 == null)
            {
                goto label_58;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_44.Invoke(arg1:  this, arg2:  (((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_53 - 1)) << 3) + 32 + 24 + ((long)(int)((val_53 - 1))) << 3) + 32 + 24 + ((long)(int)((val_53 - 1))) << 3) + 32);
            goto label_58;
            label_46:
            this.mCurSnapNearestItemIndex = 0;
            label_58:
            if(this.CanSnap() == false)
            {
                goto label_59;
            }
            
            this.UpdateCurSnapData();
            val_45 = this.mCurSnapData;
            if(this.mCurSnapData.mSnapStatus != 2)
            {
                    return;
            }
            
            if((S8 != 0f) && (S8 <= _TYPE_MAX_))
            {
                    val_45 = this.mCurSnapData;
            }
            
            val_51 = this.mCurSnapData.mCurSnapVal;
            if(this.mCurSnapData.mIsTempTarget == false)
            {
                goto label_70;
            }
            
            val_57 = this.mCurSnapData.mMoveMaxAbsVec;
            if(val_57 <= 0f)
            {
                    val_57 = this.mSnapMoveDefaultMaxAbsVec;
            }
            
            float val_22 = UnityEngine.Mathf.Sign(f:  this.mCurSnapData.mTargetSnapVal);
            val_44 = this.mCurSnapData;
            val_22 = val_57 * val_22;
            this.mSmoothDumpVel = val_22;
            val_50 = this.mCurSnapData.mCurSnapVal;
            val_58 = val_57 * UnityEngine.Time.deltaTime;
            val_59 = this.mCurSnapData.mTargetSnapVal;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.MoveTowards(current:  val_50, target:  val_59, maxDelta:  val_58);
            goto label_75;
            label_59:
            this.mCurSnapData.Clear();
            return;
            label_70:
            val_44 = this;
            float val_45 = this.mSmoothDumpVel;
            val_60 = this.mCurSnapData.mTargetSnapVal;
            val_50 = val_51;
            val_45 = val_45 * val_60;
            if(val_45 < 0)
            {
                    this.mSmoothDumpVel = 0f;
                val_60 = this.mCurSnapData.mTargetSnapVal;
                val_50 = this.mCurSnapData.mCurSnapVal;
            }
            
            val_59 = val_60;
            val_58 = this.mSmoothDumpRate;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.SmoothDamp(current:  val_50, target:  val_59, currentVelocity: ref  1.251696E-23f, smoothTime:  val_58);
            label_75:
            val_61 = this.mCurSnapData;
            if(immediate == true)
            {
                goto label_82;
            }
            
            val_52 = this.mCurSnapData.mCurSnapVal;
            val_59 = this.mCurSnapData.mTargetSnapVal ?? val_52;
            if(val_59 >= 0)
            {
                goto label_85;
            }
            
            val_61 = this.mCurSnapData;
            label_82:
            this.mCurSnapData.mSnapStatus = 3;
            val_62 = val_49 + this.mCurSnapData.mTargetSnapVal;
            val_49 = val_62 - val_51;
            if(this.mOnSnapItemFinished == null)
            {
                goto label_92;
            }
            
            SuperScrollView.LoopListViewItem2 val_27 = this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex);
            if(val_27 == 0)
            {
                goto label_92;
            }
            
            this.mOnSnapItemFinished.Invoke(arg1:  this, arg2:  val_27);
            goto label_92;
            label_85:
            val_62 = val_52 - val_51;
            val_49 = val_49 + val_62;
            label_92:
            if(this.mArrangeType != 1)
            {
                    if(this.mArrangeType != 0)
            {
                    return;
            }
            
                val_52 = this.mViewPortRectLocalCorners[0];
                UnityEngine.Rect val_29 = this.mContainerTrans.rect;
                float val_31 = val_52 + val_29.m_XMin.height;
                val_66 = val_49;
            }
            else
            {
                    val_52 = this.mViewPortRectLocalCorners[1];
                UnityEngine.Rect val_32 = this.mContainerTrans.rect;
                val_66 = val_49;
            }
            
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = val_1.x, y = UnityEngine.Mathf.Clamp(value:  val_66, min:  val_52 - val_32.m_XMin.height, max:  0f), z = val_1.z};
        }
        private void UpdateCurSnapData()
        {
            SnapData val_7;
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = this.mCurSnapData;
            if(this.mItemList == null)
            {
                goto label_3;
            }
            
            if(this.mCurSnapData.mSnapStatus == 3)
            {
                    if(this.mCurSnapData.mSnapTargetIndex == this.mCurSnapNearestItemIndex)
            {
                    return;
            }
            
                this.mCurSnapData.mSnapStatus = 0;
                val_7 = mem[this.mCurSnapData];
            }
            
            if((mem[this.mCurSnapData] + 16) != 2)
            {
                goto label_7;
            }
            
            if((mem[this.mCurSnapData] + 32) == 0)
            {
                goto label_8;
            }
            
            if((mem[this.mCurSnapData] + 33) == 0)
            {
                    return;
            }
            
            val_8 = this.GetShownItemNearestItemIndex(itemIndex:  mem[this.mCurSnapData] + 20);
            if(val_8 == 0)
            {
                goto label_12;
            }
            
            if(val_1.mItemIndex != (mem[this.mCurSnapData] + 20))
            {
                goto label_15;
            }
            
            this.UpdateAllShownItemSnapData();
            this.mCurSnapData.mTargetSnapVal = val_1.mDistanceWithViewPortSnapCenter;
            mem2[0] = 0;
            val_9 = mem[this.mCurSnapData];
            if(val_9 != 0)
            {
                goto label_18;
            }
            
            label_8:
            if((mem[this.mCurSnapData] + 20) == this.mCurSnapNearestItemIndex)
            {
                    return;
            }
            
            mem2[0] = 0;
            val_7 = mem[this.mCurSnapData];
            label_7:
            if((mem[this.mCurSnapData] + 16) == 0)
            {
                    if((this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex)) == 0)
            {
                    return;
            }
            
                mem2[0] = this.mCurSnapNearestItemIndex;
                this.mCurSnapData.mSnapStatus = 1;
                mem2[0] = 0;
                val_7 = mem[this.mCurSnapData];
            }
            
            if((mem[this.mCurSnapData] + 16) != 1)
            {
                    return;
            }
            
            val_8 = this.GetShownItemNearestItemIndex(itemIndex:  mem[this.mCurSnapData] + 20);
            if(val_8 != 0)
            {
                goto label_33;
            }
            
            label_12:
            label_3:
            mem[this.mCurSnapData].Clear();
            return;
            label_33:
            this.UpdateAllShownItemSnapData();
            this.mCurSnapData.mTargetSnapVal = val_5.mDistanceWithViewPortSnapCenter;
            mem2[0] = 0;
            val_10 = mem[this.mCurSnapData];
            if(val_5.mItemIndex != (mem[this.mCurSnapData] + 20))
            {
                goto label_40;
            }
            
            label_18:
            mem2[0] = 0;
            mem2[0] = 2;
            return;
            label_15:
            if((mem[this.mCurSnapData] + 36) == val_1.mItemIndex)
            {
                    return;
            }
            
            this.UpdateAllShownItemSnapData();
            this.mCurSnapData.mTargetSnapVal = val_1.mDistanceWithViewPortSnapCenter;
            mem2[0] = 0;
            val_11 = mem[this.mCurSnapData];
            label_40:
            mem2[0] = 2;
            mem2[0] = 1;
            mem2[0] = val_1.mItemIndex;
        }
        public void ClearSnapData()
        {
            if(this.mCurSnapData != null)
            {
                    this.mCurSnapData.Clear();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void SetSnapTargetItemIndex(int itemIndex, float moveMaxAbsVec = -1)
        {
            int val_2;
            int val_2 = this.mItemTotalCount;
            val_2 = itemIndex;
            if()
            {
                    val_2 = (val_2 > val_2) ? (val_2) : (val_2 - 1);
                val_2 = val_2 & (~(val_2 >> 31));
            }
            
            this.mCurSnapData.mSnapTargetIndex = val_2;
            this.mCurSnapData.mSnapStatus = 1;
            this.mCurSnapData.mIsForceSnapTo = 1;
            this.mCurSnapData.mMoveMaxAbsVec = moveMaxAbsVec;
        }
        public int get_CurSnapNearestItemIndex()
        {
            return (int)this.mCurSnapNearestItemIndex;
        }
        public void ForceSnapUpdateCheck()
        {
            if(this.mLeftSnapUpdateExtraCount > 0)
            {
                    return;
            }
            
            this.mLeftSnapUpdateExtraCount = 1;
        }
        private void UpdateSnapHorizontal(bool immediate = False, bool forceSendEvent = False)
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_42;
            SnapData val_43;
            float val_47;
            float val_48;
            float val_49;
            float val_50;
            var val_51;
            float val_52;
            var val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            SnapData val_59;
            float val_60;
            val_42 = forceSendEvent;
            if(this.mItemSnapEnable == false)
            {
                    return;
            }
            
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            val_47 = val_1.x;
            this.mLastSnapCheckPos = val_1;
            mem[1152921513625132660] = val_1.y;
            mem[1152921513625132664] = val_1.z;
            if(val_47 != this.mLastSnapCheckPos)
            {
                goto label_5;
            }
            
            int val_35 = this.mLeftSnapUpdateExtraCount;
            val_35 = val_35 - 1;
            if(val_47 < this.mLastSnapCheckPos)
            {
                goto label_58;
            }
            
            this.mLeftSnapUpdateExtraCount = val_35;
            label_5:
            if(val_35 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            (this.mLeftSnapUpdateExtraCount - 1) + 32.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            if(this.mArrangeType == 2)
            {
                goto label_11;
            }
            
            if(this.mArrangeType != 3)
            {
                goto label_46;
            }
            
            UnityEngine.Vector2 val_41 = this.mViewPortSnapPivot;
            UnityEngine.Rect val_3 = this.mViewPortRectTransform.rect;
            UnityEngine.Vector3 val_5 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            val_48 = val_5.x;
            float val_40 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSizeWithPadding;
            float val_7 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            UnityEngine.Vector2 val_39 = this.mItemSnapPivot;
            val_49 = 1f;
            val_50 = 3.402823E+38f;
            val_39 = val_49 - val_39;
            val_7 = val_7 * val_39;
            val_51 = 0;
            val_40 = val_48 - val_40;
            val_41 = -((val_49 - val_41) * val_3.m_XMin.width);
            val_52 = val_48 - val_7;
            goto label_18;
            label_28:
            val_53 = 1;
            if(val_53 >= X23)
            {
                goto label_36;
            }
            
            if(val_53 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_53 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_10 = val_40 - 1847620457.ItemSizeWithPadding;
            float val_11 = 1847620457.ItemSize;
            UnityEngine.Vector2 val_42 = this.mItemSnapPivot;
            val_51 = val_53;
            val_42 = val_49 - val_42;
            val_11 = val_11 * val_42;
            val_52 = val_40 - val_11;
            val_50 = val_48;
            label_18:
            val_48 = val_41 ?? val_52;
            if(val_48 < 0)
            {
                goto label_28;
            }
            
            goto label_29;
            label_11:
            val_49 = this.mViewPortSnapPivot;
            UnityEngine.Rect val_12 = this.mViewPortRectTransform.rect;
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_48 = val_14.x;
            float val_46 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSizeWithPadding;
            float val_16 = (this.mLeftSnapUpdateExtraCount - 1) + 32.ItemSize;
            if(W23 < 1)
            {
                goto label_46;
            }
            
            val_50 = 3.402823E+38f;
            val_16 = val_16 * this.mItemSnapPivot;
            val_51 = 0;
            val_49 = val_49 * val_12.m_XMin.width;
            val_46 = val_48 + val_46;
            val_54 = val_48 + val_16;
            goto label_35;
            label_45:
            val_53 = 1;
            if(val_53 >= X23)
            {
                goto label_36;
            }
            
            if(val_53 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_53 >= 20140032)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_18 = val_46 + 1847620457.ItemSizeWithPadding;
            float val_19 = 1847620457.ItemSize;
            val_51 = val_53;
            val_19 = val_19 * this.mItemSnapPivot;
            val_54 = val_46 + val_19;
            val_50 = val_48;
            label_35:
            val_48 = val_49 ?? val_54;
            if(val_48 < 0)
            {
                goto label_45;
            }
            
            label_29:
            val_51 = val_51 - 1;
            label_36:
            if((val_51 & 2147483648) != 0)
            {
                goto label_46;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_43 = (long)val_51;
            this.mCurSnapNearestItemIndex = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_51 - 1)) << 3) + 32 + 24;
            if(val_42 != true)
            {
                    val_42 = this.mItemList;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_42 = this.mOnSnapNearestChanged;
            if(val_42 == null)
            {
                goto label_58;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_42.Invoke(arg1:  this, arg2:  (((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + ((val_51 - 1)) << 3) + 32 + 24 + ((long)(int)((val_51 - 1))) << 3) + 32 + 24 + ((long)(int)((val_51 - 1))) << 3) + 32);
            goto label_58;
            label_46:
            this.mCurSnapNearestItemIndex = 0;
            label_58:
            if(this.CanSnap() == false)
            {
                goto label_59;
            }
            
            val_50 = this.mScrollRect.m_Velocity;
            this.UpdateCurSnapData();
            val_43 = this.mCurSnapData;
            if(this.mCurSnapData.mSnapStatus != 2)
            {
                    return;
            }
            
            if((val_50 != 0f) && (val_50 <= _TYPE_MAX_))
            {
                    val_43 = this.mCurSnapData;
            }
            
            val_49 = this.mCurSnapData.mCurSnapVal;
            if(this.mCurSnapData.mIsTempTarget == false)
            {
                goto label_70;
            }
            
            val_55 = this.mCurSnapData.mMoveMaxAbsVec;
            if(val_55 <= 0f)
            {
                    val_55 = this.mSnapMoveDefaultMaxAbsVec;
            }
            
            float val_21 = UnityEngine.Mathf.Sign(f:  this.mCurSnapData.mTargetSnapVal);
            val_42 = this.mCurSnapData;
            val_21 = val_55 * val_21;
            this.mSmoothDumpVel = val_21;
            val_48 = this.mCurSnapData.mCurSnapVal;
            val_56 = val_55 * UnityEngine.Time.deltaTime;
            val_57 = this.mCurSnapData.mTargetSnapVal;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.MoveTowards(current:  val_48, target:  val_57, maxDelta:  val_56);
            goto label_75;
            label_59:
            this.mCurSnapData.Clear();
            return;
            label_70:
            val_42 = this;
            float val_47 = this.mSmoothDumpVel;
            val_58 = this.mCurSnapData.mTargetSnapVal;
            val_48 = val_49;
            val_47 = val_47 * val_58;
            if(val_47 < 0)
            {
                    this.mSmoothDumpVel = 0f;
                val_58 = this.mCurSnapData.mTargetSnapVal;
                val_48 = this.mCurSnapData.mCurSnapVal;
            }
            
            val_57 = val_58;
            val_56 = this.mSmoothDumpRate;
            this.mCurSnapData.mCurSnapVal = UnityEngine.Mathf.SmoothDamp(current:  val_48, target:  val_57, currentVelocity: ref  1.407419E-23f, smoothTime:  val_56);
            label_75:
            val_59 = this.mCurSnapData;
            if(immediate == true)
            {
                goto label_82;
            }
            
            val_50 = this.mCurSnapData.mCurSnapVal;
            val_57 = this.mCurSnapData.mTargetSnapVal ?? val_50;
            if(val_57 >= 0)
            {
                goto label_85;
            }
            
            val_59 = this.mCurSnapData;
            label_82:
            this.mCurSnapData.mSnapStatus = 3;
            val_60 = val_47 + this.mCurSnapData.mTargetSnapVal;
            val_47 = val_60 - val_49;
            if(this.mOnSnapItemFinished == null)
            {
                goto label_92;
            }
            
            SuperScrollView.LoopListViewItem2 val_26 = this.GetShownItemByItemIndex(itemIndex:  this.mCurSnapNearestItemIndex);
            if(val_26 == 0)
            {
                goto label_92;
            }
            
            this.mOnSnapItemFinished.Invoke(arg1:  this, arg2:  val_26);
            goto label_92;
            label_85:
            val_60 = val_50 - val_49;
            val_47 = val_47 + val_60;
            label_92:
            if(this.mArrangeType != 3)
            {
                    if(this.mArrangeType != 2)
            {
                    return;
            }
            
                val_50 = this.mViewPortRectLocalCorners[2];
                UnityEngine.Rect val_28 = this.mContainerTrans.rect;
                float val_30 = val_50 - val_28.m_XMin.width;
            }
            else
            {
                    val_50 = this.mViewPortRectLocalCorners[1];
                UnityEngine.Rect val_31 = this.mContainerTrans.rect;
            }
            
            this.mContainerTrans.anchoredPosition3D = new UnityEngine.Vector3() {x = UnityEngine.Mathf.Clamp(value:  val_47, min:  0f, max:  val_50 + val_31.m_XMin.width), y = val_1.y, z = val_1.z};
        }
        private bool CanSnap()
        {
            float val_16;
            UnityEngine.Vector2 val_17;
            if(this.mIsDraging != false)
            {
                    return false;
            }
            
            if(this.mScrollBarClickEventListener != 0)
            {
                    if(this.mScrollBarClickEventListener.mIsPressed == true)
            {
                    return false;
            }
            
            }
            
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(this.mIsVertList != false)
            {
                    val_16 = val_2.m_XMin.height;
                float val_4 = this.ViewPortHeight;
            }
            else
            {
                    val_16 = val_2.m_XMin.width;
            }
            
            if(val_16 <= this.ViewPortWidth)
            {
                    return false;
            }
            
            if(this.mIsVertList != false)
            {
                
            }
            else
            {
                    val_17 = this.mScrollRect.m_Velocity;
            }
            
            if(System.Math.Abs(val_17) > this.mSnapVecThreshold)
            {
                    return false;
            }
            
            UnityEngine.Vector3 val_7 = this.mContainerTrans.anchoredPosition3D;
            if(this.mArrangeType > 3)
            {
                    return false;
            }
            
            var val_17 = 20152208 + (this.mArrangeType) << 2;
            val_17 = val_17 + 20152208;
            goto (20152208 + (this.mArrangeType) << 2 + 20152208);
        }
        public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            object val_4;
            object val_6;
            val_4 = this;
            int val_4 = this.mListUpdateCheckFrameCount;
            object val_5 = 1;
            val_4 = val_4 + 1;
            this.mListUpdateCheckFrameCount = val_4;
            if(this.mIsVertList == false)
            {
                goto label_6;
            }
            
            label_3:
            if(val_5 >= 9999)
            {
                goto label_2;
            }
            
            val_5 = val_5 + 1;
            if((this.UpdateForVertList(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_3;
            }
            
            return;
            label_6:
            if(val_5 >= 9999)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            if((this.UpdateForHorizontalList(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_6;
            }
            
            return;
            label_2:
            val_6 = "UpdateListView Vertical while loop ";
            goto label_8;
            label_5:
            val_6 = "UpdateListView  Horizontal while loop ";
            label_8:
            val_4 = val_6 + val_5 + " times! something is wrong!"(" times! something is wrong!");
            UnityEngine.Debug.LogError(message:  val_4);
        }
        private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_85;
            float val_86;
            UnityEngine.Vector3 val_88;
            UnityEngine.Vector3 val_89;
            UnityEngine.Vector3[] val_90;
            int val_91;
            int val_92;
            int val_93;
            UnityEngine.Object val_94;
            int val_95;
            int val_96;
            UnityEngine.Object val_97;
            var val_98;
            SuperScrollView.LoopListViewItem2 val_99;
            var val_103;
            UnityEngine.Vector3 val_104;
            UnityEngine.Vector3[] val_105;
            int val_106;
            int val_107;
            int val_108;
            int val_109;
            float val_110;
            var val_111;
            float val_112;
            float val_113;
            float val_117;
            float val_121;
            float val_122;
            val_85 = distanceForNew0;
            val_86 = distanceForRecycle0;
            if(this.mItemTotalCount == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType == 0)
            {
                goto label_3;
            }
            
            if(this.mItemTotalCount == 0)
            {
                goto label_4;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            if((this.mIsDraging == true) || (mem[26873928] == this.mListUpdateCheckFrameCount))
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_87 = this.mViewPortRectLocalCorners[0];
            val_87 = val_87 - val_2.y;
            if(val_87 > val_86)
            {
                goto label_17;
            }
            
            label_14:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_88 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_88.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_86 = val_6.y;
            val_89 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_89, z = this.mItemWorldCorners[0]});
            if((this.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 72]) == this.mListUpdateCheckFrameCount))
            {
                goto label_29;
            }
            
            UnityEngine.Vector3 val_93 = this.mViewPortRectLocalCorners[1];
            val_93 = val_7.y - val_93;
            if(val_93 > distanceForRecycle1)
            {
                goto label_32;
            }
            
            label_29:
            val_90 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_94 = val_90[1];
            val_94 = val_86 - val_94;
            if(val_94 >= 0)
            {
                goto label_38;
            }
            
            val_91 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            val_92 = this.mCurReadyMaxItemIndex;
            if(val_91 > val_92)
            {
                    this.mCurReadyMaxItemIndex = val_91;
                this.mNeedCheckNextMaxItem = true;
                val_92 = val_91;
                val_91 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            }
            
            val_93 = val_91 + 1;
            if(val_93 > val_92)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_38;
            }
            
            }
            
            val_94 = this.GetNewItemByIndex(index:  val_93);
            if(val_94 != 0)
            {
                goto label_41;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.CheckIfNeedUpdataItemPos();
            val_90 = this.mViewPortRectLocalCorners;
            label_38:
            UnityEngine.Vector3 val_95 = val_90[0];
            val_95 = val_95 - val_3.y;
            if(val_95 >= 0)
            {
                goto label_137;
            }
            
            val_95 = mem[26873880];
            val_96 = this.mCurReadyMinItemIndex;
            if(val_95 < val_96)
            {
                    this.mCurReadyMinItemIndex = val_95;
                this.mNeedCheckNextMinItem = true;
                val_96 = val_95;
                val_95 = mem[26873880];
            }
            
            val_88 = val_95 - 1;
            if(val_88 < val_96)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_137;
            }
            
            }
            
            val_97 = this.GetNewItemByIndex(index:  val_88);
            if(val_97 != 0)
            {
                goto label_50;
            }
            
            val_98 = 0;
            this.mNeedCheckNextMinItem = false;
            return (bool)val_98;
            label_1:
            if(this.mItemList >= 1)
            {
                    this.RecycleAllItem();
            }
            
            label_137:
            val_98 = 0;
            return (bool)val_98;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_55;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_13 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            bool val_103 = this.mIsDraging;
            if((val_103 == true) || (mem[26873928] == this.mListUpdateCheckFrameCount))
            {
                goto label_68;
            }
            
            UnityEngine.Vector3 val_102 = this.mViewPortRectLocalCorners[1];
            val_102 = val_14.y - val_102;
            if(val_102 <= val_86)
            {
                goto label_68;
            }
            
            label_17:
            this.mItemList.RemoveAt(index:  0);
            val_99 = 26873856;
            goto label_70;
            label_4:
            UnityEngine.Vector3 val_15 = this.mContainerTrans.anchoredPosition3D;
            int val_16 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_72;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -0f, index: ref  val_16, itemPos: ref  float val_17 = 1.722371E-23f)) == false)
            {
                goto label_137;
            }
            
            val_103 = val_16;
            goto label_75;
            label_68:
            if(val_103 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_103 = val_103 + ((val_103 - 1) << 3);
            val_88 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32];
            val_88 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32;
            val_88.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_21 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_86 = val_21.y;
            val_104 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_22 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_104, z = this.mItemWorldCorners[0]});
            if((this.mIsDraging == true) || (((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 72) == this.mListUpdateCheckFrameCount))
            {
                goto label_90;
            }
            
            UnityEngine.Vector3 val_109 = this.mViewPortRectLocalCorners[0];
            val_109 = val_109 - val_86;
            if(val_109 <= distanceForRecycle1)
            {
                goto label_90;
            }
            
            label_32:
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_99 = val_88;
            label_70:
            this.RecycleItemTmp(item:  val_99);
            if(this.mSupportScrollBar == true)
            {
                goto label_171;
            }
            
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            goto label_171;
            label_90:
            val_105 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_110 = val_105[0];
            val_110 = val_110 - val_22.y;
            if(val_110 >= 0)
            {
                goto label_99;
            }
            
            val_106 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24];
            val_106 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            val_107 = this.mCurReadyMaxItemIndex;
            if(val_106 > val_107)
            {
                    this.mCurReadyMaxItemIndex = val_106;
                this.mNeedCheckNextMaxItem = true;
                val_107 = val_106;
                val_106 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            }
            
            val_93 = val_106 + 1;
            if(val_93 > val_107)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_99;
            }
            
            }
            
            val_94 = this.GetNewItemByIndex(index:  val_93);
            if(val_94 != 0)
            {
                goto label_102;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            this.CheckIfNeedUpdataItemPos();
            val_105 = this.mViewPortRectLocalCorners;
            label_99:
            UnityEngine.Vector3 val_111 = val_105[1];
            val_111 = val_13.y - val_111;
            if(val_111 >= 0)
            {
                goto label_137;
            }
            
            val_108 = mem[26873880];
            val_109 = this.mCurReadyMinItemIndex;
            if(val_108 < val_109)
            {
                    this.mCurReadyMinItemIndex = val_108;
                this.mNeedCheckNextMinItem = true;
                val_109 = val_108;
                val_108 = mem[26873880];
            }
            
            val_88 = val_108 - 1;
            if(val_88 < val_109)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_137;
            }
            
            }
            
            val_97 = this.GetNewItemByIndex(index:  val_88);
            if(val_97 != 0)
            {
                goto label_111;
            }
            
            val_98 = 0;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = mem[26873880];
            return (bool)val_98;
            label_55:
            UnityEngine.Vector3 val_28 = this.mContainerTrans.anchoredPosition3D;
            val_85 = -0f;
            int val_29 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_114;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  0f, index: ref  val_29, itemPos: ref  float val_30 = 1.722384E-23f)) == false)
            {
                goto label_137;
            }
            
            val_110 = val_85;
            val_111 = val_29;
            val_85 = -val_110;
            goto label_117;
            label_72:
            val_103 = 0;
            label_75:
            SuperScrollView.LoopListViewItem2 val_32 = this.GetNewItemByIndex(index:  0);
            if(val_32 == 0)
            {
                goto label_137;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_35 = val_32.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_35.m_XMin.height, padding:  val_32.mPadding);
            }
            
            this.mItemList.Add(item:  val_32);
            val_112 = -0f;
            val_88 = val_32.CachedRectTransform;
            goto label_126;
            label_41:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_39 = val_94.CachedRectTransform.rect;
                val_113 = val_8.mPadding;
                this.SetItemSize(itemIndex:  val_93, itemSize:  val_39.m_XMin.height, padding:  val_113);
            }
            
            this.mItemList.Add(item:  val_94);
            UnityEngine.Vector3 val_42 = val_88.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_44 = val_88.CachedRectTransform.rect;
            float val_45 = val_44.m_XMin.height;
            val_45 = val_42.y + val_45;
            val_85 = val_45 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 64]);
            goto label_134;
            label_114:
            val_111 = 0;
            label_117:
            SuperScrollView.LoopListViewItem2 val_46 = this.GetNewItemByIndex(index:  0);
            if(val_46 == 0)
            {
                goto label_137;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_49 = val_46.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_49.m_XMin.height, padding:  val_46.mPadding);
            }
            
            this.mItemList.Add(item:  val_46);
            val_88 = val_46.CachedRectTransform;
            val_112 = val_85;
            label_126:
            UnityEngine.Vector3 val_52 = new UnityEngine.Vector3(x:  val_46.mStartPosOffset, y:  val_112, z:  0f);
            val_88.anchoredPosition3D = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
            this.UpdateContentSize();
            goto label_171;
            label_50:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_54 = val_97.CachedRectTransform.rect;
                val_117 = val_10.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_54.m_XMin.height, padding:  val_117);
            }
            
            this.mItemList.Insert(index:  0, item:  val_97);
            UnityEngine.Vector3 val_57 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_59 = val_97.CachedRectTransform.rect;
            float val_60 = val_59.m_XMin.height;
            val_60 = val_57.y - val_60;
            val_85 = val_60 - val_10.mPadding;
            goto label_152;
            label_102:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_62 = val_94.CachedRectTransform.rect;
                val_121 = val_24.mPadding;
                this.SetItemSize(itemIndex:  val_93, itemSize:  val_62.m_XMin.height, padding:  val_121);
            }
            
            this.mItemList.Add(item:  val_94);
            UnityEngine.Vector3 val_65 = val_88.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_67 = val_88.CachedRectTransform.rect;
            float val_68 = val_67.m_XMin.height;
            val_68 = val_65.y - val_68;
            val_85 = val_68 - ((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 64);
            label_134:
            UnityEngine.Vector3 val_70 = new UnityEngine.Vector3(x:  val_24.mStartPosOffset, y:  val_85, z:  0f);
            val_94.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_93 <= this.mCurReadyMaxItemIndex)
            {
                goto label_171;
            }
            
            this.mCurReadyMaxItemIndex = val_93;
            goto label_171;
            label_111:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_72 = val_97.CachedRectTransform.rect;
                val_122 = val_26.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_72.m_XMin.height, padding:  val_122);
            }
            
            this.mItemList.Insert(index:  0, item:  val_97);
            UnityEngine.Vector3 val_75 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_77 = val_97.CachedRectTransform.rect;
            float val_78 = val_77.m_XMin.height;
            val_78 = val_75.y + val_78;
            val_85 = val_78 + val_26.mPadding;
            label_152:
            UnityEngine.Vector3 val_80 = new UnityEngine.Vector3(x:  val_26.mStartPosOffset, y:  val_85, z:  0f);
            val_97.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_88 < this.mCurReadyMinItemIndex)
            {
                    this.mCurReadyMinItemIndex = val_88;
            }
            
            label_171:
            val_98 = 1;
            return (bool)val_98;
        }
        private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_86;
            float val_87;
            UnityEngine.Vector3 val_89;
            UnityEngine.Vector3 val_90;
            SuperScrollView.LoopListViewItem2 val_91;
            UnityEngine.Vector3 val_92;
            UnityEngine.Vector3[] val_93;
            UnityEngine.Vector3 val_94;
            int val_95;
            int val_96;
            int val_97;
            UnityEngine.Object val_98;
            int val_99;
            int val_100;
            UnityEngine.Object val_101;
            float val_102;
            UnityEngine.Vector3[] val_106;
            int val_107;
            int val_108;
            int val_109;
            int val_110;
            var val_111;
            float val_115;
            float val_116;
            float val_117;
            float val_121;
            float val_122;
            val_86 = distanceForNew0;
            val_87 = distanceForRecycle0;
            if(this.mItemTotalCount == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType != 2)
            {
                goto label_3;
            }
            
            if(this.mItemTotalCount == 0)
            {
                goto label_4;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_89 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_89, z = this.mItemWorldCorners[2]});
            if((this.mIsDraging == true) || (mem[26873928] == this.mListUpdateCheckFrameCount))
            {
                goto label_14;
            }
            
            val_89 = this.mViewPortRectLocalCorners[1];
            val_3.x = val_89 - val_3.x;
            if(val_3.x > val_87)
            {
                goto label_17;
            }
            
            label_14:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_90 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_90.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_87 = val_6.x;
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            if((this.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 72]) == this.mListUpdateCheckFrameCount))
            {
                goto label_32;
            }
            
            UnityEngine.Vector3 val_93 = this.mViewPortRectLocalCorners[2];
            val_93 = val_87 - val_93;
            if(val_93 <= distanceForRecycle1)
            {
                goto label_32;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            this.RecycleItemTmp(item:  val_90);
            if(this.mSupportScrollBar == true)
            {
                goto label_174;
            }
            
            goto label_35;
            label_1:
            if(this.mItemList < 1)
            {
                goto label_130;
            }
            
            this.RecycleAllItem();
            goto label_130;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_39;
            }
            
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_10 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_11 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            bool val_101 = this.mIsDraging;
            if((val_101 == true) || (mem[26873928] == this.mListUpdateCheckFrameCount))
            {
                goto label_52;
            }
            
            UnityEngine.Vector3 val_100 = this.mViewPortRectLocalCorners[2];
            val_100 = val_10.x - val_100;
            if(val_100 <= val_87)
            {
                goto label_52;
            }
            
            label_17:
            this.mItemList.RemoveAt(index:  0);
            val_91 = 26873856;
            goto label_54;
            label_52:
            if(val_101 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_101 = val_101 + ((val_101 - 1) << 3);
            val_90 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32];
            val_90 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32;
            val_90.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_87 = val_14.x;
            val_92 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_15 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_92, z = this.mItemWorldCorners[2]});
            if((this.mIsDraging == true) || (((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 72) == this.mListUpdateCheckFrameCount))
            {
                goto label_69;
            }
            
            val_92 = this.mViewPortRectLocalCorners[1];
            val_15.x = val_92 - val_15.x;
            if(val_15.x <= distanceForRecycle1)
            {
                goto label_69;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_91 = val_90;
            label_54:
            this.RecycleItemTmp(item:  val_91);
            if(this.mSupportScrollBar == true)
            {
                goto label_174;
            }
            
            label_35:
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            goto label_174;
            label_32:
            val_93 = this.mViewPortRectLocalCorners;
            val_94 = val_93[2];
            val_7.x = val_7.x - val_94;
            if(val_7.x >= 0)
            {
                goto label_78;
            }
            
            val_95 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            val_96 = this.mCurReadyMaxItemIndex;
            if(val_95 > val_96)
            {
                    this.mCurReadyMaxItemIndex = val_95;
                this.mNeedCheckNextMaxItem = true;
                val_96 = val_95;
                val_95 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            }
            
            val_97 = val_95 + 1;
            if(val_97 > val_96)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_78;
            }
            
            }
            
            val_98 = this.GetNewItemByIndex(index:  val_97);
            if(val_98 != 0)
            {
                goto label_81;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 24];
            this.CheckIfNeedUpdataItemPos();
            val_93 = this.mViewPortRectLocalCorners;
            label_78:
            UnityEngine.Vector3 val_107 = val_93[1];
            val_107 = val_107 - val_2.x;
            if(val_107 >= 0)
            {
                goto label_130;
            }
            
            val_99 = mem[26873880];
            val_100 = this.mCurReadyMinItemIndex;
            if(val_99 < val_100)
            {
                    this.mCurReadyMinItemIndex = val_99;
                this.mNeedCheckNextMinItem = true;
                val_100 = val_99;
                val_99 = mem[26873880];
            }
            
            val_90 = val_99 - 1;
            if(val_90 < val_100)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_130;
            }
            
            }
            
            val_101 = this.GetNewItemByIndex(index:  val_90);
            if(val_101 == 0)
            {
                goto label_90;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_22 = val_101.CachedRectTransform.rect;
                val_102 = val_19.mPadding;
                this.SetItemSize(itemIndex:  val_90, itemSize:  val_22.m_XMin.width, padding:  val_102);
            }
            
            this.mItemList.Insert(index:  0, item:  val_101);
            UnityEngine.Vector3 val_25 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_27 = val_101.CachedRectTransform.rect;
            float val_28 = val_27.m_XMin.width;
            val_28 = val_25.x - val_28;
            val_86 = val_28 - val_19.mPadding;
            goto label_98;
            label_69:
            val_106 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_108 = val_106[1];
            val_108 = val_108 - val_87;
            if(val_108 >= 0)
            {
                goto label_104;
            }
            
            val_107 = mem[(this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24];
            val_107 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            val_108 = this.mCurReadyMaxItemIndex;
            if(val_107 > val_108)
            {
                    this.mCurReadyMaxItemIndex = val_107;
                this.mNeedCheckNextMaxItem = true;
                val_108 = val_107;
                val_107 = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            }
            
            val_97 = val_107 + 1;
            if(val_97 > val_108)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_104;
            }
            
            }
            
            val_98 = this.GetNewItemByIndex(index:  val_97);
            if(val_98 != 0)
            {
                goto label_107;
            }
            
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 24;
            this.CheckIfNeedUpdataItemPos();
            val_106 = this.mViewPortRectLocalCorners;
            label_104:
            UnityEngine.Vector3 val_109 = val_106[2];
            val_109 = val_11.x - val_109;
            if(val_109 >= 0)
            {
                goto label_130;
            }
            
            val_109 = mem[26873880];
            val_110 = this.mCurReadyMinItemIndex;
            if(val_109 < val_110)
            {
                    this.mCurReadyMinItemIndex = val_109;
                this.mNeedCheckNextMinItem = true;
                val_110 = val_109;
                val_109 = mem[26873880];
            }
            
            val_90 = val_109 - 1;
            if(val_90 < val_110)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_130;
            }
            
            }
            
            val_101 = this.GetNewItemByIndex(index:  val_90);
            if(val_101 != 0)
            {
                goto label_116;
            }
            
            label_90:
            val_111 = 0;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = mem[26873880];
            return (bool)val_111;
            label_4:
            UnityEngine.Vector3 val_33 = this.mContainerTrans.anchoredPosition3D;
            int val_34 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_119;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -val_33.x, index: ref  val_34, itemPos: ref  float val_35 = 2.040553E-23f)) == false)
            {
                goto label_130;
            }
            
            val_90 = val_34;
            goto label_122;
            label_39:
            UnityEngine.Vector3 val_37 = this.mContainerTrans.anchoredPosition3D;
            val_86 = -val_37.x;
            int val_38 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_124;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  val_37.x, index: ref  val_38, itemPos: ref  float val_39 = 2.040541E-23f)) == false)
            {
                goto label_130;
            }
            
            val_115 = val_86;
            val_90 = val_38;
            val_86 = -val_115;
            goto label_127;
            label_119:
            val_90 = 0;
            label_122:
            SuperScrollView.LoopListViewItem2 val_41 = this.GetNewItemByIndex(index:  0);
            if(val_41 == 0)
            {
                goto label_130;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_44 = val_41.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_44.m_XMin.width, padding:  val_41.mPadding);
            }
            
            this.mItemList.Add(item:  val_41);
            val_116 = val_41.mStartPosOffset;
            val_90 = val_41.CachedRectTransform;
            goto label_136;
            label_124:
            val_90 = 0;
            label_127:
            SuperScrollView.LoopListViewItem2 val_47 = this.GetNewItemByIndex(index:  0);
            if(val_47 != 0)
            {
                goto label_139;
            }
            
            label_130:
            val_111 = 0;
            return (bool)val_111;
            label_139:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_50 = val_47.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_50.m_XMin.width, padding:  val_47.mPadding);
            }
            
            this.mItemList.Add(item:  val_47);
            val_116 = val_47.mStartPosOffset;
            val_90 = val_47.CachedRectTransform;
            label_136:
            UnityEngine.Vector3 val_53 = new UnityEngine.Vector3(x:  val_86, y:  val_116, z:  0f);
            val_90.anchoredPosition3D = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
            this.UpdateContentSize();
            goto label_174;
            label_81:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_55 = val_98.CachedRectTransform.rect;
                val_117 = val_17.mPadding;
                this.SetItemSize(itemIndex:  val_97, itemSize:  val_55.m_XMin.width, padding:  val_117);
            }
            
            this.mItemList.Add(item:  val_98);
            UnityEngine.Vector3 val_58 = val_90.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_60 = val_90.CachedRectTransform.rect;
            float val_61 = val_60.m_XMin.width;
            val_61 = val_58.x + val_61;
            val_86 = val_61 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 64]);
            goto label_155;
            label_107:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_63 = val_98.CachedRectTransform.rect;
                val_121 = val_29.mPadding;
                this.SetItemSize(itemIndex:  val_97, itemSize:  val_63.m_XMin.width, padding:  val_121);
            }
            
            this.mItemList.Add(item:  val_98);
            UnityEngine.Vector3 val_66 = val_90.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_68 = val_90.CachedRectTransform.rect;
            float val_69 = val_68.m_XMin.width;
            val_69 = val_66.x - val_69;
            val_86 = val_69 - ((this.mIsDraging + ((this.mIsDraging - 1)) << 3) + 32 + 64);
            label_155:
            UnityEngine.Vector3 val_71 = new UnityEngine.Vector3(x:  val_86, y:  val_29.mStartPosOffset, z:  0f);
            val_98.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_97 <= this.mCurReadyMaxItemIndex)
            {
                goto label_174;
            }
            
            this.mCurReadyMaxItemIndex = val_97;
            goto label_174;
            label_116:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_73 = val_101.CachedRectTransform.rect;
                val_122 = val_31.mPadding;
                this.SetItemSize(itemIndex:  val_90, itemSize:  val_73.m_XMin.width, padding:  val_122);
            }
            
            this.mItemList.Insert(index:  0, item:  val_101);
            UnityEngine.Vector3 val_76 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_78 = val_101.CachedRectTransform.rect;
            float val_79 = val_78.m_XMin.width;
            val_79 = val_76.x + val_79;
            val_86 = val_79 + val_31.mPadding;
            label_98:
            UnityEngine.Vector3 val_81 = new UnityEngine.Vector3(x:  val_86, y:  val_31.mStartPosOffset, z:  0f);
            val_101.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z};
            this.UpdateContentSize();
            this.CheckIfNeedUpdataItemPos();
            if(val_90 < this.mCurReadyMinItemIndex)
            {
                    this.mCurReadyMinItemIndex = val_90;
            }
            
            label_174:
            val_111 = 1;
            return (bool)val_111;
        }
        private float GetContentPanelSize()
        {
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_5;
            var val_6;
            System.Collections.Generic.List<SuperScrollView.LoopListViewItem2> val_7;
            float val_9;
            val_5 = this;
            bool val_5 = this.mSupportScrollBar;
            if(val_5 != false)
            {
                    val_6 = 0f;
                if(this.mItemPosMgr.mTotalSize <= 0f)
            {
                    return (float)val_4;
            }
            
                val_6 = this.mItemPosMgr.mTotalSize - this.mLastItemPadding;
                return (float)val_4;
            }
            
            val_7 = this.mItemList;
            if(val_5 == false)
            {
                    return (float)val_4;
            }
            
            bool val_1 = val_5 - 1;
            if()
            {
                    return this.mSupportScrollBar + 32.ItemSize;
            }
            
            if(val_5 != true)
            {
                goto label_8;
            }
            
            val_5 = this.mItemList;
            val_9 = this.mSupportScrollBar + 32.ItemSizeWithPadding;
            if(val_5 <= true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.mSupportScrollBar + 40) != 0)
            {
                goto label_12;
            }
            
            return (float)val_4;
            label_8:
            if(val_1 >= true)
            {
                    var val_6 = 0;
                do
            {
                if(val_5 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                val_7 = this.mItemList;
                val_6 = val_6 + 1;
                val_9 = 0f + ((this.mSupportScrollBar + 0) + 32.ItemSizeWithPadding);
            }
            while(val_6 < val_1);
            
            }
            else
            {
                    val_9 = 0f;
            }
            
            if(val_5 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_1 << 3);
            label_12:
            float val_4 = (this.mSupportScrollBar + ((this.mSupportScrollBar - 1)) << 3) + 32.ItemSize;
            val_4 = val_9 + val_4;
            return (float)val_4;
        }
        private void CheckIfNeedUpdataItemPos()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_21 = 20152224 + (this.mArrangeType) << 2;
            val_21 = val_21 + 20152224;
            goto (20152224 + (this.mArrangeType) << 2 + 20152224);
        }
        private void UpdateAllShownItemsPos()
        {
            var val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            if(W22 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.mContainerTrans.anchoredPosition3D;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.mLastFrameContainerPos, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Time.deltaTime);
            val_44 = 1152921504726016000;
            val_45 = val_4.x;
            val_46 = val_4.z;
            val_47 = val_45;
            val_48 = val_4.y;
            val_49 = val_46;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_47, y = val_48, z = val_49});
            this.mAdjustedVec = val_5;
            mem[1152921513630665312] = val_5.y;
            if(this.mArrangeType <= 3)
            {
                    var val_44 = 20152144 + (this.mArrangeType) << 2;
                val_44 = val_44 + 20152144;
            }
            else
            {
                    if(this.mIsDraging == false)
            {
                    return;
            }
            
                this.mScrollRect.m_Velocity = this.mAdjustedVec.x;
                this.mNeedAdjustVec = true;
            }
        
        }
        private void UpdateContentSize()
        {
            Axis val_6;
            float val_1 = this.GetContentPanelSize();
            UnityEngine.Rect val_2 = this.mContainerTrans.rect;
            if(this.mIsVertList != false)
            {
                    if(val_2.m_XMin.height == val_1)
            {
                    return;
            }
            
                val_6 = 1;
            }
            else
            {
                    if(val_2.m_XMin.width == val_1)
            {
                    return;
            }
            
                val_6 = 0;
            }
            
            this.mContainerTrans.SetSizeWithCurrentAnchors(axis:  val_6, size:  val_1);
        }
        public LoopListView2()
        {
            this.mItemPoolDict = new System.Collections.Generic.Dictionary<System.String, SuperScrollView.ItemPool>();
            this.mItemPoolList = new System.Collections.Generic.List<SuperScrollView.ItemPool>();
            this.mItemPrefabDataList = new System.Collections.Generic.List<SuperScrollView.ItemPrefabConfData>();
            this.mItemList = new System.Collections.Generic.List<SuperScrollView.LoopListViewItem2>();
            this.mItemDefaultWithPaddingSize = 20f;
            this.mItemWorldCorners = new UnityEngine.Vector3[4];
            this.mDistanceForRecycle0 = ;
            this.mDistanceForNew0 = ;
            this.mDistanceForRecycle1 = 300f;
            this.mDistanceForNew1 = 200f;
            this.mViewPortRectLocalCorners = new UnityEngine.Vector3[4];
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            this.mSmoothDumpRate = 0.3f;
            this.mSnapFinishThreshold = 0.1f;
            this.mSupportScrollBar = true;
            this.mSnapVecThreshold = 145f;
            this.mSnapMoveDefaultMaxAbsVec = 3400f;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.mLastFrameContainerPos = val_7;
            mem[1152921513631113596] = val_7.y;
            mem[1152921513631113600] = val_7.z;
            this.mLeftSnapUpdateExtraCount = true;
            this.mCurSnapNearestItemIndex = 0;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            this.mViewPortSnapPivot = val_8;
            mem[1152921513631113648] = val_8.y;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            this.mItemSnapPivot = val_9;
            mem[1152921513631113656] = val_9.y;
            this.mCurSnapData = new LoopListView2.SnapData();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.mLastSnapCheckPos = val_11;
            mem[1152921513631113684] = val_11.y;
            mem[1152921513631113688] = val_11.z;
        }
    
    }

}
