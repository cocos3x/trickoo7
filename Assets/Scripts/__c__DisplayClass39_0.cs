using UnityEngine;
private sealed class UIToast.<>c__DisplayClass39_0
{
    // Fields
    public UIToast <>4__this;
    public string mes;
    public DG.Tweening.TweenCallback <>9__3;
    public DG.Tweening.TweenCallback <>9__4;
    
    // Methods
    public UIToast.<>c__DisplayClass39_0()
    {
    
    }
    internal void <Show>b__0()
    {
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_3 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this.<>4__this.contents, endValue:  ((System.String.IsNullOrEmpty(value:  this.mes)) != true) ? 0f : 1f, duration:  0f);
        this.<>4__this.message.gameObject.SetActive(value:  true);
        this.<>4__this.horizontalLayoutGroup.enabled = (~(System.String.IsNullOrEmpty(value:  this.mes))) & 1;
    }
    internal void <Show>b__1()
    {
        var val_6;
        this.<>4__this.message.gameObject.SetActive(value:  true);
        this.<>4__this.horizontalLayoutGroup.enabled = (~(System.String.IsNullOrEmpty(value:  this.mes))) & 1;
        UnityEngine.Coroutine val_5 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.OptimizeLayout());
        val_6 = null;
        val_6 = null;
        UIToast.Status = 3;
    }
    internal void <Show>b__2()
    {
        DG.Tweening.TweenCallback val_10;
        DG.Tweening.TweenCallback val_11;
        string val_1 = this.mes.Trim();
        this.<>4__this.message.gameObject.SetActive(value:  false);
        this.<>4__this.horizontalLayoutGroup.enabled = false;
        val_10 = this.<>9__3;
        if(val_10 == null)
        {
                DG.Tweening.TweenCallback val_6 = null;
            val_10 = val_6;
            val_6 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIToast.<>c__DisplayClass39_0::<Show>b__3());
            this.<>9__3 = val_10;
        }
        
        val_11 = this.<>9__4;
        if(val_11 == null)
        {
                DG.Tweening.TweenCallback val_8 = null;
            val_11 = val_8;
            val_8 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void UIToast.<>c__DisplayClass39_0::<Show>b__4());
            this.<>9__4 = val_11;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.<>4__this.contents, endValue:  ((System.String.IsNullOrEmpty(value:  this.mes)) != true) ? 0f : 1f, duration:  0.15f), action:  val_6), action:  val_8);
    }
    internal void <Show>b__3()
    {
        this.<>4__this.message.gameObject.SetActive(value:  true);
        this.<>4__this.horizontalLayoutGroup.enabled = (~(System.String.IsNullOrEmpty(value:  this.mes))) & 1;
    }
    internal void <Show>b__4()
    {
        this.<>4__this.message.gameObject.SetActive(value:  true);
        this.<>4__this.horizontalLayoutGroup.enabled = (~(System.String.IsNullOrEmpty(value:  this.mes))) & 1;
    }

}
