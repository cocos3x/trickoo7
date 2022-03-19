using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass58_0
{
    // Fields
    public UIAnimation <>4__this;
    public DG.Tweening.TweenCallback actionOnComplete;
    
    // Methods
    public UIAnimation.<>c__DisplayClass58_0()
    {
    
    }
    internal void <SlideOut>b__0()
    {
        UIAnimation val_3;
        if((this.<>4__this.status) != 0)
        {
                this.<>4__this.status = 0;
            if((this.<>4__this.OnStatusChanged) != null)
        {
                this.<>4__this.OnStatusChanged.Invoke(status:  0);
        }
        
        }
        
        if(this.actionOnComplete != null)
        {
                this.actionOnComplete.Invoke();
        }
        
        val_3 = this.<>4__this;
        if((this.<>4__this.m_HideCompletedEvent) != null)
        {
                this.<>4__this.m_HideCompletedEvent.Invoke();
            val_3 = this.<>4__this;
        }
        
        if((this.<>4__this.<onHideCompleted>k__BackingField) != null)
        {
                this.<>4__this.<onHideCompleted>k__BackingField.Invoke();
            this.<>4__this.<onHideCompleted>k__BackingField = 0;
        }
        
        this.<>4__this.gameObject.SetActive(value:  ((this.<>4__this.hideAtEnd) == false) ? 1 : 0);
    }

}
