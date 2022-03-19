using UnityEngine;

namespace SuperScrollView
{
    public class StaggeredGridItemPool
    {
        // Fields
        private UnityEngine.GameObject mPrefabObj;
        private string mPrefabName;
        private int mInitCreateCount;
        private float mPadding;
        private System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> mTmpPooledItemList;
        private System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> mPooledItemList;
        private static int mCurItemIdCount;
        private UnityEngine.RectTransform mItemParent;
        
        // Methods
        public StaggeredGridItemPool()
        {
            this.mInitCreateCount = 1;
            this.mTmpPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem>();
            this.mPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem>();
        }
        public void Init(UnityEngine.GameObject prefabObj, float padding, int createCount, UnityEngine.RectTransform parent)
        {
            this.mPrefabObj = prefabObj;
            this.mPrefabName = prefabObj.name;
            this.mInitCreateCount = createCount;
            this.mPadding = padding;
            this.mItemParent = parent;
            this.mPrefabObj.SetActive(value:  false);
            if(this.mInitCreateCount < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.RecycleItemReal(item:  this.CreateItem());
                val_3 = val_3 + 1;
            }
            while(val_3 < this.mInitCreateCount);
        
        }
        public SuperScrollView.LoopStaggeredGridViewItem GetItem()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = null;
            val_3 = null;
            int val_3 = SuperScrollView.StaggeredGridItemPool.mCurItemIdCount;
            val_3 = val_3 + 1;
            SuperScrollView.StaggeredGridItemPool.mCurItemIdCount = val_3;
            val_4 = 1152921504896573439;
            if()
            {
                goto label_4;
            }
            
            val_5 = mem[1152921502919417880];
            val_6 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem>::RemoveAt(int index);
            goto label_5;
            label_4:
            if(SuperScrollView.StaggeredGridItemPool.mCurItemIdCount == 0)
            {
                goto label_7;
            }
            
            val_4 = 1152921504896573439;
            val_3 = val_3 + (-1977155592);
            val_5 = mem[((SuperScrollView.StaggeredGridItemPool.mCurItemIdCount + 1) + -1977155592) + 32];
            val_5 = ((SuperScrollView.StaggeredGridItemPool.mCurItemIdCount + 1) + -1977155592) + 32;
            val_6 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem>::RemoveAt(int index);
            label_5:
            this.mPooledItemList.RemoveAt(index:  289726463);
            val_5.gameObject.SetActive(value:  true);
            label_12:
            mem2[0] = this.mPadding;
            val_7 = null;
            val_7 = null;
            mem2[0] = SuperScrollView.StaggeredGridItemPool.mCurItemIdCount;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_5;
            label_7:
            if(this.CreateItem() != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
        }
        public void DestroyAllItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_2;
            var val_3;
            bool val_2 = true;
            this.ClearTmpRecycledItem();
            val_2 = this.mPooledItemList;
            val_3 = 0;
            label_7:
            if(val_3 >= W22)
            {
                goto label_2;
            }
            
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            UnityEngine.Object.DestroyImmediate(obj:  (true + 0) + 32.gameObject);
            val_2 = this.mPooledItemList;
            val_3 = val_3 + 1;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            val_2.Clear();
        }
        public SuperScrollView.LoopStaggeredGridViewItem CreateItem()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.mPrefabObj, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, parent:  this.mItemParent);
            val_3.SetActive(value:  true);
            UnityEngine.RectTransform val_4 = val_3.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_4.anchoredPosition3D = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_4.localEulerAngles = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_8.mStartPosOffset = 0f;
            val_8.mItemPrefabName = this.mPrefabName;
            return (SuperScrollView.LoopStaggeredGridViewItem)val_3.GetComponent<SuperScrollView.LoopStaggeredGridViewItem>();
        }
        private void RecycleItemReal(SuperScrollView.LoopStaggeredGridViewItem item)
        {
            item.gameObject.SetActive(value:  false);
            this.mPooledItemList.Add(item:  item);
        }
        public void RecycleItem(SuperScrollView.LoopStaggeredGridViewItem item)
        {
            this.mTmpPooledItemList.Add(item:  item);
        }
        public void ClearTmpRecycledItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopStaggeredGridViewItem> val_1;
            bool val_1 = true;
            val_1 = this.mTmpPooledItemList;
            if(W21 == 0)
            {
                    return;
            }
            
            var val_2 = 0;
            label_5:
            if(val_2 >= X21)
            {
                goto label_3;
            }
            
            if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            this.RecycleItemReal(item:  (true + 0) + 32);
            val_1 = this.mTmpPooledItemList;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_3:
            val_1.Clear();
        }
        private static StaggeredGridItemPool()
        {
        
        }
    
    }

}
