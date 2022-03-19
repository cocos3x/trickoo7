using UnityEngine;

namespace SuperScrollView
{
    public class GridViewSampleDemo : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private const int mItemCountPerRow = 3;
        private int mItemTotalCount;
        
        // Methods
        private void Start()
        {
            var val_3 = 0;
            val_3 = this.mItemTotalCount - val_3;
            this.mLoopListView.InitListView(itemTotalCount:  (val_3 > 0) ? (0 + 1) : 0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.GridViewSampleDemo::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int rowIndex)), initParam:  0);
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int rowIndex)
        {
            var val_7;
            var val_8;
            if((rowIndex & 2147483648) != 0)
            {
                goto label_1;
            }
            
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "RowPrefab");
            val_8 = val_1;
            val_7 = val_1.GetComponent<SuperScrollView.ListItem15>();
            if(val_1.mIsInitHandlerCalled == false)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            label_1:
            val_8 = 0;
            return (SuperScrollView.LoopListViewItem2)val_8;
            label_4:
            bool val_8 = true;
            val_1.mIsInitHandlerCalled = val_8;
            val_7.Init();
            label_5:
            var val_9 = 0;
            do
            {
                if(val_8 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + 0;
                UnityEngine.GameObject val_4 = (true + 0) + 32.gameObject;
                int val_5 = (rowIndex + (rowIndex << 1)) + val_9;
                if(val_5 < this.mItemTotalCount)
            {
                    val_4.SetActive(value:  true);
                if(val_8 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + 0;
                string val_6 = "Item" + val_5;
            }
            else
            {
                    val_4.SetActive(value:  false);
            }
            
                val_9 = val_9 + 1;
            }
            while((val_9 - 1) < 2);
            
            return (SuperScrollView.LoopListViewItem2)val_8;
        }
        public GridViewSampleDemo()
        {
            this.mItemTotalCount = 100;
        }
    
    }

}
