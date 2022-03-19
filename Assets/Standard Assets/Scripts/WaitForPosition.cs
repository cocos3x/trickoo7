using UnityEngine;
public class DOTweenCYInstruction.WaitForPosition : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    private readonly float position;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        var val_4;
        if((this.t.<active>k__BackingField) != false)
        {
                float val_4 = (float)(DG.Tweening.TweenExtensions.CompletedLoops(t:  this.t)) + 1;
            val_4 = (this.t.<position>k__BackingField) * val_4;
            var val_3 = (val_4 < 0) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public DOTweenCYInstruction.WaitForPosition(DG.Tweening.Tween tween, float position)
    {
        this.t = tween;
        this.position = position;
    }

}
