using UnityEngine;
private class LoopListView2.SnapData
{
    // Fields
    public SuperScrollView.SnapStatus mSnapStatus;
    public int mSnapTargetIndex;
    public float mTargetSnapVal;
    public float mCurSnapVal;
    public bool mIsForceSnapTo;
    public bool mIsTempTarget;
    public int mTempTargetIndex;
    public float mMoveMaxAbsVec;
    
    // Methods
    public void Clear()
    {
        this.mSnapStatus = 0;
        this.mTempTargetIndex = 0;
        this.mMoveMaxAbsVec = -1.007812f;
        this.mIsForceSnapTo = false;
    }
    public LoopListView2.SnapData()
    {
        this.mTempTargetIndex = 0;
        this.mMoveMaxAbsVec = -1.007812f;
    }

}
