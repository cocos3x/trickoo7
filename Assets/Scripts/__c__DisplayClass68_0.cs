using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass68_0
{
    // Fields
    public DG.Tweening.TweenCallback onDone;
    public UnityEngine.Transform tran;
    public float from;
    public float timeAnimation;
    
    // Methods
    public UIAnimation.<>c__DisplayClass68_0()
    {
    
    }
    internal void <DoMoveZ>b__0()
    {
        float val_4 = this.timeAnimation;
        val_4 = val_4 * 0.3f;
        if(this.onDone == null)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveZ(target:  this.tran, endValue:  this.from, duration:  val_4, snapping:  false), ease:  9), action:  this.onDone);
    }

}
