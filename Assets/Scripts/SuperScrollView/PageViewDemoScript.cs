using UnityEngine;

namespace SuperScrollView
{
    public class PageViewDemoScript : MonoBehaviour
    {
        // Fields
        public SuperScrollView.LoopListView2 mLoopListView;
        private UnityEngine.UI.Button mBackButton;
        private int mPageCount;
        public UnityEngine.Transform mDotsRootObj;
        private System.Collections.Generic.List<SuperScrollView.DotElem> mDotElemList;
        
        // Methods
        private void Start()
        {
            this.InitDots();
            val_1.mSnapVecThreshold = 99999f;
            this.mLoopListView.mOnBeginDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PageViewDemoScript::OnBeginDrag());
            this.mLoopListView.mOnDragingAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PageViewDemoScript::OnDraging());
            this.mLoopListView.mOnEndDragAction = new System.Action(object:  this, method:  System.Void SuperScrollView.PageViewDemoScript::OnEndDrag());
            this.mLoopListView.mOnSnapNearestChanged = new System.Action<SuperScrollView.LoopListView2, SuperScrollView.LoopListViewItem2>(object:  this, method:  System.Void SuperScrollView.PageViewDemoScript::OnSnapNearestChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item));
            this.mLoopListView.InitListView(itemTotalCount:  this.mPageCount, onGetItemByIndex:  new System.Func<SuperScrollView.LoopListView2, System.Int32, SuperScrollView.LoopListViewItem2>(object:  this, method:  SuperScrollView.LoopListViewItem2 SuperScrollView.PageViewDemoScript::OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int pageIndex)), initParam:  SuperScrollView.LoopListViewInitParam.CopyDefaultInitParam());
            this.mBackButton = UnityEngine.GameObject.Find(name:  "ButtonPanel/BackButton").GetComponent<UnityEngine.UI.Button>();
            val_8.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SuperScrollView.PageViewDemoScript::OnBackBtnClicked()));
        }
        private void InitDots()
        {
            int val_1 = this.mDotsRootObj.childCount;
            if(val_1 < 1)
            {
                    return;
            }
            
            int val_12 = 0;
            do
            {
                .<>4__this = this;
                UnityEngine.Transform val_3 = this.mDotsRootObj.GetChild(index:  0);
                .mDotElemRoot = val_3.gameObject;
                .mDotSmall = val_3.Find(n:  "dotSmall").gameObject;
                .mDotBig = val_3.Find(n:  "dotBig").gameObject;
                SuperScrollView.ClickEventListener val_10 = SuperScrollView.ClickEventListener.Get(obj:  (SuperScrollView.DotElem)[1152921513556174160].mDotElemRoot);
                .index = val_12;
                val_10.mClickedHandler = new System.Action<UnityEngine.GameObject>(object:  new PageViewDemoScript.<>c__DisplayClass6_0(), method:  System.Void PageViewDemoScript.<>c__DisplayClass6_0::<InitDots>b__0(UnityEngine.GameObject obj));
                this.mDotElemList.Add(item:  new SuperScrollView.DotElem());
                val_12 = val_12 + 1;
            }
            while(val_12 < val_1);
        
        }
        private void OnDotClicked(int index)
        {
            if(this.mLoopListView != null)
            {
                    if((this.mLoopListView.mCurSnapNearestItemIndex & 2147483648) != 0)
            {
                    return;
            }
            
                if(this.mLoopListView.mCurSnapNearestItemIndex == index)
            {
                    return;
            }
            
                if(this.mLoopListView.mCurSnapNearestItemIndex >= this.mPageCount)
            {
                    return;
            }
            
                this.mLoopListView.SetSnapTargetItemIndex(itemIndex:  index, moveMaxAbsVec:  -1f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void UpdateAllDots()
        {
            var val_1;
            if((this.mLoopListView.mCurSnapNearestItemIndex & 2147483648) != 0)
            {
                    return;
            }
            
            int val_1 = this.mPageCount;
            if(this.mLoopListView.mCurSnapNearestItemIndex >= val_1)
            {
                    return;
            }
            
            if(this.mLoopListView.mCurSnapNearestItemIndex >= W21)
            {
                    return;
            }
            
            if(W21 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                if(this.mLoopListView.mCurSnapNearestItemIndex == val_2)
            {
                    (this.mPageCount + 0) + 32 + 24.SetActive(value:  false);
                val_1 = 1;
            }
            else
            {
                    (this.mPageCount + 0) + 32 + 24.SetActive(value:  true);
                val_1 = 0;
            }
            
                (this.mPageCount + 0) + 32 + 32.SetActive(value:  false);
                val_2 = val_2 + 1;
                if(val_2 >= W21)
            {
                    return;
            }
            
            }
            while(this.mDotElemList != null);
            
            throw new NullReferenceException();
        }
        private void OnSnapNearestChanged(SuperScrollView.LoopListView2 listView, SuperScrollView.LoopListViewItem2 item)
        {
            this.UpdateAllDots();
        }
        private void OnBackBtnClicked()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu");
        }
        private SuperScrollView.LoopListViewItem2 OnGetItemByIndex(SuperScrollView.LoopListView2 listView, int pageIndex)
        {
            if(((pageIndex & 2147483648) != 0) || (this.mPageCount <= pageIndex))
            {
                    return 0;
            }
            
            SuperScrollView.ListItem14 val_2 = listView.NewListViewItem(itemPrefabName:  "ItemPrefab1").GetComponent<SuperScrollView.ListItem14>();
            if(val_1.mIsInitHandlerCalled == false)
            {
                goto label_5;
            }
            
            if(val_2 != null)
            {
                goto label_6;
            }
            
            return 0;
            label_5:
            val_1.mIsInitHandlerCalled = true;
            val_2.Init();
            label_6:
            if(W23 < 1)
            {
                    return 0;
            }
            
            var val_11 = 0;
            label_23:
            if((SuperScrollView.DataSourceMgr.Get.GetItemDataByIndex(index:  (W23 * pageIndex) + val_11)) == null)
            {
                goto label_14;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 0) + 32 + 16.SetActive(value:  true);
            (SuperScrollView.DataSourceMgr.__il2cppRuntimeField_cctor_finished + 0) + 32 + 24.sprite = SuperScrollView.ResManager.Get.GetSpriteByName(spriteName:  val_6.mIcon);
            val_11 = val_11 + 1;
            if(val_11 < W23)
            {
                goto label_23;
            }
            
            return 0;
            label_14:
            if(val_11 >= W23)
            {
                    return 0;
            }
            
            do
            {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                11993091.SetActive(value:  false);
                val_11 = val_11 + 1;
            }
            while(val_11 < W23);
            
            return 0;
        }
        private void OnBeginDrag()
        {
        
        }
        private void OnDraging()
        {
        
        }
        private void OnEndDrag()
        {
            int val_6;
            SuperScrollView.LoopListViewItem2 val_1 = this.mLoopListView.GetShownItemByItemIndex(itemIndex:  this.mLoopListView.mCurSnapNearestItemIndex);
            if(val_1 == 0)
            {
                    this.mLoopListView.ClearSnapData();
                return;
            }
            
            if(System.Math.Abs(this.mLoopListView.mScrollRect.m_Velocity) < 0)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_3 = this.mLoopListView.GetItemCornerPosInViewPort(item:  val_1, corner:  1);
            if(val_3.x <= 0f)
            {
                goto label_11;
            }
            
            if(this.mLoopListView.mScrollRect.m_Velocity <= 0f)
            {
                goto label_13;
            }
            
            goto label_14;
            label_11:
            if(val_3.x >= 0)
            {
                goto label_16;
            }
            
            if(this.mLoopListView.mScrollRect.m_Velocity <= 0f)
            {
                goto label_19;
            }
            
            label_13:
            val_6 = this.mLoopListView.mCurSnapNearestItemIndex;
            goto label_18;
            label_16:
            if(this.mLoopListView.mScrollRect.m_Velocity <= 0f)
            {
                goto label_19;
            }
            
            label_14:
            val_6 = this.mLoopListView.mCurSnapNearestItemIndex - 1;
            goto label_20;
            label_19:
            val_6 = this.mLoopListView.mCurSnapNearestItemIndex + 1;
            label_20:
            label_18:
            this.mLoopListView.SetSnapTargetItemIndex(itemIndex:  val_6, moveMaxAbsVec:  -1f);
        }
        public PageViewDemoScript()
        {
            this.mPageCount = 5;
            this.mDotElemList = new System.Collections.Generic.List<SuperScrollView.DotElem>();
        }
    
    }

}
