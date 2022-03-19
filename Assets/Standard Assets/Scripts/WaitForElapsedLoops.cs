using UnityEngine;
public class DOTweenCYInstruction.WaitForElapsedLoops : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    private readonly int elapsedLoops;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        var val_3;
        if((this.t.<active>k__BackingField) != false)
        {
                var val_2 = ((DG.Tweening.TweenExtensions.CompletedLoops(t:  this.t)) < this.elapsedLoops) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public DOTweenCYInstruction.WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops)
    {
        this.t = tween;
        this.elapsedLoops = elapsedLoops;
    }

}
