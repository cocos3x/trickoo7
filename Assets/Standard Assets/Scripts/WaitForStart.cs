using UnityEngine;
public class DOTweenCYInstruction.WaitForStart : CustomYieldInstruction
{
    // Fields
    private readonly DG.Tweening.Tween t;
    
    // Properties
    public override bool keepWaiting { get; }
    
    // Methods
    public override bool get_keepWaiting()
    {
        if(this.t != null)
        {
                if((this.t.<active>k__BackingField) == false)
        {
                return false;
        }
        
            return (bool)((this.t.<playedOnce>k__BackingField) == false) ? 1 : 0;
        }
        
        throw new NullReferenceException();
    }
    public DOTweenCYInstruction.WaitForStart(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
