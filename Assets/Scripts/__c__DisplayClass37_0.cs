using UnityEngine;
private sealed class MusicManager.<>c__DisplayClass37_0
{
    // Fields
    public System.Action actionOnDone;
    
    // Methods
    public MusicManager.<>c__DisplayClass37_0()
    {
    
    }
    internal void <FadeIn>b__0()
    {
        if(this.actionOnDone == null)
        {
                return;
        }
        
        this.actionOnDone.Invoke();
    }

}
