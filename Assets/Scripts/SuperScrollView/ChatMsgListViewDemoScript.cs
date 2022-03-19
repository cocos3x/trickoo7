using UnityEngine;

namespace SuperScrollView
{
    public class ChatMsgListViewDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mScrollToButton;
        private UnityEngine.UI.InputField mScrollToInput;
        private UnityEngine.UI.Button mBackButton;
        private UnityEngine.UI.Button mAppendMsgButton;
        
        // Methods
        private void Start()
        {
            this.mLoopListView.InitListView(itemTotalCount:  SuperScrollView.ChatMsgDataSourceMgr.Get.TotalItemCount, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.ChatMsgListViewDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mScrollToButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToButton").GetComponent<UnityEngine.UI.Button>();
            this.mScrollToInput = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup2/ScrollToInputField").GetComponent<UnityEngine.UI.InputField>();
            this.mScrollToButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ChatMsgListViewDemoScript::OnJumpBtnClicked()));
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_10.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ChatMsgListViewDemoScript::OnBackBtnClicked()));
            this.mAppendMsgButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/buttonGroup1/AppendButton").GetComponent<UnityEngine.UI.Button>();
            val_13.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.ChatMsgListViewDemoScript::OnAppendMsgBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private void OnAppendMsgBtnClicked()
        {
            SuperScrollView.ChatMsgDataSourceMgr.Get.AppendOneMsg();
            this.mLoopListView.SetListItemCount(itemCount:  SuperScrollView.ChatMsgDataSourceMgr.Get.TotalItemCount, resetPos:  false);
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  SuperScrollView.ChatMsgDataSourceMgr.Get.TotalItemCount - 1, offset:  0f);
        }
        private void OnJumpBtnClicked()
        {
            int val_1 = 0;
            if((System.Int32.TryParse(s:  this.mScrollToInput.m_Text, result: out  val_1)) == false)
            {
                    return;
            }
            
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            this.mLoopListView.MovePanelToItemIndex(itemIndex:  0, offset:  0f);
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_8;
            if((index & 2147483648) != 0)
            {
                    return 0;
            }
            
            val_8 = 1152921504890925056;
            if(SuperScrollView.ChatMsgDataSourceMgr.Get.TotalItemCount <= index)
            {
                    return 0;
            }
            
            SuperScrollView.ChatMsg val_4 = SuperScrollView.ChatMsgDataSourceMgr.Get.GetChatMsgByIndex(index:  index);
            if(val_4 == null)
            {
                    return 0;
            }
            
            SuperScrollView.ListItem4 val_7 = listView.NewListViewItem(itemPrefabName:  (val_4.mPersonId == 0) ? "ItemPrefab1" : "ItemPrefab2").GetComponent<SuperScrollView.ListItem4>();
            if(val_6.mIsInitHandlerCalled == false)
            {
                goto label_12;
            }
            
            if(val_7 != null)
            {
                goto label_13;
            }
            
            return 0;
            label_12:
            val_6.mIsInitHandlerCalled = true;
            val_7.Init();
            label_13:
            val_7.SetItemData(itemData:  val_4, itemIndex:  index);
            return 0;
        }
        public ChatMsgListViewDemoScript()
        {
        
        }
    
    }

}
