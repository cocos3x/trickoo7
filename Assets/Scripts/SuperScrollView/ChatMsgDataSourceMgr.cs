using UnityEngine;

namespace SuperScrollView
{
    public class ChatMsgDataSourceMgr : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<int, SuperScrollView.PersonInfo> mPersonInfoDict;
        private System.Collections.Generic.List<SuperScrollView.ChatMsg> mChatMsgList;
        private static SuperScrollView.ChatMsgDataSourceMgr instance;
        private static string[] mChatDemoStrList;
        private static string[] mChatDemoPicList;
        
        // Properties
        public static SuperScrollView.ChatMsgDataSourceMgr Get { get; }
        public int TotalItemCount { get; }
        
        // Methods
        public static SuperScrollView.ChatMsgDataSourceMgr get_Get()
        {
            var val_3;
            SuperScrollView.ChatMsgDataSourceMgr val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = SuperScrollView.ChatMsgDataSourceMgr.instance;
            if(val_4 == 0)
            {
                    val_5 = null;
                val_4 = UnityEngine.Object.FindObjectOfType<SuperScrollView.ChatMsgDataSourceMgr>();
                val_5 = null;
                SuperScrollView.ChatMsgDataSourceMgr.instance = val_4;
            }
            
            val_6 = null;
            val_6 = null;
            return (SuperScrollView.ChatMsgDataSourceMgr)SuperScrollView.ChatMsgDataSourceMgr.instance;
        }
        private void Awake()
        {
            this.Init();
        }
        public SuperScrollView.PersonInfo GetPersonInfo(int personId)
        {
            SuperScrollView.PersonInfo val_1 = 0;
            return (SuperScrollView.PersonInfo)((this.mPersonInfoDict.TryGetValue(key:  personId, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public void Init()
        {
            this.mPersonInfoDict.Clear();
            .mId = 0;
            .mHeadIcon = "grid_pencil_128_g8";
            .mName = "Jaci";
            this.mPersonInfoDict.Add(key:  0, value:  new SuperScrollView.PersonInfo());
            .mId = 1;
            .mHeadIcon = "grid_pencil_128_g5";
            .mName = "Toc";
            this.mPersonInfoDict.Add(key:  1, value:  new SuperScrollView.PersonInfo());
            this.InitChatDataSource();
        }
        public SuperScrollView.ChatMsg GetChatMsgByIndex(int index)
        {
            var val_1;
            bool val_1 = true;
            if(((index & 2147483648) == 0) && (val_1 > index))
            {
                    if(val_1 <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + (index << 3);
                val_1 = mem[(true + (index) << 3) + 32];
                val_1 = (true + (index) << 3) + 32;
                return (SuperScrollView.ChatMsg)val_1;
            }
            
            val_1 = 0;
            return (SuperScrollView.ChatMsg)val_1;
        }
        public int get_TotalItemCount()
        {
            return 4335;
        }
        private void InitChatDataSource()
        {
            var val_10;
            var val_11;
            this.mChatMsgList.Clear();
            val_10 = null;
            val_10 = null;
            var val_10 = 0;
            do
            {
                int val_2 = UnityEngine.Random.Range(min:  0, max:  99);
                SuperScrollView.MsgTypeEnum val_3 = (val_2 < 0) ? (val_2 + 1) : (val_2);
                val_3 = val_3 & 4294967294;
                val_3 = val_2 - val_3;
                .mMsgType = val_3;
                int val_4 = UnityEngine.Random.Range(min:  0, max:  99);
                int val_5 = (val_4 < 0) ? (val_4 + 1) : (val_4);
                val_5 = val_5 & 4294967294;
                val_5 = val_4 - val_5;
                .mPersonId = val_5;
                val_11 = null;
                val_11 = null;
                int val_6 = UnityEngine.Random.Range(min:  0, max:  99);
                int val_7 = val_6 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length;
                val_7 = val_6 - (val_7 * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length);
                val_7 = SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList + (val_7 << 3);
                .mSrtMsg = (SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList + (val_6 - ((val_6 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length) * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length + 32;
                int val_8 = UnityEngine.Random.Range(min:  0, max:  99);
                int val_9 = val_8 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length;
                val_9 = val_8 - (val_9 * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length);
                val_9 = SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList + (val_9 << 3);
                .mPicMsgSpriteName = (SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList + (val_8 - ((val_8 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length) * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length + 32;
                this.mChatMsgList.Add(item:  new SuperScrollView.ChatMsg());
                val_10 = val_10 + 1;
            }
            while(val_10 < 99);
        
        }
        public void AppendOneMsg()
        {
            null = null;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  99);
            SuperScrollView.MsgTypeEnum val_3 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_3 = val_3 & 4294967294;
            val_3 = val_2 - val_3;
            .mMsgType = val_3;
            int val_4 = UnityEngine.Random.Range(min:  0, max:  99);
            int val_5 = (val_4 < 0) ? (val_4 + 1) : (val_4);
            val_5 = val_5 & 4294967294;
            val_5 = val_4 - val_5;
            .mPersonId = val_5;
            int val_6 = UnityEngine.Random.Range(min:  0, max:  99);
            int val_7 = val_6 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length;
            val_7 = val_6 - (val_7 * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length);
            val_7 = SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList + (val_7 << 3);
            .mSrtMsg = (SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList + (val_6 - ((val_6 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length) * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList.Length + 32;
            int val_8 = UnityEngine.Random.Range(min:  0, max:  99);
            int val_9 = val_8 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length;
            val_9 = val_8 - (val_9 * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length);
            val_9 = SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList + (val_9 << 3);
            .mPicMsgSpriteName = (SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList + (val_8 - ((val_8 / SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length) * SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList.Length + 32;
            this.mChatMsgList.Add(item:  new SuperScrollView.ChatMsg());
        }
        public ChatMsgDataSourceMgr()
        {
            this.mPersonInfoDict = new System.Collections.Generic.Dictionary<System.Int32, SuperScrollView.PersonInfo>();
            this.mChatMsgList = new System.Collections.Generic.List<SuperScrollView.ChatMsg>();
        }
        private static ChatMsgDataSourceMgr()
        {
            int val_3;
            int val_4;
            SuperScrollView.ChatMsgDataSourceMgr.instance = 0;
            string[] val_1 = new string[5];
            val_3 = val_1.Length;
            val_1[0] = "Support ListView and GridView.";
            val_3 = val_1.Length;
            val_1[1] = "Support Infinity Vertical and Horizontal ScrollView.";
            val_3 = val_1.Length;
            val_1[2] = "Support items in different sizes such as widths or heights. Support items with unknown size at init time.";
            val_3 = val_1.Length;
            val_1[3] = "Support changing item count and item size at runtime. Support looping items such as spinners. Support item padding.";
            val_3 = val_1.Length;
            val_1[4] = "Use only one C# script to help the UGUI ScrollRect to support any count items with high performance.";
            SuperScrollView.ChatMsgDataSourceMgr.mChatDemoStrList = val_1;
            string[] val_2 = new string[4];
            val_4 = val_2.Length;
            val_2[0] = "grid_pencil_128_g2";
            val_4 = val_2.Length;
            val_2[1] = "grid_flower_200_3";
            val_4 = val_2.Length;
            val_2[2] = "grid_pencil_128_g3";
            val_4 = val_2.Length;
            val_2[3] = "grid_flower_200_7";
            SuperScrollView.ChatMsgDataSourceMgr.mChatDemoPicList = val_2;
        }
    
    }

}
