using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass67_0
{
    // Fields
    public UnityEngine.Transform tran;
    public float timeAnimation;
    
    // Methods
    public UIAnimation.<>c__DisplayClass67_0()
    {
    
    }
    internal void <DoScale>b__0()
    {
        float val_3 = 0.65f;
        val_3 = this.timeAnimation * val_3;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tran, endValue:  1f, duration:  val_3), ease:  9);
    }

}
