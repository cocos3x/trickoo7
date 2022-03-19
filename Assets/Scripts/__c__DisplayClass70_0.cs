using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass70_0
{
    // Fields
    public DG.Tweening.TweenCallback onDone;
    public UnityEngine.UI.Image img;
    public float from;
    public float timeAnimation;
    
    // Methods
    public UIAnimation.<>c__DisplayClass70_0()
    {
    
    }
    internal void <DoAlpha>b__0()
    {
        float val_4 = this.timeAnimation;
        val_4 = val_4 * 0.3f;
        if(this.onDone == null)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.img, endValue:  this.from, duration:  val_4), ease:  9), action:  this.onDone);
    }

}
