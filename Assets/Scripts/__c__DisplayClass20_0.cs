using UnityEngine;
private sealed class GameUIManager.<>c__DisplayClass20_0
{
    // Fields
    public GameUIManager <>4__this;
    public Level level;
    
    // Methods
    public GameUIManager.<>c__DisplayClass20_0()
    {
    
    }
    internal void <FinishLevelHandler>b__0()
    {
        this.<>4__this.UIPopupVictory.Show(level:  this.level);
    }
    internal void <FinishLevelHandler>b__1()
    {
        this.<>4__this.UIPopupRate.Show(onDone:  0);
    }

}
