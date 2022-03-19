using UnityEngine;

namespace SuperScrollView
{
    public class LoopGridViewInitParam
    {
        // Fields
        public float mSmoothDumpRate;
        public float mSnapFinishThreshold;
        public float mSnapVecThreshold;
        
        // Methods
        public static SuperScrollView.LoopGridViewInitParam CopyDefaultInitParam()
        {
            SuperScrollView.LoopGridViewInitParam val_1 = null;
            .mSmoothDumpRate = 0.3f;
            .mSnapFinishThreshold = 0.01f;
            .mSnapVecThreshold = 145f;
            val_1 = new SuperScrollView.LoopGridViewInitParam();
            return val_1;
        }
        public LoopGridViewInitParam()
        {
            this.mSnapVecThreshold = 145f;
            this.mSmoothDumpRate = 0.3f;
            this.mSnapFinishThreshold = 0.01f;
        }
    
    }

}
