using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass57_0
{
    // Fields
    public DG.Tweening.TweenCallback actionOnStart;
    public UIAnimation <>4__this;
    public DG.Tweening.TweenCallback actionOnComplete;
    public DG.Tweening.TweenCallback <>9__2;
    
    // Methods
    public UIAnimation.<>c__DisplayClass57_0()
    {
    
    }
    internal void <SlideIn>b__0()
    {
        if(this.actionOnStart != null)
        {
                this.actionOnStart.Invoke();
        }
        
        if((this.<>4__this.m_StartEvent) == null)
        {
                return;
        }
        
        this.<>4__this.m_StartEvent.Invoke();
    }
    internal void <SlideIn>b__1()
    {
        DG.Tweening.TweenCallback val_2 = this.<>9__2;
        if(val_2 == null)
        {
                DG.Tweening.TweenCallback val_1 = null;
            val_2 = val_1;
            val_1 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIAnimation.<>c__DisplayClass57_0::<SlideIn>b__2());
            this.<>9__2 = val_2;
        }
        
        this.<>4__this.ShowElements(actionOnCompleted:  val_1);
    }
    internal void <SlideIn>b__2()
    {
        if((this.<>4__this.status) != 3)
        {
                this.<>4__this.status = 3;
            if((this.<>4__this.OnStatusChanged) != null)
        {
                this.<>4__this.OnStatusChanged.Invoke(status:  3);
        }
        
        }
        
        if(this.actionOnComplete != null)
        {
                this.actionOnComplete.Invoke();
        }
        
        if((this.<>4__this.m_ShowCompletedEvent) == null)
        {
                return;
        }
        
        this.<>4__this.m_ShowCompletedEvent.Invoke();
    }

}
