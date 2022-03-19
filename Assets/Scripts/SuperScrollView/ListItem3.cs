using UnityEngine;

namespace SuperScrollView
{
    public class ListItem3 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mNameText;
        public UnityEngine.UI.Image mIcon;
        public UnityEngine.UI.Text mDescText;
        private int mItemIndex;
        public UnityEngine.UI.Toggle mToggle;
        
        // Methods
        public void Init()
        {
            this.mToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SuperScrollView.ListItem3::OnToggleValueChanged(bool check)));
        }
        private void OnToggleValueChanged(bool check)
        {
            if((SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  this.mItemIndex)) == null)
            {
                    return;
            }
            
            val_2.mChecked = check;
        }
        public void SetItemData(SuperScrollView.ItemData itemData, int itemIndex)
        {
            this.mItemIndex = itemIndex;
            this.mIcon.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  itemData.mIcon);
            this.mToggle.isOn = itemData.mChecked;
        }
        public ListItem3()
        {
            this.mItemIndex = 0;
        }
    
    }

}
