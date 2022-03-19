using UnityEngine;

namespace SuperScrollView
{
    public class ListItem12 : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text mText;
        public UnityEngine.GameObject mArrow;
        public UnityEngine.UI.Button mButton;
        private int mTreeItemIndex;
        private System.Action<int> mClickHandler;
        
        // Properties
        public int TreeItemIndex { get; }
        
        // Methods
        public int get_TreeItemIndex()
        {
            return (int)this.mTreeItemIndex;
        }
        public void Init()
        {
            this.mButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ListItem12::OnButtonClicked()));
        }
        public void SetClickCallBack(System.Action<int> clickHandler)
        {
            this.mClickHandler = clickHandler;
        }
        private void OnButtonClicked()
        {
            if(this.mClickHandler == null)
            {
                    return;
            }
            
            this.mClickHandler.Invoke(obj:  this.mTreeItemIndex);
        }
        public void SetExpand(bool expand)
        {
            if(expand != false)
            {
                
            }
            
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  90f);
            this.mArrow.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public void SetItemData(int treeItemIndex, bool expand)
        {
            this.mTreeItemIndex = treeItemIndex;
            this.SetExpand(expand:  expand);
        }
        public ListItem12()
        {
            this.mTreeItemIndex = 0;
        }
    
    }

}
