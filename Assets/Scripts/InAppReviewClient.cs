using UnityEngine;
public class InAppReviewClient : MonoBehaviour
{
    // Fields
    private Google.Play.Review.ReviewManager reviewManager;
    private Google.Play.Review.PlayReviewInfo playReviewInfo;
    
    // Methods
    public void StartRequestReview()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.RequestReview());
    }
    private System.Collections.IEnumerator RequestReview()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InAppReviewClient.<RequestReview>d__3();
    }
    public InAppReviewClient()
    {
    
    }

}
