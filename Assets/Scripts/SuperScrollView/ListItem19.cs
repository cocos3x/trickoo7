using UnityEngine;

namespace SuperScrollView
{
    public class ListItem19 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mNameText;
        public UnityEngine.UI.Image mIcon;
        public UnityEngine.UI.Image mStarIcon;
        public UnityEngine.UI.Text mStarCount;
        public UnityEngine.UI.Text mRowText;
        public UnityEngine.UI.Text mColumnText;
        public UnityEngine.Color32 mRedStarColor;
        public UnityEngine.Color32 mGrayStarColor;
        public UnityEngine.UI.Toggle mToggle;
        private int mItemDataIndex;
        
        // Methods
        public void Init()
        {
            SuperScrollView.ClickEventListener val_2 = SuperScrollView.ClickEventListener.Get(obj:  this.mStarIcon.gameObject);
            val_2.mClickedHandler = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void SuperScrollView.ListItem19::OnStarClicked(UnityEngine.GameObject obj));
            this.mToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SuperScrollView.ListItem19::OnToggleValueChanged(bool check)));
        }
        private void OnToggleValueChanged(bool check)
        {
            if((SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  this.mItemDataIndex)) == null)
            {
                    return;
            }
            
            val_2.mChecked = check;
        }
        private void OnStarClicked(UnityEngine.GameObject obj)
        {
            if((SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  this.mItemDataIndex)) == null)
            {
                    return;
            }
            
            int val_3 = (val_2.mStarCount == 5) ? 0 : (val_2.mStarCount + 1);
            val_2.mStarCount = val_3;
            this.SetStarCount(count:  val_3);
        }
        public void SetStarCount(int count)
        {
            UnityEngine.Color32 val_3;
            string val_1 = count.ToString();
            if(count != 0)
            {
                    val_3 = this.mRedStarColor;
            }
            else
            {
                    val_3 = this.mGrayStarColor;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_3, g = val_3, b = val_3, a = val_3});
            this.mStarIcon.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        public void SetItemData(SuperScrollView.ItemData itemData, int itemIndex, int row, int column)
        {
            this.mItemDataIndex = itemIndex;
            string val_1 = "Row: "("Row: ") + row;
            string val_2 = "Column: "("Column: ") + column;
            this.mIcon.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  itemData.mIcon);
            this.SetStarCount(count:  itemData.mStarCount);
            this.mToggle.isOn = itemData.mChecked;
        }
        public ListItem19()
        {
            UnityEngine.Color32 val_1 = new UnityEngine.Color32(r:  236, g:  217, b:  103, a:  255);
            this.mRedStarColor = val_1.r;
            UnityEngine.Color32 val_2 = new UnityEngine.Color32(r:  215, g:  215, b:  215, a:  255);
            this.mGrayStarColor = val_2.r;
            this.mItemDataIndex = 0;
        }
    
    }

}
