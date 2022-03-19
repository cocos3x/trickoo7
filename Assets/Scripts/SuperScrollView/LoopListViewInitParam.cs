using UnityEngine;

namespace SuperScrollView
{
    public class LoopListViewInitParam
    {
        // Fields
        public float mDistanceForRecycle0;
        public float mDistanceForNew0;
        public float mDistanceForRecycle1;
        public float mDistanceForNew1;
        public float mSmoothDumpRate;
        public float mSnapFinishThreshold;
        public float mSnapVecThreshold;
        public float mItemDefaultWithPaddingSize;
        
        // Methods
        public static SuperScrollView.LoopListViewInitParam CopyDefaultInitParam()
        {
            SuperScrollView.LoopListViewInitParam val_1 = null;
            .mDistanceForRecycle0 = ;
            .mDistanceForNew0 = ;
            .mDistanceForRecycle1 = 300f;
            .mDistanceForNew1 = 200f;
            .mSmoothDumpRate = ;
            .mSnapFinishThreshold = ;
            .mSnapVecThreshold = 145f;
            .mItemDefaultWithPaddingSize = 20f;
            val_1 = new SuperScrollView.LoopListViewInitParam();
            return val_1;
        }
        public LoopListViewInitParam()
        {
            this.mDistanceForRecycle0 = ;
            this.mDistanceForNew0 = ;
            this.mDistanceForRecycle1 = 300f;
            this.mDistanceForNew1 = 200f;
            this.mSmoothDumpRate = ;
            this.mSnapFinishThreshold = ;
            this.mSnapVecThreshold = 145f;
            this.mItemDefaultWithPaddingSize = 20f;
        }
    
    }

}
