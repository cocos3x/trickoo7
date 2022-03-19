using UnityEngine;
private sealed class LevelFind.<>c__DisplayClass8_0
{
    // Fields
    public Evidence evi;
    public LevelFind <>4__this;
    
    // Methods
    public LevelFind.<>c__DisplayClass8_0()
    {
    
    }
    internal void <CollectEvidenceHandler>b__0()
    {
        this.evi.Hide();
        this.<>4__this.DisplayResult();
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.WaitAnimWin());
    }

}
