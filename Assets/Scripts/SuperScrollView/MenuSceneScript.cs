using UnityEngine;

namespace SuperScrollView
{
    internal class MenuSceneScript : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform mButtonPanelTf;
        private SuperScrollView.SceneNameInfo[] mSceneNameArray;
        
        // Methods
        private void Start()
        {
            this.CreateFpsDisplyObj();
            int val_1 = this.mButtonPanelTf.childCount;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_12 = 0;
            do
            {
                UnityEngine.GameObject val_4 = this.mButtonPanelTf.GetChild(index:  0).gameObject;
                if(val_12 < this.mSceneNameArray.Length)
            {
                    val_4.SetActive(value:  true);
                .info = this.mSceneNameArray[val_12];
                val_6.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new MenuSceneScript.<>c__DisplayClass2_0(), method:  System.Void MenuSceneScript.<>c__DisplayClass2_0::<Start>b__0()));
                UnityEngine.UI.Text val_10 = this.mButtonPanelTf.GetChild(index:  0).GetComponent<UnityEngine.UI.Button>().transform.Find(n:  "Text").GetComponent<UnityEngine.UI.Text>();
            }
            else
            {
                    val_4.SetActive(value:  false);
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < (long)val_1);
        
        }
        private void CreateFpsDisplyObj()
        {
            if((UnityEngine.Object.FindObjectOfType<SuperScrollView.FPSDisplay>()) != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject();
            val_3.name = "FPSDisplay";
            SuperScrollView.FPSDisplay val_4 = val_3.AddComponent<SuperScrollView.FPSDisplay>();
            UnityEngine.Object.DontDestroyOnLoad(target:  val_3);
        }
        public MenuSceneScript()
        {
            SuperScrollView.SceneNameInfo[] val_1 = new SuperScrollView.SceneNameInfo[18];
            .mName = "Staggered GridView1";
            .mSceneName = "StaggeredGridView_TopToBottom";
            val_1[0] = new SuperScrollView.SceneNameInfo();
            .mName = "Staggered GridView2";
            .mSceneName = "StaggeredGridView_LeftToRight";
            val_1[1] = new SuperScrollView.SceneNameInfo();
            .mName = "Chat Message List";
            .mSceneName = "ChatMsgListViewDemo";
            val_1[2] = new SuperScrollView.SceneNameInfo();
            .mName = "Horizontal Gallery";
            .mSceneName = "HorizontalGalleryDemo";
            val_1[3] = new SuperScrollView.SceneNameInfo();
            .mName = "Vertical Gallery";
            .mSceneName = "VerticalGalleryDemo";
            val_1[4] = new SuperScrollView.SceneNameInfo();
            .mName = "GridView";
            .mSceneName = "GridView_TopLeftToBottomRight";
            val_1[5] = new SuperScrollView.SceneNameInfo();
            .mName = "PageView";
            .mSceneName = "PageViewDemo";
            val_1[6] = new SuperScrollView.SceneNameInfo();
            .mName = "TreeView";
            .mSceneName = "TreeViewDemo";
            val_1[7] = new SuperScrollView.SceneNameInfo();
            .mName = "Spin Date Picker";
            .mSceneName = "SpinDatePickerDemo";
            val_1[8] = new SuperScrollView.SceneNameInfo();
            .mName = "Pull Down To Refresh";
            .mSceneName = "PullAndRefreshDemo";
            val_1[9] = new SuperScrollView.SceneNameInfo();
            .mName = "TreeView\nWith Sticky Head";
            .mSceneName = "TreeViewWithStickyHeadDemo";
            val_1[10] = new SuperScrollView.SceneNameInfo();
            .mName = "Change Item Height";
            .mSceneName = "ChangeItemHeightDemo";
            val_1[11] = new SuperScrollView.SceneNameInfo();
            .mName = "Pull Up To Load More";
            .mSceneName = "PullAndLoadMoreDemo";
            val_1[12] = new SuperScrollView.SceneNameInfo();
            .mName = "Click Load More";
            .mSceneName = "ClickAndLoadMoreDemo";
            val_1[13] = new SuperScrollView.SceneNameInfo();
            .mName = "Select And Delete";
            .mSceneName = "DeleteItemDemo";
            val_1[14] = new SuperScrollView.SceneNameInfo();
            .mName = "GridView Select Delete ";
            .mSceneName = "GridViewDeleteItemDemo";
            val_1[15] = new SuperScrollView.SceneNameInfo();
            .mName = "Responsive GridView";
            .mSceneName = "ResponsiveGridViewDemo";
            val_1[16] = new SuperScrollView.SceneNameInfo();
            .mName = "TreeView\nWith Children Indent";
            .mSceneName = "TreeViewWithChildrenIndentDemo";
            val_1[17] = new SuperScrollView.SceneNameInfo();
            this.mSceneNameArray = val_1;
        }
    
    }

}
