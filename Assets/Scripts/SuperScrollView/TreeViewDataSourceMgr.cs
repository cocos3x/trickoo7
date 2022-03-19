using UnityEngine;

namespace SuperScrollView
{
    public class TreeViewDataSourceMgr : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<SuperScrollView.TreeViewItemData> mItemDataList;
        private static SuperScrollView.TreeViewDataSourceMgr instance;
        private int mTreeViewItemCount;
        private int mTreeViewChildItemCount;
        
        // Properties
        public static SuperScrollView.TreeViewDataSourceMgr Get { get; }
        public int TreeViewItemCount { get; }
        public int TotalTreeViewItemAndChildCount { get; }
        
        // Methods
        public static SuperScrollView.TreeViewDataSourceMgr get_Get()
        {
            var val_3;
            SuperScrollView.TreeViewDataSourceMgr val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = SuperScrollView.TreeViewDataSourceMgr.instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<SuperScrollView.TreeViewDataSourceMgr>();
                val_5 = null;
                SuperScrollView.TreeViewDataSourceMgr.instance = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (SuperScrollView.TreeViewDataSourceMgr)SuperScrollView.TreeViewDataSourceMgr.instance;
        }
        private void Awake()
        {
            this.DoRefreshDataSource();
        }
        public void Init()
        {
            this.DoRefreshDataSource();
        }
        public SuperScrollView.TreeViewItemData GetItemDataByIndex(int index)
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
                return (SuperScrollView.TreeViewItemData)val_1;
            }
            
            val_1 = 0;
            return (SuperScrollView.TreeViewItemData)val_1;
        }
        public SuperScrollView.ItemData GetItemChildDataByIndex(int itemIndex, int childIndex)
        {
            SuperScrollView.TreeViewItemData val_1 = this.GetItemDataByIndex(index:  itemIndex);
            if(val_1 == null)
            {
                    return (SuperScrollView.ItemData)val_1;
            }
            
            return val_1.GetChild(index:  childIndex);
        }
        public int get_TreeViewItemCount()
        {
            return 18526;
        }
        public int get_TotalTreeViewItemAndChildCount()
        {
            var val_2;
            bool val_2 = true;
            if(W21 >= 1)
            {
                    var val_3 = 0;
                do
            {
                if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 0;
                val_3 = val_3 + 1;
                val_2 = ((true + 0) + 32.ChildCount) + 0;
                if(val_3 >= W21)
            {
                    return (int)val_2;
            }
            
            }
            while(this.mItemDataList != null);
            
                throw new NullReferenceException();
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public void AddNewItemChildForTest(int itemIndex, int AddToBeforeChildIndex)
        {
            SuperScrollView.ItemData val_10;
            int val_11;
            int val_12;
            var val_13;
            var val_14;
            val_11 = itemIndex;
            bool val_10 = true;
            if((val_11 & 2147483648) != 0)
            {
                    return;
            }
            
            if(val_10 <= val_11)
            {
                    return;
            }
            
            if(val_10 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (val_11 << 3);
            SuperScrollView.ItemData val_1 = null;
            val_10 = val_1;
            val_1 = new SuperScrollView.ItemData();
            object[] val_2 = new object[4];
            val_2[0] = "New Added Item";
            val_12 = val_2.Length;
            val_2[1] = val_11;
            val_12 = val_2.Length;
            val_2[2] = ":";
            val_11 = AddToBeforeChildIndex;
            val_2[3] = val_11;
            string val_3 = +val_2;
            .mName = val_3;
            .mDesc = "Item Desc For " + val_3;
            .mIcon = SuperScrollView.ResManager.Get.GetSpriteNameByIndex(index:  UnityEngine.Random.Range(min:  0, max:  24));
            .mStarCount = UnityEngine.Random.Range(min:  0, max:  6);
            .mFileSize = UnityEngine.Random.Range(min:  20, max:  231);
            if((AddToBeforeChildIndex & 2147483648) != 0)
            {
                goto label_24;
            }
            
            if(((true + (itemIndex) << 3) + 32 + 32 + 24) <= AddToBeforeChildIndex)
            {
                goto label_25;
            }
            
            val_13 = 1152921513518772752;
            val_14 = AddToBeforeChildIndex;
            goto label_26;
            label_24:
            val_13 = 1152921513518772752;
            val_14 = 0;
            label_26:
            (true + (itemIndex) << 3) + 32 + 32.Insert(index:  0, item:  val_1);
            return;
            label_25:
            (true + (itemIndex) << 3) + 32 + 32.Add(item:  val_1);
        }
        private void DoRefreshDataSource()
        {
            int val_15;
            SuperScrollView.ItemData val_16;
            int val_17;
            this.mItemDataList.Clear();
            if(this.mTreeViewItemCount < 1)
            {
                    return;
            }
            
            object val_16 = 0;
            do
            {
                SuperScrollView.TreeViewItemData val_1 = new SuperScrollView.TreeViewItemData();
                .mName = "Item" + val_16;
                val_16 = SuperScrollView.ResManager.Get;
                .mIcon = val_16.GetSpriteNameByIndex(index:  UnityEngine.Random.Range(min:  0, max:  24));
                this.mItemDataList.Add(item:  val_1);
                val_15 = this.mTreeViewChildItemCount;
                if(val_15 >= 1)
            {
                    object val_15 = 1;
                do
            {
                SuperScrollView.ItemData val_6 = null;
                val_16 = val_6;
                val_6 = new SuperScrollView.ItemData();
                object[] val_7 = new object[4];
                val_7[0] = "Item";
                val_17 = val_7.Length;
                val_7[1] = val_16;
                val_17 = val_7.Length;
                val_7[2] = ":Child";
                val_7[3] = val_15;
                string val_8 = +val_7;
                .mName = val_8;
                .mDesc = "Item Desc For " + val_8;
                .mIcon = SuperScrollView.ResManager.Get.GetSpriteNameByIndex(index:  UnityEngine.Random.Range(min:  0, max:  24));
                .mStarCount = UnityEngine.Random.Range(min:  0, max:  6);
                .mFileSize = UnityEngine.Random.Range(min:  20, max:  231);
                val_1.AddChild(data:  val_6);
                val_15 = val_15 + 1;
            }
            while(val_15 <= val_15);
            
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 < this.mTreeViewItemCount);
        
        }
        public TreeViewDataSourceMgr()
        {
            this.mItemDataList = new System.Collections.Generic.List<SuperScrollView.TreeViewItemData>();
            this.mTreeViewItemCount = 20;
            this.mTreeViewChildItemCount = 30;
        }
        private static TreeViewDataSourceMgr()
        {
        
        }
    
    }

}
