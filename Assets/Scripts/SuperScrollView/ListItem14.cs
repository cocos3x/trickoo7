using UnityEngine;

namespace SuperScrollView
{
    public class ListItem14 : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<SuperScrollView.ListItem14Elem> mElemItemList;
        
        // Methods
        public void Init()
        {
            int val_2 = this.transform.childCount;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_11 = 0;
            do
            {
                UnityEngine.Transform val_4 = this.transform.GetChild(index:  0);
                .mRootObj = val_4.gameObject;
                .mIcon = val_4.Find(n:  "ItemIcon").GetComponent<UnityEngine.UI.Image>();
                .mName = val_4.Find(n:  "ItemIcon/name").GetComponent<UnityEngine.UI.Text>();
                this.mElemItemList.Add(item:  new SuperScrollView.ListItem14Elem());
                val_11 = val_11 + 1;
            }
            while(val_11 < val_2);
        
        }
        public ListItem14()
        {
            this.mElemItemList = new System.Collections.Generic.List<SuperScrollView.ListItem14Elem>();
        }
    
    }

}
