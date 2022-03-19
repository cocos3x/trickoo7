using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass5_0
{
    // Fields
    public UnityEngine.UI.Image target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass5_0()
    {
    
    }
    internal float <DOFillAmount>b__0()
    {
        if(this.target != null)
        {
                return (float)this.target.m_FillAmount;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOFillAmount>b__1(float x)
    {
        if(this.target != null)
        {
                this.target.fillAmount = x;
            return;
        }
        
        throw new NullReferenceException();
    }

}
