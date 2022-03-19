using UnityEngine;
private sealed class Level.<>c__DisplayClass32_0
{
    // Fields
    public int levelTut;
    public Level <>4__this;
    public System.Collections.Generic.List<UnityEngine.Vector2> positions;
    
    // Methods
    public Level.<>c__DisplayClass32_0()
    {
    
    }
    internal void <HandleTutorial>b__1()
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        if(val_2.level != this.levelTut)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(listener:  this.<>4__this, eventID:  18, param:  this.positions);
    }
    internal void <HandleTutorial>b__2()
    {
        EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  120);
    }

}
