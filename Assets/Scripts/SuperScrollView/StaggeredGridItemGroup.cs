using UnityEngine;

namespace SuperScrollView
{
    public class StaggeredGridItemGroup
    {
        // Fields
        private SuperScrollView.LoopStaggeredGridView mParentGridView;
        private SuperScrollView.ListItemArrangeType mArrangeType;
        private System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> mItemList;
        private UnityEngine.RectTransform mContainerTrans;
        private UnityEngine.UI.ScrollRect mScrollRect;
        public int mGroupIndex;
        private UnityEngine.GameObject mGameObject;
        private System.Collections.Generic.List<int> mItemIndexMap;
        private UnityEngine.RectTransform mScrollRectTransform;
        private UnityEngine.RectTransform mViewPortRectTransform;
        private float mItemDefaultWithPaddingSize;
        private int mItemTotalCount;
        private bool mIsVertList;
        private System.Func<int, int, SuperScrollView.LoopStaggeredGridViewItem> mOnGetItemByIndex;
        private UnityEngine.Vector3[] mItemWorldCorners;
        private UnityEngine.Vector3[] mViewPortRectLocalCorners;
        private int mCurReadyMinItemIndex;
        private int mCurReadyMaxItemIndex;
        private bool mNeedCheckNextMinItem;
        private bool mNeedCheckNextMaxItem;
        private SuperScrollView.ItemPosMgr mItemPosMgr;
        private bool mSupportScrollBar;
        private int mLastItemIndex;
        private float mLastItemPadding;
        private UnityEngine.Vector3 mLastFrameContainerPos;
        private int mListUpdateCheckFrameCount;
        
        // Properties
        public System.Collections.Generic.List<int> ItemIndexMap { get; }
        public float ViewPortSize { get; }
        public float ViewPortWidth { get; }
        public float ViewPortHeight { get; }
        private bool IsDraging { get; }
        public int HadCreatedItemCount { get; }
        
