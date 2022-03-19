using UnityEngine;

namespace SuperScrollView
{
    public class GridViewLayoutParam
    {
        // Fields
        public int mColumnOrRowCount;
        public float mItemWidthOrHeight;
        public float mPadding1;
        public float mPadding2;
        public float[] mCustomColumnOrRowOffsetArray;
        
        // Methods
        public bool CheckParam()
        {
            var val_1;
            object val_2;
            if(this.mColumnOrRowCount <= 0)
            {
                goto label_1;
            }
            
            if(this.mItemWidthOrHeight <= 0f)
            {
                goto label_2;
            }
            
            if(this.mCustomColumnOrRowOffsetArray != null)
            {
                    if(this.mColumnOrRowCount != this.mCustomColumnOrRowOffsetArray.Length)
            {
                goto label_4;
            }
            
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_1:
            val_2 = "mColumnOrRowCount shoud be > 0";
            goto label_11;
            label_2:
            val_2 = "mItemWidthOrHeight shoud be > 0";
            goto label_11;
            label_4:
            val_2 = "mGroupOffsetArray.Length != mColumnOrRowCount";
            label_11:
            UnityEngine.Debug.LogError(message:  val_2);
            val_1 = 0;
            return (bool)val_1;
        }
        public GridViewLayoutParam()
        {
        
        }
    
    }

}
