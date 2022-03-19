using UnityEngine;

namespace SuperScrollView
{
    public class StaggeredGridViewInitParam
    {
        // Fields
        public float mDistanceForRecycle0;
        public float mDistanceForNew0;
        public float mDistanceForRecycle1;
        public float mDistanceForNew1;
        public float mItemDefaultWithPaddingSize;
        
        // Methods
        public static SuperScrollView.StaggeredGridViewInitParam CopyDefaultInitParam()
        {
            SuperScrollView.StaggeredGridViewInitParam val_1 = null;
            .mDistanceForRecycle0 = ;
            .mDistanceForNew0 = ;
            .mDistanceForRecycle1 = 300f;
            .mDistanceForNew1 = 200f;
            .mItemDefaultWithPaddingSize = 20f;
            val_1 = new SuperScrollView.StaggeredGridViewInitParam();
            return val_1;
        }
        public StaggeredGridViewInitParam()
        {
            this.mItemDefaultWithPaddingSize = 20f;
            this.mDistanceForRecycle0 = ;
            this.mDistanceForNew0 = ;
            this.mDistanceForRecycle1 = 300f;
            this.mDistanceForNew1 = 200f;
        }
    
    }

}
