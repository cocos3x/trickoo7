using UnityEngine;

namespace SuperScrollView
{
    public class ListItem13 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mNameText;
        public UnityEngine.UI.Image mIcon;
        public UnityEngine.UI.Image[] mStarArray;
        public UnityEngine.UI.Text mDescText;
        public UnityEngine.UI.Text mDescText2;
        public UnityEngine.Color32 mRedStarColor;
        public UnityEngine.Color32 mGrayStarColor;
        public UnityEngine.GameObject mContentRootObj;
        private int mItemDataIndex;
        private int mChildDataIndex;
        
        // Methods
        public void Init()
        {
            int val_5 = 0;
            do
            {
                if(val_5 >= this.mStarArray.Length)
            {
                    return;
            }
            
                .<>4__this = this;
                .index = val_5;
                SuperScrollView.ClickEventListener val_3 = SuperScrollView.ClickEventListener.Get(obj:  this.mStarArray[val_5].gameObject);
                val_3.mClickedHandler = new System.Action<UnityEngine.GameObject>(object:  new ListItem13.<>c__DisplayClass10_0(), method:  System.Void ListItem13.<>c__DisplayClass10_0::<Init>b__0(UnityEngine.GameObject obj));
                val_5 = val_5 + 1;
            }
            while(this.mStarArray != null);
            
            throw new NullReferenceException();
        }
        private void OnStarClicked(int index)
        {
            int val_4;
            if((SuperScrollView.TreeViewDataSourceMgr.Get.GetItemChildDataByIndex(itemIndex:  this.mItemDataIndex, childIndex:  this.mChildDataIndex)) == null)
            {
                    return;
            }
            
            if((index == 0) && (val_2.mStarCount == 1))
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = index + 1;
            }
            
            val_2.mStarCount = val_4;
            this.SetStarCount(count:  val_4);
        }
        public void SetStarCount(int count)
        {
            var val_3;
            var val_4;
            if(count >= 1)
            {
                    do
            {
                UnityEngine.Color val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = this.mRedStarColor, g = this.mRedStarColor, b = this.mRedStarColor, a = this.mRedStarColor});
                this.mStarArray[0].color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
                val_3 = 0 + 1;
            }
            while(val_3 < count);
            
            }
            else
            {
                    val_3 = 0;
            }
            
            val_4 = 4;
            do
            {
                if((val_4 - 4) >= this.mStarArray.Length)
            {
                    return;
            }
            
                UnityEngine.Color val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = this.mGrayStarColor, g = this.mGrayStarColor, b = this.mGrayStarColor, a = this.mGrayStarColor});
                this.mStarArray[0].color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
                val_4 = val_4 + 1;
            }
            while(this.mStarArray != null);
            
            throw new NullReferenceException();
        }
        public void SetItemData(SuperScrollView.ItemData itemData, int itemIndex, int childIndex)
        {
            this.mItemDataIndex = itemIndex;
            this.mChildDataIndex = childIndex;
            string val_2 = itemData.mFileSize.ToString() + "KB";
            this.mIcon.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  itemData.mIcon);
            this.SetStarCount(count:  itemData.mStarCount);
        }
        public ListItem13()
        {
            UnityEngine.Color32 val_1 = new UnityEngine.Color32(r:  249, g:  227, b:  101, a:  255);
            this.mRedStarColor = val_1.r;
            UnityEngine.Color32 val_2 = new UnityEngine.Color32(r:  215, g:  215, b:  215, a:  255);
            this.mGrayStarColor = val_2.r;
            this.mItemDataIndex = -1;
            this.mChildDataIndex = -1;
        }
    
    }

}
