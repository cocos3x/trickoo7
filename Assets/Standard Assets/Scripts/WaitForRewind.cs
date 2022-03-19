using UnityEngine;
public class DOTweenCYInstruction.WaitForRewind : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        var val_4;
        if((this.t.<active>k__BackingField) == false)
        {
            goto label_1;
        }
        
        if((this.t.<playedOnce>k__BackingField) == false)
        {
            goto label_2;
        }
        
        float val_4 = (float)(DG.Tweening.TweenExtensions.CompletedLoops(t:  this.t)) + 1;
        val_4 = (this.t.<position>k__BackingField) * val_4;
        var val_3 = (val_4 > 0f) ? 1 : 0;
        return (bool)val_4;
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        val_4 = 1;
        return (bool)val_4;
    }
    public DOTweenCYInstruction.WaitForRewind(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