        // Methods
        public void Init(SuperScrollView.LoopStaggeredGridView parent, int itemTotalCount, int groupIndex, System.Func<int, int, SuperScrollView.LoopStaggeredGridViewItem> onGetItemByIndex)
        {
            int val_7;
            SuperScrollView.ItemPosMgr val_8;
            this.mGroupIndex = groupIndex;
            this.mParentGridView = parent;
            this.mArrangeType = parent.mArrangeType;
            UnityEngine.GameObject val_1 = parent.gameObject;
            this.mGameObject = val_1;
            this.mScrollRect = val_1.GetComponent<UnityEngine.UI.ScrollRect>();
            this.mItemPosMgr = new SuperScrollView.ItemPosMgr(itemDefaultSize:  this.mItemDefaultWithPaddingSize);
            this.mScrollRectTransform = this.mScrollRect.GetComponent<UnityEngine.RectTransform>();
            this.mContainerTrans = this.mScrollRect.m_Content;
            this.mViewPortRectTransform = this.mScrollRect.m_Viewport;
            if(this.mScrollRect.m_Viewport == 0)
            {
                    this.mViewPortRectTransform = this.mScrollRectTransform;
            }
            
            this.mOnGetItemByIndex = onGetItemByIndex;
            this.mItemTotalCount = itemTotalCount;
            this.mIsVertList = (this.mArrangeType < 2) ? 1 : 0;
            this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
            val_7 = this.mItemTotalCount;
            if((val_7 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_8 = this.mItemPosMgr;
            if(this.mSupportScrollBar == false)
            {
                goto label_10;
            }
            
            if(val_8 != null)
            {
                goto label_11;
            }
            
            label_9:
            val_8 = this.mItemPosMgr;
            this.mSupportScrollBar = false;
            label_10:
            val_7 = 0;
            label_11:
            val_8.SetItemMaxCount(maxCount:  0);
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
        }
        public System.Collections.Generic.List<int> get_ItemIndexMap()
        {
            return (System.Collections.Generic.List<System.Int32>)this.mItemIndexMap;
        }
        public void ResetListView()
        {
            if(this.mViewPortRectTransform != null)
            {
                    this.mViewPortRectTransform.GetLocalCorners(fourCornersArray:  this.mViewPortRectLocalCorners);
                return;
            }
            
            throw new NullReferenceException();
        }
        public SuperScrollView.LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
        {
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_1 = this.mItemList;
            if(==0)
            {
                    return 0;
            }
            
            if((X9 + 24) > itemIndex)
            {
                    return 0;
            }
            
            val_1 = val_1 + 215023608;
            if(val_1 < itemIndex)
            {
                    return 0;
            }
            
            if(26877952 < 1)
            {
                    return 0;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < 26877952);
            
            return 0;
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
        private bool get_IsDraging()
        {
            if(this.mParentGridView != null)
            {
                    return (bool)this.mParentGridView.mIsDraging;
            }
            
            throw new NullReferenceException();
        }
        public SuperScrollView.LoopStaggeredGridViewItem GetShownItemByIndexInGroup(int indexInGroup)
        {
            return 0;
        }
        public int GetIndexInShownItemList(SuperScrollView.LoopStaggeredGridViewItem item)
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
        public void RefreshAllShownItem()
        {
            if(W9 == 0)
            {
                    return;
            }
            
            this.RefreshAllShownItemWithFirstIndexInGroup(firstItemIndexInGroup:  0);
        }
        public void OnItemSizeChanged(int indexInGroup)
        {
            SuperScrollView.LoopStaggeredGridViewItem val_1 = this.GetShownItemByIndexInGroup(indexInGroup:  indexInGroup);
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
            
                this.SetItemSize(itemIndex:  indexInGroup, itemSize:  val_4.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.UpdateAllShownItemsPos();
        }
        public void RefreshItemByIndexInGroup(int indexInGroup)
        {
            if(true == 0)
            {
                    return;
            }
            
            if((X10 + 28) > indexInGroup)
            {
                    return;
            }
        
        }
        public void RefreshAllShownItemWithFirstIndexInGroup(int firstItemIndexInGroup)
        {
            UnityEngine.Object val_13;
            var val_14;
            if(W23 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = 16713.CachedRectTransform.anchoredPosition3D;
            val_14 = val_2.x;
            this.RecycleAllItem();
            if(W23 < 1)
            {
                goto label_8;
            }
            
            var val_13 = 0;
            label_16:
            int val_3 = firstItemIndexInGroup + val_13;
            val_13 = this.GetNewItemByIndexInGroup(indexInGroup:  val_3);
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
            this.UpdateAllShownItemsPos();
            this.mParentGridView.ClearAllTmpRecycledItem();
        }
        public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndexInGroup, UnityEngine.Vector3 pos)
        {
            this.RecycleAllItem();
            SuperScrollView.LoopStaggeredGridViewItem val_1 = this.GetNewItemByIndexInGroup(indexInGroup:  firstItemIndexInGroup);
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
            
                this.SetItemSize(itemIndex:  firstItemIndexInGroup, itemSize:  val_5.m_XMin.width, padding:  val_1.mPadding);
            }
            
            this.mItemList.Add(item:  val_1);
            this.UpdateAllShownItemsPos();
            this.mParentGridView.UpdateListViewWithDefault();
            this.mParentGridView.ClearAllTmpRecycledItem();
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
                    return this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  pos, index: ref  int val_1 = index, itemPos: ref  float val_2 = 1.308731E-22f);
            }
            
            throw new NullReferenceException();
        }
        public float GetItemPos(int itemIndex)
        {
            if(this.mItemPosMgr != null)
            {
                    return this.mItemPosMgr.GetItemPos(itemIndex:  itemIndex);
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetItemCornerPosInViewPort(SuperScrollView.LoopStaggeredGridViewItem item, SuperScrollView.ItemCornerEnum corner = 0)
        {
            item.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3[] val_2 = this.mItemWorldCorners;
            val_2 = val_2 + ((long)corner * 12);
            return this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32, y = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 32 + 4, z = ((long)(int)(corner) * 12) + this.mItemWorldCorners + 40});
        }
        public void RecycleItemTmp(SuperScrollView.LoopStaggeredGridViewItem item)
        {
            if(this.mParentGridView != null)
            {
                    this.mParentGridView.RecycleItemTmp(item:  item);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void RecycleAllItem()
        {
            List.Enumerator<T> val_1 = this.mItemList.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(this.mParentGridView == null)
            {
                    throw new NullReferenceException();
            }
            
            this.mParentGridView.RecycleItemTmp(item:  0);
            goto label_4;
            label_2:
            0.Dispose();
            this.mItemList.Clear();
        }
        public void ClearAllTmpRecycledItem()
        {
            if(this.mParentGridView != null)
            {
                    this.mParentGridView.ClearAllTmpRecycledItem();
                return;
            }
            
            throw new NullReferenceException();
        }
        private SuperScrollView.LoopStaggeredGridViewItem GetNewItemByIndexInGroup(int indexInGroup)
        {
            if(this.mParentGridView != null)
            {
                    return this.mParentGridView.GetNewItemByGroupAndIndex(groupIndex:  this.mGroupIndex, indexInGroup:  indexInGroup);
            }
            
            throw new NullReferenceException();
        }
        public int get_HadCreatedItemCount()
        {
            return 16725;
        }
        public void SetListItemCount(int itemCount)
        {
            int val_2;
            if(this.mItemTotalCount == itemCount)
            {
                    return;
            }
            
            this.mItemTotalCount = itemCount;
            this.UpdateItemIndexMap(oldItemTotalCount:  this.mItemTotalCount);
            val_2 = this.mItemTotalCount;
            if(this.mItemTotalCount < val_2)
            {
                
            }
            else
            {
                    this.mItemPosMgr.SetItemMaxCount(maxCount:  this.HadCreatedItemCount);
                val_2 = this.mItemTotalCount;
            }
            
            this.mItemPosMgr.SetItemMaxCount(maxCount:  val_2);
            this.RecycleAllItem();
            int val_2 = this.mItemTotalCount;
            if(val_2 != 0)
            {
                    if(this.mCurReadyMaxItemIndex >= val_2)
            {
                    val_2 = val_2 - 1;
                this.mCurReadyMaxItemIndex = val_2;
            }
            
                this.mNeedCheckNextMinItem = true;
                this.mNeedCheckNextMaxItem = true;
                return;
            }
            
            this.mNeedCheckNextMinItem = false;
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMinItemIndex = 0;
            this.mCurReadyMaxItemIndex = 0;
            this.mItemIndexMap.Clear();
        }
        private void UpdateItemIndexMap(int oldItemTotalCount)
        {
            System.Collections.Generic.List<System.Int32> val_9;
            var val_10;
            val_9 = this.mItemIndexMap;
            if(W22 == 0)
            {
                    return;
            }
            
            if(this.mItemTotalCount == 0)
            {
                goto label_3;
            }
            
            if(this.mItemTotalCount >= oldItemTotalCount)
            {
                    return;
            }
            
            var val_1 = W22 - 1;
            var val_2 = X9 + (val_1 << 2);
            if(((X9 + ((W22 - 1)) << 2) + 32) >= this.mParentGridView.mItemTotalCount)
            {
                goto label_6;
            }
            
            return;
            label_3:
            val_9.Clear();
            return;
            label_6:
            val_10 = 0;
            if((val_1 & 2147483648) != 0)
            {
                goto label_11;
            }
            
            label_12:
            var val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            var val_4 = val_3 >> 1;
            if(W9 <= (val_3 >> 1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_4 << 2);
            if(((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32) == this.mParentGridView.mItemTotalCount)
            {
                goto label_9;
            }
            
            if(((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32) >= this.mParentGridView.mItemTotalCount)
            {
                goto label_11;
            }
            
            val_10 = val_4 + 1;
            if(val_4 >= val_1)
            {
                goto label_11;
            }
            
            var val_5 = val_4 + W22;
            if(this.mItemIndexMap != null)
            {
                goto label_12;
            }
            
            label_9:
            val_10 = val_4;
            label_11:
            if(val_10 >= W22)
            {
                goto label_14;
            }
            
            val_9 = ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32) + 32;
            label_18:
            if(((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32 + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) + ((val_1 < 0x0 ? ((W22 - 1) + 1) : (W22 - 1) >> 1)) << 2) + 32 + 32)) >= this.mParentGridView.mItemTotalCount)
            {
                goto label_17;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 4;
            if(val_10 < W22)
            {
                goto label_18;
            }
            
            label_14:
            val_10 = 0;
            label_17:
            this.mItemIndexMap.RemoveRange(index:  0, count:  W22 - val_10);
        }
        public void UpdateListViewPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_5;
            float val_6;
            float val_7;
            if(this.mSupportScrollBar != false)
            {
                    this.mItemPosMgr.Update(updateAll:  false);
            }
            
            object val_5 = 1;
            this.mListUpdateCheckFrameCount = this.mParentGridView.mListUpdateCheckFrameCount;
            label_8:
            if(this.mIsVertList == false)
            {
                goto label_4;
            }
            
            val_5 = distanceForRecycle0;
            val_6 = distanceForRecycle1;
            val_7 = distanceForNew0;
            if((this.UpdateForVertListPart1(distanceForRecycle0:  val_5, distanceForRecycle1:  val_6, distanceForNew0:  val_7, distanceForNew1:  distanceForNew1)) == true)
            {
                goto label_5;
            }
            
            goto label_7;
            label_4:
            val_5 = distanceForRecycle0;
            val_6 = distanceForRecycle1;
            val_7 = distanceForNew0;
            if((this.UpdateForHorizontalListPart1(distanceForRecycle0:  val_5, distanceForRecycle1:  val_6, distanceForNew0:  val_7, distanceForNew1:  distanceForNew1)) == false)
            {
                goto label_7;
            }
            
            label_5:
            val_5 = val_5 + 1;
            if(val_5 < 9999)
            {
                goto label_8;
            }
            
            UnityEngine.Debug.LogError(message:  "UpdateListViewPart1 while loop " + val_5 + " times! something is wrong!"(" times! something is wrong!"));
            label_7:
            UnityEngine.Vector3 val_4 = this.mContainerTrans.anchoredPosition3D;
            this.mLastFrameContainerPos = val_4;
            mem[1152921513653188160] = val_4.y;
            mem[1152921513653188164] = val_4.z;
        }
        public bool UpdateListViewPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            if(this.mIsVertList == false)
            {
                    return this.UpdateForHorizontalListPart2(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1);
            }
            
            return this.UpdateForVertListPart2(distanceForRecycle0:  distanceForRecycle0, distanceForRecycle1:  distanceForRecycle1, distanceForNew0:  distanceForNew0, distanceForNew1:  distanceForNew1);
        }
        public bool UpdateForVertListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_85;
            var val_86;
            int val_87;
            float val_88;
            UnityEngine.Vector3 val_89;
            UnityEngine.Vector3 val_90;
            UnityEngine.Vector3[] val_91;
            int val_92;
            int val_93;
            int val_94;
            UnityEngine.Object val_95;
            int val_96;
            int val_97;
            UnityEngine.Object val_98;
            float val_99;
            var val_103;
            SuperScrollView.LoopStaggeredGridViewItem val_104;
            var val_108;
            UnityEngine.Vector3 val_109;
            UnityEngine.Vector3[] val_110;
            int val_111;
            int val_112;
            int val_113;
            int val_114;
            float val_115;
            var val_116;
            float val_118;
            float val_119;
            float val_123;
            float val_124;
            val_85 = distanceForNew1;
            val_86 = this;
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
            
            X21.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            val_88 = val_3.y;
            if((this.mParentGridView.mIsDraging == true) || ((X21 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_87 = this.mViewPortRectLocalCorners[0];
            val_87 = val_87 - val_2.y;
            if(val_87 > distanceForRecycle0)
            {
                goto label_18;
            }
            
            label_15:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_89 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_89.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_90 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_90, z = this.mItemWorldCorners[0]});
            if((this.mParentGridView.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 76]) == this.mListUpdateCheckFrameCount))
            {
                goto label_31;
            }
            
            UnityEngine.Vector3 val_93 = this.mViewPortRectLocalCorners[1];
            val_93 = val_7.y - val_93;
            if(val_93 > distanceForRecycle1)
            {
                goto label_34;
            }
            
            label_31:
            val_91 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_94 = val_91[0];
            val_94 = val_94 - val_88;
            if(val_94 >= 0)
            {
                goto label_40;
            }
            
            val_92 = mem[X21 + 28];
            val_92 = X21 + 28;
            val_93 = this.mCurReadyMinItemIndex;
            if(val_92 < val_93)
            {
                    this.mCurReadyMinItemIndex = val_92;
                this.mNeedCheckNextMinItem = true;
                val_93 = val_92;
                val_92 = X21 + 28;
            }
            
            val_94 = val_92 - 1;
            if(val_94 < val_93)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_40;
            }
            
            }
            
