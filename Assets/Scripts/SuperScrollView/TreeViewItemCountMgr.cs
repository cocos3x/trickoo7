using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewItemCountMgr
    {
        // Fields
        private System.Collections.Generic.List<SuperScrollView.TreeViewItemCountData> mTreeItemDataList;
        private SuperScrollView.TreeViewItemCountData mLastQueryResult;
        private bool mIsDirty;
        
        // Properties
        public int TreeViewItemCount { get; }
        
        // Methods
        public void AddTreeItem(int count, bool isExpand)
        {
            SuperScrollView.TreeViewItemCountData val_1 = null;
            .mIsExpand = true;
            val_1 = new SuperScrollView.TreeViewItemCountData();
            .mIsExpand = isExpand;
            .mTreeItemIndex = this.mTreeItemDataList;
            .mChildCount = count;
            this.mTreeItemDataList.Add(item:  val_1);
            this.mIsDirty = true;
        }
        public void Clear()
        {
            this.mTreeItemDataList.Clear();
            this.mLastQueryResult = 0;
            this.mIsDirty = true;
        }
        public SuperScrollView.TreeViewItemCountData GetTreeItem(int treeIndex)
        {
            var val_1;
            bool val_1 = true;
            if(((treeIndex & 2147483648) == 0) && (val_1 > treeIndex))
            {
                    if(val_1 <= treeIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (treeIndex << 3);
                val_1 = mem[(true + (treeIndex) << 3) + 32];
                val_1 = (true + (treeIndex) << 3) + 32;
                return (SuperScrollView.TreeViewItemCountData)val_1;
            }
            
            val_1 = 0;
            return (SuperScrollView.TreeViewItemCountData)val_1;
        }
        public void SetItemChildCount(int treeIndex, int count)
        {
            if((treeIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(true <= treeIndex)
            {
                    return;
            }
            
            bool val_1 = true;
            this.mIsDirty = val_1;
            if(val_1 <= treeIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (treeIndex << 3);
            mem2[0] = count;
        }
        public void SetItemExpand(int treeIndex, bool isExpand)
        {
            if((treeIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(true <= treeIndex)
            {
                    return;
            }
            
            bool val_2 = true;
            this.mIsDirty = val_2;
            if(val_2 <= treeIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (treeIndex << 3);
            mem2[0] = isExpand;
        }
        public void ToggleItemExpand(int treeIndex)
        {
            if((treeIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(true <= treeIndex)
            {
                    return;
            }
            
            bool val_1 = true;
            this.mIsDirty = val_1;
            if(val_1 <= treeIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (treeIndex << 3);
            var val_2 = (true + (treeIndex) << 3) + 32 + 24;
            val_2 = val_2 ^ 1;
            mem2[0] = val_2;
        }
        public bool IsTreeItemExpand(int treeIndex)
        {
            if((this.GetTreeItem(treeIndex:  treeIndex)) == null)
            {
                    return (bool)(val_1.mIsExpand == true) ? 1 : 0;
            }
            
            return (bool)(val_1.mIsExpand == true) ? 1 : 0;
        }
        private void UpdateAllTreeItemDataIndex()
        {
            var val_2;
            if(this.mIsDirty == false)
            {
                    return;
            }
            
            this.mLastQueryResult = 0;
            this.mIsDirty = false;
            if(==0)
            {
                    return;
            }
            
            mem2[0] = 0;
            if(W9 != 0)
            {
                
            }
            else
            {
                    val_2 = 0;
            }
            
            mem2[0] = val_2;
            if(26869760 < 2)
            {
                    return;
            }
            
            do
            {
                if(this.mTreeItemDataList <= (5 - 4))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = val_2 + 1;
                mem2[0] = val_2;
                val_2 = W10 + val_2;
                mem2[0] = val_2;
            }
            while(((5 + 1) - 4) < 26869760);
        
        }
        public int get_TreeViewItemCount()
        {
            return 18541;
        }
        public int GetTotalItemAndChildCount()
        {
            System.Collections.Generic.List<SuperScrollView.TreeViewItemCountData> val_2;
            var val_3;
            val_2 = this;
            System.Collections.Generic.List<SuperScrollView.TreeViewItemCountData> val_1 = this.mTreeItemDataList;
            if(!=0)
            {
                    this.UpdateAllTreeItemDataIndex();
                val_2 = this.mTreeItemDataList;
                if(val_1 <= 26869759)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 214958072;
                val_3 = val_1 + 1;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public SuperScrollView.TreeViewItemCountData QueryTreeItemByTotalIndex(int totalIndex)
        {
            var val_5;
            SuperScrollView.TreeViewItemCountData val_6;
            if(((totalIndex & 2147483648) != 0) || (==0))
            {
                goto label_15;
            }
            
            this.UpdateAllTreeItemDataIndex();
            val_6 = this.mLastQueryResult;
            if((val_6 != null) && (this.mLastQueryResult.mBeginIndex <= totalIndex))
            {
                    if(this.mLastQueryResult.mEndIndex >= totalIndex)
            {
                    return (SuperScrollView.TreeViewItemCountData)val_6;
            }
            
            }
            
            val_5 = 26869759;
            if(this.mLastQueryResult.mEndIndex < 0)
            {
                goto label_15;
            }
            
            var val_4 = 0;
            label_16:
            var val_1 = val_4 + val_5;
            var val_2 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            var val_3 = val_2 >> 1;
            if(W9 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (val_3 << 3);
            if(((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) + ((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) >> 1)) << 3) + 32 + 28) <= totalIndex)
            {
                    if(((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) + ((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) >> 1)) << 3) + 32 + 28 + 4) >= totalIndex)
            {
                goto label_12;
            }
            
            }
            
            if(((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) + ((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) >> 1)) << 3) + 32 + 28 + 4) >= totalIndex)
            {
                goto label_13;
            }
            
            val_4 = val_3 + 1;
            if(val_3 < val_5)
            {
                goto label_16;
            }
            
            goto label_15;
            label_13:
            val_6 = 0;
            val_5 = val_3 - 1;
            if(val_4 < val_3)
            {
                goto label_16;
            }
            
            return (SuperScrollView.TreeViewItemCountData)val_6;
            label_15:
            val_6 = 0;
            return (SuperScrollView.TreeViewItemCountData)val_6;
            label_12:
            this.mLastQueryResult = (val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) + ((val_1 < 0x0 ? ((0 + val_5) + 1) : (0 + val_5) >> 1)) << 3) + 32;
            return (SuperScrollView.TreeViewItemCountData)val_6;
        }
        public TreeViewItemCountMgr()
        {
            this.mTreeItemDataList = new System.Collections.Generic.List<SuperScrollView.TreeViewItemCountData>();
            this.mIsDirty = true;
        }
    
    }

}
