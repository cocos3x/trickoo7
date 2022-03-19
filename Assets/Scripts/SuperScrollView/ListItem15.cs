using UnityEngine;

namespace SuperScrollView
{
    public class ListItem15 : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<SuperScrollView.ListItem16> mItemList;
        
        // Methods
        public void Init()
        {
            List.Enumerator<T> val_1 = this.mItemList.GetEnumerator();
            label_3:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 != 0)
            {
                goto label_3;
            }
            
            throw new NullReferenceException();
            label_2:
            0.Dispose();
        }
        public ListItem15()
        {
        
        }
    
    }

}
