using UnityEngine;
private sealed class PageViewDemoScript.<>c__DisplayClass6_0
{
    // Fields
    public int index;
    public SuperScrollView.PageViewDemoScript <>4__this;
    
    // Methods
    public PageViewDemoScript.<>c__DisplayClass6_0()
    {
    
    }
    internal void <InitDots>b__0(UnityEngine.GameObject obj)
    {
        if((this.<>4__this) != null)
        {
                this.<>4__this.OnDotClicked(index:  this.index);
            return;
        }
        
        throw new NullReferenceException();
    }

}
