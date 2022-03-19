using UnityEngine;
private sealed class TransformExtend.<>c__DisplayClass5_0
{
    // Fields
    public DG.Tweening.TweenCallback onAnimationDone;
    
    // Methods
    public TransformExtend.<>c__DisplayClass5_0()
    {
    
    }
    internal void <DoJump>b__0()
    {
        if(this.onAnimationDone == null)
        {
                return;
        }
        
        this.onAnimationDone.Invoke();
    }

}
