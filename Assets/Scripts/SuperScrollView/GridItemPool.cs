using UnityEngine;

namespace SuperScrollView
{
    public class GridItemPool
    {
        // Fields
        private UnityEngine.GameObject mPrefabObj;
        private string mPrefabName;
        private int mInitCreateCount;
        private System.Collections.Generic.List<SuperScrollView.LoopGridViewItem> mTmpPooledItemList;
        private System.Collections.Generic.List<SuperScrollView.LoopGridViewItem> mPooledItemList;
        private static int mCurItemIdCount;
        private UnityEngine.RectTransform mItemParent;
        
        // Methods
        public GridItemPool()
        {
            this.mInitCreateCount = 1;
            this.mTmpPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopGridViewItem>();
            this.mPooledItemList = new System.Collections.Generic.List<SuperScrollView.LoopGridViewItem>();
        }
        public void Init(UnityEngine.GameObject prefabObj, int createCount, UnityEngine.RectTransform parent)
        {
            this.mPrefabObj = prefabObj;
            this.mPrefabName = prefabObj.name;
            this.mInitCreateCount = createCount;
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
        public SuperScrollView.LoopGridViewItem GetItem()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            int val_3 = SuperScrollView.GridItemPool.mCurItemIdCount;
            val_3 = val_3 + 1;
            SuperScrollView.GridItemPool.mCurItemIdCount = val_3;
            val_4 = 1152921504895455231;
            if()
            {
                goto label_4;
            }
            
            val_5 = mem[1152921502909354008];
            val_6 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopGridViewItem>::RemoveAt(int index);
            goto label_5;
            label_4:
            if(SuperScrollView.GridItemPool.mCurItemIdCount == 0)
            {
                goto label_7;
            }
            
            val_4 = 1152921504895455231;
            val_3 = val_3 + (-1986101256);
            val_5 = mem[((SuperScrollView.GridItemPool.mCurItemIdCount + 1) + -1986101256) + 32];
            val_5 = ((SuperScrollView.GridItemPool.mCurItemIdCount + 1) + -1986101256) + 32;
            val_6 = public System.Void System.Collections.Generic.List<SuperScrollView.LoopGridViewItem>::RemoveAt(int index);
            label_5:
            this.mPooledItemList.RemoveAt(index:  288608255);
            val_5.gameObject.SetActive(value:  true);
            label_13:
            mem2[0] = SuperScrollView.GridItemPool.mCurItemIdCount;
            return (SuperScrollView.LoopGridViewItem)val_5;
            label_7:
            SuperScrollView.LoopGridViewItem val_2 = this.CreateItem();
            goto label_13;
        }
        public void DestroyAllItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopGridViewItem> val_2;
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
        public SuperScrollView.LoopGridViewItem CreateItem()
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
            val_8.mItemPrefabName = this.mPrefabName;
            return (SuperScrollView.LoopGridViewItem)val_3.GetComponent<SuperScrollView.LoopGridViewItem>();
        }
        private void RecycleItemReal(SuperScrollView.LoopGridViewItem item)
        {
            item.gameObject.SetActive(value:  false);
            this.mPooledItemList.Add(item:  item);
        }
        public void RecycleItem(SuperScrollView.LoopGridViewItem item)
        {
            item.mPrevItem = 0;
            item.mNextItem = 0;
            this.mTmpPooledItemList.Add(item:  item);
        }
        public void ClearTmpRecycledItem()
        {
            System.Collections.Generic.List<SuperScrollView.LoopGridViewItem> val_1;
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
        private static GridItemPool()
        {
        
        }
    
    }

}
