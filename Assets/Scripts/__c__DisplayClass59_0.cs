using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass59_0
{
    // Fields
    public UIAnimation <>4__this;
    public float end;
    public float timeAnimation;
    public float timeDelay;
    public DG.Tweening.Ease ease;
    public DG.Tweening.TweenCallback actionOnStart;
    public DG.Tweening.TweenCallback actionOnComplete;
    public DG.Tweening.TweenCallback <>9__1;
    public DG.Tweening.TweenCallback <>9__3;
    public DG.Tweening.TweenCallback <>9__2;
    
    // Methods
    public UIAnimation.<>c__DisplayClass59_0()
    {
    
    }
    internal void <FaceIn>b__0()
    {
        DG.Tweening.TweenCallback val_9;
        DG.Tweening.TweenCallback val_10;
        val_9 = this.<>9__1;
        if(val_9 == null)
        {
                DG.Tweening.TweenCallback val_5 = null;
            val_9 = val_5;
            val_5 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIAnimation.<>c__DisplayClass59_0::<FaceIn>b__1());
            this.<>9__1 = val_9;
        }
        
        val_10 = this.<>9__2;
        if(val_10 == null)
        {
                DG.Tweening.TweenCallback val_7 = null;
            val_10 = val_7;
            val_7 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIAnimation.<>c__DisplayClass59_0::<FaceIn>b__2());
            this.<>9__2 = val_10;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.<>4__this.<canvasGroup>k__BackingField, endValue:  this.end, duration:  this.timeAnimation), delay:  this.timeDelay), ease:  this.ease), updateType:  0, isIndependentUpdate:  true), action:  val_5), action:  val_7);
    }
    internal void <FaceIn>b__1()
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
    internal void <FaceIn>b__2()
    {
        DG.Tweening.TweenCallback val_2 = this.<>9__3;
        if(val_2 == null)
        {
                DG.Tweening.TweenCallback val_1 = null;
            val_2 = val_1;
            val_1 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIAnimation.<>c__DisplayClass59_0::<FaceIn>b__3());
            this.<>9__3 = val_2;
        }
        
        this.<>4__this.ShowElements(actionOnCompleted:  val_1);
    }
    internal void <FaceIn>b__3()
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
