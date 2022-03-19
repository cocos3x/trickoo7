using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass29_0
{
    // Fields
    public UnityEngine.RectTransform target;
    public float startPosY;
    public bool offsetYSet;
    public float offsetY;
    public DG.Tweening.Sequence s;
    public UnityEngine.Vector2 endValue;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass29_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOJumpAnchorPos>b__0()
    {
        if(this.target != null)
        {
                return this.target.anchoredPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJumpAnchorPos>b__2()
    {
        UnityEngine.Vector2 val_1 = this.target.anchoredPosition;
        this.startPosY = val_1.y;
    }
    internal UnityEngine.Vector2 <DOJumpAnchorPos>b__3()
    {
        if(this.target != null)
        {
                return this.target.anchoredPosition;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x)
    {
        if(this.target != null)
        {
                this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJumpAnchorPos>b__5()
    {
        float val_5;
        if(this.offsetYSet != true)
        {
                this.offsetYSet = true;
            if(this.s == null)
        {
                val_5 = S0 - this.startPosY;
        }
        
            this.offsetY = val_5;
        }
        
        UnityEngine.Vector2 val_1 = this.target.anchoredPosition;
        float val_4 = this.offsetY;
        val_4 = val_1.y + (DG.Tweening.DOVirtual.EasedValue(from:  0f, to:  val_4, lifetimePercentage:  DG.Tweening.TweenExtensions.ElapsedDirectionalPercentage(t:  this.s), easeType:  6));
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_4};
    }

}