            val_95 = this.GetNewItemByIndexInGroup(indexInGroup:  val_94);
            if(val_95 != 0)
            {
                goto label_43;
            }
            
            val_91 = this.mViewPortRectLocalCorners;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = X21 + 28;
            label_40:
            UnityEngine.Vector3 val_95 = val_91[1];
            val_95 = val_6.y - val_95;
            if(val_95 >= 0)
            {
                goto label_154;
            }
            
            val_96 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 28];
            val_97 = this.mCurReadyMaxItemIndex;
            if(val_96 > val_97)
            {
                    this.mCurReadyMaxItemIndex = val_96;
                this.mNeedCheckNextMaxItem = true;
                val_97 = val_96;
                val_96 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 28];
            }
            
            val_87 = val_96 + 1;
            if(val_87 >= this.mItemIndexMap)
            {
                goto label_154;
            }
            
            if(val_87 > val_97)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_154;
            }
            
            }
            
            val_98 = this.GetNewItemByIndexInGroup(indexInGroup:  val_87);
            if(val_98 == 0)
            {
                goto label_54;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_13 = val_98.CachedRectTransform.rect;
                val_99 = val_10.mPadding;
                this.SetItemSize(itemIndex:  val_87, itemSize:  val_13.m_XMin.height, padding:  val_99);
            }
            
            this.mItemList.Add(item:  val_98);
            UnityEngine.Vector3 val_16 = val_89.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_18 = val_89.CachedRectTransform.rect;
            float val_19 = val_18.m_XMin.height;
            val_19 = val_16.y + val_19;
            val_85 = val_19 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 36]);
            goto label_62;
            label_1:
            if(this.mItemList >= 1)
            {
                    this.RecycleAllItem();
            }
            
            label_154:
            val_103 = 0;
            return (bool)val_103;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_66;
            }
            
            X21.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_21 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_88 = val_21.y;
            UnityEngine.Vector3 val_22 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = this.mItemWorldCorners[0], z = this.mItemWorldCorners[0]});
            bool val_103 = this.mParentGridView.mIsDraging;
            if((val_103 == true) || ((X21 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_80;
            }
            
            UnityEngine.Vector3 val_102 = this.mViewPortRectLocalCorners[1];
            val_102 = val_22.y - val_102;
            if(val_102 <= distanceForRecycle0)
            {
                goto label_80;
            }
            
            label_18:
            this.mItemList.RemoveAt(index:  0);
            val_104 = X21;
            goto label_83;
            label_4:
            UnityEngine.Vector3 val_23 = this.mContainerTrans.anchoredPosition3D;
            int val_24 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_85;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -0f, index: ref  val_24, itemPos: ref  float val_25 = 1.644317E-22f)) == false)
            {
                goto label_154;
            }
            
            val_108 = val_24;
            goto label_88;
            label_80:
            if(val_103 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_103 = val_103 + ((val_103 - 1) << 3);
            val_89 = mem[(this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32];
            val_89 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32;
            val_89.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_29 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_109 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_30 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_109, z = this.mItemWorldCorners[0]});
            if((this.mParentGridView.mIsDraging == true) || (((this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_104;
            }
            
            UnityEngine.Vector3 val_109 = this.mViewPortRectLocalCorners[0];
            val_109 = val_109 - val_29.y;
            if(val_109 <= distanceForRecycle1)
            {
                goto label_104;
            }
            
            label_34:
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_104 = val_89;
            label_83:
            this.mParentGridView.RecycleItemTmp(item:  val_104);
            if(this.mSupportScrollBar == true)
            {
                goto label_180;
            }
            
            this.CheckIfNeedUpdateItemPos();
            goto label_180;
            label_104:
            val_110 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_110 = val_110[1];
            val_110 = val_88 - val_110;
            if(val_110 >= 0)
            {
                goto label_114;
            }
            
            val_111 = mem[X21 + 28];
            val_111 = X21 + 28;
            val_112 = this.mCurReadyMinItemIndex;
            if(val_111 < val_112)
            {
                    this.mCurReadyMinItemIndex = val_111;
                this.mNeedCheckNextMinItem = true;
                val_112 = val_111;
                val_111 = X21 + 28;
            }
            
            val_94 = val_111 - 1;
            if(val_94 < val_112)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_114;
            }
            
            }
            
            val_95 = this.GetNewItemByIndexInGroup(indexInGroup:  val_94);
            if(val_95 != 0)
            {
                goto label_117;
            }
            
            val_110 = this.mViewPortRectLocalCorners;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = X21 + 28;
            label_114:
            UnityEngine.Vector3 val_111 = val_110[0];
            val_111 = val_111 - val_30.y;
            if(val_111 >= 0)
            {
                goto label_154;
            }
            
            val_113 = mem[(this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28];
            val_113 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            val_114 = this.mCurReadyMaxItemIndex;
            if(val_113 > val_114)
            {
                    this.mCurReadyMaxItemIndex = val_113;
                this.mNeedCheckNextMaxItem = true;
                val_114 = val_113;
                val_113 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            }
            
            val_87 = val_113 + 1;
            if(val_87 >= this.mItemIndexMap)
            {
                goto label_154;
            }
            
            if(val_87 > val_114)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_154;
            }
            
            }
            
            val_98 = this.GetNewItemByIndexInGroup(indexInGroup:  val_87);
            if(val_98 != 0)
            {
                goto label_128;
            }
            
            label_54:
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            this.CheckIfNeedUpdateItemPos();
            goto label_154;
            label_66:
            UnityEngine.Vector3 val_36 = this.mContainerTrans.anchoredPosition3D;
            int val_37 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_131;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  0f, index: ref  val_37, itemPos: ref  float val_38 = 1.644327E-22f)) == false)
            {
                goto label_154;
            }
            
            val_116 = val_37;
            val_115 = -(-0f);
            goto label_134;
            label_85:
            val_108 = 0;
            label_88:
            SuperScrollView.LoopStaggeredGridViewItem val_40 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_40 == 0)
            {
                goto label_154;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    val_87 = val_24;
                UnityEngine.Rect val_43 = val_40.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_43.m_XMin.height, padding:  val_40.mPadding);
            }
            
            this.mItemList.Add(item:  val_40);
            UnityEngine.RectTransform val_45 = val_40.CachedRectTransform;
            val_118 = -0f;
            goto label_143;
            label_43:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_47 = val_95.CachedRectTransform.rect;
                val_119 = val_8.mPadding;
                this.SetItemSize(itemIndex:  val_94, itemSize:  val_47.m_XMin.height, padding:  val_119);
            }
            
            this.mItemList.Insert(index:  0, item:  val_95);
            UnityEngine.Vector3 val_50 = X21.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_52 = val_95.CachedRectTransform.rect;
            float val_53 = val_52.m_XMin.height;
            val_53 = val_50.y - val_53;
            val_85 = val_53 - val_8.mPadding;
            goto label_151;
            label_131:
            val_116 = 0;
            label_134:
            SuperScrollView.LoopStaggeredGridViewItem val_54 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_54 == 0)
            {
                goto label_154;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    val_87 = val_37;
                UnityEngine.Rect val_57 = val_54.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_57.m_XMin.height, padding:  val_54.mPadding);
            }
            
            this.mItemList.Add(item:  val_54);
            val_118 = val_115;
            label_143:
            val_86 = val_54.CachedRectTransform;
            UnityEngine.Vector3 val_60 = new UnityEngine.Vector3(x:  val_54.mStartPosOffset, y:  val_118, z:  0f);
            val_86.anchoredPosition3D = new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z};
            goto label_180;
            label_117:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_62 = val_95.CachedRectTransform.rect;
                val_123 = val_32.mPadding;
                this.SetItemSize(itemIndex:  val_94, itemSize:  val_62.m_XMin.height, padding:  val_123);
            }
            
            this.mItemList.Insert(index:  0, item:  val_95);
            UnityEngine.Vector3 val_65 = X21.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_67 = val_95.CachedRectTransform.rect;
            float val_68 = val_67.m_XMin.height;
            val_68 = val_65.y + val_68;
            val_85 = val_68 + val_32.mPadding;
            label_151:
            UnityEngine.Vector3 val_70 = new UnityEngine.Vector3(x:  val_32.mStartPosOffset, y:  val_85, z:  0f);
            val_95.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_94 >= this.mCurReadyMinItemIndex)
            {
                goto label_180;
            }
            
            this.mCurReadyMinItemIndex = val_94;
            goto label_180;
            label_128:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_72 = val_98.CachedRectTransform.rect;
                val_124 = val_34.mPadding;
                this.SetItemSize(itemIndex:  val_87, itemSize:  val_72.m_XMin.height, padding:  val_124);
            }
            
            this.mItemList.Add(item:  val_98);
            UnityEngine.Vector3 val_75 = val_89.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_77 = val_89.CachedRectTransform.rect;
            float val_78 = val_77.m_XMin.height;
            val_78 = val_75.y - val_78;
            val_85 = val_78 - ((this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 36);
            label_62:
            UnityEngine.Vector3 val_80 = new UnityEngine.Vector3(x:  val_34.mStartPosOffset, y:  val_85, z:  0f);
            val_98.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_87 > this.mCurReadyMaxItemIndex)
            {
                    this.mCurReadyMaxItemIndex = val_87;
            }
            
            label_180:
            val_103 = 1;
            return (bool)val_103;
        }
        public bool UpdateForVertListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            UnityEngine.Vector3 val_51;
            bool val_52;
            int val_53;
            int val_54;
            UnityEngine.Object val_55;
            float val_59;
            UnityEngine.Vector3 val_60;
            bool val_61;
            int val_62;
            var val_66;
            float val_67;
            var val_68;
            float val_70;
            int val_48 = this.mItemTotalCount;
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_49 = this.mItemList;
            if(val_48 == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType == 0)
            {
                goto label_3;
            }
            
            if(val_48 == 0)
            {
                goto label_4;
            }
            
            val_48 = val_48 - 1;
            val_49 = val_49 + (val_48 << 3);
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            val_51 = this.mItemWorldCorners[1];
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = val_51, z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_52 = this.mViewPortRectLocalCorners[1];
            val_52 = val_2.y - val_52;
            if(val_52 >= 0)
            {
                    return false;
            }
            
            val_52 = static_value_019A201C;
            val_53 = this.mCurReadyMaxItemIndex;
            if(val_52 > val_53)
            {
                    this.mCurReadyMaxItemIndex = val_52;
                this.mNeedCheckNextMaxItem = true;
                val_53 = val_52;
                val_52 = static_value_019A201C;
            }
            
            val_54 = val_52 + 1;
            if(val_54 > val_53)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                    return false;
            }
            
            }
            
            val_55 = this.GetNewItemByIndexInGroup(indexInGroup:  val_54);
            if(val_55 == 0)
            {
                goto label_18;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_6 = val_55.CachedRectTransform.rect;
                val_51 = val_3.mPadding;
                this.SetItemSize(itemIndex:  val_54, itemSize:  val_6.m_XMin.height, padding:  val_51);
            }
            
            this.mItemList.Add(item:  val_55);
            UnityEngine.Vector3 val_9 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_11 = CachedRectTransform.rect;
            float val_12 = val_11.m_XMin.height;
            val_12 = val_9.y + val_12;
            val_59 = val_12 + static_value_019A2024;
            goto label_26;
            label_1:
            if(val_49 < 1)
            {
                    return false;
            }
            
            this.RecycleAllItem();
            return false;
            label_3:
            if(val_48 == 0)
            {
                goto label_30;
            }
            
            val_48 = val_48 - 1;
            val_49 = val_49 + (val_48 << 3);
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            val_60 = this.mItemWorldCorners[0];
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[0], y = val_60, z = this.mItemWorldCorners[0]});
            UnityEngine.Vector3 val_55 = this.mViewPortRectLocalCorners[0];
            val_55 = val_55 - val_14.y;
            if(val_55 >= 0)
            {
                    return false;
            }
            
            val_61 = static_value_019A201C;
            val_62 = this.mCurReadyMaxItemIndex;
            if(val_61 > val_62)
            {
                    this.mCurReadyMaxItemIndex = val_61;
                this.mNeedCheckNextMaxItem = true;
                val_62 = val_61;
                val_61 = static_value_019A201C;
            }
            
            val_54 = val_61 + 1;
            if(val_54 > val_62)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                    return false;
            }
            
            }
            
            val_55 = this.GetNewItemByIndexInGroup(indexInGroup:  val_54);
            if(val_55 != 0)
            {
                goto label_44;
            }
            
            label_18:
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = static_value_019A201C;
            this.CheckIfNeedUpdateItemPos();
            return false;
            label_4:
            UnityEngine.Vector3 val_17 = this.mContainerTrans.anchoredPosition3D;
            int val_18 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_47;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -0f, index: ref  val_18, itemPos: ref  float val_19 = 1.825447E-22f)) == false)
            {
                    return false;
            }
            
            val_66 = val_18;
            goto label_50;
            label_30:
            UnityEngine.Vector3 val_21 = this.mContainerTrans.anchoredPosition3D;
            int val_22 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_52;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  0f, index: ref  val_22, itemPos: ref  float val_23 = 1.825451E-22f)) == false)
            {
                    return false;
            }
            
            val_68 = val_22;
            val_67 = -(-0f);
            goto label_55;
            label_47:
            val_66 = 0;
            label_50:
            SuperScrollView.LoopStaggeredGridViewItem val_25 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_25 == 0)
            {
                    return false;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_28 = val_25.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_28.m_XMin.height, padding:  val_25.mPadding);
            }
            
            this.mItemList.Add(item:  val_25);
            UnityEngine.RectTransform val_30 = val_25.CachedRectTransform;
            val_70 = -0f;
            goto label_64;
            label_52:
            val_68 = 0;
            label_55:
            SuperScrollView.LoopStaggeredGridViewItem val_31 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_31 == 0)
            {
                    return false;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_34 = val_31.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_34.m_XMin.height, padding:  val_31.mPadding);
            }
            
            this.mItemList.Add(item:  val_31);
            val_70 = val_67;
            label_64:
            UnityEngine.Vector3 val_37 = new UnityEngine.Vector3(x:  val_31.mStartPosOffset, y:  val_70, z:  0f);
            val_31.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
            return false;
            label_44:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_39 = val_55.CachedRectTransform.rect;
                val_60 = val_15.mPadding;
                this.SetItemSize(itemIndex:  val_54, itemSize:  val_39.m_XMin.height, padding:  val_60);
            }
            
            this.mItemList.Add(item:  val_55);
            UnityEngine.Vector3 val_42 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_44 = CachedRectTransform.rect;
            float val_45 = val_44.m_XMin.height;
            val_45 = val_42.y - val_45;
            val_59 = val_45 - static_value_019A2024;
            label_26:
            UnityEngine.Vector3 val_47 = new UnityEngine.Vector3(x:  val_15.mStartPosOffset, y:  val_59, z:  0f);
            val_55.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_54 <= this.mCurReadyMaxItemIndex)
            {
                    return false;
            }
            
            this.mCurReadyMaxItemIndex = val_54;
            return false;
        }
        public bool UpdateForHorizontalListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            float val_86;
            var val_87;
            int val_88;
            float val_89;
            UnityEngine.Vector3 val_90;
            UnityEngine.Vector3 val_91;
            UnityEngine.Vector3 val_92;
            SuperScrollView.LoopStaggeredGridViewItem val_93;
            UnityEngine.Vector3 val_94;
            UnityEngine.Vector3[] val_95;
            int val_96;
            int val_97;
            int val_98;
            UnityEngine.Object val_99;
            int val_100;
            int val_101;
            UnityEngine.Object val_102;
            float val_103;
            UnityEngine.Vector3[] val_107;
            int val_108;
            int val_109;
            int val_110;
            int val_111;
            var val_115;
            float val_116;
            var val_117;
            UnityEngine.Object val_118;
            var val_120;
            float val_121;
            float val_125;
            float val_126;
            val_86 = distanceForNew1;
            val_87 = this;
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
            
            X21.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_89 = val_2.x;
            val_90 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_3 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_90, z = this.mItemWorldCorners[2]});
            if((this.mParentGridView.mIsDraging == true) || ((X21 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_15;
            }
            
            val_90 = this.mViewPortRectLocalCorners[1];
            val_3.x = val_90 - val_3.x;
            if(val_3.x > distanceForRecycle0)
            {
                goto label_18;
            }
            
            label_15:
            if(this.mViewPortRectLocalCorners == null)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_91 = this.mViewPortRectLocalCorners[(this.mViewPortRectLocalCorners - 1) << 3];
            val_91.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_6 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_92 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_7 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_92, z = this.mItemWorldCorners[2]});
            if((this.mParentGridView.mIsDraging == true) || ((mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 76]) == this.mListUpdateCheckFrameCount))
            {
                goto label_34;
            }
            
            UnityEngine.Vector3 val_92 = this.mViewPortRectLocalCorners[2];
            val_92 = val_6.x - val_92;
            if(val_92 <= distanceForRecycle1)
            {
                goto label_34;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            this.mParentGridView.RecycleItemTmp(item:  val_91);
            if(this.mSupportScrollBar == true)
            {
                goto label_185;
            }
            
            goto label_38;
            label_1:
            if(this.mItemList < 1)
            {
                goto label_141;
            }
            
            this.RecycleAllItem();
            goto label_141;
            label_3:
            if(this.mItemTotalCount == 0)
            {
                goto label_42;
            }
            
            X21.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_10 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            UnityEngine.Vector3 val_11 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            bool val_100 = this.mParentGridView.mIsDraging;
            val_89 = val_11.x;
            if((val_100 == true) || ((X21 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_56;
            }
            
            UnityEngine.Vector3 val_99 = this.mViewPortRectLocalCorners[2];
            val_99 = val_10.x - val_99;
            if(val_99 <= distanceForRecycle0)
            {
                goto label_56;
            }
            
            label_18:
            this.mItemList.RemoveAt(index:  0);
            val_93 = X21;
            goto label_59;
            label_56:
            if(val_100 != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_100 = val_100 + ((val_100 - 1) << 3);
            val_91 = mem[(this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32];
            val_91 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32;
            val_91.CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_94 = this.mItemWorldCorners[2];
            UnityEngine.Vector3 val_15 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = val_94, z = this.mItemWorldCorners[2]});
            if((this.mParentGridView.mIsDraging == true) || (((this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 76) == this.mListUpdateCheckFrameCount))
            {
                goto label_75;
            }
            
            val_94 = this.mViewPortRectLocalCorners[1];
            val_15.x = val_94 - val_15.x;
            if(val_15.x <= distanceForRecycle1)
            {
                goto label_75;
            }
            
            this.mItemList.RemoveAt(index:  this.mViewPortRectLocalCorners - 1);
            val_93 = val_91;
            label_59:
            this.mParentGridView.RecycleItemTmp(item:  val_93);
            if(this.mSupportScrollBar == true)
            {
                goto label_185;
            }
            
            label_38:
            this.CheckIfNeedUpdateItemPos();
            goto label_185;
            label_34:
            val_95 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_106 = val_95[1];
            val_106 = val_106 - val_89;
            if(val_106 >= 0)
            {
                goto label_85;
            }
            
            val_96 = mem[X21 + 28];
            val_96 = X21 + 28;
            val_97 = this.mCurReadyMinItemIndex;
            if(val_96 < val_97)
            {
                    this.mCurReadyMinItemIndex = val_96;
                this.mNeedCheckNextMinItem = true;
                val_97 = val_96;
                val_96 = X21 + 28;
            }
            
            val_98 = val_96 - 1;
            if(val_98 < val_97)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_85;
            }
            
            }
            
            val_99 = this.GetNewItemByIndexInGroup(indexInGroup:  val_98);
            if(val_99 != 0)
            {
                goto label_88;
            }
            
            val_95 = this.mViewPortRectLocalCorners;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = X21 + 28;
            label_85:
            UnityEngine.Vector3 val_107 = val_95[2];
            val_107 = val_7.x - val_107;
            if(val_107 >= 0)
            {
                goto label_141;
            }
            
            val_100 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 28];
            val_101 = this.mCurReadyMaxItemIndex;
            if(val_100 > val_101)
            {
                    this.mCurReadyMaxItemIndex = val_100;
                this.mNeedCheckNextMaxItem = true;
                val_101 = val_100;
                val_100 = mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 28];
            }
            
            val_88 = val_100 + 1;
            if(val_88 >= this.mItemIndexMap)
            {
                goto label_141;
            }
            
            if(val_88 > val_101)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_141;
            }
            
            }
            
            val_102 = this.GetNewItemByIndexInGroup(indexInGroup:  val_88);
            if(val_102 == 0)
            {
                goto label_99;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_22 = val_102.CachedRectTransform.rect;
                val_103 = val_19.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_22.m_XMin.width, padding:  val_103);
            }
            
            this.mItemList.Add(item:  val_102);
            UnityEngine.Vector3 val_25 = val_91.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_27 = val_91.CachedRectTransform.rect;
            float val_28 = val_27.m_XMin.width;
            val_28 = val_25.x + val_28;
            val_86 = val_28 + (mem[this.mViewPortRectLocalCorners[((this.mViewPortRectLocalCorners - 1)) << 3][0] + 36]);
            goto label_107;
            label_75:
            val_107 = this.mViewPortRectLocalCorners;
            UnityEngine.Vector3 val_108 = val_107[2];
            val_108 = val_89 - val_108;
            if(val_108 >= 0)
            {
                goto label_113;
            }
            
            val_108 = mem[X21 + 28];
            val_108 = X21 + 28;
            val_109 = this.mCurReadyMinItemIndex;
            if(val_108 < val_109)
            {
                    this.mCurReadyMinItemIndex = val_108;
                this.mNeedCheckNextMinItem = true;
                val_109 = val_108;
                val_108 = X21 + 28;
            }
            
            val_98 = val_108 - 1;
            if(val_98 < val_109)
            {
                    if(this.mNeedCheckNextMinItem == false)
            {
                goto label_113;
            }
            
            }
            
            val_99 = this.GetNewItemByIndexInGroup(indexInGroup:  val_98);
            if(val_99 != 0)
            {
                goto label_116;
            }
            
            val_107 = this.mViewPortRectLocalCorners;
            this.mNeedCheckNextMinItem = false;
            this.mCurReadyMinItemIndex = X21 + 28;
            label_113:
            UnityEngine.Vector3 val_109 = val_107[1];
            val_109 = val_109 - val_14.x;
            if(val_109 >= 0)
            {
                goto label_141;
            }
            
            val_110 = mem[(this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28];
            val_110 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            val_111 = this.mCurReadyMaxItemIndex;
            if(val_110 > val_111)
            {
                    this.mCurReadyMaxItemIndex = val_110;
                this.mNeedCheckNextMaxItem = true;
                val_111 = val_110;
                val_110 = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            }
            
            val_88 = val_110 + 1;
            if(val_88 >= this.mItemIndexMap)
            {
                goto label_141;
            }
            
            if(val_88 > val_111)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                goto label_141;
            }
            
            }
            
            val_102 = this.GetNewItemByIndexInGroup(indexInGroup:  val_88);
            if(val_102 != 0)
            {
                goto label_127;
            }
            
            label_99:
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = (this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 28;
            this.CheckIfNeedUpdateItemPos();
            goto label_141;
            label_4:
            UnityEngine.Vector3 val_33 = this.mContainerTrans.anchoredPosition3D;
            int val_34 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_130;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -val_33.x, index: ref  val_34, itemPos: ref  float val_35 = 2.007608E-22f)) == false)
            {
                goto label_141;
            }
            
            val_115 = val_34;
            goto label_133;
            label_42:
            UnityEngine.Vector3 val_37 = this.mContainerTrans.anchoredPosition3D;
            int val_38 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_135;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  val_37.x, index: ref  val_38, itemPos: ref  float val_39 = 2.007598E-22f)) == false)
            {
                goto label_141;
            }
            
            val_117 = val_38;
            val_116 = -(-val_37.x);
            goto label_138;
            label_130:
            val_115 = 0;
            label_133:
            val_118 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_118 == 0)
            {
                goto label_141;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    val_88 = val_34;
                UnityEngine.Rect val_44 = val_118.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_44.m_XMin.width, padding:  val_41.mPadding);
            }
            
            this.mItemList.Add(item:  val_118);
            UnityEngine.RectTransform val_46 = val_118.CachedRectTransform;
            goto label_147;
            label_135:
            val_117 = 0;
            label_138:
            val_118 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_118 != 0)
            {
                goto label_150;
            }
            
            label_141:
            val_120 = 0;
            return (bool)val_120;
            label_150:
            if(this.mSupportScrollBar != false)
            {
                    val_88 = val_38;
                UnityEngine.Rect val_50 = val_118.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_50.m_XMin.width, padding:  val_47.mPadding);
            }
            
            this.mItemList.Add(item:  val_118);
            label_147:
            val_87 = val_118.CachedRectTransform;
            UnityEngine.Vector3 val_53 = new UnityEngine.Vector3(x:  val_116, y:  val_47.mStartPosOffset, z:  0f);
            val_87.anchoredPosition3D = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
            goto label_185;
            label_88:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_55 = val_99.CachedRectTransform.rect;
                val_121 = val_17.mPadding;
                this.SetItemSize(itemIndex:  val_98, itemSize:  val_55.m_XMin.width, padding:  val_121);
            }
            
            this.mItemList.Insert(index:  0, item:  val_99);
            UnityEngine.Vector3 val_58 = X21.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_60 = val_99.CachedRectTransform.rect;
            float val_61 = val_60.m_XMin.width;
            val_61 = val_58.x - val_61;
            val_86 = val_61 - val_17.mPadding;
            goto label_166;
            label_116:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_63 = val_99.CachedRectTransform.rect;
                val_125 = val_29.mPadding;
                this.SetItemSize(itemIndex:  val_98, itemSize:  val_63.m_XMin.width, padding:  val_125);
            }
            
            this.mItemList.Insert(index:  0, item:  val_99);
            UnityEngine.Vector3 val_66 = X21.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_68 = val_99.CachedRectTransform.rect;
            float val_69 = val_68.m_XMin.width;
            val_69 = val_66.x + val_69;
            val_86 = val_69 + val_29.mPadding;
            label_166:
            UnityEngine.Vector3 val_71 = new UnityEngine.Vector3(x:  val_86, y:  val_29.mStartPosOffset, z:  0f);
            val_99.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_98 >= this.mCurReadyMinItemIndex)
            {
                goto label_185;
            }
            
            this.mCurReadyMinItemIndex = val_98;
            goto label_185;
            label_127:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_73 = val_102.CachedRectTransform.rect;
                val_126 = val_31.mPadding;
                this.SetItemSize(itemIndex:  val_88, itemSize:  val_73.m_XMin.width, padding:  val_126);
            }
            
            this.mItemList.Add(item:  val_102);
            UnityEngine.Vector3 val_76 = val_91.CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_78 = val_91.CachedRectTransform.rect;
            float val_79 = val_78.m_XMin.width;
            val_79 = val_76.x - val_79;
            val_86 = val_79 - ((this.mParentGridView.mIsDraging + ((this.mParentGridView.mIsDraging - 1)) << 3) + 32 + 36);
            label_107:
            UnityEngine.Vector3 val_81 = new UnityEngine.Vector3(x:  val_86, y:  val_31.mStartPosOffset, z:  0f);
            val_102.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_88 > this.mCurReadyMaxItemIndex)
            {
                    this.mCurReadyMaxItemIndex = val_88;
            }
            
            label_185:
            val_120 = 1;
            return (bool)val_120;
        }
        public bool UpdateForHorizontalListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
        {
            UnityEngine.Vector3 val_51;
            bool val_52;
            int val_53;
            int val_54;
            UnityEngine.Object val_55;
            float val_59;
            UnityEngine.Vector3 val_60;
            bool val_61;
            int val_62;
            var val_66;
            float val_67;
            var val_68;
            UnityEngine.Object val_69;
            int val_48 = this.mItemTotalCount;
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_49 = this.mItemList;
            if(val_48 == 0)
            {
                goto label_1;
            }
            
            if(this.mArrangeType != 2)
            {
                goto label_3;
            }
            
            if(val_48 == 0)
            {
                goto label_4;
            }
            
            val_48 = val_48 - 1;
            val_49 = val_49 + (val_48 << 3);
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_2 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[2], y = this.mItemWorldCorners[2], z = this.mItemWorldCorners[2]});
            val_51 = this.mViewPortRectLocalCorners[2];
            val_2.x = val_2.x - val_51;
            if(val_2.x >= 0)
            {
                    return false;
            }
            
            val_52 = static_value_019A201C;
            val_53 = this.mCurReadyMaxItemIndex;
            if(val_52 > val_53)
            {
                    this.mCurReadyMaxItemIndex = val_52;
                this.mNeedCheckNextMaxItem = true;
                val_53 = val_52;
                val_52 = static_value_019A201C;
            }
            
            val_54 = val_52 + 1;
            if(val_54 > val_53)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                    return false;
            }
            
            }
            
            val_55 = this.GetNewItemByIndexInGroup(indexInGroup:  val_54);
            if(val_55 == 0)
            {
                goto label_18;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_6 = val_55.CachedRectTransform.rect;
                val_51 = val_3.mPadding;
                this.SetItemSize(itemIndex:  val_54, itemSize:  val_6.m_XMin.width, padding:  val_51);
            }
            
            this.mItemList.Add(item:  val_55);
            UnityEngine.Vector3 val_9 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_11 = CachedRectTransform.rect;
            float val_12 = val_11.m_XMin.width;
            val_12 = val_9.x + val_12;
            val_59 = val_12 + static_value_019A2024;
            goto label_26;
            label_1:
            if(val_49 < 1)
            {
                    return false;
            }
            
            this.RecycleAllItem();
            return false;
            label_3:
            if(val_48 == 0)
            {
                goto label_30;
            }
            
            val_48 = val_48 - 1;
            val_49 = val_49 + (val_48 << 3);
            CachedRectTransform.GetWorldCorners(fourCornersArray:  this.mItemWorldCorners);
            UnityEngine.Vector3 val_14 = this.mViewPortRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.mItemWorldCorners[1], y = this.mItemWorldCorners[1], z = this.mItemWorldCorners[1]});
            val_60 = this.mViewPortRectLocalCorners[1];
            val_14.x = val_60 - val_14.x;
            if(val_14.x >= 0)
            {
                    return false;
            }
            
            val_61 = static_value_019A201C;
            val_62 = this.mCurReadyMaxItemIndex;
            if(val_61 > val_62)
            {
                    this.mCurReadyMaxItemIndex = val_61;
                this.mNeedCheckNextMaxItem = true;
                val_62 = val_61;
                val_61 = static_value_019A201C;
            }
            
            val_54 = val_61 + 1;
            if(val_54 > val_62)
            {
                    if(this.mNeedCheckNextMaxItem == false)
            {
                    return false;
            }
            
            }
            
            val_55 = this.GetNewItemByIndexInGroup(indexInGroup:  val_54);
            if(val_55 != 0)
            {
                goto label_44;
            }
            
            label_18:
            this.mNeedCheckNextMaxItem = false;
            this.mCurReadyMaxItemIndex = static_value_019A201C;
            this.CheckIfNeedUpdateItemPos();
            return false;
            label_4:
            UnityEngine.Vector3 val_17 = this.mContainerTrans.anchoredPosition3D;
            int val_18 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_47;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  -val_17.x, index: ref  val_18, itemPos: ref  float val_19 = 2.261949E-22f)) == false)
            {
                    return false;
            }
            
            val_66 = val_18;
            goto label_50;
            label_30:
            UnityEngine.Vector3 val_21 = this.mContainerTrans.anchoredPosition3D;
            int val_22 = 0;
            if(this.mSupportScrollBar == false)
            {
                goto label_52;
            }
            
            if((this.mItemPosMgr.GetItemIndexAndPosAtGivenPos(pos:  val_21.x, index: ref  val_22, itemPos: ref  float val_23 = 2.261941E-22f)) == false)
            {
                    return false;
            }
            
            val_68 = val_22;
            val_67 = -(-val_21.x);
            goto label_55;
            label_47:
            val_66 = 0;
            label_50:
            val_69 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_69 == 0)
            {
                    return false;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_28 = val_69.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_28.m_XMin.width, padding:  val_25.mPadding);
            }
            
            this.mItemList.Add(item:  val_69);
            UnityEngine.RectTransform val_30 = val_69.CachedRectTransform;
            goto label_64;
            label_52:
            val_68 = 0;
            label_55:
            val_69 = this.GetNewItemByIndexInGroup(indexInGroup:  0);
            if(val_69 == 0)
            {
                    return false;
            }
            
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_34 = val_69.CachedRectTransform.rect;
                this.SetItemSize(itemIndex:  0, itemSize:  val_34.m_XMin.width, padding:  val_31.mPadding);
            }
            
            this.mItemList.Add(item:  val_69);
            label_64:
            UnityEngine.Vector3 val_37 = new UnityEngine.Vector3(x:  val_67, y:  val_31.mStartPosOffset, z:  0f);
            val_69.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
            return false;
            label_44:
            if(this.mSupportScrollBar != false)
            {
                    UnityEngine.Rect val_39 = val_55.CachedRectTransform.rect;
                val_60 = val_15.mPadding;
                this.SetItemSize(itemIndex:  val_54, itemSize:  val_39.m_XMin.width, padding:  val_60);
            }
            
            this.mItemList.Add(item:  val_55);
            UnityEngine.Vector3 val_42 = CachedRectTransform.anchoredPosition3D;
            UnityEngine.Rect val_44 = CachedRectTransform.rect;
            float val_45 = val_44.m_XMin.width;
            val_45 = val_42.x - val_45;
            val_59 = val_45 - static_value_019A2024;
            label_26:
            UnityEngine.Vector3 val_47 = new UnityEngine.Vector3(x:  val_59, y:  val_15.mStartPosOffset, z:  0f);
            val_55.CachedRectTransform.anchoredPosition3D = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
            this.CheckIfNeedUpdateItemPos();
            if(val_54 <= this.mCurReadyMaxItemIndex)
            {
                    return false;
            }
            
            this.mCurReadyMaxItemIndex = val_54;
            return false;
        }
        public float GetContentPanelSize()
        {
            var val_1;
            if(this.mItemPosMgr != null)
            {
                    val_1 = 0f;
                if(this.mItemPosMgr.mTotalSize <= 0f)
            {
                    return 0f;
            }
            
                val_1 = this.mItemPosMgr.mTotalSize - this.mLastItemPadding;
                return 0f;
            }
            
            throw new NullReferenceException();
        }
        public float GetShownItemPosMaxValue()
        {
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_7 = this.mItemList;
            if(W9 == 0)
            {
                    return (float)System.Math.Abs(null);
            }
            
            if(this.mArrangeType > 3)
            {
                    return (float)System.Math.Abs(null);
            }
            
            val_7 = val_7 + ((W9 - 1) << 3);
            var val_2 = (20154548 + (this.mArrangeType) << 2) + 20154548;
            goto (20154548 + (this.mArrangeType) << 2 + 20154548);
        }
        public void CheckIfNeedUpdateItemPos()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_17 = 20154532 + (this.mArrangeType) << 2;
            val_17 = val_17 + 20154532;
            goto (20154532 + (this.mArrangeType) << 2 + 20154532);
        }
        public void UpdateAllShownItemsPos()
        {
            if(W22 == 0)
            {
                    return;
            }
            
            if(this.mArrangeType > 3)
            {
                    return;
            }
            
            var val_25 = 20154516 + (this.mArrangeType) << 2;
            val_25 = val_25 + 20154516;
            goto (20154516 + (this.mArrangeType) << 2 + 20154516);
        }
        public StaggeredGridItemGroup()
        {
            this.mItemList = new System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem>();
            this.mItemIndexMap = new System.Collections.Generic.List<System.Int32>();
            this.mItemWorldCorners = new UnityEngine.Vector3[4];
            this.mViewPortRectLocalCorners = new UnityEngine.Vector3[4];
            this.mNeedCheckNextMinItem = true;
            this.mNeedCheckNextMaxItem = true;
            this.mSupportScrollBar = true;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.mLastFrameContainerPos = val_5;
            mem[1152921513659877760] = val_5.y;
            mem[1152921513659877764] = val_5.z;
        }
    
    }

}
