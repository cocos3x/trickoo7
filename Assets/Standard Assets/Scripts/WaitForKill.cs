using UnityEngine;
public class DOTweenCYInstruction.WaitForKill : CustomYieldInstruction
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
                return (bool)this.t.<active>k__BackingField;
        }
        
        throw new NullReferenceException();
    }
    public DOTweenCYInstruction.WaitForKill(DG.Tweening.Tween tween)
    {
        this.t = tween;
    }

}
