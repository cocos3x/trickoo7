using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewItemCountData
    {
        // Fields
        public int mTreeItemIndex;
        public int mChildCount;
        public bool mIsExpand;
        public int mBeginIndex;
        public int mEndIndex;
        
        // Methods
        public bool IsChild(int index)
        {
            return (bool)(this.mBeginIndex != index) ? 1 : 0;
        }
        public int GetChildIndex(int index)
        {
            return (int)(~this.mBeginIndex) + index;
        }
        public TreeViewItemCountData()
        {
            this.mIsExpand = true;
        }
    
    }

}
