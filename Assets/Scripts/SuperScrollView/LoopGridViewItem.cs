using UnityEngine;

namespace SuperScrollView
{
    public class LoopGridViewItem : MonoBehaviour
    {
        // Fields
        private int mItemIndex;
        private int mRow;
        private int mColumn;
        private int mItemId;
        private SuperScrollView.LoopGridView mParentGridView;
        private bool mIsInitHandlerCalled;
        private string mItemPrefabName;
        private UnityEngine.RectTransform mCachedRectTransform;
        private int mItemCreatedCheckFrameCount;
        private object mUserObjectData;
        private int mUserIntData1;
        private int mUserIntData2;
        private string mUserStringData1;
        private string mUserStringData2;
        private SuperScrollView.LoopGridViewItem mPrevItem;
        private SuperScrollView.LoopGridViewItem mNextItem;
        
        // Properties
        public object UserObjectData { get; set; }
        public int UserIntData1 { get; set; }
        public int UserIntData2 { get; set; }
        public string UserStringData1 { get; set; }
        public string UserStringData2 { get; set; }
        public int ItemCreatedCheckFrameCount { get; set; }
        public UnityEngine.RectTransform CachedRectTransform { get; }
        public string ItemPrefabName { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int ItemIndex { get; set; }
        public int ItemId { get; set; }
        public bool IsInitHandlerCalled { get; set; }
        public SuperScrollView.LoopGridView ParentGridView { get; set; }
        public SuperScrollView.LoopGridViewItem PrevItem { get; set; }
        public SuperScrollView.LoopGridViewItem NextItem { get; set; }
        
        // Methods
        public object get_UserObjectData()
        {
            return (object)this.mUserObjectData;
        }
        public void set_UserObjectData(object value)
        {
            this.mUserObjectData = value;
        }
        public int get_UserIntData1()
        {
            return (int)this.mUserIntData1;
        }
        public void set_UserIntData1(int value)
        {
            this.mUserIntData1 = value;
        }
        public int get_UserIntData2()
        {
            return (int)this.mUserIntData2;
        }
        public void set_UserIntData2(int value)
        {
            this.mUserIntData2 = value;
        }
        public string get_UserStringData1()
        {
            return (string)this.mUserStringData1;
        }
        public void set_UserStringData1(string value)
        {
            this.mUserStringData1 = value;
        }
        public string get_UserStringData2()
        {
            return (string)this.mUserStringData2;
        }
        public void set_UserStringData2(string value)
        {
            this.mUserStringData2 = value;
        }
        public int get_ItemCreatedCheckFrameCount()
        {
            return (int)this.mItemCreatedCheckFrameCount;
        }
        public void set_ItemCreatedCheckFrameCount(int value)
        {
            this.mItemCreatedCheckFrameCount = value;
        }
        public UnityEngine.RectTransform get_CachedRectTransform()
        {
            UnityEngine.RectTransform val_4;
            if(this.mCachedRectTransform == 0)
            {
                    this.mCachedRectTransform = this.gameObject.GetComponent<UnityEngine.RectTransform>();
                return val_4;
            }
            
            val_4 = this.mCachedRectTransform;
            return val_4;
        }
        public string get_ItemPrefabName()
        {
            return (string)this.mItemPrefabName;
        }
        public void set_ItemPrefabName(string value)
        {
            this.mItemPrefabName = value;
        }
        public int get_Row()
        {
            return (int)this.mRow;
        }
        public void set_Row(int value)
        {
            this.mRow = value;
        }
        public int get_Column()
        {
            return (int)this.mColumn;
        }
        public void set_Column(int value)
        {
            this.mColumn = value;
        }
        public int get_ItemIndex()
        {
            return (int)this.mItemIndex;
        }
        public void set_ItemIndex(int value)
        {
            this.mItemIndex = value;
        }
        public int get_ItemId()
        {
            return (int)this.mItemId;
        }
        public void set_ItemId(int value)
        {
            this.mItemId = value;
        }
        public bool get_IsInitHandlerCalled()
        {
            return (bool)this.mIsInitHandlerCalled;
        }
        public void set_IsInitHandlerCalled(bool value)
        {
            this.mIsInitHandlerCalled = value;
        }
        public SuperScrollView.LoopGridView get_ParentGridView()
        {
            return (SuperScrollView.LoopGridView)this.mParentGridView;
        }
        public void set_ParentGridView(SuperScrollView.LoopGridView value)
        {
            this.mParentGridView = value;
        }
        public SuperScrollView.LoopGridViewItem get_PrevItem()
        {
            return (SuperScrollView.LoopGridViewItem)this.mPrevItem;
        }
        public void set_PrevItem(SuperScrollView.LoopGridViewItem value)
        {
            this.mPrevItem = value;
        }
        public SuperScrollView.LoopGridViewItem get_NextItem()
        {
            return (SuperScrollView.LoopGridViewItem)this.mNextItem;
        }
        public void set_NextItem(SuperScrollView.LoopGridViewItem value)
        {
            this.mNextItem = value;
        }
        public LoopGridViewItem()
        {
            this.mItemIndex = 0;
            this.mRow = 0;
            this.mColumn = 0;
            this.mItemId = 0;
        }
    
    }

}
