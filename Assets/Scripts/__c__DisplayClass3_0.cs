using UnityEngine;
private sealed class UIPopupRate.<>c__DisplayClass3_0
{
    // Fields
    public int star;
    public UIPopupRate <>4__this;
    
    // Methods
    public UIPopupRate.<>c__DisplayClass3_0()
    {
    
    }
    internal void <Rate>b__0()
    {
        if(this.star == 5)
        {
                this.<>4__this.inAppReviewClient.StartRequestReview();
        }
        
        this.<>4__this.Hide();
    }

}
