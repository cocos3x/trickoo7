using UnityEngine;

namespace SuperScrollView
{
    public class GridItemGroup
    {
        // Fields
        private int mCount;
        private int mGroupIndex;
        private SuperScrollView.LoopGridViewItem mFirst;
        private SuperScrollView.LoopGridViewItem mLast;
        
        // Properties
        public int Count { get; }
        public SuperScrollView.LoopGridViewItem First { get; }
        public SuperScrollView.LoopGridViewItem Last { get; }
        public int GroupIndex { get; set; }
        
        // Methods
        public int get_Count()
        {
            return (int)this.mCount;
        }
        public SuperScrollView.LoopGridViewItem get_First()
        {
            return (SuperScrollView.LoopGridViewItem)this.mFirst;
        }
        public SuperScrollView.LoopGridViewItem get_Last()
        {
            return (SuperScrollView.LoopGridViewItem)this.mLast;
        }
        public int get_GroupIndex()
        {
            return (int)this.mGroupIndex;
        }
        public void set_GroupIndex(int value)
        {
            this.mGroupIndex = value;
        }
        public SuperScrollView.LoopGridViewItem GetItemByColumn(int column)
        {
            goto label_1;
            label_6:
            if(this.mLast == column)
            {
                    return 0;
            }
            
            this.mFirst = 1152921513591163880;
            label_1:
            if(1152921504895397888 != 0)
            {
                goto label_6;
            }
            
            return 0;
        }
        public SuperScrollView.LoopGridViewItem GetItemByRow(int row)
        {
            SuperScrollView.LoopGridViewItem val_2 = this.mFirst;
            goto label_1;
            label_6:
            if(val_2 == row)
            {
                    return 0;
            }
            
            val_2 = 1152921513591279976;
            label_1:
            if(1152921504895397888 != 0)
            {
                goto label_6;
            }
            
            return 0;
        }
        public void ReplaceItem(SuperScrollView.LoopGridViewItem curItem, SuperScrollView.LoopGridViewItem newItem)
        {
            newItem.mPrevItem = curItem.mPrevItem;
            newItem.mNextItem = curItem.mNextItem;
            if(curItem.mPrevItem != 0)
            {
                    newItem.mPrevItem.mNextItem = newItem;
            }
            
            if(newItem.mNextItem != 0)
            {
                    newItem.mNextItem.mPrevItem = newItem;
            }
            
            if(this.mFirst == curItem)
            {
                    this.mFirst = newItem;
            }
            
            if(this.mLast != curItem)
            {
                    return;
            }
            
            this.mLast = newItem;
        }
        public void AddFirst(SuperScrollView.LoopGridViewItem newItem)
        {
            newItem.mPrevItem = 0;
            newItem.mNextItem = 0;
            if(this.mFirst == 0)
            {
                    this.mFirst = newItem;
                this.mLast = newItem;
                newItem.mPrevItem = 0;
                this.mFirst.mNextItem = 0;
            }
            else
            {
                    this.mFirst.mPrevItem = newItem;
                newItem.mPrevItem = 0;
                newItem.mNextItem = this.mFirst;
                this.mFirst = newItem;
            }
            
            int val_2 = this.mCount;
            val_2 = val_2 + 1;
            this.mCount = val_2;
        }
        public void AddLast(SuperScrollView.LoopGridViewItem newItem)
        {
            newItem.mPrevItem = 0;
            newItem.mNextItem = 0;
            if(this.mFirst == 0)
            {
                    this.mFirst = newItem;
                this.mLast = newItem;
                newItem.mPrevItem = 0;
                this.mFirst.mNextItem = 0;
            }
            else
            {
                    this.mLast.mNextItem = newItem;
                newItem.mPrevItem = this.mLast;
                newItem.mNextItem = 0;
                this.mLast = newItem;
            }
            
            int val_2 = this.mCount;
            val_2 = val_2 + 1;
            this.mCount = val_2;
        }
        public SuperScrollView.LoopGridViewItem RemoveFirst()
        {
            if(this.mFirst == 0)
            {
                    return (SuperScrollView.LoopGridViewItem)this.mFirst;
            }
            
            1152921504729477120 = this.mLast;
            if(this.mFirst == 1152921504729477120)
            {
                    this.mFirst = 0;
                this.mLast = 0;
            }
            else
            {
                    this.mFirst = 1;
                mem[25769803889] = 0;
            }
            
            int val_3 = this.mCount;
            val_3 = val_3 - 1;
            this.mCount = val_3;
            return (SuperScrollView.LoopGridViewItem)this.mFirst;
        }
        public SuperScrollView.LoopGridViewItem RemoveLast()
        {
            SuperScrollView.LoopGridViewItem val_3 = this.mFirst;
            if(val_3 == 0)
            {
                    return (SuperScrollView.LoopGridViewItem)this.mLast;
            }
            
            val_3 = this.mLast;
            if(this.mFirst == val_3)
            {
                    this.mFirst = 0;
                this.mLast = 0;
            }
            else
            {
                    this.mLast = this.mLast.mPrevItem;
                this.mLast.mPrevItem.mNextItem = 0;
            }
            
            int val_3 = this.mCount;
            val_3 = val_3 - 1;
            this.mCount = val_3;
            return (SuperScrollView.LoopGridViewItem)this.mLast;
        }
        public void Clear()
        {
            goto label_1;
            label_5:
            this.mFirst.mPrevItem = 0;
            this.mFirst.mNextItem = 0;
            this.mFirst = 0;
            label_1:
            if(this.mFirst != 0)
            {
                goto label_5;
            }
            
            this.mCount = 0;
            this.mFirst = 0;
            mem[1152921513592185360] = 0;
        }
        public GridItemGroup()
        {
            this.mGroupIndex = 0;
        }
    
    }

}
