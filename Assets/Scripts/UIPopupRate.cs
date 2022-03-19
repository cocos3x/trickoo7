using UnityEngine;
public class UIPopupRate : UICore
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.UI.Image> stars;
    private UnityEngine.Sprite[] spr;
    private InAppReviewClient inAppReviewClient;
    
    // Methods
    public void Rate(int star)
    {
        var val_5;
        .star = star;
        .<>4__this = this;
        val_5 = 0;
        label_12:
        if(val_5 >= 1152921504889647104)
        {
            goto label_3;
        }
        
        if(1152921504889647104 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = X9 + 0;
        if((val_5 + 1) <= ((UIPopupRate.<>c__DisplayClass3_0)[1152921513501284656].star))
        {
            goto label_6;
        }
        
        if(((X9 + 0) + 32) != 0)
        {
            goto label_8;
        }
        
        label_6:
        label_8:
        (X9 + 0) + 32.sprite = null;
        val_5 = val_5 + 1;
        if(this.stars != null)
        {
            goto label_12;
        }
        
        throw new NullReferenceException();
        label_3:
        (X9 + 0) + 32.SaveActivityTime(isFinish:  true);
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.5f, callback:  new DG.Tweening.TweenCallback(object:  new UIPopupRate.<>c__DisplayClass3_0(), method:  System.Void UIPopupRate.<>c__DisplayClass3_0::<Rate>b__0()), ignoreTimeScale:  true);
    }
    public void SaveActivityTime(bool isFinish)
    {
        if(isFinish == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "rate", value:  1);
    }
    public UIPopupRate()
    {
    
    }
    private void <>n__0()
    {
        this.Hide();
    }

}
