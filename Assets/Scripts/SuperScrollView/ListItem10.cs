using UnityEngine;

namespace SuperScrollView
{
    public class ListItem10 : MonoBehaviour
    {
        // Fields
        public SuperScrollView.ListItem9[] mItemList;
        
        // Methods
        public void Init()
        {
            if(this.mItemList.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.mItemList[val_2].Init();
                val_2 = val_2 + 1;
            }
            while(val_2 < this.mItemList.Length);
        
        }
        public ListItem10()
        {
        
        }
    
    }

}
