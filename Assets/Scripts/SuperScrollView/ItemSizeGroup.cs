using UnityEngine;

namespace SuperScrollView
{
    public class ItemSizeGroup
    {
        // Fields
        public float[] mItemSizeArray;
        public float[] mItemStartPosArray;
        public int mItemCount;
        private int mDirtyBeginIndex;
        public float mGroupSize;
        public float mGroupStartPos;
        public float mGroupEndPos;
        public int mGroupIndex;
        private float mItemDefaultSize;
        private int mMaxNoZeroIndex;
        
        // Properties
        public bool IsDirty { get; }
        
        // Methods
        public ItemSizeGroup(int index, float itemDefaultSize)
        {
            this.mDirtyBeginIndex = 100;
            this.mGroupIndex = index;
            this.mItemDefaultSize = itemDefaultSize;
            this.Init();
        }
        public void Init()
        {
            float[] val_1 = new float[100];
            this.mItemSizeArray = val_1;
            if(this.mItemDefaultSize == 0f)
            {
                goto label_3;
            }
            
            var val_4 = 0;
            label_5:
            if(val_4 >= (val_1.Length << ))
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_1[val_4] = this.mItemDefaultSize;
            if(this.mItemSizeArray != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_3:
            float[] val_2 = new float[100];
            this.mItemStartPosArray = val_2;
            val_2[0] = 0f;
            this.mItemCount = 100;
            float val_5 = (float)this.mItemSizeArray.Length;
            val_5 = this.mItemDefaultSize * val_5;
            this.mGroupSize = val_5;
            this.mDirtyBeginIndex = (this.mItemDefaultSize == 0f) ? 100 : 0;
        }
        public float GetItemStartPos(int index)
        {
            float val_2 = this.mGroupStartPos;
            val_2 = val_2 + this.mItemStartPosArray[index];
            return (float)val_2;
        }
        public bool get_IsDirty()
        {
            return (bool)(this.mDirtyBeginIndex < this.mItemCount) ? 1 : 0;
        }
        public float SetItemSize(int index, float size)
        {
            if((size > 0f) && (this.mMaxNoZeroIndex < index))
            {
                    this.mMaxNoZeroIndex = index;
            }
            
            float val_1 = this.mItemSizeArray[index];
            if(val_1 == size)
            {
                    return 0f;
            }
            
            mem2[0] = size;
            if(this.mDirtyBeginIndex > index)
            {
                    this.mDirtyBeginIndex = index;
            }
            
            size = size - val_1;
            val_1 = size + this.mGroupSize;
            this.mGroupSize = val_1;
            return 0f;
        }
        public void SetItemCount(int count)
        {
            if(this.mMaxNoZeroIndex > count)
            {
                    this.mMaxNoZeroIndex = count;
            }
            
            if(this.mItemCount == count)
            {
                    return;
            }
            
            this.mItemCount = count;
            this.RecalcGroupSize();
        }
        public void RecalcGroupSize()
        {
            this.mGroupSize = 0f;
            if(this.mItemCount < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            float val_2 = 0f;
            do
            {
                val_1 = val_1 + 1;
                val_2 = val_2 + null;
                this.mGroupSize = val_2;
            }
            while(val_1 < this.mItemCount);
        
        }
        public int GetItemIndexByPos(float pos)
        {
            int val_3;
            var val_4;
            int val_2 = this.mItemCount;
            if(val_2 == 0)
            {
                goto label_13;
            }
            
            if(this.mItemDefaultSize != 0f)
            {
                goto label_1;
            }
            
            val_3 = this.mMaxNoZeroIndex;
            if((val_3 & 2147483648) == 0)
            {
                goto label_3;
            }
            
            val_3 = 0;
            this.mMaxNoZeroIndex = 0;
            goto label_3;
            label_1:
            val_3 = val_2 - 1;
            if((val_3 & 2147483648) != 0)
            {
                goto label_13;
            }
            
            label_3:
            var val_5 = 0;
            label_14:
            val_2 = val_5 + val_3;
            var val_1 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_4 = val_1 >> 1;
            float val_3 = this.mItemStartPosArray[(long)(val_1 >> 1) & 2147483647];
            val_3 = val_3 + (this.mItemSizeArray[(long)(val_1 >> 1) & 2147483647]);
            if(val_3 <= pos)
            {
                    if(val_3 >= pos)
            {
                    return (int)val_4;
            }
            
            }
            
            if(val_3 >= 0)
            {
                goto label_11;
            }
            
            val_5 = val_4 + 1;
            if(val_4 < val_3)
            {
                goto label_14;
            }
            
            goto label_13;
            label_11:
            val_3 = val_4 - 1;
            val_4 = 0;
            if(val_5 < val_4)
            {
                goto label_14;
            }
            
            return (int)val_4;
            label_13:
            val_4 = 0;
            return (int)val_4;
        }
        public void UpdateAllItemStartPos()
        {
            int val_4;
            val_4 = this.mItemCount;
            if(this.mDirtyBeginIndex >= val_4)
            {
                    return;
            }
            
            var val_1 = (this.mDirtyBeginIndex > 1) ? this.mDirtyBeginIndex : (0 + 1);
            if(val_1 < val_4)
            {
                    var val_4 = val_1;
                do
            {
                var val_2 = val_4 - 1;
                val_4 = val_4 + 1;
                this.mItemStartPosArray[val_4] = S0 + S1;
                val_4 = this.mItemCount;
            }
            while(val_4 < val_4);
            
            }
            
            this.mDirtyBeginIndex = val_4;
        }
        public void ClearOldData()
        {
            int val_3 = this.mItemCount;
            if(val_3 > 99)
            {
                    return;
            }
            
            var val_2 = (long)val_3;
            val_2 = val_2 + 8;
            do
            {
                mem2[0] = 0;
                val_2 = val_2 + 1;
                val_3 = val_3 + 1;
            }
            while((val_2 - 8) < 99);
        
        }
    
    }

}
