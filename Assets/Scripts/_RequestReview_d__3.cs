using UnityEngine;
private sealed class InAppReviewClient.<RequestReview>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InAppReviewClient <>4__this;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> <requestFlowOperation>5__2;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> <launchFlowOperation>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InAppReviewClient.<RequestReview>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_8;
        }
        
        this.<>1__state = 0;
        Google.Play.Review.ReviewManager val_1 = new Google.Play.Review.ReviewManager();
        this.<>4__this.reviewManager = val_1;
        Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> val_2 = val_1.RequestReviewFlow();
        this.<requestFlowOperation>5__2 = val_2;
        this.<>2__current = val_2;
        val_5 = 1;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        if(0 != 0)
        {
            goto label_8;
        }
        
        Google.Play.Review.PlayReviewInfo val_3 = this.<requestFlowOperation>5__2.GetResult();
        this.<>4__this.playReviewInfo = val_3;
        Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> val_4 = this.<>4__this.reviewManager.LaunchReviewFlow(reviewInfo:  val_3);
        this.<launchFlowOperation>5__3 = val_4;
        this.<>2__current = val_4;
        val_5 = 1;
        this.<>1__state = 2;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.playReviewInfo = 0;
        label_8:
        val_5 = 0;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
