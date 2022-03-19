using UnityEngine;

namespace SuperScrollView
{
    public class SpinDatePickerDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListViewMonth;
        public SuperScrollView.LoopListView2 mLoopListViewDay;
        public SuperScrollView.LoopListView2 mLoopListViewHour;
        public UnityEngine.UI.Button mBackButton;
        private static int[] mMonthDayCountArray;
        private static string[] mMonthNameArray;
        private int mCurSelectedMonth;
        private int mCurSelectedDay;
        private int mCurSelectedHour;
        
        // Properties
        public int CurSelectedMonth { get; }
        public int CurSelectedDay { get; }
        public int CurSelectedHour { get; }
        
        // Methods
        public int get_CurSelectedMonth()
        {
            return (int)this.mCurSelectedMonth;
        }
        public int get_CurSelectedDay()
        {
            return (int)this.mCurSelectedDay;
        }
        public int get_CurSelectedHour()
        {
            return (int)this.mCurSelectedHour;
        }
        private void Start()
        {
            this.mLoopListViewMonth.mOnSnapNearestChanged = new System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2>(object:  this, method:  System.Void SuperScrollView.SpinDatePickerDemoScript::OnMonthSnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item));
            this.mLoopListViewDay.mOnSnapNearestChanged = new System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2>(object:  this, method:  System.Void SuperScrollView.SpinDatePickerDemoScript::OnDaySnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item));
            this.mLoopListViewHour.mOnSnapNearestChanged = new System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2>(object:  this, method:  System.Void SuperScrollView.SpinDatePickerDemoScript::OnHourSnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item));
            this.mLoopListViewMonth.InitListView(itemTotalCount:  0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.SpinDatePickerDemoScript::OnGetItemByIndexForMonth(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListViewDay.InitListView(itemTotalCount:  0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.SpinDatePickerDemoScript::OnGetItemByIndexForDay(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListViewHour.InitListView(itemTotalCount:  0, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.SpinDatePickerDemoScript::OnGetItemByIndexForHour(SuperScrollView.LoopListView2 listView, int index)), initParam:  0);
            this.mLoopListViewMonth.mOnSnapItemFinished = new System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2>(object:  this, method:  System.Void SuperScrollView.SpinDatePickerDemoScript::OnMonthSnapTargetFinished(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item));
            this.mBackButton.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.SpinDatePickerDemoScript::OnBackBtnClicked()));
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndexForHour(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_5;
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            if(val_1.mIsInitHandlerCalled != true)
            {
                    val_1.mIsInitHandlerCalled = true;
                val_1.GetComponent<SuperScrollView.ListItem7>().Init();
            }
            
            if((index & 2147483648) == 0)
            {
                    val_5 = 0;
            }
            else
            {
                    int val_3 = index + 1;
                val_5 = 23;
            }
            
            val_2.mValue = 24;
            string val_4 = 24.ToString();
            return val_1;
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndexForMonth(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_4;
            var val_5;
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            SuperScrollView.ListItem7 val_2 = val_1.GetComponent<SuperScrollView.ListItem7>();
            if(val_1.mIsInitHandlerCalled == false)
            {
                goto label_3;
            }
            
            if((index & 2147483648) != 0)
            {
                goto label_4;
            }
            
            label_8:
            val_4 = 0;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            val_1.mIsInitHandlerCalled = true;
            val_2.Init();
            if((index & 2147483648) == 0)
            {
                goto label_8;
            }
            
            label_4:
            int val_3 = index + 1;
            val_4 = 11;
            label_5:
            val_2.mValue = 12;
            val_5 = null;
            val_5 = null;
            return val_1;
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndexForDay(SuperScrollView.LoopListView2 listView, int index)
        {
            var val_7;
            int val_8;
            SuperScrollView.LoopListViewItem2 val_1 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1");
            if(val_1.mIsInitHandlerCalled != true)
            {
                    val_1.mIsInitHandlerCalled = true;
                val_1.GetComponent<SuperScrollView.ListItem7>().Init();
            }
            
            val_7 = null;
            val_7 = null;
            System.Int32[] val_8 = SuperScrollView.SpinDatePickerDemoScript.mMonthDayCountArray;
            int val_7 = this.mCurSelectedMonth;
            val_7 = val_7 - 1;
            val_8 = val_8 + (val_7 << 2);
            var val_9 = (SuperScrollView.SpinDatePickerDemoScript.mMonthDayCountArray + ((this.mCurSelectedMonth - 1)) << 2) + 32;
            if((index & 2147483648) == 0)
            {
                    val_8 = index - ((index / val_9) * val_9);
            }
            else
            {
                    int val_4 = index + 1;
                val_4 = val_4 - ((val_4 / val_9) * val_9);
                val_9 = val_9 + val_4;
                val_8 = val_9 - 1;
            }
            
            val_8 = val_8 + 1;
            val_2.mValue = val_8;
            string val_6 = val_8.ToString();
            return val_1;
        }
        private void OnMonthSnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item)
        {
            int val_1 = listView.GetIndexInShownItemList(item:  item);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            this.mCurSelectedMonth = val_2.mValue;
            item.GetComponent<SuperScrollView.ListItem7>().OnListViewSnapTargetChanged(listView:  listView, targetIndex:  val_1);
        }
        private void OnDaySnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item)
        {
            int val_1 = listView.GetIndexInShownItemList(item:  item);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            this.mCurSelectedDay = val_2.mValue;
            item.GetComponent<SuperScrollView.ListItem7>().OnListViewSnapTargetChanged(listView:  listView, targetIndex:  val_1);
        }
        private void OnHourSnapTargetChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item)
        {
            int val_1 = listView.GetIndexInShownItemList(item:  item);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            this.mCurSelectedHour = val_2.mValue;
            item.GetComponent<SuperScrollView.ListItem7>().OnListViewSnapTargetChanged(listView:  listView, targetIndex:  val_1);
        }
        private void OnMonthSnapTargetFinished(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item)
        {
            SuperScrollView.ListItem7 val_2 = this.mLoopListViewDay.GetShownItemByIndex(index:  0).GetComponent<SuperScrollView.ListItem7>();
            this.mLoopListViewDay.RefreshAllShownItemWithFirstIndex(firstItemIndex:  val_2.mValue - 1);
        }
        private void OnListViewSnapTargetChanged(SuperScrollView.LoopListView2 listView, int targetIndex)
        {
            var val_6;
            int val_1 = listView.ShownItemCount;
            if(val_1 < 1)
            {
                    return;
            }
            
            val_6 = val_1;
            var val_6 = 0;
            label_9:
            SuperScrollView.ListItem7 val_3 = listView.GetShownItemByIndex(index:  0).GetComponent<SuperScrollView.ListItem7>();
            if(targetIndex != val_6)
            {
                goto label_5;
            }
            
            UnityEngine.Color val_4 = UnityEngine.Color.red;
            if(val_3.mText != null)
            {
                goto label_6;
            }
            
            label_5:
            UnityEngine.Color val_5 = UnityEngine.Color.black;
            label_6:
            val_3.mText.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            val_6 = val_6 + 1;
            if(val_6 < val_6)
            {
                goto label_9;
            }
        
        }
        public SpinDatePickerDemoScript()
        {
            this.mCurSelectedMonth = 2;
            this.mCurSelectedDay = 0;
            this.mCurSelectedHour = 2;
        }
        private static SpinDatePickerDemoScript()
        {
            int val_3;
            SuperScrollView.SpinDatePickerDemoScript.mMonthDayCountArray = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] val_2 = new string[12];
            val_3 = val_2.Length;
            val_2[0] = "Jan.";
            val_3 = val_2.Length;
            val_2[1] = "Feb.";
            val_3 = val_2.Length;
            val_2[2] = "Mar.";
            val_3 = val_2.Length;
            val_2[3] = "Apr.";
            val_3 = val_2.Length;
            val_2[4] = "May.";
            val_3 = val_2.Length;
            val_2[5] = "Jun.";
            val_3 = val_2.Length;
            val_2[6] = "Jul.";
            val_3 = val_2.Length;
            val_2[7] = "Aug.";
            val_3 = val_2.Length;
            val_2[8] = "Sep.";
            val_3 = val_2.Length;
            val_2[9] = "Oct.";
            val_3 = val_2.Length;
            val_2[10] = "Nov.";
            val_3 = val_2.Length;
            val_2[11] = "Dec.";
            SuperScrollView.SpinDatePickerDemoScript.mMonthNameArray = val_2;
        }
    
    }

}
