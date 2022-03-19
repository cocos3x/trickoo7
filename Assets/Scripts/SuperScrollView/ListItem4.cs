using UnityEngine;

namespace SuperScrollView
{
    public class ListItem4 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mMsgText;
        public UnityEngine.UI.Image mMsgPic;
        public UnityEngine.UI.Image mIcon;
        public UnityEngine.UI.Image mItemBg;
        public UnityEngine.UI.Image mArrow;
        public UnityEngine.UI.Text mIndexText;
        private int mItemIndex;
        
        // Properties
        public int ItemIndex { get; }
        
        // Methods
        public int get_ItemIndex()
        {
            return (int)this.mItemIndex;
        }
        public void Init()
        {
        
        }
        public void SetItemData(SuperScrollView.ChatMsg itemData, int itemIndex)
        {
            var val_39;
            float val_40;
            UnityEngine.UI.Image val_41;
            byte val_42;
            string val_1 = itemIndex.ToString();
            SuperScrollView.PersonInfo val_3 = SuperScrollView.ChatMsgDataSourceMgr.Get.GetPersonInfo(personId:  itemData.mPersonId);
            this.mItemIndex = itemIndex;
            UnityEngine.GameObject val_4 = this.mMsgPic.gameObject;
            if(itemData.mMsgType == 0)
            {
                goto label_8;
            }
            
            val_4.SetActive(value:  true);
            this.mMsgText.gameObject.SetActive(value:  false);
            this.mMsgPic.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  itemData.mPicMsgSpriteName);
            this.mIcon.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  val_3.mHeadIcon);
            val_39 = 1152921508158487888;
            UnityEngine.Vector2 val_11 = this.mItemBg.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            UnityEngine.Vector2 val_13 = this.mMsgPic.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            UnityEngine.Vector2 val_15 = this.mMsgPic.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            val_40 = val_15.y + 20f;
            this.mItemBg.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_13.x + 20f, y = val_40};
            val_41 = this.mItemBg;
            if(val_3.mId != 0)
            {
                goto label_27;
            }
            
            UnityEngine.Color32 val_18 = new UnityEngine.Color32(r:  160, g:  231, b:  90, a:  255);
            val_42 = val_18.r;
            goto label_28;
            label_8:
            val_4.SetActive(value:  false);
            this.mMsgText.gameObject.SetActive(value:  true);
            UnityEngine.UI.ContentSizeFitter val_20 = this.mMsgText.GetComponent<UnityEngine.UI.ContentSizeFitter>();
            this.mIcon.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  val_3.mHeadIcon);
            val_39 = 1152921508158487888;
            UnityEngine.Vector2 val_24 = this.mItemBg.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            UnityEngine.Vector2 val_26 = this.mMsgText.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            UnityEngine.Vector2 val_28 = this.mMsgText.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            val_40 = val_28.y + 20f;
            this.mItemBg.GetComponent<UnityEngine.RectTransform>().sizeDelta = new UnityEngine.Vector2() {x = val_26.x + 20f, y = val_40};
            val_41 = this.mItemBg;
            if(val_3.mId == 0)
            {
                goto label_47;
            }
            
            label_27:
            UnityEngine.Color val_31 = UnityEngine.Color.white;
            if(val_41 != null)
            {
                goto label_48;
            }
            
            label_47:
            UnityEngine.Color32 val_32 = new UnityEngine.Color32(r:  160, g:  231, b:  90, a:  255);
            val_42 = val_32.r;
            label_28:
            UnityEngine.Color val_33 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_42, g = val_42, b = val_42, a = val_42});
            label_48:
            val_41.color = new UnityEngine.Color() {r = val_33.r, g = val_33.g, b = val_33.b, a = val_33.a};
            UnityEngine.Color val_34 = this.mItemBg.color;
            this.mArrow.color = new UnityEngine.Color() {r = val_34.r, g = val_34.g, b = val_34.b, a = val_34.a};
            this.gameObject.GetComponent<UnityEngine.RectTransform>().SetSizeWithCurrentAnchors(axis:  1, size:  75f);
        }
        public ListItem4()
        {
            this.mItemIndex = 0;
        }
    
    }

}
