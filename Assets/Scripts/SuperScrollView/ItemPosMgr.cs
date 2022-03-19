using UnityEngine;

namespace SuperScrollView
{
    public class ItemPosMgr
    {
        // Fields
        public const int mItemMaxCountPerGroup = 100;
        private System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> mItemSizeGroupList;
        private int mDirtyBeginIndex;
        public float mTotalSize;
        public float mItemDefaultSize;
        private int mMaxNotEmptyGroupIndex;
        
        // Methods
        public ItemPosMgr(float itemDefaultSize)
        {
            this.mItemSizeGroupList = new System.Collections.Generic.List<SuperScrollView.ItemSizeGroup>();
            this.mDirtyBeginIndex = 2147483647;
            this.mItemDefaultSize = 20f;
            this.mItemDefaultSize = itemDefaultSize;
        }
        public void SetItemMaxCount(int maxCount)
        {
            int val_11;
            var val_12;
            int val_1 = (0 > 0) ? (0 + 1) : 0;
            var val_2 = (0 < 1) ? 100 : 0;
            this.mDirtyBeginIndex = 0;
            this.mTotalSize = 0f;
            if(0 <= 1)
            {
                goto label_2;
            }
            
            this.mItemSizeGroupList.RemoveRange(index:  val_1, count:  W22 - val_1);
            goto label_11;
            label_2:
            if(0 >= 1)
            {
                goto label_4;
            }
            
            var val_4 = W22 - 1;
            if(0 >= 1)
            {
                    val_4 = 100 + (val_4 << 3);
                (100 + ((W22 - 1)) << 3) + 32.ClearOldData();
            }
            
            var val_5 = val_1 - W22;
            if(val_5 < 1)
            {
                goto label_11;
            }
            
            val_12 = 1152921504895291392;
            var val_10 = 0;
            do
            {
                SuperScrollView.ItemSizeGroup val_6 = null;
                val_11 = W22 + val_10;
                .mDirtyBeginIndex = 100;
                val_6 = new SuperScrollView.ItemSizeGroup();
                .mGroupIndex = val_11;
                .mItemDefaultSize = this.mItemDefaultSize;
                val_6.Init();
                this.mItemSizeGroupList.Add(item:  val_6);
                val_10 = val_10 + 1;
            }
            while(val_10 < val_5);
            
            goto label_11;
            label_4:
            var val_7 = W22 - 1;
            if(0 >= 1)
            {
                    val_7 = 100 + (val_7 << 3);
                (100 + ((W22 - 1)) << 3) + 32.ClearOldData();
            }
            
            label_11:
            var val_8 = val_1 - 1;
            int val_9 = (val_8 < this.mMaxNotEmptyGroupIndex) ? (val_8) : this.mMaxNotEmptyGroupIndex;
            if((val_8 < this.mMaxNotEmptyGroupIndex) || ((val_9 & 2147483648) != 0))
            {
                goto label_15;
            }
            
            if(val_1 != 0)
            {
                goto label_16;
            }
            
            return;
            label_15:
            val_9 = val_9 & (~(val_9 >> 31));
            this.mMaxNotEmptyGroupIndex = val_9;
            if(val_1 == 0)
            {
                    return;
            }
            
            label_16:
            var val_11 = 0;
            val_12 = 100;
            label_24:
            if(val_11 >= val_8)
            {
                goto label_19;
            }
            
            if(val_9 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            if((((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32 + 60) >= 101)
            {
                    mem2[0] = 100;
            }
            
            if((((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32 + 32) != 100)
            {
                    mem2[0] = 100;
                ((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32.RecalcGroupSize();
            }
            
            val_11 = val_11 + 1;
            if(this.mItemSizeGroupList != null)
            {
                goto label_24;
            }
            
            label_19:
            if(val_9 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (val_8 << 3);
            if((((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32 + 60) > val_2)
            {
                    mem2[0] = val_2;
            }
            
            var val_12 = ((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32 + 32;
            if(val_12 != val_2)
            {
                    mem2[0] = val_2;
                ((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIn + 32.RecalcGroupSize();
            }
            
            if(val_1 < 1)
            {
                    return;
            }
            
            float val_13 = this.mTotalSize;
            do
            {
                if(val_12 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + 0;
                val_11 = 0 + 1;
                val_13 = val_13 + ((((val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupIndex & (~((int)val_8 < this.mMaxNotEmptyGroupIndex ? (0 > 0x0 ? (0 + 1) : 0 - 1) : this.mMaxNotEmptyGroupI + 32 + 40);
                this.mTotalSize = val_13;
            }
            while(val_11 < val_1);
        
        }
        public void SetItemSize(int itemIndex, float size)
        {
            var val_2 = 0;
            if(W9 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            itemIndex = itemIndex - (0 * 100);
            float val_1 = (0 + 0) + 32.SetItemSize(index:  itemIndex, size:  size);
            if((val_1 != 0f) && (0 < this.mDirtyBeginIndex))
            {
                    this.mDirtyBeginIndex = 0;
            }
            
            val_1 = val_1 + this.mTotalSize;
            this.mTotalSize = val_1;
            if(size <= 0f)
            {
                    return;
            }
            
            if(0 <= this.mMaxNotEmptyGroupIndex)
            {
                    return;
            }
            
            this.mMaxNotEmptyGroupIndex = 0;
        }
        public float GetItemPos(int itemIndex)
        {
            this.Update(updateAll:  true);
            var val_2 = 0;
            if(W9 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            return (0 + 0) + 32.GetItemStartPos(index:  itemIndex - (0 * 100));
        }
        public bool GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
        {
            int val_6;
            var val_7;
            this.Update(updateAll:  true);
            index = 0;
            itemPos = 0f;
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_5 = this.mItemSizeGroupList;
            if(val_5 == null)
            {
                goto label_2;
            }
            
            if(this.mItemDefaultSize != 0f)
            {
                goto label_3;
            }
            
            val_6 = this.mMaxNotEmptyGroupIndex;
            if((val_6 & 2147483648) == 0)
            {
                goto label_5;
            }
            
            val_6 = 0;
            this.mMaxNotEmptyGroupIndex = 0;
            goto label_5;
            label_3:
            val_6 = val_5 - 1;
            if((val_6 & 2147483648) != 0)
            {
                goto label_17;
            }
            
            label_5:
            var val_6 = 0;
            label_15:
            val_5 = val_6 + val_6;
            var val_1 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            var val_2 = val_1 >> 1;
            if(W9 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (val_2 << 3);
            float val_7 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44;
            if(val_7 <= pos)
            {
                    if(((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44 + 4) >= pos)
            {
                goto label_11;
            }
            
            }
            
            if(((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 44 + 4) >= 0)
            {
                goto label_12;
            }
            
            val_6 = val_2 + 1;
            if(val_2 < val_6)
            {
                goto label_15;
            }
            
            goto label_17;
            label_12:
            val_7 = 0;
            val_6 = val_2 - 1;
            if(val_6 < val_2)
            {
                goto label_15;
            }
            
            return (bool)val_7;
            label_11:
            val_7 = pos - val_7;
            int val_3 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32.GetItemIndexByPos(pos:  val_7);
            if((val_3 & 2147483648) != 0)
            {
                goto label_17;
            }
            
            int val_8 = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32 + 52;
            val_8 = val_3 + (val_8 * 100);
            index = val_8;
            itemPos = (this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 + (this.mItemSizeGroupList - 1)) + ((this.mItemSizeGroupList < null ? ((0 + (this.mItemSizeGroupList - 1)) + 1) : (0 +  + 32.GetItemStartPos(index:  val_3);
            label_2:
            val_7 = 1;
            return (bool)val_7;
            label_17:
            val_7 = 0;
            return (bool)val_7;
        }
        public void Update(bool updateAll)
        {
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_8;
            System.Collections.Generic.List<SuperScrollView.ItemSizeGroup> val_9;
            bool val_7 = true;
            val_8 = this.mItemSizeGroupList;
            if(W22 == 0)
            {
                    return;
            }
            
            if(this.mDirtyBeginIndex >= W22)
            {
                    return;
            }
            
            var val_9 = 1;
            do
            {
                val_9 = this.mDirtyBeginIndex + val_9;
                int val_1 = val_9 - 1;
                if(val_7 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (val_1 << 3);
                val_8 = mem[(true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32];
                val_8 = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32;
                int val_2 = this.mDirtyBeginIndex + 1;
                this.mDirtyBeginIndex = val_2;
                val_8.UpdateAllItemStartPos();
                if(val_9 == 1)
            {
                    mem2[0] = 0;
                mem2[0] = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32 + 40;
            }
            else
            {
                    val_9 = this.mItemSizeGroupList;
                int val_4 = (this.mDirtyBeginIndex + val_9) - 2;
                if(val_2 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (val_4 << 3);
                float val_8 = (true + (((this.mDirtyBeginIndex + 1) - 1)) << 3) + 32 + 40;
                val_8 = (((this.mDirtyBeginIndex + 1) + (((this.mDirtyBeginIndex + 1) - 2)) << 3) + 32 + 48) + val_8;
                mem2[0] = ((this.mDirtyBeginIndex + 1) + (((this.mDirtyBeginIndex + 1) - 2)) << 3) + 32 + 48;
                mem2[0] = val_8;
            }
            
                var val_5 = (val_9 < 2) ? 1 : 0;
                val_5 = val_5 | updateAll;
                if(val_5 == false)
            {
                    return;
            }
            
                if((this.mDirtyBeginIndex + val_9) >= W22)
            {
                    return;
            }
            
                val_8 = this.mItemSizeGroupList;
                val_9 = val_9 + 1;
            }
            while(val_8 != null);
            
            throw new NullReferenceException();
        }
    
    }

}
