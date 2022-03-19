using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass69_0
{
    // Fields
    public DG.Tweening.TweenCallback onDone;
    
    // Methods
    public UIAnimation.<>c__DisplayClass69_0()
    {
    
    }
    internal void <DoRotateZ>b__0()
    {
        if(this.onDone == null)
        {
                return;
        }
        
        this.onDone.Invoke();
    }

}
