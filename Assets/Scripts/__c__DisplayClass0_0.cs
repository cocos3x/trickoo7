using UnityEngine;
private sealed class TransformExtend.<>c__DisplayClass0_0
{
    // Fields
    public UnityEngine.Transform transform;
    public float scaleFrom;
    public float timeAnimation;
    
    // Methods
    public TransformExtend.<>c__DisplayClass0_0()
    {
    
    }
    internal void <DoScale>b__0()
    {
        float val_3 = this.timeAnimation;
        val_3 = val_3 * 0.65f;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  this.scaleFrom, duration:  val_3), ease:  9);
    }

}
