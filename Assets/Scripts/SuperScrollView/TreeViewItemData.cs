using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewItemData
    {
        // Fields
        public string mName;
        public string mIcon;
        public System.Collections.Generic.List<SuperScrollView.ItemData> mChildItemDataList;
        
        // Properties
        public int ChildCount { get; }
        
        // Methods
        public int get_ChildCount()
        {
            return 18545;
        }
        public void AddChild(SuperScrollView.ItemData data)
        {
            this.mChildItemDataList.Add(item:  data);
        }
        public SuperScrollView.ItemData GetChild(int index)
        {
            var val_1;
            bool val_1 = true;
            if(((index & 2147483648) == 0) && (val_1 > index))
            {
                    if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (index << 3);
                val_1 = mem[(true + (index) << 3) + 32];
                val_1 = (true + (index) << 3) + 32;
                return (SuperScrollView.ItemData)val_1;
            }
            
            val_1 = 0;
            return (SuperScrollView.ItemData)val_1;
        }
        public TreeViewItemData()
        {
            this.mChildItemDataList = new System.Collections.Generic.List<SuperScrollView.ItemData>();
        }
    
    }

}
