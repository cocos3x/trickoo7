using UnityEngine;

namespace SuperScrollView
{
    public class DataSourceMgr : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<SuperScrollView.ItemData> mItemDataList;
        private System.Action mOnRefreshFinished;
        private System.Action mOnLoadMoreFinished;
        private int mLoadMoreCount;
        private float mDataLoadLeftTime;
        private float mDataRefreshLeftTime;
        private bool mIsWaittingRefreshData;
        private bool mIsWaitLoadingMoreData;
        public int mTotalDataCount;
        private static SuperScrollView.DataSourceMgr instance;
        
        // Properties
        public static SuperScrollView.DataSourceMgr Get { get; }
        public int TotalItemCount { get; }
        
        // Methods
        public static SuperScrollView.DataSourceMgr get_Get()
        {
            var val_3;
            SuperScrollView.DataSourceMgr val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = SuperScrollView.DataSourceMgr.instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<SuperScrollView.DataSourceMgr>();
                val_5 = null;
                SuperScrollView.DataSourceMgr.instance = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (SuperScrollView.DataSourceMgr)SuperScrollView.DataSourceMgr.instance;
        }
        private void Awake()
        {
            this.DoRefreshDataSource();
        }
        public void Init()
        {
            this.DoRefreshDataSource();
        }
        public SuperScrollView.ItemData GetItemDataByIndex(int index)
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
        public SuperScrollView.ItemData GetItemDataById(int itemId)
        {
            var val_1;
            System.Collections.Generic.List<SuperScrollView.ItemData> val_2;
            var val_3;
            val_2 = itemId;
            bool val_1 = true;
            if(W22 < 1)
            {
                goto label_6;
            }
            
            val_1 = 0;
            label_7:
            if(val_1 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            var val_2 = (true + 0) + 32 + 16;
            if(val_2 == val_2)
            {
                goto label_5;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < W22)
            {
                    if(this.mItemDataList != null)
            {
                goto label_7;
            }
            
            }
            
            label_6:
            val_3 = 0;
            return (SuperScrollView.ItemData)val_3;
            label_5:
            val_2 = this.mItemDataList;
            if(val_2 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            val_3 = mem[((true + 0) + 32 + 16 + 0) + 32];
            val_3 = ((true + 0) + 32 + 16 + 0) + 32;
            return (SuperScrollView.ItemData)val_3;
        }
        public int get_TotalItemCount()
        {
            return 5571;
        }
        public void RequestRefreshDataList(System.Action onReflushFinished)
        {
            this.mOnRefreshFinished = onReflushFinished;
            this.mDataRefreshLeftTime = 1f;
            this.mIsWaittingRefreshData = true;
        }
        public void RequestLoadMoreDataList(int loadCount, System.Action onLoadMoreFinished)
        {
            this.mOnLoadMoreFinished = onLoadMoreFinished;
            this.mLoadMoreCount = loadCount;
            this.mDataLoadLeftTime = 1f;
            this.mIsWaitLoadingMoreData = true;
        }
        public void Update()
        {
            if(this.mIsWaittingRefreshData != false)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_1 = this.mDataRefreshLeftTime - val_1;
                this.mDataRefreshLeftTime = val_1;
                if(val_1 <= 0f)
            {
                    this.mIsWaittingRefreshData = false;
                this.DoRefreshDataSource();
                if(this.mOnRefreshFinished != null)
            {
                    this.mOnRefreshFinished.Invoke();
            }
            
            }
            
            }
            
            if(this.mIsWaitLoadingMoreData == false)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.mDataLoadLeftTime - val_2;
            this.mDataLoadLeftTime = val_2;
            if(val_2 > 0f)
            {
                    return;
            }
            
            this.mIsWaitLoadingMoreData = false;
            this.DoLoadMoreDataSource();
            if(this.mOnLoadMoreFinished == null)
            {
                    return;
            }
            
            this.mOnLoadMoreFinished.Invoke();
        }
        public void SetDataTotalCount(int count)
        {
            this.mTotalDataCount = count;
            this.DoRefreshDataSource();
        }
        public void ExchangeData(int index1, int index2)
        {
            System.Collections.Generic.List<SuperScrollView.ItemData> val_2;
            SuperScrollView.ItemData val_3;
            val_2 = this.mItemDataList;
            if(true > index1)
            {
                    val_3 = true + (index1 << 3);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_2 = this.mItemDataList;
                val_3 = X9 + (index1 << 3);
            }
            
            val_3 = val_3 + 32;
            if(W9 <= index2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (index2 << 3);
            this.mItemDataList.set_Item(index:  index1, value:  (((X9 + (index1) << 3) + 32) + (index2) << 3) + 32);
            this.mItemDataList.set_Item(index:  index2, value:  val_3);
        }
        public void RemoveData(int index)
        {
            this.mItemDataList.RemoveAt(index:  index);
        }
        public void InsertData(int index, SuperScrollView.ItemData data)
        {
            this.mItemDataList.Insert(index:  index, item:  data);
        }
        private void DoRefreshDataSource()
        {
            this.mItemDataList.Clear();
            if(this.mTotalDataCount < 1)
            {
                    return;
            }
            
            int val_9 = 0;
            do
            {
                .mId = val_9;
                .mName = "Item" + val_9;
                .mDesc = "Item Desc For Item " + val_9;
                .mIcon = SuperScrollView.ResManager.Get.GetSpriteNameByIndex(index:  UnityEngine.Random.Range(min:  0, max:  24));
                .mStarCount = UnityEngine.Random.Range(min:  0, max:  6);
                .mFileSize = UnityEngine.Random.Range(min:  20, max:  231);
                .mChecked = false;
                .mIsExpand = false;
                this.mItemDataList.Add(item:  new SuperScrollView.ItemData());
                val_9 = val_9 + 1;
            }
            while(val_9 < this.mTotalDataCount);
        
        }
        private void DoLoadMoreDataSource()
        {
            if(this.mLoadMoreCount >= 1)
            {
                    var val_10 = 0;
                do
            {
                int val_2 = W23 + val_10;
                .mId = val_2;
                .mName = "Item" + val_2;
                .mDesc = "Item Desc For Item " + val_2;
                .mIcon = SuperScrollView.ResManager.Get.GetSpriteNameByIndex(index:  UnityEngine.Random.Range(min:  0, max:  24));
                .mStarCount = UnityEngine.Random.Range(min:  0, max:  6);
                .mFileSize = UnityEngine.Random.Range(min:  20, max:  231);
                .mChecked = false;
                .mIsExpand = false;
                this.mItemDataList.Add(item:  new SuperScrollView.ItemData());
                val_10 = val_10 + 1;
            }
            while(val_10 < this.mLoadMoreCount);
            
                this.mItemDataList = this.mItemDataList;
            }
            
            this.mTotalDataCount = this.mItemDataList;
        }
        public void CheckAllItem()
        {
            bool val_1 = true;
            if(26865664 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_2 = val_2 + 1;
                mem2[0] = 1;
                if(val_2 >= 26865664)
            {
                    return;
            }
            
            }
            while(this.mItemDataList != null);
            
            throw new NullReferenceException();
        }
        public void UnCheckAllItem()
        {
            bool val_1 = true;
            if(26865664 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_2 = val_2 + 1;
                mem2[0] = 0;
                if(val_2 >= 26865664)
            {
                    return;
            }
            
            }
            while(this.mItemDataList != null);
            
            throw new NullReferenceException();
        }
        public bool DeleteAllCheckedItem()
        {
            var val_4;
            System.Predicate<SuperScrollView.ItemData> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = DataSourceMgr.<>c.<>9__29_0;
            if(val_6 == null)
            {
                    System.Predicate<SuperScrollView.ItemData> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Predicate<SuperScrollView.ItemData>(object:  DataSourceMgr.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DataSourceMgr.<>c::<DeleteAllCheckedItem>b__29_0(SuperScrollView.ItemData it));
                DataSourceMgr.<>c.<>9__29_0 = val_6;
            }
            
            int val_2 = this.mItemDataList.RemoveAll(match:  val_1);
            return (bool)(W23 != this.mItemDataList) ? 1 : 0;
        }
        public DataSourceMgr()
        {
            this.mItemDataList = new System.Collections.Generic.List<SuperScrollView.ItemData>();
            this.mLoadMoreCount = 20;
            this.mTotalDataCount = 10000;
        }
        private static DataSourceMgr()
        {
        
        }
    
    }

}
