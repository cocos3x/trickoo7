using UnityEngine;

namespace SuperScrollView
{
    public class ListItem6 : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<SuperScrollView.ListItem5> mItemList;
        
        // Methods
        public void Init()
        {
            List.Enumerator<T> val_1 = this.mItemList.GetEnumerator();
            label_4:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.Init();
            goto label_4;
            label_2:
            0.Dispose();
        }
        public ListItem6()
        {
        
        }
    
    }

}
